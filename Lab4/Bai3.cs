using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            download(file_url_tb.Text, url_tb.Text);
        }
        private void download(string fileUrl, string url)
        {
            WebClient myClient = new WebClient();
            myClient.DownloadFile(url, fileUrl);
            Stream response = myClient.OpenRead(url);
            StreamReader reader = new StreamReader(response);
            content_rtb.Text = reader.ReadToEnd();
        }
    }
}
