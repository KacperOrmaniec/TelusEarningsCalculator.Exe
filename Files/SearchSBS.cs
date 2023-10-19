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
    public partial class SearchSBS : Form
    {

        double searchSbs_60_rate = 0.137;
        double searchSbs_80_rate = 0.183;
        double searchSbs_90_rate = 0.206;
        double searchSbs_120_rate = 0.274;
        double searchSbs_160_rate = 0.365;
        double searchSbs_180_rate = 0.411;
        double searchSbs_240_rate = 0.548;
        double searchSbs_300_rate = 0.685;
        double searchSbs_320_rate = 0.731;
        double searchSbs_360_rate = 0.822;
        double searchSbs_420_rate = 0.959;
        double searchSbs_480_rate = 1.096;
        double searchSbs_540_rate = 1.233;
        double searchSbs_600_rate = 1.370;


        int sec60 = new int();
        int sec80 = new int();
        int sec90 = new int();
        int sec120 = new int();
        int sec160 = new int();
        int sec180 = new int();
        int sec240 = new int();
        int sec300 = new int();
        int sec320 = new int();
        int sec360 = new int();
        int sec420 = new int();
        int sec480 = new int();
        int sec540 = new int();
        int sec600 = new int();

        double result = new double();

        public SearchSBS()
        {
            InitializeComponent();
        }

        private void SearchSBS_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSBS60.Text != "")
            {
                sec60 = Convert.ToInt32(tbSBS60.Text);
            }

            else
            {
                sec60 = 0;
            }

            if (tbSBS80.Text != "")
            {
                sec80 = Convert.ToInt32(tbSBS80.Text);
            }

            else
            {
                sec80 = 0;
            }


            if (tbSBS90.Text != "")
            {
                sec90 = Convert.ToInt32(tbSBS90.Text);
            }

            else
            {
                sec90 = 0;
            }


            if (tbSBS120.Text != "")
            {
                sec120 = Convert.ToInt32(tbSBS120.Text);
            }

            else
            {
                sec120 = 0;
            }


            if (tbSBS160.Text != "")
            {
                sec160 = Convert.ToInt32(tbSBS160.Text);
            }

            else
            {
                sec160 = 0;
            }


            if (tbSBS180.Text != "")
            {
                sec180 = Convert.ToInt32(tbSBS180.Text);
            }

            else
            {
                sec180 = 0;
            }


            if (tbSBS240.Text != "")
            {
                sec240 = Convert.ToInt32(tbSBS240.Text);
            }

            else
            {
                sec240 = 0;
            }


            if (tbSBS300.Text != "")
            {
                sec300 = Convert.ToInt32(tbSBS300.Text);
            }

            else
            {
                sec300 = 0;
            }


            if (tbSBS320.Text != "")
            {
                sec320 = Convert.ToInt32(tbSBS320.Text);
            }

            else
            {
                sec320 = 0;
            }


            if (tbSBS360.Text != "")
            {
                sec360 = Convert.ToInt32(tbSBS360.Text);
            }

            else
            {
                sec360 = 0;
            }


            if (tbSBS420.Text != "")
            {
                sec420 = Convert.ToInt32(tbSBS420.Text);
            }

            else
            {
                sec420 = 0;
            }


            if (tbSBS480.Text != "")
            {
                sec480 = Convert.ToInt32(tbSBS480.Text);
            }

            else
            {
                sec480 = 0;
            }


            if (tbSBS540.Text != "")
            {
                sec540 = Convert.ToInt32(tbSBS540.Text);
            }

            else
            {
                sec540 = 0;
            }

            if (tbSBS600.Text != "")
            {
                sec600 = Convert.ToInt32(tbSBS600.Text);
            }

            else
            {
                sec600 = 0;
            }


            result = (sec60 * searchSbs_60_rate) + (sec80 * searchSbs_80_rate) + (sec90 * searchSbs_90_rate) +
                (sec120 * searchSbs_120_rate) + (sec160 * searchSbs_160_rate) + (sec180 * searchSbs_180_rate) +
                (sec240 * searchSbs_240_rate) + (sec300 * searchSbs_300_rate) + (sec320 * searchSbs_320_rate) +
                (sec360 * searchSbs_360_rate) + (sec420 * searchSbs_420_rate) + (sec480 * searchSbs_480_rate) +
                (sec540 * searchSbs_540_rate) + (sec600 * searchSbs_600_rate);

            tbResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
