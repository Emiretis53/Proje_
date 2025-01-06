namespace Projee
{
    partial class admin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            biletiptalb = new Button();
            otokontrolb = new Button();
            pictureBox1 = new PictureBox();
            gerib = new Button();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // biletiptalb
            // 
            biletiptalb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            biletiptalb.Location = new Point(114, 62);
            biletiptalb.Margin = new Padding(3, 2, 3, 2);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(124, 36);
            biletiptalb.TabIndex = 0;
            biletiptalb.Text = "BİLET İPTAL";
            biletiptalb.UseVisualStyleBackColor = true;
            biletiptalb.Click += biletiptalb_Click;
            // 
            // otokontrolb
            // 
            otokontrolb.BackColor = Color.Transparent;
            otokontrolb.Location = new Point(114, 233);
            otokontrolb.Margin = new Padding(3, 2, 3, 2);
            otokontrolb.Name = "otokontrolb";
            otokontrolb.Size = new Size(124, 36);
            otokontrolb.TabIndex = 2;
            otokontrolb.Text = "OTOBÜS KONTROL";
            otokontrolb.UseVisualStyleBackColor = false;
            otokontrolb.Click += otokontrolb_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._360_F_475009987_zwsk4c77x3cTpcI3W1C1LU4pOSyPKaqi__1_;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.InitialImage = Properties.Resources._360_F_475009987_zwsk4c77x3cTpcI3W1C1LU4pOSyPKaqi__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 361);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // gerib
            // 
            gerib.ImageKey = "png-clipart-button-back-s-blue-text-thumbnail.png";
            gerib.ImageList = ımageList1;
            gerib.Location = new Point(308, 12);
            gerib.Name = "gerib";
            gerib.Size = new Size(47, 41);
            gerib.TabIndex = 8;
            gerib.UseVisualStyleBackColor = true;
            gerib.Click += gerib_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "png-clipart-button-back-s-blue-text-thumbnail.png");
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 361);
            Controls.Add(gerib);
            Controls.Add(otokontrolb);
            Controls.Add(biletiptalb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMİN PANEL";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button biletiptalb;
        private Button otokontrolb;
        private PictureBox pictureBox1;
        public Button gerib;
        private ImageList ımageList1;
    }
}