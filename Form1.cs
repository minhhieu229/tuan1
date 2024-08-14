using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ptbh pt;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btgiaipt_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a =double.Parse( txta.Text);
            b= Convert.ToDouble(txtb.Text);
            bool k;
            k = double.TryParse(txtc.Text, out c);
            if(k)
            {
                pt = new ptbh(a, b, c);
                string kq=pt.giaipt();
                txtkq.Text = kq;

            }
        }
    }
}
