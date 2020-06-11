using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bai2_Click(object sender, EventArgs e)
        {
            bai2 b2 = new bai2();
            b2.Show();
            
        }
    }
}
