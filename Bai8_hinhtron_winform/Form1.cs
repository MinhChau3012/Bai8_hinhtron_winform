using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_hinhtron_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            double R,chuvi;
            double PI = 3.14;
            R = Convert.ToDouble(txtR.Text);

            double p = R* PI;
            txtKq.Text = p.ToString();
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            double R, dientich;
            double PI = 3.14;
            R = Convert.ToDouble(txtR.Text);

            double s = R * R * PI;
            txtKq.Text = s.ToString();
        }
    }
}
