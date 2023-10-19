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
    public partial class SearchAds : Form
    {
        double searchAdsCV_225_rate = 0.514;
        double searchAdsCV_315_rate = 0.719;
        double searchAdsCV_450_rate = 1.028;

        int sec225 = new int();
        int sec315 = new int();
        int sec450 = new int();

        double result = new double();
        public SearchAds()
        {
            InitializeComponent();
        }

        private void SearchAds_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tbPE120.Text != "")
            {
                sec225 = Convert.ToInt32(tbPE120.Text);
            }

            else
            {
                sec225 = 0;
            }

            if (tbPE150.Text != "")
            {
                sec315 = Convert.ToInt32(tbPE150.Text);
            }

            else
            {
                sec315 = 0;
            }

            if (tbPE330.Text != "")
            {
                sec450 = Convert.ToInt32(tbPE330.Text);
            }

            else
            {
                sec450 = 0;
            }

            result = (sec225 * searchAdsCV_225_rate) + (sec315 * searchAdsCV_315_rate) + (sec450 * searchAdsCV_450_rate);

            tbResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
