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

        private async void button1_Click(object sender, EventArgs e)
        {
            var dzLogPath = @"D:\play\dzclient\log\";

            _logFileList =
                Directory.GetFiles(dzLogPath, "war3dll.log", SearchOption.AllDirectories)
                 .OrderByDescending(item => new FileInfo(item).LastWriteTime).Take(20).ToArray();
            var index = 0;
            FilesDataGridView.Rows.Clear();

            foreach (var item in _logFileList)
            {
                FilesDataGridView.Rows.Add();
                var cell = FilesDataGridView.Rows[index].Cells;

                cell[0].Value = index + 1;
                cell[1].Value = new FileInfo(item).LastWriteTime.ToString("HH:mm:ss yyyy-MM-dd");
                index++;
            }
        }

        private void ShowDetail(DataGridView dataGridView, string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return;

            Task.Run(async () =>
            {
                var data = await File.ReadAllTextAsync(filePath);

                var dataList = Regex.Matches(data, "get archive, player=0, key=(.*), val=(.*)");

                var index = 0;

                this.Invoke(() =>
                {
                    dataGridView.Rows.Clear();
                    this.TotalLable.Text = dataList.Count.ToString();
                });

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
                    if (index > Convert.ToInt32(this.textBox1.Text) - 1)
                    {
                        return;
                    }
                }
            });
        }

        private int _selectIndex = -1;
        private int _selectDataGrdiViewId = -1;

        private void dataGridView2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    _selectIndex = e.RowIndex;

                    MenuContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void ToLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogQuestionShowDetail(LeftDataGridView);
        }

        private void ToRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogQuestionShowDetail(RightDataGridView);
        }

        private void DialogQuestionShowDetail(DataGridView dataGridView)
        {
            var result = MessageBox.Show($"把 {_selectIndex + 1} 显示到左侧?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            var data = _logFileList[_selectIndex] ?? string.Empty;
            ShowDetail(dataGridView, data);
        }

        private void LeftDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.RightDataGridView.RowCount > 0)
            {
                this.RightDataGridView.FirstDisplayedScrollingRowIndex = Math.Min(this.LeftDataGridView.FirstDisplayedScrollingRowIndex, this.RightDataGridView.RowCount - 1);
                this.RightDataGridView.HorizontalScrollingOffset = this.LeftDataGridView.HorizontalScrollingOffset;
            }
        }

        private void RightDataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            if (this.LeftDataGridView.RowCount > 0)
            {
                this.LeftDataGridView.FirstDisplayedScrollingRowIndex = Math.Min(this.RightDataGridView.FirstDisplayedScrollingRowIndex, this.LeftDataGridView.RowCount - 1);
                this.LeftDataGridView.HorizontalScrollingOffset = this.RightDataGridView.HorizontalScrollingOffset;
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cell;
            if (_selectDataGrdiViewId == 1)
            {
                cell = LeftDataGridView.Rows[_selectIndex].Cells;
            }
            else if (_selectDataGrdiViewId == 2)
            {
                cell = RightDataGridView.Rows[_selectIndex].Cells;
            }
            else
            {
                return;
            }

            var keyName = cell[1].Value;

            var keyValue = cell[2].Value;

            var data = $"存档保存(\"{keyName}\",\"{keyValue}\")";
            Clipboard.SetText(data);

            MessageBox.Show($"内容复制成功:{data}");
        }

        private void LeftRightDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    _selectIndex = e.RowIndex;
                    var dataGridViewName = ((DataGridView)sender).Name;

                    if (dataGridViewName == nameof(LeftDataGridView))
                    {
                        _selectDataGrdiViewId = 1;
                    }
                    else if (dataGridViewName == nameof(RightDataGridView))
                    {
                        _selectDataGrdiViewId = 2;
                    }
                    else
                    {
                        _selectDataGrdiViewId = -1;
                    }

                    LeftRightContextMenuStrip.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LeftDataGridView.Rows.Count; i++)
            {
                if (RightDataGridView.Rows.Count >= i + 1)
                {
                    var leftCell = LeftDataGridView.Rows[i].Cells;

                    var leftKeyName = leftCell[1].Value.ToString();
                    var leftKeyValue = leftCell[2].Value.ToString();

                    var rightCell = RightDataGridView.Rows[i].Cells;

                    var rightKeyName = rightCell[1].Value.ToString();
                    var rightKeyValue = rightCell[2].Value.ToString();

                    if (leftKeyName != rightKeyName)
                    {
                        leftCell[1].Style.BackColor = Color.Yellow;
                    }
                    if (leftKeyValue != rightKeyValue)
                    {
                        leftCell[2].Style.BackColor = Color.Yellow;
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}