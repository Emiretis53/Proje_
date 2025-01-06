namespace Projee
{
    partial class Form6
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
            ygostermedata = new DataGridView();
            ylistelabel = new Label();
            biletiptalb = new Button();
            yolcutc = new TextBox();
            idlabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ygostermedata).BeginInit();
            SuspendLayout();
            // 
            // ygostermedata
            // 
            ygostermedata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ygostermedata.Location = new Point(32, 61);
            ygostermedata.Name = "ygostermedata";
            ygostermedata.Size = new Size(1087, 374);
            ygostermedata.TabIndex = 0;
            // 
            // ylistelabel
            // 
            ylistelabel.AutoSize = true;
            ylistelabel.Location = new Point(32, 40);
            ylistelabel.Name = "ylistelabel";
            ylistelabel.Size = new Size(85, 15);
            ylistelabel.TabIndex = 1;
            ylistelabel.Text = "YOLCU LİSTESİ";
            // 
            // biletiptalb
            // 
            biletiptalb.Location = new Point(882, 474);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(131, 23);
            biletiptalb.TabIndex = 2;
            biletiptalb.Text = "BİLETİ İPTAL ET";
            biletiptalb.UseVisualStyleBackColor = true;
            biletiptalb.Click += button1_Click;
            // 
            // yolcutc
            // 
            yolcutc.Location = new Point(893, 448);
            yolcutc.Name = "yolcutc";
            yolcutc.Size = new Size(100, 23);
            yolcutc.TabIndex = 3;
            // 
            // idlabel
            // 
            idlabel.AutoSize = true;
            idlabel.Location = new Point(830, 456);
            idlabel.Name = "idlabel";
            idlabel.Size = new Size(57, 15);
            idlabel.TabIndex = 4;
            idlabel.Text = "TC Giriniz";
            idlabel.Click += idlabel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1019, 474);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 5;
            button1.Text = "Yenile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1178, 523);
            Controls.Add(button1);
            Controls.Add(idlabel);
            Controls.Add(yolcutc);
            Controls.Add(biletiptalb);
            Controls.Add(ylistelabel);
            Controls.Add(ygostermedata);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)ygostermedata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ylistelabel;
        private Button biletiptalb;
        public DataGridView ygostermedata;
        private TextBox yolcutc;
        private Label idlabel;
        private Button button1;
    }
}