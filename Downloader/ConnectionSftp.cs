using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Downloader
{
    public class ConnectionSftp
    {
        public bool PingHost()
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect("79.112.50.56", 22, null, null);
                    var success = result.AsyncWaitHandle.WaitOne(5000);
                    client.EndConnect(result);
                    return success;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
