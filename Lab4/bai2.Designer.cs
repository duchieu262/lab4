namespace Lab4
{
    partial class bai2
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
            this.data_rtb = new System.Windows.Forms.RichTextBox();
            this.header_lv = new System.Windows.Forms.ListView();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.download_btn = new System.Windows.Forms.Button();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Header = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // data_rtb
            // 
            this.data_rtb.Location = new System.Drawing.Point(12, 70);
            this.data_rtb.Name = "data_rtb";
            this.data_rtb.Size = new System.Drawing.Size(566, 476);
            this.data_rtb.TabIndex = 0;
            this.data_rtb.Text = "";
            // 
            // header_lv
            // 
            this.header_lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Header,
            this.Value});
            this.header_lv.Location = new System.Drawing.Point(618, 70);
            this.header_lv.Name = "header_lv";
            this.header_lv.Size = new System.Drawing.Size(413, 476);
            this.header_lv.TabIndex = 1;
            this.header_lv.UseCompatibleStateImageBehavior = false;
            this.header_lv.View = System.Windows.Forms.View.Details;
            // 
            // url_tb
            // 
            this.url_tb.Location = new System.Drawing.Point(13, 22);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(566, 22);
            this.url_tb.TabIndex = 2;
            this.url_tb.Text = "http://nc.uit.edu.vn";
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(618, 20);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(120, 23);
            this.download_btn.TabIndex = 3;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 53;
            // 
            // Header
            // 
            this.Header.Text = "Header";
            this.Header.Width = 118;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 186;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 580);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.url_tb);
            this.Controls.Add(this.header_lv);
            this.Controls.Add(this.data_rtb);
            this.Name = "bai2";
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox data_rtb;
        private System.Windows.Forms.ListView header_lv;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Header;
        private System.Windows.Forms.ColumnHeader Value;
    }
}