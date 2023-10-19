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
    public partial class Search2 : Form
    {
        double search2_90_rate = 0.206;
        double search2_100_rate = 0.228;
        double search2_115_rate = 0.263;
        double search2_190_rate = 0.434;
        double search2_205_rate = 0.468;
        double search2_220_rate = 0.502;
        double search2_280_rate = 0.639;
        double search2_295_rate = 0.674;
        double search2_310_rate = 0.708;
        double search2_325_rate = 0.742;
        double search2_370_rate = 0.845;
        double search2_385_rate = 0.879;
        double search2_400_rate = 0.913;
        double search2_460_rate = 1.050;
        double search2_475_rate = 1.085;
        double search2_550_rate = 1.256;

        int sec90 = new int();
        int sec100 = new int();
        int sec115 = new int();
        int sec190 = new int();
        int sec205 = new int();
        int sec220 = new int();
        int sec280 = new int();
        int sec295 = new int();
        int sec310 = new int();
        int sec325 = new int();
        int sec370 = new int();
        int sec385 = new int();
        int sec400 = new int();
        int sec460 = new int();
        int sec475 = new int();
        int sec550 = new int();


        double result = 0.00;

        public Search2()
        {
            InitializeComponent();
        }

        private void Search2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb90.Text != "")
            {
                sec90 = Convert.ToInt32(tb90.Text);
            }

            else
            {
                sec90 = 0;
            }

            if (tb100.Text != "")
            {
                sec100 = Convert.ToInt32(tb100.Text);
            }

            else
            {
                sec100 = 0;
            }

            if (tb115.Text != "")
            {
                sec115 = Convert.ToInt32(tb115.Text);
            }

            else
            {
                sec115 = 0;
            }

            if (tb190.Text != "")
            {
                sec190 = Convert.ToInt32(tb190.Text);
            }

            else
            {
                sec190 = 0;
            }

            if (tb205.Text != "")
            {
                sec205 = Convert.ToInt32(tb205.Text);
            }

            else
            {
                sec205 = 0;
            }

            if (tb220.Text != "")
            {
                sec220 = Convert.ToInt32(tb220.Text);
            }

            else
            {
                sec220 = 0;
            }

            if (tb280.Text != "")
            {
                sec280 = Convert.ToInt32(tb280.Text);
            }

            else
            {
                sec280 = 0;
            }

            if (tb295.Text != "")
            {
                sec295 = Convert.ToInt32(tb295.Text);
            }

            else
            {
                sec295 = 0;
            }

            if (tb310.Text != "")
            {
                sec310 = Convert.ToInt32(tb310.Text);
            }

            else
            {
                sec310 = 0;
            }

            if (tb325.Text != "")
            {
                sec325 = Convert.ToInt32(tb325.Text);
            }

            else
            {
                sec325 = 0;
            }
            if (tb370.Text != "")
            {
                sec370 = Convert.ToInt32(tb370.Text);
            }

            else
            {
                sec370 = 0;
            }

            if (tb385.Text != "")
            {
                sec385 = Convert.ToInt32(tb385.Text);
            }

            else
            {
                sec385 = 0;
            }

            if (tb400.Text != "")
            {
                sec400 = Convert.ToInt32(tb400.Text);
            }

            else
            {
                sec400 = 0;
            }

            if (tb460.Text != "")
            {
                sec460 = Convert.ToInt32(tb460.Text);
            }

            else
            {
                sec460 = 0;
            }

            if (tb475.Text != "")
            {
                sec475 = Convert.ToInt32(tb475.Text);
            }

            else
            {
                sec475 = 0;
            }

            if (tb550.Text != "")
            {
                sec550 = Convert.ToInt32(tb550.Text);
            }

            else
            {
                sec550 = 0;
            }

            result = (sec90 * search2_90_rate) + (sec100 * search2_100_rate) + (sec115 * search2_115_rate) + (sec190 * search2_190_rate) +
                (sec205 * search2_205_rate) + (sec220 * search2_220_rate) + (sec280 * search2_280_rate) + (sec295 * search2_295_rate) +
                (sec310 * search2_310_rate) + (sec325 * search2_325_rate) + (sec370 * search2_370_rate) + (sec385 * search2_385_rate) +
                (sec400 * search2_400_rate) + (sec460 * search2_460_rate) + (sec475 * search2_475_rate) + (sec550 * search2_550_rate);

            tbResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
