namespace Lab4
{
    partial class Bai1
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
            this.url_tb = new System.Windows.Forms.TextBox();
            this.get_btn = new System.Windows.Forms.Button();
            this.content_rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // url_tb
            // 
            this.url_tb.Location = new System.Drawing.Point(25, 26);
            this.url_tb.Multiline = true;
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(638, 30);
            this.url_tb.TabIndex = 0;
            // 
            // get_btn
            // 
            this.get_btn.Location = new System.Drawing.Point(691, 26);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(97, 30);
            this.get_btn.TabIndex = 1;
            this.get_btn.Text = "GET";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.get_btn_Click);
            // 
            // content_rtb
            // 
            this.content_rtb.Location = new System.Drawing.Point(25, 90);
            this.content_rtb.Name = "content_rtb";
            this.content_rtb.Size = new System.Drawing.Size(763, 348);
            this.content_rtb.TabIndex = 2;
            this.content_rtb.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.content_rtb);
            this.Controls.Add(this.get_btn);
            this.Controls.Add(this.url_tb);
            this.Name = "Bai1";
            this.Text = "bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.RichTextBox content_rtb;
    }
}