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
    public partial class Autocomplete : Form
    {

        double autocomplete_90_rate = 0.203;
        double autocomplete_100_rate = 0.225;
        double autocomplete_115_rate = 0.259;
        double autocomplete_190_rate = 0.427;
        double autocomplete_205_rate = 0.461;
        double autocomplete_220_rate = 0.495;
        double autocomplete_295_rate = 0.664;
        double autocomplete_370_rate = 0.832;
        double autocomplete_400_rate = 0.900;
        double autocomplete_475_rate = 1.069;
        double autocomplete_505_rate = 1.136;
        double autocomplete_550_rate = 1.237;
        double autocomplete_580_rate = 1.305;
        double autocomplete_730_rate = 1.642;
        double autocomplete_835_rate = 1.879;
        double autocomplete_910_rate = 2.047;

        int sec90 = new int();
        int sec100 = new int();
        int sec115 = new int();
        int sec190 = new int();
        int sec205 = new int();
        int sec220 = new int();
        int sec295 = new int();
        int sec370 = new int();
        int sec400 = new int();
        int sec475 = new int();
        int sec505 = new int();
        int sec550 = new int();
        int sec580 = new int();
        int sec730 = new int();
        int sec835 = new int();
        int sec910 = new int();

        double result = 0.00;
        public Autocomplete()
        {
            InitializeComponent();
        }

        private void Autocomplete_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void buttonAC1_Click(object sender, EventArgs e)
        {
            if (tbAC90.Text != "")
            {
                sec90 = Convert.ToInt32(tbAC90.Text);
            }

            else
            {
                sec90 = 0;
            }

            if (tbAC100.Text != "")
            {
                sec100 = Convert.ToInt32(tbAC100.Text);
            }

            else
            {
                sec100 = 0;
            }

            if (tbAC115.Text != "")
            {
                sec115 = Convert.ToInt32(tbAC115.Text);
            }

            else
            {
                sec115 = 0;
            }

            if (tbAC190.Text != "")
            {
                sec190 = Convert.ToInt32(tbAC190.Text);
            }

            else
            {
                sec190 = 0;
            }

            if (tbAC205.Text != "")
            {
                sec205 = Convert.ToInt32(tbAC205.Text);
            }

            else
            {
                sec205 = 0;
            }

            if (tbAC220.Text != "")
            {
                sec220 = Convert.ToInt32(tbAC220.Text);
            }

            else
            {
                sec220 = 0;
            }


            if (tbAC295.Text != "")
            {
                sec295 = Convert.ToInt32(tbAC295.Text);
            }

            else
            {
                sec295 = 0;
            }


            if (tbAC370.Text != "")
            {
                sec370 = Convert.ToInt32(tbAC370.Text);
            }

            else
            {
                sec370 = 0;
            }


            if (tbAC400.Text != "")
            {
                sec400 = Convert.ToInt32(tbAC400.Text);
            }

            else
            {
                sec400 = 0;
            }


            if (tbAC475.Text != "")
            {
                sec475 = Convert.ToInt32(tbAC475.Text);
            }

            else
            {
                sec475 = 0;
            }

            if (tbAC505.Text != "")
            {
                sec505 = Convert.ToInt32(tbAC505.Text);
            }

            else
            {
                sec505 = 0;
            }

            if (tbAC550.Text != "")
            {
                sec550 = Convert.ToInt32(tbAC550.Text);
            }

            else
            {
                sec550 = 0;
            }

            if (tbAC580.Text != "")
            {
                sec580 = Convert.ToInt32(tbAC580.Text);
            }

            else
            {
                sec580 = 0;
            }

            if (tbAC730.Text != "")
            {
                sec730 = Convert.ToInt32(tbAC730.Text);
            }

            else
            {
                sec730 = 0;
            }

            if (tbAC835.Text != "")
            {
                sec835 = Convert.ToInt32(tbAC835.Text);
            }

            else
            {
                sec835 = 0;
            }

            if (tbAC910.Text != "")
            {
                sec910 = Convert.ToInt32(tbAC910.Text);
            }

            else
            {
                sec910 = 0;
            }

            result = (sec90 * autocomplete_90_rate) + (sec100 * autocomplete_100_rate) + (sec115 * autocomplete_115_rate) + (sec190 * autocomplete_190_rate) +
                (sec205 * autocomplete_205_rate) + (sec220 * autocomplete_220_rate) + (sec295 * autocomplete_295_rate) + (sec370 * autocomplete_370_rate) +
                (sec400 * autocomplete_400_rate) + (sec475 * autocomplete_475_rate) + (sec505 * autocomplete_505_rate) + (sec550 * autocomplete_550_rate)
                + (sec580 * autocomplete_580_rate) + (sec730 * autocomplete_730_rate) + (sec835 * autocomplete_835_rate) + (sec910 * autocomplete_910_rate);

            tbACResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
