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


            double R = double.Parse(txtR.Text);
            lblKq.Text = "- Diện Tích " + dientich(R) + "\n - Chu VI :" + chuvi(R);
        }
        double chuvi(double R) { return R * R * 3.14; }
        double dientich(double R) { return R * 3.14; }
    }
}
