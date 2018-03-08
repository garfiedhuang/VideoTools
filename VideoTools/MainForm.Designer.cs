namespace Com.Garfield.VideoTools
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBottomRightCorner = new System.Windows.Forms.CheckBox();
            this.chkBottomLeftCorner = new System.Windows.Forms.CheckBox();
            this.chkTopRightCorner = new System.Windows.Forms.CheckBox();
            this.chkTopLeftCorner = new System.Windows.Forms.CheckBox();
            this.chkIsGenerateThumbnail = new System.Windows.Forms.CheckBox();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSelectWaterPicture = new System.Windows.Forms.Button();
            this.btnSelectVideoOutputDirectory = new System.Windows.Forms.Button();
            this.btnSelectVideoInputDirectory = new System.Windows.Forms.Button();
            this.txtWaterY = new System.Windows.Forms.TextBox();
            this.txtWaterX = new System.Windows.Forms.TextBox();
            this.txtWaterPicture = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVideoOutputDirectory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVideoInputDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbOutputLog = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkBottomRightCorner);
            this.groupBox1.Controls.Add(this.chkBottomLeftCorner);
            this.groupBox1.Controls.Add(this.chkTopRightCorner);
            this.groupBox1.Controls.Add(this.chkTopLeftCorner);
            this.groupBox1.Controls.Add(this.chkIsGenerateThumbnail);
            this.groupBox1.Controls.Add(this.btnOpenDirectory);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.btnSelectWaterPicture);
            this.groupBox1.Controls.Add(this.btnSelectVideoOutputDirectory);
            this.groupBox1.Controls.Add(this.btnSelectVideoInputDirectory);
            this.groupBox1.Controls.Add(this.txtWaterY);
            this.groupBox1.Controls.Add(this.txtWaterX);
            this.groupBox1.Controls.Add(this.txtWaterPicture);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVideoOutputDirectory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVideoInputDirectory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数设置";
            // 
            // chkBottomRightCorner
            // 
            this.chkBottomRightCorner.AutoSize = true;
            this.chkBottomRightCorner.Enabled = false;
            this.chkBottomRightCorner.Location = new System.Drawing.Point(349, 114);
            this.chkBottomRightCorner.Name = "chkBottomRightCorner";
            this.chkBottomRightCorner.Size = new System.Drawing.Size(60, 16);
            this.chkBottomRightCorner.TabIndex = 9;
            this.chkBottomRightCorner.Text = "右下角";
            this.chkBottomRightCorner.UseVisualStyleBackColor = true;
            this.chkBottomRightCorner.CheckedChanged += new System.EventHandler(this.chkBottomRightCorner_CheckedChanged);
            // 
            // chkBottomLeftCorner
            // 
            this.chkBottomLeftCorner.AutoSize = true;
            this.chkBottomLeftCorner.Enabled = false;
            this.chkBottomLeftCorner.Location = new System.Drawing.Point(263, 114);
            this.chkBottomLeftCorner.Name = "chkBottomLeftCorner";
            this.chkBottomLeftCorner.Size = new System.Drawing.Size(60, 16);
            this.chkBottomLeftCorner.TabIndex = 8;
            this.chkBottomLeftCorner.Text = "左下角";
            this.chkBottomLeftCorner.UseVisualStyleBackColor = true;
            this.chkBottomLeftCorner.CheckedChanged += new System.EventHandler(this.chkBottomLeftCorner_CheckedChanged);
            // 
            // chkTopRightCorner
            // 
            this.chkTopRightCorner.AutoSize = true;
            this.chkTopRightCorner.Checked = true;
            this.chkTopRightCorner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTopRightCorner.Location = new System.Drawing.Point(188, 114);
            this.chkTopRightCorner.Name = "chkTopRightCorner";
            this.chkTopRightCorner.Size = new System.Drawing.Size(60, 16);
            this.chkTopRightCorner.TabIndex = 7;
            this.chkTopRightCorner.Text = "右上角";
            this.chkTopRightCorner.UseVisualStyleBackColor = true;
            this.chkTopRightCorner.CheckedChanged += new System.EventHandler(this.chkTopRightCorner_CheckedChanged);
            // 
            // chkTopLeftCorner
            // 
            this.chkTopLeftCorner.AutoSize = true;
            this.chkTopLeftCorner.Location = new System.Drawing.Point(102, 114);
            this.chkTopLeftCorner.Name = "chkTopLeftCorner";
            this.chkTopLeftCorner.Size = new System.Drawing.Size(60, 16);
            this.chkTopLeftCorner.TabIndex = 6;
            this.chkTopLeftCorner.Text = "左上角";
            this.chkTopLeftCorner.UseVisualStyleBackColor = true;
            this.chkTopLeftCorner.CheckedChanged += new System.EventHandler(this.chkTopLeftCorner_CheckedChanged);
            // 
            // chkIsGenerateThumbnail
            // 
            this.chkIsGenerateThumbnail.AutoSize = true;
            this.chkIsGenerateThumbnail.Location = new System.Drawing.Point(525, 116);
            this.chkIsGenerateThumbnail.Name = "chkIsGenerateThumbnail";
            this.chkIsGenerateThumbnail.Size = new System.Drawing.Size(108, 16);
            this.chkIsGenerateThumbnail.TabIndex = 10;
            this.chkIsGenerateThumbnail.Text = "是否生成缩略图";
            this.chkIsGenerateThumbnail.UseVisualStyleBackColor = true;
            this.chkIsGenerateThumbnail.CheckedChanged += new System.EventHandler(this.chkIsGenerateThumbnail_CheckedChanged);
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Location = new System.Drawing.Point(715, 54);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDirectory.TabIndex = 4;
            this.btnOpenDirectory.Text = "打开";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcess.Location = new System.Drawing.Point(634, 135);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(156, 40);
            this.btnProcess.TabIndex = 13;
            this.btnProcess.Text = "一键处理";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSelectWaterPicture
            // 
            this.btnSelectWaterPicture.Location = new System.Drawing.Point(634, 81);
            this.btnSelectWaterPicture.Name = "btnSelectWaterPicture";
            this.btnSelectWaterPicture.Size = new System.Drawing.Size(75, 23);
            this.btnSelectWaterPicture.TabIndex = 5;
            this.btnSelectWaterPicture.Text = "选择";
            this.btnSelectWaterPicture.UseVisualStyleBackColor = true;
            this.btnSelectWaterPicture.Click += new System.EventHandler(this.btnSelectWaterPicture_Click);
            // 
            // btnSelectVideoOutputDirectory
            // 
            this.btnSelectVideoOutputDirectory.Location = new System.Drawing.Point(634, 54);
            this.btnSelectVideoOutputDirectory.Name = "btnSelectVideoOutputDirectory";
            this.btnSelectVideoOutputDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSelectVideoOutputDirectory.TabIndex = 3;
            this.btnSelectVideoOutputDirectory.Text = "选择";
            this.btnSelectVideoOutputDirectory.UseVisualStyleBackColor = true;
            this.btnSelectVideoOutputDirectory.Click += new System.EventHandler(this.btnSelectVideoOutputDirectory_Click);
            // 
            // btnSelectVideoInputDirectory
            // 
            this.btnSelectVideoInputDirectory.Location = new System.Drawing.Point(634, 28);
            this.btnSelectVideoInputDirectory.Name = "btnSelectVideoInputDirectory";
            this.btnSelectVideoInputDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnSelectVideoInputDirectory.TabIndex = 1;
            this.btnSelectVideoInputDirectory.Text = "选择";
            this.btnSelectVideoInputDirectory.UseVisualStyleBackColor = true;
            this.btnSelectVideoInputDirectory.Click += new System.EventHandler(this.btnSelectVideoInputDirectory_Click);
            // 
            // txtWaterY
            // 
            this.txtWaterY.Location = new System.Drawing.Point(268, 137);
            this.txtWaterY.Name = "txtWaterY";
            this.txtWaterY.ReadOnly = true;
            this.txtWaterY.Size = new System.Drawing.Size(59, 21);
            this.txtWaterY.TabIndex = 12;
            this.txtWaterY.Text = "10";
            this.txtWaterY.TextChanged += new System.EventHandler(this.txtWaterY_TextChanged);
            // 
            // txtWaterX
            // 
            this.txtWaterX.Location = new System.Drawing.Point(116, 137);
            this.txtWaterX.Name = "txtWaterX";
            this.txtWaterX.ReadOnly = true;
            this.txtWaterX.Size = new System.Drawing.Size(59, 21);
            this.txtWaterX.TabIndex = 11;
            this.txtWaterX.Text = "10";
            this.txtWaterX.TextChanged += new System.EventHandler(this.txtWaterX_TextChanged);
            // 
            // txtWaterPicture
            // 
            this.txtWaterPicture.Location = new System.Drawing.Point(102, 83);
            this.txtWaterPicture.Name = "txtWaterPicture";
            this.txtWaterPicture.ReadOnly = true;
            this.txtWaterPicture.Size = new System.Drawing.Size(525, 21);
            this.txtWaterPicture.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "水印坐标(Y)：";
            // 
            // txtVideoOutputDirectory
            // 
            this.txtVideoOutputDirectory.Location = new System.Drawing.Point(102, 56);
            this.txtVideoOutputDirectory.Name = "txtVideoOutputDirectory";
            this.txtVideoOutputDirectory.ReadOnly = true;
            this.txtVideoOutputDirectory.Size = new System.Drawing.Size(525, 21);
            this.txtVideoOutputDirectory.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "水印坐标(X)：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "水印位置：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "水印图片：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输出目录：";
            // 
            // txtVideoInputDirectory
            // 
            this.txtVideoInputDirectory.Location = new System.Drawing.Point(102, 29);
            this.txtVideoInputDirectory.Name = "txtVideoInputDirectory";
            this.txtVideoInputDirectory.ReadOnly = true;
            this.txtVideoInputDirectory.Size = new System.Drawing.Size(525, 21);
            this.txtVideoInputDirectory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "视频目录：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rtbOutputLog);
            this.groupBox2.Location = new System.Drawing.Point(13, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 292);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输出日志";
            // 
            // rtbOutputLog
            // 
            this.rtbOutputLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutputLog.BackColor = System.Drawing.Color.White;
            this.rtbOutputLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbOutputLog.ForeColor = System.Drawing.Color.Green;
            this.rtbOutputLog.Location = new System.Drawing.Point(6, 20);
            this.rtbOutputLog.Name = "rtbOutputLog";
            this.rtbOutputLog.ReadOnly = true;
            this.rtbOutputLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbOutputLog.Size = new System.Drawing.Size(799, 266);
            this.rtbOutputLog.TabIndex = 14;
            this.rtbOutputLog.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Water Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtVideoInputDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVideoOutputDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWaterPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Button btnSelectVideoOutputDirectory;
        private System.Windows.Forms.Button btnSelectVideoInputDirectory;
        private System.Windows.Forms.Button btnSelectWaterPicture;
        private System.Windows.Forms.CheckBox chkIsGenerateThumbnail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaterY;
        private System.Windows.Forms.TextBox txtWaterX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBottomRightCorner;
        private System.Windows.Forms.CheckBox chkBottomLeftCorner;
        private System.Windows.Forms.CheckBox chkTopRightCorner;
        private System.Windows.Forms.CheckBox chkTopLeftCorner;
        private System.Windows.Forms.RichTextBox rtbOutputLog;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

