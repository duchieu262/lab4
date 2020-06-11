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

        private void bai1_Click(object sender, EventArgs e)
        {
            Bai1 b1 = new Bai1();
            b1.Show();
        }

        private void bai3_Click(object sender, EventArgs e)
        {
            Bai3 b3 = new Bai3();
            b3.Show();
        }
    }
}
