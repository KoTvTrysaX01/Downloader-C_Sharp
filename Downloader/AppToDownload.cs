using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    class AppToDownload
    {
        private string appName;
        private string fileName;
        private Image icon;
        private string commandLine;
        private string section;


        public AppToDownload(string appName, string fileName, Image icon, string commandLine, string section)
        {
            this.appName = appName;
            this.fileName = fileName;
            this.icon = icon;
            this.commandLine = commandLine;
            this.section = section;
        }

        public string GetAppName()
        {
            return appName;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public Image GetIcon()
        {
            return icon;
        }

        public string GetCommandLine()
        {
            return commandLine;
        }

        public string GetSection()
        {
            return section;
        }
    }
}
