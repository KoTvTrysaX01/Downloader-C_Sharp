using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    class AppButton : Button
    {
        public AppToDownload appToDownload;

        public AppButton(AppToDownload appToDownload)
        {
            this.appToDownload = appToDownload;
            this.Size = new Size(115, 80);
            this.Image = appToDownload.GetIcon();
            this.Text = appToDownload.GetAppName();
            this.Margin = new Padding(10);
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
        }
    }
}