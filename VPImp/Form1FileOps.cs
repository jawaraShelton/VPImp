using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

using MetadataExtractor;

namespace VPImp
{
    public partial class Form1 : Form
    {
        private Boolean DeleteIfEmpty(String src)
        {
            Boolean retval = false;

            if (IsEmpty(src))
            {
                System.IO.Directory.Delete(src);
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
            return ((System.IO.Directory.GetFiles(targetDirectory).Length + System.IO.Directory.GetDirectories(targetDirectory).Length) == 0);
        }

        public DateTime? DateTaken(String fNym)
        {
            String nbcLock = "2/19/1936";
            DateTime retval;

            try
            {
                IEnumerable<MetadataExtractor.Directory> directories = ImageMetadataReader.ReadMetadata(fNym);
                foreach (var directory in directories)
                    foreach (var tag in directory.Tags)
                        if (directory.Name == "Exif IFD0" && tag.TagName == "Date/Time")
                            nbcLock = tag.Description.Substring(0, 11).Replace(':', '-') + tag.Description.Substring(11);
            }
            catch
            {
               
            }

            if (DateTime.TryParse(nbcLock, out retval))
                return retval;
            else
                return DateTime.Parse("2/19/1936");
        }
    }
}
