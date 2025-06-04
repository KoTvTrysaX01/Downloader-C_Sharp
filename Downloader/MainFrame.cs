namespace Downloader
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();

            ConnectionDb db = new ConnectionDb();

            List<AppToDownload> listApps = db.ReadTable();

            foreach (AppToDownload app in listApps)
            {
                switch(app.GetSection())
                {
                    case "Browsers":
                        BrowsersPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Launchers":
                        LaunchersPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Media":
                        MediaPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Programming":
                        ProgrammingPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Communication":
                        CommunicationPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Overview":
                        OverviewPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Tests":
                        TestsPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Network":
                        NetworkPanel.Controls.Add(new AppButton(app));
                        break;

                    case "OSs & ISOs":
                        OSsAndISOsPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Disk":
                        DiskPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Protection":
                        ProtectionPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Other apps":
                        OtherAppsPanel.Controls.Add(new AppButton(app));
                        break;

                    case "Archives":
                        ArchivesPanel.Controls.Add(new AppButton(app));
                        break;

                }

                
            }
        }
        private void btn_CheckCon_Click(object sender, EventArgs e)
        {
            ConnectionSftp c = new ConnectionSftp();
            bool v = c.PingHost();


            if (v)
            {
                lbl_ImgConStatus.Image = new Bitmap(Properties.Resources.happy, new Size(50, 50));
            }
            else
            {
                lbl_ImgConStatus.Image = new Bitmap(Properties.Resources.sad, new Size(50, 50));

            }

        }

        private void btn_Apps_Click(object sender, EventArgs e)
        {
            AppsTabs.Visible = true;
            ToolsTabs.Visible = false;
            OtherTabs.Visible = false;
        }

        private void btn_Tools_Click(object sender, EventArgs e)
        {
            AppsTabs.Visible = false;
            ToolsTabs.Visible = true;
            OtherTabs.Visible = false;
        }

        private void btn_Other_apps_Click(object sender, EventArgs e)
        {
            AppsTabs.Visible = false;
            ToolsTabs.Visible = false;
            OtherTabs.Visible = true;
        }

        private void btn_Profiles_Click(object sender, EventArgs e)
        {
            AppsTabs.Visible = false;
            ToolsTabs.Visible = false;
            OtherTabs.Visible = false;
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            AppsTabs.Visible = false;
            ToolsTabs.Visible = false;
            OtherTabs.Visible = false;
        }

        public void AppendTextToConsole(string message)
        {
            console.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + message + "\n");
        }
    }
}
