namespace Lab4
{
    partial class Bai3
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
            this.download_btn = new System.Windows.Forms.Button();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.file_url_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.content_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(668, 12);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(110, 30);
            this.download_btn.TabIndex = 3;
            this.download_btn.Text = "DOWNLOAD";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // url_tb
            // 
            this.url_tb.Location = new System.Drawing.Point(168, 12);
            this.url_tb.Multiline = true;
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(482, 30);
            this.url_tb.TabIndex = 2;
            // 
            // file_url_tb
            // 
            this.file_url_tb.Location = new System.Drawing.Point(168, 70);
            this.file_url_tb.Multiline = true;
            this.file_url_tb.Name = "file_url_tb";
            this.file_url_tb.Size = new System.Drawing.Size(482, 30);
            this.file_url_tb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "File URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Web URL";
            // 
            // content_rtb
            // 
            this.content_rtb.Location = new System.Drawing.Point(12, 131);
            this.content_rtb.Name = "content_rtb";
            this.content_rtb.Size = new System.Drawing.Size(766, 307);
            this.content_rtb.TabIndex = 7;
            this.content_rtb.Text = "";
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content_rtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file_url_tb);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.url_tb);
            this.Name = "bai3";
            this.Text = "bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.TextBox file_url_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox content_rtb;
    }
}