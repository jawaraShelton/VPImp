namespace VPImp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.txbSrc = new System.Windows.Forms.TextBox();
            this.txbDst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonUpdateDest = new System.Windows.Forms.Button();
            this.buttonUpdateSource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Begin Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(17, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit pImp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbSrc
            // 
            this.txbSrc.Location = new System.Drawing.Point(82, 342);
            this.txbSrc.Name = "txbSrc";
            this.txbSrc.Size = new System.Drawing.Size(202, 20);
            this.txbSrc.TabIndex = 4;
            this.txbSrc.TextChanged += new System.EventHandler(this.txbSrc_TextChanged);
            // 
            // txbDst
            // 
            this.txbDst.Location = new System.Drawing.Point(82, 367);
            this.txbDst.Name = "txbDst";
            this.txbDst.Size = new System.Drawing.Size(202, 20);
            this.txbDst.TabIndex = 5;
            this.txbDst.TextChanged += new System.EventHandler(this.txbDst_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Import From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // buttonUpdateDest
            // 
            this.buttonUpdateDest.Location = new System.Drawing.Point(290, 366);
            this.buttonUpdateDest.Name = "buttonUpdateDest";
            this.buttonUpdateDest.Size = new System.Drawing.Size(25, 21);
            this.buttonUpdateDest.TabIndex = 8;
            this.buttonUpdateDest.Text = "...";
            this.buttonUpdateDest.UseVisualStyleBackColor = true;
            this.buttonUpdateDest.Click += new System.EventHandler(this.buttonUpdateDest_Click);
            // 
            // buttonUpdateSource
            // 
            this.buttonUpdateSource.Location = new System.Drawing.Point(290, 342);
            this.buttonUpdateSource.Name = "buttonUpdateSource";
            this.buttonUpdateSource.Size = new System.Drawing.Size(25, 20);
            this.buttonUpdateSource.TabIndex = 9;
            this.buttonUpdateSource.Text = "...";
            this.buttonUpdateSource.UseVisualStyleBackColor = true;
            this.buttonUpdateSource.Click += new System.EventHandler(this.buttonUpdateSource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 435);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.buttonUpdateSource);
            this.Controls.Add(this.buttonUpdateDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDst);
            this.Controls.Add(this.txbSrc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "P.Imp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbSrc;
        private System.Windows.Forms.TextBox txbDst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonUpdateDest;
        private System.Windows.Forms.Button buttonUpdateSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

