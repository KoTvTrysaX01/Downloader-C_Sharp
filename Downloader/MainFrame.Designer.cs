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
            TopPanel = new System.Windows.Forms.TableLayoutPanel();
            lbl_PrgName = new System.Windows.Forms.Label();
            lbl_ImgConStatus = new System.Windows.Forms.Label();
            btn_CheckCon = new System.Windows.Forms.Button();
            lbl_Author = new System.Windows.Forms.Label();
            LeftPanel = new System.Windows.Forms.TableLayoutPanel();
            btn_Download = new System.Windows.Forms.Button();
            btn_Profiles = new System.Windows.Forms.Button();
            btn_Other_apps = new System.Windows.Forms.Button();
            btn_Tools = new System.Windows.Forms.Button();
            btn_Apps = new System.Windows.Forms.Button();
            ConsolePanel = new System.Windows.Forms.TableLayoutPanel();
            console = new System.Windows.Forms.RichTextBox();
            lbl_CurApps = new System.Windows.Forms.Label();
            TopPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ConsolePanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            TopPanel.ColumnCount = 4;
            TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.80428F));
            TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.19572F));
            TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            TopPanel.Controls.Add(this.lbl_PrgName, 0, 0);
            TopPanel.Controls.Add(this.lbl_ImgConStatus, 3, 0);
            TopPanel.Controls.Add(this.btn_CheckCon, 2, 0);
            TopPanel.Controls.Add(this.lbl_Author, 1, 0);
            TopPanel.Location = new System.Drawing.Point(12, 12);
            TopPanel.Name = "TopPanel";
            TopPanel.RowCount = 1;
            TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            TopPanel.Size = new System.Drawing.Size(1360, 60);
            TopPanel.TabIndex = 0;
            // 
            // lbl_PrgName
            // 
            lbl_PrgName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lbl_PrgName.AutoSize = true;
            lbl_PrgName.BackColor = System.Drawing.Color.Navy;
            lbl_PrgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbl_PrgName.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lbl_PrgName.ForeColor = System.Drawing.Color.White;
            lbl_PrgName.Location = new System.Drawing.Point(5, 6);
            lbl_PrgName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_PrgName.Name = "lbl_PrgName";
            lbl_PrgName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            lbl_PrgName.Size = new System.Drawing.Size(300, 48);
            lbl_PrgName.TabIndex = 0;
            lbl_PrgName.Text = "DOWNLOADER";
            lbl_PrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ImgConStatus
            // 
            lbl_ImgConStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lbl_ImgConStatus.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ImgConStatus.Image")));
            lbl_ImgConStatus.Location = new System.Drawing.Point(1285, 5);
            lbl_ImgConStatus.Name = "lbl_ImgConStatus";
            lbl_ImgConStatus.Size = new System.Drawing.Size(72, 50);
            lbl_ImgConStatus.TabIndex = 3;
            lbl_ImgConStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CheckCon
            // 
            btn_CheckCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            btn_CheckCon.BackColor = System.Drawing.Color.MediumBlue;
            btn_CheckCon.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_CheckCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            btn_CheckCon.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn_CheckCon.ForeColor = System.Drawing.Color.White;
            btn_CheckCon.Location = new System.Drawing.Point(978, 3);
            btn_CheckCon.Name = "btn_CheckCon";
            btn_CheckCon.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            btn_CheckCon.Size = new System.Drawing.Size(301, 54);
            btn_CheckCon.TabIndex = 2;
            btn_CheckCon.Text = "Check connection";
            btn_CheckCon.UseVisualStyleBackColor = false;
            btn_CheckCon.Click += new System.EventHandler(this.btn_CheckCon_Click);
            // 
            // lbl_Author
            // 
            lbl_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            lbl_Author.AutoSize = true;
            lbl_Author.BackColor = System.Drawing.Color.DeepSkyBlue;
            lbl_Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbl_Author.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lbl_Author.ForeColor = System.Drawing.Color.Navy;
            lbl_Author.Location = new System.Drawing.Point(315, 6);
            lbl_Author.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl_Author.Name = "lbl_Author";
            lbl_Author.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            lbl_Author.Size = new System.Drawing.Size(655, 48);
            lbl_Author.TabIndex = 4;
            lbl_Author.Text = "Vadim Elshin | DAW 1 | IES Doctor Balmis";
            lbl_Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = System.Drawing.Color.Navy;
            LeftPanel.ColumnCount = 1;
            LeftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            LeftPanel.Controls.Add(this.btn_Download, 0, 4);
            LeftPanel.Controls.Add(this.btn_Profiles, 0, 3);
            LeftPanel.Controls.Add(this.btn_Other_apps, 0, 2);
            LeftPanel.Controls.Add(this.btn_Tools, 0, 1);
            LeftPanel.Controls.Add(this.btn_Apps, 0, 0);
            LeftPanel.Location = new System.Drawing.Point(12, 86);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.RowCount = 5;
            LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            LeftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            LeftPanel.Size = new System.Drawing.Size(275, 428);
            LeftPanel.TabIndex = 1;
            // 
            // btn_Download
            // 
            btn_Download.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Download.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            btn_Download.Location = new System.Drawing.Point(18, 353);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new System.Drawing.Size(239, 61);
            btn_Download.TabIndex = 4;
            btn_Download.Text = "DOWNLOAD";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_Profiles
            // 
            btn_Profiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Profiles.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            btn_Profiles.Location = new System.Drawing.Point(18, 267);
            btn_Profiles.Name = "btn_Profiles";
            btn_Profiles.Size = new System.Drawing.Size(239, 61);
            btn_Profiles.TabIndex = 3;
            btn_Profiles.Text = "PROFILES";
            btn_Profiles.UseVisualStyleBackColor = true;
            btn_Profiles.Click += new System.EventHandler(this.btn_Profiles_Click);
            // 
            // btn_Other_apps
            // 
            btn_Other_apps.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Other_apps.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            btn_Other_apps.Location = new System.Drawing.Point(18, 182);
            btn_Other_apps.Name = "btn_Other_apps";
            btn_Other_apps.Size = new System.Drawing.Size(239, 61);
            btn_Other_apps.TabIndex = 2;
            btn_Other_apps.Text = "OTHER APPS";
            btn_Other_apps.UseVisualStyleBackColor = true;
            btn_Other_apps.Click += new System.EventHandler(this.btn_Other_apps_Click);
            // 
            // btn_Tools
            // 
            btn_Tools.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Tools.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            btn_Tools.Location = new System.Drawing.Point(18, 97);
            btn_Tools.Name = "btn_Tools";
            btn_Tools.Size = new System.Drawing.Size(239, 61);
            btn_Tools.TabIndex = 1;
            btn_Tools.Text = "TOOLS";
            btn_Tools.UseVisualStyleBackColor = true;
            btn_Tools.Click += new System.EventHandler(this.btn_Tools_Click);
            // 
            // btn_Apps
            // 
            btn_Apps.Anchor = System.Windows.Forms.AnchorStyles.None;
            btn_Apps.Font = new System.Drawing.Font("Arial Narrow", 28F, System.Drawing.FontStyle.Bold);
            btn_Apps.Location = new System.Drawing.Point(18, 12);
            btn_Apps.Name = "btn_Apps";
            btn_Apps.Size = new System.Drawing.Size(239, 61);
            btn_Apps.TabIndex = 0;
            btn_Apps.Text = "APPS";
            btn_Apps.UseVisualStyleBackColor = true;
            btn_Apps.Click += new System.EventHandler(this.btn_Apps_Click);
            // 
            // ConsolePanel
            // 
            ConsolePanel.BackColor = System.Drawing.Color.RoyalBlue;
            ConsolePanel.ColumnCount = 1;
            ConsolePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            ConsolePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            ConsolePanel.Controls.Add(this.console, 0, 1);
            ConsolePanel.Controls.Add(this.lbl_CurApps, 0, 0);
            ConsolePanel.Location = new System.Drawing.Point(12, 529);
            ConsolePanel.Name = "ConsolePanel";
            ConsolePanel.RowCount = 2;
            ConsolePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.83502F));
            ConsolePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.16499F));
            ConsolePanel.Size = new System.Drawing.Size(275, 320);
            ConsolePanel.TabIndex = 2;
            // 
            // console
            // 
            console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            console.Location = new System.Drawing.Point(3, 56);
            console.Name = "console";
            console.Size = new System.Drawing.Size(269, 261);
            console.TabIndex = 1;
            console.Text = "";
            // 
            // lbl_CurApps
            // 
            lbl_CurApps.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_CurApps.AutoSize = true;
            lbl_CurApps.BackColor = System.Drawing.Color.DarkBlue;
            lbl_CurApps.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            lbl_CurApps.ForeColor = System.Drawing.Color.White;
            lbl_CurApps.Location = new System.Drawing.Point(3, 4);
            lbl_CurApps.Margin = new System.Windows.Forms.Padding(0);
            lbl_CurApps.Name = "lbl_CurApps";
            lbl_CurApps.Padding = new System.Windows.Forms.Padding(25, 6, 25, 6);
            lbl_CurApps.Size = new System.Drawing.Size(268, 44);
            lbl_CurApps.TabIndex = 0;
            lbl_CurApps.Text = "Selected apps: 0";
            lbl_CurApps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1384, 861);
            Controls.Add(ConsolePanel);
            Controls.Add(LeftPanel);
            Controls.Add(TopPanel);
            Name = "MainFrame";
            Text = "Downloader";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            ConsolePanel.ResumeLayout(false);
            ConsolePanel.PerformLayout();
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
        private Button btn_Other_apps;
        private Button btn_Tools;
        private TableLayoutPanel ConsolePanel;
        private RichTextBox console;
        private Label lbl_CurApps;
    }
}
