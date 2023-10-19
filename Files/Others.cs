using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TelusEarningsCalculator
{
    public partial class Others : Form
    {
        double nameEvaluation_120_rate = 0.274;
        double nameTranslation_30_rate = 0.069;
        double ACQuery_30_rate = 0.069;
        double CNTC_45_rate = 0.103;
        double CNTC_120_rate = 0.274;
        double crosswalkAnnotation_240_rate = 0.548;
        double MNE_360_rate = 0.822;
        double drivingNavigation_120_rate = 0.274;
        double queryIntent_200_rate = 0.457;
        double mapQueryIntent_120_rate = 0.274;
        double addressVerification_210_rate = 0.588;
        double POI_180_rate = 0.411;

        int nameEvaluation = new int();
        int nameTranslation = new int();
        int ACQuery = new int();
        int CNTC_45 = new int();
        int CNTC_120 = new int();
        int crosswalkAnnotation = new int();
        int MNE = new int();
        int drivingNavigation = new int();
        int queryIntent = new int();
        int mapQueryIntent = new int();
        int addressVerification = new int();
        int POI = new int();

        double result = new double();
        public Others()
        {
            InitializeComponent();
        }

        private void Others_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNE120.Text != "")
            {
                nameEvaluation = Convert.ToInt32(tbNE120.Text);
            }

            else
            {
                nameEvaluation = 0;
            }


            if (tbNT30.Text != "")
            {
                nameTranslation = Convert.ToInt32(tbNT30.Text);
            }

            else
            {
                nameTranslation = 0;
            }


            if (tbAC30.Text != "")
            {
                ACQuery = Convert.ToInt32(tbAC30.Text);
            }

            else
            {
                ACQuery = 0;
            }


            if (tbNR120.Text != "")
            {
                CNTC_120 = Convert.ToInt32(tbNR120.Text);
            }

            else
            {
                CNTC_120 = 0;
            }


            if (tbNR45.Text != "")
            {
                CNTC_45 = Convert.ToInt32(tbNR45.Text);
            }

            else
            {
                CNTC_45 = 0;
            }


            if (tbCA240.Text != "")
            {
                crosswalkAnnotation = Convert.ToInt32(tbCA240.Text);
            }

            else
            {
                crosswalkAnnotation = 0;
            }


            if (tbMNE360.Text != "")
            {
                MNE = Convert.ToInt32(tbMNE360.Text);
            }

            else
            {
                MNE = 0;
            }


            if (tbDN120.Text != "")
            {
                drivingNavigation = Convert.ToInt32(tbDN120.Text);
            }

            else
            {
                drivingNavigation = 0;
            }


            if (tbQIC200.Text != "")
            {
                queryIntent = Convert.ToInt32(tbQIC200.Text);
            }

            else
            {
                queryIntent = 0;
            }


            if (tbMQTT120.Text != "")
            {
                mapQueryIntent = Convert.ToInt32(tbMQTT120.Text);
            }

            else
            {
                mapQueryIntent = 0;
            }


            if (tbAV210.Text != "")
            {
                addressVerification = Convert.ToInt32(tbAV210.Text);
            }

            else
            {
                addressVerification = 0;
            }


            if (tbPOI180.Text != "")
            {
                POI = Convert.ToInt32(tbPOI180.Text);
            }

            else
            {
                POI = 0;
            }

            result = (POI * POI_180_rate) + (addressVerification*addressVerification_210_rate) + (mapQueryIntent* mapQueryIntent_120_rate) +
                (queryIntent*queryIntent_200_rate) + (drivingNavigation*drivingNavigation_120_rate) + (MNE * MNE_360_rate) +
                (crosswalkAnnotation*crosswalkAnnotation_240_rate) + (CNTC_120 +CNTC_120_rate) + (CNTC_45*CNTC_45_rate) +
                (ACQuery*ACQuery_30_rate) + (nameTranslation*nameTranslation_30_rate) + (nameEvaluation*nameEvaluation_120_rate);

            tbResult.Text = Convert.ToString(result) + " USD";
        }
    }
}
