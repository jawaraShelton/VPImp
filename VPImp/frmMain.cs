﻿using System;
using System.Windows.Forms;

namespace VPImp
{
    public partial class frmMain : Form
    {
        public frmMain()
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
            PImp(Properties.Settings.Default.ImageSource, Properties.Settings.Default.ImageDestination);
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
            Properties.Settings.Default.ImageDestination = txbDst.Text;
            Properties.Settings.Default.Save();
        }
    }
}
