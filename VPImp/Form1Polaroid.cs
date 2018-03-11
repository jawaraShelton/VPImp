using System;
using System.Drawing;
using System.Windows.Forms;

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
                    pictureBox1.Image = null;
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
