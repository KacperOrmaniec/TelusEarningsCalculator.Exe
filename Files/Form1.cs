namespace TelusEarningsCalculator
{
    public partial class Form1 : Form
    {
        Search2 search2;
        PoiEvaluation poievaluation;
        Autocomplete autocomp;
        SearchAds searchads;
        SearchSBS searchsbs;
        WebQuery webquery;
        Others others;
        TaskRates taskrates;

        public Form1()
        {
            InitializeComponent();
            mdiProp();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                EarningsContainer.Start();
            }
            else if (sidebarExpand == false && menuExpand == false)
            {
                sidebarTransition.Start();
                EarningsContainer.Start();
            }
            else
            {
                sidebarTransition.Start();
            }
        }
        bool menuExpand = false;
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232,234,237);
        }
        private void EarningsContainer_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 696)
                {
                    EarningsContainer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 80)
                {
                    EarningsContainer.Stop();
                    menuExpand = false;
                }
            }
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 404)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
            else
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 110)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            if (menuExpand == true) 
            {
                EarningsContainer.Start();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Search20_Click(object sender, EventArgs e)
        {
            if (search2 == null)
            {
                search2 = new Search2();
                search2.FormClosed += Search2_FormClosed;
                search2.MdiParent = this;
                search2.Dock = DockStyle.Fill;
                search2.Show();
            }
            else
            {
                search2.Activate();
            }
        }
        private void Search2_FormClosed(object sender, FormClosedEventArgs e)
        {
            search2 = null;
        }

        private void poiEvaluation_Click(object sender, EventArgs e)
        {
            if (poievaluation == null)
            {
                poievaluation = new PoiEvaluation();
                poievaluation.FormClosed += PoiE_FormClosed;
                poievaluation.MdiParent = this;
                poievaluation.Dock = DockStyle.Fill;
                poievaluation.Show();
            }
            else
            {
                poievaluation.Activate();
            }
        }
        private void PoiE_FormClosed(object sender, FormClosedEventArgs e)
        {
            poievaluation = null;
        }

        private void autocomplete_Click(object sender, EventArgs e)
        {
            if (autocomp == null)
            {
                autocomp = new Autocomplete();
                autocomp.FormClosed += autocomp_FormClosed;
                autocomp.MdiParent = this;
                autocomp.Dock = DockStyle.Fill;
                autocomp.Show();
            }
            else
            {
                autocomp.Activate();
            }
        }
        private void autocomp_FormClosed(object sender, FormClosedEventArgs e)
        {
            autocomp = null;
        }

        private void searchAds_Click(object sender, EventArgs e)
        {
            if (searchads == null)
            {
                searchads = new SearchAds();
                searchads.FormClosed += searchads_FormClosed;
                searchads.MdiParent = this;
                searchads.Dock = DockStyle.Fill;
                searchads.Show();
            }
            else
            {
                searchads.Activate();
            }
        }
        private void searchads_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchads = null;
        }

        private void searchSbs_Click(object sender, EventArgs e)
        {
            if (searchsbs == null)
            {
                searchsbs = new SearchSBS();
                searchsbs.FormClosed += searchsbs_FormClosed;
                searchsbs.MdiParent = this;
                searchsbs.Dock = DockStyle.Fill;
                searchsbs.Show();
            }
            else
            {
                searchsbs.Activate();
            }
        }
        private void searchsbs_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchsbs = null;
        }

        private void webQuery_Click(object sender, EventArgs e)
        {
            if (webquery == null)
            {
                webquery = new WebQuery();
                webquery.FormClosed += webquery_FormClosed;
                webquery.MdiParent = this;
                webquery.Dock = DockStyle.Fill;
                webquery.Show();
            }
            else
            {
                webquery.Activate();
            }
        }
        private void webquery_FormClosed(object sender, FormClosedEventArgs e)
        {
            webquery = null;
        }

        private void other_Click(object sender, EventArgs e)
        {
            if (others == null)
            {
                others = new Others();
                others.FormClosed += others_FormClosed;
                others.MdiParent = this;
                others.Dock = DockStyle.Fill;
                others.Show();
            }
            else
            {
                others.Activate();
            }
        }
        private void others_FormClosed(object sender, FormClosedEventArgs e)
        {
            others = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (taskrates == null)
            {
                taskrates = new TaskRates();
                taskrates.FormClosed += taskrates_FormClosed;
                taskrates.MdiParent = this;
                taskrates.Dock = DockStyle.Fill;
                taskrates.Show();
            }
            else
            {
                taskrates.Activate();
            }
        }
        private void taskrates_FormClosed(object sender, FormClosedEventArgs e)
        {
            taskrates = null;
        }
    }
}