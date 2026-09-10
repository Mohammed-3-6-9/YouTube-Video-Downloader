namespace Download_Youtube_Videos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVideoQuality = new System.Windows.Forms.ComboBox();
            this.cbAudioQuality = new System.Windows.Forms.ComboBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVideoCodec = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAudioCodec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.llblLinkedIn = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.llblGitHub = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video Quality :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(502, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Audio Quality :";
            // 
            // cbVideoQuality
            // 
            this.cbVideoQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbVideoQuality.FormattingEnabled = true;
            this.cbVideoQuality.Items.AddRange(new object[] {
            "144p",
            "240p",
            "360p",
            "480p",
            "720p",
            "1080p",
            "1440p",
            "2160p",
            "Best"});
            this.cbVideoQuality.Location = new System.Drawing.Point(186, 155);
            this.cbVideoQuality.Name = "cbVideoQuality";
            this.cbVideoQuality.Size = new System.Drawing.Size(228, 37);
            this.cbVideoQuality.TabIndex = 2;
            // 
            // cbAudioQuality
            // 
            this.cbAudioQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbAudioQuality.FormattingEnabled = true;
            this.cbAudioQuality.Items.AddRange(new object[] {
            "Auto",
            "64 kbps",
            "128 kbps",
            "160 kbps",
            "192 kbps",
            "256 kbps",
            "Best"});
            this.cbAudioQuality.Location = new System.Drawing.Point(675, 155);
            this.cbAudioQuality.Name = "cbAudioQuality";
            this.cbAudioQuality.Size = new System.Drawing.Size(228, 37);
            this.cbAudioQuality.TabIndex = 3;
            // 
            // cbFormat
            // 
            this.cbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "MP4",
            "MKV",
            "WebM"});
            this.cbFormat.Location = new System.Drawing.Point(213, 276);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(228, 37);
            this.cbFormat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Format :";
            // 
            // cbVideoCodec
            // 
            this.cbVideoCodec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbVideoCodec.FormattingEnabled = true;
            this.cbVideoCodec.Items.AddRange(new object[] {
            "Auto (Recommended)",
            "AV1",
            "VP9",
            "H.264"});
            this.cbVideoCodec.Location = new System.Drawing.Point(213, 332);
            this.cbVideoCodec.Name = "cbVideoCodec";
            this.cbVideoCodec.Size = new System.Drawing.Size(228, 37);
            this.cbVideoCodec.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Video Codec :";
            // 
            // cbAudioCodec
            // 
            this.cbAudioCodec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbAudioCodec.FormattingEnabled = true;
            this.cbAudioCodec.Items.AddRange(new object[] {
            "Auto (Recommended)",
            "Opus",
            "AAC"});
            this.cbAudioCodec.Location = new System.Drawing.Point(703, 332);
            this.cbAudioCodec.Name = "cbAudioCodec";
            this.cbAudioCodec.Size = new System.Drawing.Size(228, 37);
            this.cbAudioCodec.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(502, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Audio Codec :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBox1.Location = new System.Drawing.Point(41, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(235, 33);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Advanced Options";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(149, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(782, 67);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(35, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "URL : ";
            // 
            // llblLinkedIn
            // 
            this.llblLinkedIn.AutoSize = true;
            this.llblLinkedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.llblLinkedIn.Location = new System.Drawing.Point(457, 424);
            this.llblLinkedIn.Name = "llblLinkedIn";
            this.llblLinkedIn.Size = new System.Drawing.Size(77, 22);
            this.llblLinkedIn.TabIndex = 13;
            this.llblLinkedIn.TabStop = true;
            this.llblLinkedIn.Text = "LinkedIn";
            this.llblLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLinkedIn_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(321, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "© 2026 Mohammed Tawfiq · Open Source";
            // 
            // llblGitHub
            // 
            this.llblGitHub.AutoSize = true;
            this.llblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.llblGitHub.Location = new System.Drawing.Point(552, 424);
            this.llblGitHub.Name = "llblGitHub";
            this.llblGitHub.Size = new System.Drawing.Size(66, 22);
            this.llblGitHub.TabIndex = 15;
            this.llblGitHub.TabStop = true;
            this.llblGitHub.Text = "GitHub";
            this.llblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGitHub_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(350, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Follow Me :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(954, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.llblGitHub);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.llblLinkedIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbAudioCodec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbVideoCodec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAudioQuality);
            this.Controls.Add(this.cbVideoQuality);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbVideoQuality;
        private System.Windows.Forms.ComboBox cbAudioQuality;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVideoCodec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAudioCodec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llblLinkedIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llblGitHub;
        private System.Windows.Forms.Label label8;
    }
}

