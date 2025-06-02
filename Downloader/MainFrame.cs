namespace Downloader
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }
        private void btn_CheckCon_Click(object sender, EventArgs e)
        {
            ConnectionSftp c = new ConnectionSftp();
            bool v = c.PingHost();


            if (v)
            {
                this.lbl_ImgConStatus.Image = new Bitmap(Properties.Resources.happy, new Size(50, 50));
            }
            else
            {
                this.lbl_ImgConStatus.Image = new Bitmap(Properties.Resources.sad, new Size(50, 50));

            }

        }

        private void btn_Apps_Click(object sender, EventArgs e)
        {

        }

        private void btn_Tools_Click(object sender, EventArgs e)
        {

        }

        private void btn_Other_apps_Click(object sender, EventArgs e)
        {


        }

        private void btn_Profiles_Click(object sender, EventArgs e)
        {


        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            ConnectionDb db = new ConnectionDb();
            db.ReadTable();
        }

        public void AppendTextToConsole(string message)
        {
            this.console.AppendText(DateTime.Now.ToString("HH:mm:ss") + ": " + message + "\n");
        }
    }
}
