using System;
using System.Windows.Forms;
using System.IO;


namespace VPImp
{
    public partial class Form1 : Form
    {
        private void PImp(String src, String dst)
        {

            String exts = Properties.Settings.Default.ImageExtensions;
            String[] folders = Directory.GetDirectories(src);
            String[] files = Directory.GetFiles(src);

            foreach (string nbcLock in folders)
                PImp(nbcLock, dst);

            foreach (string nbcLock in files)
            {
                if (exts.Contains(nbcLock.Substring(nbcLock.Length - 3, 3).ToUpper()))
                {
                    DateTime? d = DateTaken(nbcLock);
                    String imageSortFolder = dst + "\\" + d.Value.Year.ToString() + "." + d.Value.Month.ToString("00") + "." + d.Value.Day.ToString("00");

                    UpdatePolaroidWindow(nbcLock);

                    if (!Directory.Exists(imageSortFolder))
                        Directory.CreateDirectory(imageSortFolder);

                    try
                    {
                        File.Move(nbcLock, imageSortFolder + "\\" + Path.GetFileName(nbcLock));
                    }
                    catch
                    {
                        File.Move(nbcLock, imageSortFolder + "\\" + Renamed(nbcLock));
                    }
                }

                Application.DoEvents();
            }

            DeleteIfEmpty(src);
            WipePolaroidWindow();

            toolStripStatusLabel1.Text = "Import Complete.";
            statusStrip1.Refresh();
        }
    }
}
