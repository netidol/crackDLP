namespace PowerPoint
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.单文件操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.多文件操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量解密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量还原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单文件操作ToolStripMenuItem,
            this.多文件操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 单文件操作ToolStripMenuItem
            // 
            this.单文件操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.解密ToolStripMenuItem,
            this.还原ToolStripMenuItem});
            this.单文件操作ToolStripMenuItem.Name = "单文件操作ToolStripMenuItem";
            this.单文件操作ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.单文件操作ToolStripMenuItem.Text = "单文件操作";
            // 
            // 解密ToolStripMenuItem
            // 
            this.解密ToolStripMenuItem.Name = "解密ToolStripMenuItem";
            this.解密ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.解密ToolStripMenuItem.Text = "单文件解密";
            this.解密ToolStripMenuItem.Click += new System.EventHandler(this.解密ToolStripMenuItem_Click);
            // 
            // 还原ToolStripMenuItem
            // 
            this.还原ToolStripMenuItem.Name = "还原ToolStripMenuItem";
            this.还原ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.还原ToolStripMenuItem.Text = "单文件还原";
            // 
            // 多文件操作ToolStripMenuItem
            // 
            this.多文件操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.批量解密ToolStripMenuItem,
            this.批量还原ToolStripMenuItem});
            this.多文件操作ToolStripMenuItem.Name = "多文件操作ToolStripMenuItem";
            this.多文件操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.多文件操作ToolStripMenuItem.Text = "批量操作";
            // 
            // 批量解密ToolStripMenuItem
            // 
            this.批量解密ToolStripMenuItem.Name = "批量解密ToolStripMenuItem";
            this.批量解密ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.批量解密ToolStripMenuItem.Text = "批量解密";
            this.批量解密ToolStripMenuItem.Click += new System.EventHandler(this.批量解密ToolStripMenuItem_Click);
            // 
            // 批量还原ToolStripMenuItem
            // 
            this.批量还原ToolStripMenuItem.Name = "批量还原ToolStripMenuItem";
            this.批量还原ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.批量还原ToolStripMenuItem.Text = "批量还原";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 42);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 27);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 单文件操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 还原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 多文件操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量解密ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量还原ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

