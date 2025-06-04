using System.Windows.Forms;

namespace Downloader
{
    partial class MainFrame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            TopPanel = new TableLayoutPanel();
            lbl_Author = new Label();
            lbl_PrgName = new Label();
            lbl_ImgConStatus = new Label();
            btn_CheckCon = new Button();
            LeftPanel = new TableLayoutPanel();
            btn_Profiles = new Button();
            btn_Other = new Button();
            btn_Tools = new Button();
            btn_Apps = new Button();
            btn_Download = new Button();
            ConsolePanel = new TableLayoutPanel();
            console = new RichTextBox();
            lbl_CurApps = new Label();
            AppsTabs = new TabControl();
            BrowsersTab = new TabPage();
            BrowsersPanel = new FlowLayoutPanel();
            LaunchersTab = new TabPage();
            LaunchersPanel = new FlowLayoutPanel();
            MediaTab = new TabPage();
            MediaPanel = new FlowLayoutPanel();
            CommunicationTab = new TabPage();
            CommunicationPanel = new FlowLayoutPanel();
            ProgrammingTab = new TabPage();
            ProgrammingPanel = new FlowLayoutPanel();
            OverviewTab = new TabPage();
            OverviewPanel = new FlowLayoutPanel();
            TestsTab = new TabPage();
            TestsPanel = new FlowLayoutPanel();
            NetworkTab = new TabPage();
            NetworkPanel = new FlowLayoutPanel();
            OSsAndISOsTab = new TabPage();
            OSsAndISOsPanel = new FlowLayoutPanel();
            DiskTab = new TabPage();
            DiskPanel = new FlowLayoutPanel();
            ProtectionTab = new TabPage();
            ProtectionPanel = new FlowLayoutPanel();
            OtherAppsTab = new TabPage();
            OtherAppsPanel = new FlowLayoutPanel();
            ArchivesTab = new TabPage();
            ArchivesPanel = new FlowLayoutPanel();
            ToolsTabs = new TabControl();
            OtherTabs = new TabControl();
            TopPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ConsolePanel.SuspendLayout();
            AppsTabs.SuspendLayout();
            ToolsTabs.SuspendLayout();
            OtherTabs.SuspendLayout();
            BrowsersTab.SuspendLayout();
            LaunchersTab.SuspendLayout();
            MediaTab.SuspendLayout();
            CommunicationTab.SuspendLayout();
            ProgrammingTab.SuspendLayout();
            OverviewTab.SuspendLayout();
            TestsTab.SuspendLayout();
            NetworkTab.SuspendLayout();
            OSsAndISOsTab.SuspendLayout();
            DiskTab.SuspendLayout();
            ProtectionTab.SuspendLayout();
            OtherAppsTab.SuspendLayout();
            ArchivesTab.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.CornflowerBlue;
            TopPanel.ColumnCount = 4;
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.80428F));
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.19572F));
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 358F));
            TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 91F));
            TopPanel.Controls.Add(lbl_Author, 1, 0);
            TopPanel.Controls.Add(lbl_PrgName, 0, 0);
            TopPanel.Controls.Add(lbl_ImgConStatus, 3, 0);
            TopPanel.Controls.Add(btn_CheckCon, 2, 0);
            TopPanel.Location = new Point(14, 14);
            TopPanel.Margin = new Padding(4, 3, 4, 3);
            TopPanel.Name = "TopPanel";
            TopPanel.RowCount = 1;
            TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TopPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            TopPanel.Size = new Size(1257, 61);
            TopPanel.TabIndex = 0;
            // 
            // lbl_Author
            // 
            lbl_Author.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_Author.AutoSize = true;
            lbl_Author.BackColor = Color.DeepSkyBlue;
            lbl_Author.FlatStyle = FlatStyle.Flat;
            lbl_Author.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_Author.ForeColor = Color.Navy;
            lbl_Author.Location = new Point(262, 9);
            lbl_Author.Margin = new Padding(6, 0, 6, 0);
            lbl_Author.Name = "lbl_Author";
            lbl_Author.Padding = new Padding(0, 3, 0, 3);
            lbl_Author.Size = new Size(539, 43);
            lbl_Author.TabIndex = 4;
            lbl_Author.Text = "Vadim Elshin | DAW 1 | IES Doctor Balmis";
            lbl_Author.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_PrgName
            // 
            lbl_PrgName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_PrgName.AutoSize = true;
            lbl_PrgName.BackColor = Color.Navy;
            lbl_PrgName.FlatStyle = FlatStyle.Flat;
            lbl_PrgName.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_PrgName.ForeColor = Color.White;
            lbl_PrgName.Location = new Point(6, 9);
            lbl_PrgName.Margin = new Padding(6, 0, 6, 0);
            lbl_PrgName.Name = "lbl_PrgName";
            lbl_PrgName.Padding = new Padding(0, 3, 0, 3);
            lbl_PrgName.Size = new Size(244, 43);
            lbl_PrgName.TabIndex = 0;
            lbl_PrgName.Text = "DOWNLOADER";
            lbl_PrgName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ImgConStatus
            // 
            lbl_ImgConStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_ImgConStatus.Image = (Image)resources.GetObject("lbl_ImgConStatus.Image");
            lbl_ImgConStatus.Location = new Point(1169, 3);
            lbl_ImgConStatus.Margin = new Padding(4, 0, 4, 0);
            lbl_ImgConStatus.Name = "lbl_ImgConStatus";
            lbl_ImgConStatus.Size = new Size(84, 54);
            lbl_ImgConStatus.TabIndex = 3;
            lbl_ImgConStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_CheckCon
            // 
            btn_CheckCon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_CheckCon.BackColor = Color.MediumBlue;
            btn_CheckCon.Cursor = Cursors.Hand;
            btn_CheckCon.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            btn_CheckCon.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_CheckCon.ForeColor = Color.White;
            btn_CheckCon.Location = new Point(811, 3);
            btn_CheckCon.Margin = new Padding(4, 3, 4, 3);
            btn_CheckCon.Name = "btn_CheckCon";
            btn_CheckCon.Padding = new Padding(0, 3, 0, 3);
            btn_CheckCon.Size = new Size(350, 55);
            btn_CheckCon.TabIndex = 2;
            btn_CheckCon.Text = "Check connection";
            btn_CheckCon.UseVisualStyleBackColor = false;
            btn_CheckCon.Click += btn_CheckCon_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.Navy;
            LeftPanel.ColumnCount = 1;
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LeftPanel.Controls.Add(btn_Profiles, 0, 3);
            LeftPanel.Controls.Add(btn_Other, 0, 2);
            LeftPanel.Controls.Add(btn_Tools, 0, 1);
            LeftPanel.Controls.Add(btn_Apps, 0, 0);
            LeftPanel.Controls.Add(btn_Download, 0, 4);
            LeftPanel.Location = new Point(14, 93);
            LeftPanel.Margin = new Padding(4, 3, 4, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.RowCount = 5;
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LeftPanel.Size = new Size(260, 421);
            LeftPanel.TabIndex = 1;
            // 
            // btn_Profiles
            // 
            btn_Profiles.Anchor = AnchorStyles.None;
            btn_Profiles.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Profiles.Location = new Point(16, 264);
            btn_Profiles.Margin = new Padding(4, 3, 4, 3);
            btn_Profiles.Name = "btn_Profiles";
            btn_Profiles.Size = new Size(227, 60);
            btn_Profiles.TabIndex = 3;
            btn_Profiles.Text = "PROFILES";
            btn_Profiles.UseVisualStyleBackColor = true;
            btn_Profiles.Click += btn_Profiles_Click;
            // 
            // btn_Other
            // 
            btn_Other.Anchor = AnchorStyles.None;
            btn_Other.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_Other.Location = new Point(16, 180);
            btn_Other.Margin = new Padding(4, 3, 4, 3);
            btn_Other.Name = "btn_Other";
            btn_Other.Size = new Size(227, 60);
            btn_Other.TabIndex = 2;
            btn_Other.Text = "OTHER";
            btn_Other.UseVisualStyleBackColor = true;
            btn_Other.Click += btn_Other_apps_Click;
            // 
            // btn_Tools
            // 
            btn_Tools.Anchor = AnchorStyles.None;
            btn_Tools.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Tools.Location = new Point(16, 96);
            btn_Tools.Margin = new Padding(4, 3, 4, 3);
            btn_Tools.Name = "btn_Tools";
            btn_Tools.Size = new Size(227, 60);
            btn_Tools.TabIndex = 1;
            btn_Tools.Text = "TOOLS";
            btn_Tools.UseVisualStyleBackColor = true;
            btn_Tools.Click += btn_Tools_Click;
            // 
            // btn_Apps
            // 
            btn_Apps.Anchor = AnchorStyles.None;
            btn_Apps.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Apps.Location = new Point(16, 12);
            btn_Apps.Margin = new Padding(4, 3, 4, 3);
            btn_Apps.Name = "btn_Apps";
            btn_Apps.Size = new Size(227, 60);
            btn_Apps.TabIndex = 0;
            btn_Apps.Text = "APPS";
            btn_Apps.UseVisualStyleBackColor = true;
            btn_Apps.Click += btn_Apps_Click;
            // 
            // btn_Download
            // 
            btn_Download.Anchor = AnchorStyles.None;
            btn_Download.Font = new Font("Arial Narrow", 28F, FontStyle.Bold);
            btn_Download.Location = new Point(16, 348);
            btn_Download.Margin = new Padding(4, 3, 4, 3);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(227, 60);
            btn_Download.TabIndex = 4;
            btn_Download.Text = "DOWNLOAD";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // ConsolePanel
            // 
            ConsolePanel.BackColor = Color.RoyalBlue;
            ConsolePanel.ColumnCount = 1;
            ConsolePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ConsolePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ConsolePanel.Controls.Add(console, 0, 1);
            ConsolePanel.Controls.Add(lbl_CurApps, 0, 0);
            ConsolePanel.Location = new Point(14, 531);
            ConsolePanel.Margin = new Padding(4, 3, 4, 3);
            ConsolePanel.Name = "ConsolePanel";
            ConsolePanel.RowCount = 2;
            ConsolePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.83502F));
            ConsolePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.16499F));
            ConsolePanel.Size = new Size(260, 268);
            ConsolePanel.TabIndex = 2;
            // 
            // console
            // 
            console.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            console.Location = new Point(4, 48);
            console.Margin = new Padding(4, 3, 4, 3);
            console.Name = "console";
            console.Size = new Size(252, 217);
            console.TabIndex = 1;
            console.Text = "";
            // 
            // lbl_CurApps
            // 
            lbl_CurApps.Anchor = AnchorStyles.None;
            lbl_CurApps.AutoSize = true;
            lbl_CurApps.BackColor = Color.DarkBlue;
            lbl_CurApps.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_CurApps.ForeColor = Color.White;
            lbl_CurApps.Location = new Point(3, 0);
            lbl_CurApps.Margin = new Padding(0);
            lbl_CurApps.Name = "lbl_CurApps";
            lbl_CurApps.Padding = new Padding(29, 7, 29, 7);
            lbl_CurApps.Size = new Size(253, 45);
            lbl_CurApps.TabIndex = 0;
            lbl_CurApps.Text = "Selected apps: 0";
            lbl_CurApps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AppsTabs
            // 
            AppsTabs.Appearance = TabAppearance.Buttons;
            AppsTabs.Controls.Add(BrowsersTab);
            AppsTabs.Controls.Add(LaunchersTab);
            AppsTabs.Controls.Add(MediaTab);
            AppsTabs.Controls.Add(CommunicationTab);
            AppsTabs.Controls.Add(ProgrammingTab);
            AppsTabs.Location = new Point(295, 93);
            AppsTabs.Name = "AppsTabs";
            AppsTabs.SelectedIndex = 0;
            AppsTabs.Size = new Size(976, 706);
            AppsTabs.TabIndex = 3;
            AppsTabs.Visible = false;
            // 
            // BrowsersTab
            // 
            BrowsersTab.Controls.Add(BrowsersPanel);
            BrowsersTab.Location = new Point(4, 27);
            BrowsersTab.Name = "BrowsersTab";
            BrowsersTab.Padding = new Padding(3);
            BrowsersTab.Size = new Size(968, 675);
            BrowsersTab.TabIndex = 0;
            BrowsersTab.Text = "Browsers";
            BrowsersTab.UseVisualStyleBackColor = true;
            // 
            // BrowsersPanel
            // 
            BrowsersPanel.Location = new Point(6, 6);
            BrowsersPanel.Name = "BrowsersPanel";
            BrowsersPanel.Padding = new Padding(5);
            BrowsersPanel.Size = new Size(956, 663);
            BrowsersPanel.TabIndex = 0;
            //
            // LaunchersTab
            // 
            LaunchersTab.Controls.Add(LaunchersPanel);
            LaunchersTab.Location = new Point(4, 27);
            LaunchersTab.Name = "LaunchersTab";
            LaunchersTab.Padding = new Padding(3);
            LaunchersTab.Size = new Size(968, 675);
            LaunchersTab.TabIndex = 1;
            LaunchersTab.Text = "Launchers";
            LaunchersTab.UseVisualStyleBackColor = true;
            // 
            // LaunchersPanel
            // 
            LaunchersPanel.Location = new Point(6, 6);
            LaunchersPanel.Name = "LaunchersPanel";
            LaunchersPanel.Padding = new Padding(5);
            LaunchersPanel.Size = new Size(956, 663);
            LaunchersPanel.TabIndex = 1;
            // 
            // MediaTab
            // 
            MediaTab.Controls.Add(MediaPanel);
            MediaTab.Location = new Point(4, 27);
            MediaTab.Name = "MediaTab";
            MediaTab.Padding = new Padding(3);
            MediaTab.Size = new Size(968, 675);
            MediaTab.TabIndex = 2;
            MediaTab.Text = "Media";
            MediaTab.UseVisualStyleBackColor = true;
            // 
            // MediaPanel
            // 
            MediaPanel.Location = new Point(6, 6);
            MediaPanel.Name = "MediaPanel";
            MediaPanel.Padding = new Padding(5);
            MediaPanel.Size = new Size(956, 663);
            MediaPanel.TabIndex = 1;
            // 
            // CommunicationTab
            // 
            CommunicationTab.Controls.Add(CommunicationPanel);
            CommunicationTab.Location = new Point(4, 27);
            CommunicationTab.Name = "CommunicationTab";
            CommunicationTab.Padding = new Padding(3);
            CommunicationTab.Size = new Size(968, 675);
            CommunicationTab.TabIndex = 3;
            CommunicationTab.Text = "Communication";
            CommunicationTab.UseVisualStyleBackColor = true;
            // 
            // CommunicationPanel
            // 
            CommunicationPanel.Location = new Point(6, 6);
            CommunicationPanel.Name = "CommunicationPanel";
            CommunicationPanel.Padding = new Padding(5);
            CommunicationPanel.Size = new Size(956, 663);
            CommunicationPanel.TabIndex = 1;
            // 
            // ProgrammingTab
            // 
            ProgrammingTab.Controls.Add(ProgrammingPanel);
            ProgrammingTab.Location = new Point(4, 27);
            ProgrammingTab.Name = "ProgrammingTab";
            ProgrammingTab.Padding = new Padding(3);
            ProgrammingTab.Size = new Size(968, 675);
            ProgrammingTab.TabIndex = 4;
            ProgrammingTab.Text = "Programming";
            ProgrammingTab.UseVisualStyleBackColor = true;
            // 
            // ProgrammingPanel
            // 
            ProgrammingPanel.Location = new Point(6, 6);
            ProgrammingPanel.Name = "ProgrammingPanel";
            ProgrammingPanel.Padding = new Padding(5);
            ProgrammingPanel.Size = new Size(956, 663);
            ProgrammingPanel.TabIndex = 1;
            // 
            // ToolsTabs
            // 
            ToolsTabs.Appearance = TabAppearance.Buttons;
            ToolsTabs.Controls.Add(OverviewTab);
            ToolsTabs.Controls.Add(TestsTab);
            ToolsTabs.Controls.Add(NetworkTab);
            ToolsTabs.Controls.Add(OSsAndISOsTab);
            ToolsTabs.Controls.Add(DiskTab);
            ToolsTabs.Controls.Add(ProtectionTab);
            ToolsTabs.Location = new Point(295, 93);
            ToolsTabs.Name = "ToolsTabs";
            ToolsTabs.SelectedIndex = 0;
            ToolsTabs.Size = new Size(976, 706);
            ToolsTabs.TabIndex = 0;
            ToolsTabs.Visible = false;
            // 
            // OverviewTab
            // 
            OverviewTab.Controls.Add(OverviewPanel);
            OverviewTab.Location = new Point(4, 27);
            OverviewTab.Name = "OverviewTab";
            OverviewTab.Padding = new Padding(3);
            OverviewTab.Size = new Size(968, 675);
            OverviewTab.TabIndex = 0;
            OverviewTab.Text = "Overview";
            OverviewTab.UseVisualStyleBackColor = true;
            // 
            // OverviewPanel
            // 
            OverviewPanel.Location = new Point(6, 6);
            OverviewPanel.Name = "OverviewPanel";
            OverviewPanel.Padding = new Padding(5);
            OverviewPanel.Size = new Size(956, 663);
            OverviewPanel.TabIndex = 1;
            // 
            // TestsTab
            // 
            TestsTab.Controls.Add(TestsPanel);
            TestsTab.Location = new Point(4, 27);
            TestsTab.Name = "TestsTab";
            TestsTab.Padding = new Padding(3);
            TestsTab.Size = new Size(968, 675);
            TestsTab.TabIndex = 1;
            TestsTab.Text = "Tests";
            TestsTab.UseVisualStyleBackColor = true;
            // 
            // TestsPanel
            // 
            TestsPanel.Location = new Point(6, 6);
            TestsPanel.Name = "TestsPanel";
            TestsPanel.Padding = new Padding(5);
            TestsPanel.Size = new Size(956, 663);
            TestsPanel.TabIndex = 1;
            // 
            // NetworkTab
            // 
            NetworkTab.Controls.Add(NetworkPanel);
            NetworkTab.Location = new Point(4, 27);
            NetworkTab.Name = "NetworkTab";
            NetworkTab.Padding = new Padding(3);
            NetworkTab.Size = new Size(968, 675);
            NetworkTab.TabIndex = 2;
            NetworkTab.Text = "Network";
            NetworkTab.UseVisualStyleBackColor = true;
            // 
            // NetworkPanel
            // 
            NetworkPanel.Location = new Point(6, 6);
            NetworkPanel.Name = "NetworkPanel";
            NetworkPanel.Padding = new Padding(5);
            NetworkPanel.Size = new Size(956, 663);
            NetworkPanel.TabIndex = 1;
            // 
            // OSsAndISOsTab
            // 
            OSsAndISOsTab.Controls.Add(OSsAndISOsPanel);
            OSsAndISOsTab.Location = new Point(4, 27);
            OSsAndISOsTab.Name = "OSsAndISOsTab";
            OSsAndISOsTab.Padding = new Padding(3);
            OSsAndISOsTab.Size = new Size(968, 675);
            OSsAndISOsTab.TabIndex = 3;
            OSsAndISOsTab.Text = "OSs & ISOs";
            OSsAndISOsTab.UseVisualStyleBackColor = true;
            // 
            // OSsAndISOsPanel
            // 
            OSsAndISOsPanel.Location = new Point(6, 6);
            OSsAndISOsPanel.Name = "OSsAndISOsPanel";
            OSsAndISOsPanel.Padding = new Padding(5);
            OSsAndISOsPanel.Size = new Size(956, 663);
            OSsAndISOsPanel.TabIndex = 1;
            // 
            // DiskTab
            // 
            DiskTab.Controls.Add(DiskPanel);
            DiskTab.Location = new Point(4, 27);
            DiskTab.Name = "DiskTab";
            DiskTab.Padding = new Padding(3);
            DiskTab.Size = new Size(968, 675);
            DiskTab.TabIndex = 4;
            DiskTab.Text = "Disk";
            DiskTab.UseVisualStyleBackColor = true;
            // 
            // DiskPanel
            // 
            DiskPanel.Location = new Point(6, 6);
            DiskPanel.Name = "DiskPanel";
            DiskPanel.Padding = new Padding(5);
            DiskPanel.Size = new Size(956, 663);
            DiskPanel.TabIndex = 1;
            // 
            // ProtectionTab
            // 
            ProtectionTab.Controls.Add(ProtectionPanel);
            ProtectionTab.Location = new Point(4, 27);
            ProtectionTab.Name = "ProtectionTab";
            ProtectionTab.Padding = new Padding(3);
            ProtectionTab.Size = new Size(968, 675);
            ProtectionTab.TabIndex = 5;
            ProtectionTab.Text = "Protection";
            ProtectionTab.UseVisualStyleBackColor = true;
            // 
            // ProtectionPanel
            // 
            ProtectionPanel.Location = new Point(6, 6);
            ProtectionPanel.Name = "ProtectionPanel";
            ProtectionPanel.Padding = new Padding(5);
            ProtectionPanel.Size = new Size(956, 663);
            ProtectionPanel.TabIndex = 1;
            // 
            // OtherTabs
            // 
            OtherTabs.Appearance = TabAppearance.Buttons;
            OtherTabs.Controls.Add(OtherAppsTab);
            OtherTabs.Controls.Add(ArchivesTab);
            OtherTabs.Location = new Point(295, 93);
            OtherTabs.Name = "OtherTabs";
            OtherTabs.SelectedIndex = 0;
            OtherTabs.Size = new Size(976, 706);
            OtherTabs.TabIndex = 3;
            OtherTabs.Visible = false;
            // 
            // OtherAppsTab
            // 
            OtherAppsTab.Controls.Add(OtherAppsPanel);
            OtherAppsTab.Location = new Point(4, 27);
            OtherAppsTab.Name = "OtherAppsTab";
            OtherAppsTab.Padding = new Padding(3);
            OtherAppsTab.Size = new Size(968, 675);
            OtherAppsTab.TabIndex = 0;
            OtherAppsTab.Text = "Other apps";
            OtherAppsTab.UseVisualStyleBackColor = true;
            // 
            // OtherAppsPanel
            // 
            OtherAppsPanel.Location = new Point(6, 6);
            OtherAppsPanel.Name = "OtherAppsPanel";
            OtherAppsPanel.Padding = new Padding(5);
            OtherAppsPanel.Size = new Size(956, 663);
            OtherAppsPanel.TabIndex = 1;
            // 
            // ArchivesTab
            // 
            ArchivesTab.Controls.Add(ArchivesPanel);
            ArchivesTab.Location = new Point(4, 27);
            ArchivesTab.Name = "ArchivesTab";
            ArchivesTab.Padding = new Padding(3);
            ArchivesTab.Size = new Size(968, 675);
            ArchivesTab.TabIndex = 1;
            ArchivesTab.Text = "Archives";
            ArchivesTab.UseVisualStyleBackColor = true;
            // 
            // ArchivesPanel
            // 
            ArchivesPanel.Location = new Point(6, 6);
            ArchivesPanel.Name = "ArchivesPanel";
            ArchivesPanel.Padding = new Padding(5);
            ArchivesPanel.Size = new Size(956, 663);
            ArchivesPanel.TabIndex = 1;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1284, 811);
            Controls.Add(AppsTabs);
            Controls.Add(ToolsTabs);
            Controls.Add(OtherTabs);
            Controls.Add(ConsolePanel);
            Controls.Add(LeftPanel);
            Controls.Add(TopPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainFrame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Downloader";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            ConsolePanel.ResumeLayout(false);
            ConsolePanel.PerformLayout();
            AppsTabs.ResumeLayout(false);
            ToolsTabs.ResumeLayout(false);
            OtherTabs.ResumeLayout(false);
            BrowsersTab.ResumeLayout(false);
            LaunchersTab.ResumeLayout(false);
            MediaTab.ResumeLayout(false);
            CommunicationTab.ResumeLayout(false);
            ProgrammingTab.ResumeLayout(false);
            OverviewTab.ResumeLayout(false);
            TestsTab.ResumeLayout(false);
            NetworkTab.ResumeLayout(false);
            OSsAndISOsTab.ResumeLayout(false);
            DiskTab.ResumeLayout(false);
            ProtectionTab.ResumeLayout(false);
            OtherAppsTab.ResumeLayout(false);
            ArchivesTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_PrgName;
        private System.Windows.Forms.Button btn_CheckCon;
        private System.Windows.Forms.Label lbl_ImgConStatus;
        private TableLayoutPanel LeftPanel;
        private Button btn_Apps;
        private Button btn_Download;
        private Button btn_Profiles;
        private Button btn_Other;
        private Button btn_Tools;
        private TableLayoutPanel ConsolePanel;
        private RichTextBox console;
        private Label lbl_CurApps;
        private TabControl AppsTabs;
        private TabControl ToolsTabs;
        private TabControl OtherTabs;
        private TabPage BrowsersTab;
        private TabPage LaunchersTab;
        private FlowLayoutPanel BrowsersPanel;
        private TabPage MediaTab;
        private TabPage CommunicationTab;
        private FlowLayoutPanel LaunchersPanel;
        private FlowLayoutPanel MediaPanel;
        private FlowLayoutPanel CommunicationPanel;
        private TabPage ProgrammingTab;
        private FlowLayoutPanel ProgrammingPanel;
        private TabPage OverviewTab;
        private FlowLayoutPanel OverviewPanel;
        private TabPage TestsTab;
        private FlowLayoutPanel TestsPanel;
        private TabPage NetworkTab;
        private FlowLayoutPanel NetworkPanel;
        private TabPage OSsAndISOsTab;
        private FlowLayoutPanel OSsAndISOsPanel;
        private TabPage DiskTab;
        private FlowLayoutPanel DiskPanel;
        private TabPage ProtectionTab;
        private FlowLayoutPanel ProtectionPanel;
        private TabPage OtherAppsTab;
        private FlowLayoutPanel OtherAppsPanel;
        private TabPage ArchivesTab;
        private FlowLayoutPanel ArchivesPanel;
    }
}
