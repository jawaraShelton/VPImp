using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;

namespace VPImp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statusStrip1.Refresh();

            txbSrc.Text = Properties.Settings.Default.ImageSource;
            txbDst.Text = Properties.Settings.Default.ImageDestination;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String src = Properties.Settings.Default.ImageSource;
            String dst = Properties.Settings.Default.ImageDestination;

            PImp(src, dst);
        }

        private void PImp(String src, String dst)
        {
            
            String exts = Properties.Settings.Default.ImageExtensions;
            String[] folders = Directory.GetDirectories(src);
            String[] files = Directory.GetFiles(src);

            foreach (string nbcLock in folders)
                PImp(nbcLock, dst);

            foreach (string nbcLock in files)
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

            DeleteIfEmpty(src);
            WipePolaroidWindow();

            toolStripStatusLabel1.Text = "Import Complete.";
            statusStrip1.Refresh();
        }

        private void WipePolaroidWindow()
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

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

        public Boolean UpdatePolaroidWindow(String fNym)
        {
            Boolean retval = false;
            try
            {
                using (Image myImage = Image.FromFile(fNym))
                {
                    pictureBox1.Image = myImage;
                    pictureBox1.Refresh();
                }

                retval = true;
            }
            catch
            {
                retval = false;
            }

            return retval;
        }

        public DateTime? DateTaken(String fNym)
        {
            Regex r = new Regex(":");
            string dateTaken = "";

            using (FileStream fs = new FileStream(fNym, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromFile(fNym))
            {
                PropertyItem propItem;

                try
                { 
                    propItem = myImage.GetPropertyItem(0x9003);
                    dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                }
                catch
                {
                    dateTaken = "2/19/1936";
                }
                Console.WriteLine(dateTaken);

            }
            return DateTime.Parse(dateTaken);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdateSource_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string foldername = this.folderBrowserDialog1.SelectedPath;

                txbSrc.Text = foldername;
                txbSrc.Refresh();

                Properties.Settings.Default.ImageSource = foldername;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonUpdateDest_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string foldername = this.folderBrowserDialog1.SelectedPath;

                txbDst.Text = foldername;
                txbDst.Refresh();

                Properties.Settings.Default.ImageDestination = foldername;
                Properties.Settings.Default.Save();
            }
        }

        private void txbSrc_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ImageSource = txbSrc.Text;
            Properties.Settings.Default.Save();
        }

        private void txbDst_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ImageDestination = txbSrc.Text;
            Properties.Settings.Default.Save();
        }
    }
}
