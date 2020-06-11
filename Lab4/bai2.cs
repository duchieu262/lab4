using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Lab4
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }
        WebClient client = new WebClient();
        private void download_btn_Click(object sender, EventArgs e)
        {
            byte[] response = client.DownloadData(url_tb.Text);
            data_rtb.Text = Encoding.UTF8.GetString(response);
            WebHeaderCollection whc = client.ResponseHeaders;
            int stt = 1;
            string[] header = whc.ToString().Split('\n');
            foreach(var h in header)
            {
                if(h != "\r" && h != "")
                {
                    int index = h.IndexOf(':');
                    printHeader(stt, h.Substring(0, index), h.Substring(index + 1));
                    stt++;
                }
                
            }
        }
        private void printHeader(int stt, string header, string value)
        {
            ListViewItem it = new ListViewItem(stt.ToString());
            ListViewItem.ListViewSubItem h = new ListViewItem.ListViewSubItem(it,header);
            ListViewItem.ListViewSubItem v = new ListViewItem.ListViewSubItem(it, value);
            it.SubItems.Add(h);
            it.SubItems.Add(v);
            header_lv.Items.Add(it);
        }
    }
}
