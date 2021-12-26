using System.Text.RegularExpressions;

namespace DzCd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] _logFileList = Array.Empty<string>();

        private int _selectIndex = -1;
        private DataGridViewCellCollection? _selectDataGrdiViewCell = default;

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetFilesListButton_Click(object sender, EventArgs e)
        {
            var dzLogPath = @"D:\play\dzclient\log\";

            // 筛选出子目录中所有的 war3dll.log, 取最新的20个
            _logFileList =
                Directory.GetFiles(dzLogPath, "war3dll.log", SearchOption.AllDirectories)
                 .OrderByDescending(item => new FileInfo(item).LastWriteTime).Take(20).ToArray();

            var index = 0;
            FilesDataGridView.Rows.Clear();
            // 显示
            foreach (var item in _logFileList)
            {
                FilesDataGridView.Rows.Add();
                var cell = FilesDataGridView.Rows[index].Cells;

                cell[0].Value = index + 1;
                cell[1].Value = new FileInfo(item).LastWriteTime.ToString("HH:mm:ss yyyy-MM-dd");
                index++;
            }
        }

        /// <summary>
        /// 显示存档详细内容
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="filePath"></param>
        private void ShowDetail(DataGridView dataGridView, string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return;
            // 开启一个线程, 防止卡顿
            Task.Run(async () =>
            {
                var data = await File.ReadAllTextAsync(filePath);

                // 正则提取存档内容的 key 与 value
                var dataList = Regex.Matches(data, "get archive, player=0, key=(.*), val=(.*)");

                var index = 0;

                this.Invoke(() =>
                {
                    dataGridView.Rows.Clear();
                    this.TotalLable.Text = dataList.Count.ToString();
                });

                // 显示
                for (int i = 0; i < dataList.Count; i++)
                {
                    var item = dataList[i].Groups;
                    var keyName = item[1].ToString();
                    var keyValue = item[2].ToString().Replace("\r", "");
                    this.Invoke(() =>
                    {
                        dataGridView.Rows.Add();
                        var cell = dataGridView.Rows[index].Cells;

                        cell[0].Value = index + 1;
                        cell[1].Value = keyName;
                        cell[2].Value = keyValue;
                    });

                    index++;

                    // 限制显示的数量
                    if (index > Convert.ToInt32(this.ShowDetailCountTextBox.Text) - 1)
                    {
                        return;
                    }
                }
            });
        }

        /// <summary>
        /// 文件DataGridView 右键单击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilesDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    _selectIndex = e.RowIndex;
                    // 弹出右键菜单
                    MenuContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        /// <summary>
        /// 详情 DataGridView 单元格 右键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftRightDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var selectIndex = e.RowIndex;

                if (selectIndex < 0) return;

                var dataGridView = ((DataGridView)sender);

                _selectDataGrdiViewCell = dataGridView.Rows[selectIndex].Cells;

                // 弹出右键菜单
                LeftRightContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
            }
        }

        /// <summary>
        /// 显示到左侧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogQuestionShowDetail(LeftDataGridView);
        }

        /// <summary>
        /// 显示到右侧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogQuestionShowDetail(RightDataGridView);
        }

        /// <summary>
        /// 询问是否显示详情
        /// </summary>
        /// <param name="dataGridView"></param>
        private void DialogQuestionShowDetail(DataGridView dataGridView)
        {
            var result = MessageBox.Show($"显示 {_selectIndex + 1} 的内容?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var data = _logFileList[_selectIndex] ?? string.Empty;
            ShowDetail(dataGridView, data);
        }

        /// <summary>
        ///  左侧 DataGridView 滚动 (让另一个同步滚动)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.RightDataGridView.RowCount > 0)
            {
                this.RightDataGridView.FirstDisplayedScrollingRowIndex = Math.Min(this.LeftDataGridView.FirstDisplayedScrollingRowIndex, this.RightDataGridView.RowCount - 1);
                this.RightDataGridView.HorizontalScrollingOffset = this.LeftDataGridView.HorizontalScrollingOffset;
            }
        }

        /// <summary>
        /// 右侧 DataGridView 滚动 (让另一个同步滚动)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.LeftDataGridView.RowCount > 0)
            {
                this.LeftDataGridView.FirstDisplayedScrollingRowIndex = Math.Min(this.RightDataGridView.FirstDisplayedScrollingRowIndex, this.LeftDataGridView.RowCount - 1);
                this.LeftDataGridView.HorizontalScrollingOffset = this.RightDataGridView.HorizontalScrollingOffset;
            }
        }

        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_selectDataGrdiViewCell is null) return;

            // 取值
            var keyName = _selectDataGrdiViewCell[1].Value;

            var keyValue = _selectDataGrdiViewCell[2].Value;

            var data = $"存档保存(\"{keyName}\",\"{keyValue}\")";

            // 设置剪贴板
            Clipboard.SetText(data);

            MessageBox.Show($"内容复制成功:{data}");
        }

        /// <summary>
        /// 对比
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContrastButton_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                // 遍历 DataGridView
                for (int i = 0; i < LeftDataGridView.Rows.Count; i++)
                {
                    // 如果右侧没有,则结束对比
                    if (RightDataGridView.Rows.Count >= i + 1)
                    {
                        var leftCell = LeftDataGridView.Rows[i].Cells;

                        var leftKeyName = leftCell[1].Value.ToString();
                        var leftKeyValue = leftCell[2].Value.ToString();

                        var rightCell = RightDataGridView.Rows[i].Cells;

                        var rightKeyName = rightCell[1].Value.ToString();
                        var rightKeyValue = rightCell[2].Value.ToString();

                        // 对比值,并改变颜色
                        if (leftKeyName != rightKeyName)
                        {
                            this.Invoke(() =>
                            {
                                leftCell[1].Style.BackColor = Color.Yellow;
                                rightCell[1].Style.BackColor = Color.Yellow;
                            });
                        }
                        if (leftKeyValue != rightKeyValue)
                        {
                            this.Invoke(() =>
                            {
                                leftCell[2].Style.BackColor = Color.Yellow;
                                rightCell[2].Style.BackColor = Color.Yellow;
                            });
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            });
        }
    }
}