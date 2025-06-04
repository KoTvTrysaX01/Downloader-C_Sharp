using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.Sqlite;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Collections;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace Downloader
{
    class ConnectionDb
    {
        public List<AppToDownload> ReadTable()
        {
            List<AppToDownload> listApps = new List<AppToDownload>();
            string source = "Data source = 'C:\\Users\\elshi\\Desktop\\AppToDownload.db'";

            using (var conn = new SqliteConnection(source))
            {
                conn.Open();
                using (SqliteCommand cmd = new SqliteCommand("Select * from AppToDownload", conn))
                {
                    cmd.Connection = conn;
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                                listApps.Add(new AppToDownload(
                                reader.GetString("AppName"),
                                reader.GetString("FileName"),
                                MyBytesToImage((byte[])reader["Icon"]),
                                reader.GetString("CommandLine"),
                                reader.GetString("Section")));
                        }
                        return listApps;
                    }
                }
            }
            return null;
        }

        public Bitmap MyBytesToImage(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                Image img = Image.FromStream(ms);
                return ResizeImage(Image.FromStream(ms), 50, 50);
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
