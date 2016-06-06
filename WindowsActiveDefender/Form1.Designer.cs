namespace WindowsActiveDefence
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.FileMonitorStartBtn = new System.Windows.Forms.Button();
            this.FileMonitorStopBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(672, 220);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // FileMonitorStartBtn
            // 
            this.FileMonitorStartBtn.Location = new System.Drawing.Point(12, 12);
            this.FileMonitorStartBtn.Name = "FileMonitorStartBtn";
            this.FileMonitorStartBtn.Size = new System.Drawing.Size(122, 23);
            this.FileMonitorStartBtn.TabIndex = 1;
            this.FileMonitorStartBtn.Text = "Start File Monitor";
            this.FileMonitorStartBtn.UseVisualStyleBackColor = true;
            // 
            // FileMonitorStopBtn
            // 
            this.FileMonitorStopBtn.Location = new System.Drawing.Point(140, 12);
            this.FileMonitorStopBtn.Name = "FileMonitorStopBtn";
            this.FileMonitorStopBtn.Size = new System.Drawing.Size(117, 23);
            this.FileMonitorStopBtn.TabIndex = 2;
            this.FileMonitorStopBtn.Text = "Stop File Monitor";
            this.FileMonitorStopBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 488);
            this.Controls.Add(this.FileMonitorStopBtn);
            this.Controls.Add(this.FileMonitorStartBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button FileMonitorStartBtn;
        private System.Windows.Forms.Button FileMonitorStopBtn;
    }
}

