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
    public partial class PoiEvaluation : Form
    {
        double POIEvaluation_120_rate = 0.274;
        double POIEvaluation_150_rate = 0.343;
        double POIEvaluation_330_rate = 0.754;
        double POIEvaluation_345_rate = 0.788;
        double POIEvaluation_375_rate = 0.856;
        double POIEvaluation_390_rate = 0.891;
        double POIEvaluation_420_rate = 0.959;

        int sec120 = new int();
        int sec150 = new int();
        int sec330 = new int();
        int sec345 = new int();
        int sec375 = new int();
        int sec390 = new int();
        int sec420 = new int();

        double result = new double();
        public PoiEvaluation()
        {
            InitializeComponent();
        }

        private void PoiEvaluation_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbPE120.Text != "")
            {
                sec120 = Convert.ToInt32(tbPE120.Text);
            }

            else
            {
                sec120 = 0;
            }


            if (tbPE150.Text != "")
            {
                sec150 = Convert.ToInt32(tbPE150.Text);
            }

            else
            {
                sec150 = 0;
            }

            if (tbPE330.Text != "")
            {
                sec120 = Convert.ToInt32(tbPE330.Text);
            }

            else
            {
                sec330 = 0;
            }

            if (tbPE345.Text != "")
            {
                sec345 = Convert.ToInt32(tbPE345.Text);
            }

            else
            {
                sec345 = 0;
            }

            if (tbPE375.Text != "")
            {
                sec375 = Convert.ToInt32(tbPE375.Text);
            }

            else
            {
                sec375 = 0;
            }

            if (tbPE390.Text != "")
            {
                sec390 = Convert.ToInt32(tbPE390.Text);
            }

            else
            {
                sec390 = 0;
            }

            if (tbPE420.Text != "")
            {
                sec420 = Convert.ToInt32(tbPE420.Text);
            }

            else
            {
                sec420 = 0;
            }

            result = (sec120 * POIEvaluation_120_rate) + (sec150 * POIEvaluation_150_rate) + (sec330 * POIEvaluation_330_rate) +
            (sec345 * POIEvaluation_345_rate) + (sec375 * POIEvaluation_375_rate) + (sec390 * POIEvaluation_390_rate) + (sec420 * POIEvaluation_420_rate);

            tbResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
