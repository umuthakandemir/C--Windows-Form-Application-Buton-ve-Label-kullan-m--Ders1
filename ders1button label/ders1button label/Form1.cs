using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders1button_label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void btnIsim_Click(object sender, EventArgs e)
        {
            lblIsim.Text = "butona tıklandı..";
            sayac++;
            if (sayac == 2)
            {
                lblIsim.Text = "işlem tamamlandı..";
                btnIsim.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnIsim.Text = "TIKLA";
            lblIsim.Text = "";
        }
    }
}
