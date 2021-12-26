namespace DzCd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.RightDataGridView = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilesDataGridView = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftRightSplitContainer = new System.Windows.Forms.SplitContainer();
            this.LeftDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalLable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MenuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.LeftRightContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RightDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRightSplitContainer)).BeginInit();
            this.LeftRightSplitContainer.Panel1.SuspendLayout();
            this.LeftRightSplitContainer.Panel2.SuspendLayout();
            this.LeftRightSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.MenuContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.LeftRightContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "获取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RightDataGridView
            // 
            this.RightDataGridView.AllowUserToAddRows = false;
            this.RightDataGridView.AllowUserToDeleteRows = false;
            this.RightDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RightDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RightDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.名称,
            this.值});
            this.RightDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RightDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.RightDataGridView.Name = "RightDataGridView";
            this.RightDataGridView.RowTemplate.Height = 25;
            this.RightDataGridView.Size = new System.Drawing.Size(924, 734);
            this.RightDataGridView.TabIndex = 1;
            this.RightDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LeftRightDataGridView_CellMouseDown);
            this.RightDataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RightDataGridView_Scroll);
            // 
            // 序号
            // 
            this.序号.HeaderText = "*";
            this.序号.Name = "序号";
            this.序号.Width = 43;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.Width = 71;
            // 
            // 值
            // 
            this.值.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.值.HeaderText = "值";
            this.值.Name = "值";
            // 
            // FilesDataGridView
            // 
            this.FilesDataGridView.AllowUserToAddRows = false;
            this.FilesDataGridView.AllowUserToDeleteRows = false;
            this.FilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.时间});
            this.FilesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FilesDataGridView.Name = "FilesDataGridView";
            this.FilesDataGridView.ReadOnly = true;
            this.FilesDataGridView.RowTemplate.Height = 25;
            this.FilesDataGridView.Size = new System.Drawing.Size(246, 734);
            this.FilesDataGridView.TabIndex = 2;
            this.FilesDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseDown);
            // 
            // 编号
            // 
            this.编号.HeaderText = "*";
            this.编号.Name = "编号";
            this.编号.ReadOnly = true;
            this.编号.Width = 50;
            // 
            // 时间
            // 
            this.时间.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.时间.HeaderText = "时间";
            this.时间.Name = "时间";
            this.时间.ReadOnly = true;
            // 
            // LeftRightSplitContainer
            // 
            this.LeftRightSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.LeftRightSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftRightSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.LeftRightSplitContainer.Name = "LeftRightSplitContainer";
            // 
            // LeftRightSplitContainer.Panel1
            // 
            this.LeftRightSplitContainer.Panel1.Controls.Add(this.LeftDataGridView);
            // 
            // LeftRightSplitContainer.Panel2
            // 
            this.LeftRightSplitContainer.Panel2.Controls.Add(this.RightDataGridView);
            this.LeftRightSplitContainer.Size = new System.Drawing.Size(1556, 734);
            this.LeftRightSplitContainer.SplitterDistance = 628;
            this.LeftRightSplitContainer.TabIndex = 6;
            // 
            // LeftDataGridView
            // 
            this.LeftDataGridView.AllowUserToAddRows = false;
            this.LeftDataGridView.AllowUserToDeleteRows = false;
            this.LeftDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LeftDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.LeftDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LeftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LeftDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.LeftDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftDataGridView.Location = new System.Drawing.Point(0, 0);
            this.LeftDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.LeftDataGridView.Name = "LeftDataGridView";
            this.LeftDataGridView.RowTemplate.Height = 25;
            this.LeftDataGridView.Size = new System.Drawing.Size(628, 734);
            this.LeftDataGridView.TabIndex = 3;
            this.LeftDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LeftRightDataGridView_CellMouseDown);
            this.LeftDataGridView.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LeftDataGridView_Scroll);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "*";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 71;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "值";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TotalLable);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1806, 51);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(821, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "对比";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "/";
            // 
            // TotalLable
            // 
            this.TotalLable.AutoSize = true;
            this.TotalLable.Location = new System.Drawing.Point(307, 16);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(46, 24);
            this.TotalLable.TabIndex = 2;
            this.TotalLable.Text = "总数";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "50";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MenuContextMenuStrip
            // 
            this.MenuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToLeftToolStripMenuItem,
            this.ToRightToolStripMenuItem});
            this.MenuContextMenuStrip.Name = "contextMenuStrip1";
            this.MenuContextMenuStrip.Size = new System.Drawing.Size(137, 48);
            // 
            // ToLeftToolStripMenuItem
            // 
            this.ToLeftToolStripMenuItem.Name = "ToLeftToolStripMenuItem";
            this.ToLeftToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ToLeftToolStripMenuItem.Text = "显示到左侧";
            this.ToLeftToolStripMenuItem.Click += new System.EventHandler(this.ToLeftToolStripMenuItem_Click);
            // 
            // ToRightToolStripMenuItem
            // 
            this.ToRightToolStripMenuItem.Name = "ToRightToolStripMenuItem";
            this.ToRightToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ToRightToolStripMenuItem.Text = "显示到右侧";
            this.ToRightToolStripMenuItem.Click += new System.EventHandler(this.ToRightToolStripMenuItem_Click);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 57);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.FilesDataGridView);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.LeftRightSplitContainer);
            this.MainSplitContainer.Size = new System.Drawing.Size(1806, 734);
            this.MainSplitContainer.SplitterDistance = 246;
            this.MainSplitContainer.TabIndex = 4;
            // 
            // LeftRightContextMenuStrip
            // 
            this.LeftRightContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem});
            this.LeftRightContextMenuStrip.Name = "LeftRightContextMenuStrip";
            this.LeftRightContextMenuStrip.Size = new System.Drawing.Size(125, 26);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.CopyToolStripMenuItem.Text = "复制结果";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 791);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "存档对比工具";
            ((System.ComponentModel.ISupportInitialize)(this.RightDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).EndInit();
            this.LeftRightSplitContainer.Panel1.ResumeLayout(false);
            this.LeftRightSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftRightSplitContainer)).EndInit();
            this.LeftRightSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MenuContextMenuStrip.ResumeLayout(false);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.LeftRightContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DataGridView RightDataGridView;
        private DataGridView FilesDataGridView;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private Label TotalLable;
        private ContextMenuStrip MenuContextMenuStrip;
        private ToolStripMenuItem ToLeftToolStripMenuItem;
        private ToolStripMenuItem ToRightToolStripMenuItem;
        private DataGridView LeftDataGridView;
        private SplitContainer LeftRightSplitContainer;
        private DataGridViewTextBoxColumn 序号;
        private DataGridViewTextBoxColumn 名称;
        private DataGridViewTextBoxColumn 值;
        private DataGridViewTextBoxColumn 编号;
        private DataGridViewTextBoxColumn 时间;
        private SplitContainer MainSplitContainer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private ContextMenuStrip LeftRightContextMenuStrip;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private Button button2;
    }
}