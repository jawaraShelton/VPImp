using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace VPImp
{
    public partial class Form1 : Form
    {
        private Boolean DeleteIfEmpty(String src)
        {
            Boolean retval = false;

            if (IsEmpty(src))
            {
                Directory.Delete(src);
                retval = true;
            }

            return retval;
        }

        private static String Renamed(String nbcLock)
        {
            int fLen = Path.GetFileName(nbcLock).Length;
            String fExt = Path.GetFileName(nbcLock).Substring(fLen - 3, 3);
            String fNym = Path.GetFileName(nbcLock).Substring(0, fLen - 5);
            String fDst = fNym + DateTime.Now.ToString("H.mm.ss.ffff") + "." + fExt;

            return (fDst);
        }

        private static Boolean IsEmpty(String targetDirectory)
        {
            return ((Directory.GetFiles(targetDirectory).Length + Directory.GetDirectories(targetDirectory).Length) == 0);
        }

        public DateTime? DateTaken(String fNym)
        {
            Regex r = new Regex(":");
            String dateTaken = "";
            DateTime retval;

            using (FileStream fs = new FileStream(fNym, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromFile(fNym))
            {
                try
                {
                    PropertyItem propItem = myImage.GetPropertyItem(0x9003);
                    dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                }
                catch
                {
                    dateTaken = "2/19/1936";
                }
            }

            if (DateTime.TryParse(dateTaken, out retval))
                return retval;
            else
                return DateTime.Parse("2/19/1936");
        }
    }
}
