using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelusEarningsCalculator
{
    public partial class WebQuery : Form
    {
        double webQuery_45_rate = 0.514;
        double webQuery_90_rate = 0.719;
        double webQuery_135_rate = 1.028;

        int sec45 = new int();
        int sec90 = new int();
        int sec135 = new int();

        double result = new double();
        public WebQuery()
        {
            InitializeComponent();
        }

        private void WebQuery_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void tbPE150_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPE120.Text != "")
            {
                sec45 = Convert.ToInt32(tbPE120.Text);
            }

            else
            {
                sec45 = 0;
            }

            if (tbPE150.Text != "")
            {
                sec90 = Convert.ToInt32(tbPE150.Text);
            }

            else
            {
                sec90 = 0;
            }

            if (tbPE330.Text != "")
            {
                sec135 = Convert.ToInt32(tbPE330.Text);
            }

            else
            {
                sec135 = 0;
            }

            result = (sec45 * webQuery_45_rate) + (sec90 * webQuery_90_rate) + (sec135 * webQuery_135_rate);

            tbResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
