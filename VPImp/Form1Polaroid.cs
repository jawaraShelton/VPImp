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

        private void WipePolaroidWindow()
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }
    }
}
