namespace Projee
{
    partial class Ana_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Form));
            admingirisb = new Button();
            biletiptalb = new Button();
            tarihsec = new DateTimePicker();
            otobakb = new Button();
            label1 = new Label();
            label2 = new Label();
            combonereden = new ComboBox();
            combonereye = new ComboBox();
            pictureBox1 = new PictureBox();
            ımageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // admingirisb
            // 
            admingirisb.Location = new Point(460, 429);
            admingirisb.Name = "admingirisb";
            admingirisb.Size = new Size(102, 31);
            admingirisb.TabIndex = 0;
            admingirisb.Text = "Admin Giriş";
            admingirisb.UseVisualStyleBackColor = true;
            admingirisb.Click += button1_Click;
            // 
            // biletiptalb
            // 
            biletiptalb.Location = new Point(460, 466);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(102, 34);
            biletiptalb.TabIndex = 1;
            biletiptalb.Text = "Bilet İptal Et";
            biletiptalb.UseVisualStyleBackColor = true;
            biletiptalb.Click += button2_Click;
            // 
            // tarihsec
            // 
            tarihsec.Location = new Point(233, 93);
            tarihsec.Name = "tarihsec";
            tarihsec.Size = new Size(177, 23);
            tarihsec.TabIndex = 2;
            // 
            // otobakb
            // 
            otobakb.Location = new Point(233, 161);
            otobakb.Name = "otobakb";
            otobakb.Size = new Size(113, 23);
            otobakb.TabIndex = 3;
            otobakb.Text = "Otobüs Bul";
            otobakb.UseVisualStyleBackColor = true;
            otobakb.Click += otobakb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 144);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Nereye";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 75);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Nereden";
            // 
            // combonereden
            // 
            combonereden.FormattingEnabled = true;
            combonereden.Location = new Point(65, 93);
            combonereden.Name = "combonereden";
            combonereden.Size = new Size(121, 23);
            combonereden.TabIndex = 6;
            combonereden.SelectedIndexChanged += combonereden_SelectedIndexChanged;
            // 
            // combonereye
            // 
            combonereye.FormattingEnabled = true;
            combonereye.Location = new Point(65, 162);
            combonereye.Name = "combonereye";
            combonereye.Size = new Size(121, 23);
            combonereye.TabIndex = 7;
            combonereye.SelectedIndexChanged += combonereye_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.d209cfe457e410d808e0b9bd2787b09b;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 510);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "d209cfe457e410d808e0b9bd2787b09b.jpg");
            // 
            // Ana_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(574, 512);
            Controls.Add(combonereye);
            Controls.Add(combonereden);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(otobakb);
            Controls.Add(tarihsec);
            Controls.Add(biletiptalb);
            Controls.Add(admingirisb);
            Controls.Add(pictureBox1);
            Name = "Ana_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana_Form";
            Load += Ana_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        public Button admingirisb;
        public Button biletiptalb;
        public DateTimePicker tarihsec;
        public Button otobakb;
        public ComboBox combonereden;
        public ComboBox combonereye;
        private PictureBox pictureBox1;
        private ImageList ımageList1;
    }
}