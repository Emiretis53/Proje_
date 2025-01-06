namespace Projee
{
    partial class Form8
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
            dataGridView1 = new DataGridView();
            seferiptal = new Button();
            plakatext = new TextBox();
            plaka = new Label();
            plaka2 = new Label();
            plakatext2 = new TextBox();
            seferekle = new Button();
            label1 = new Label();
            seferyenile = new Button();
            markatext = new TextBox();
            label2 = new Label();
            koltukstext = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 319);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // seferiptal
            // 
            seferiptal.Location = new Point(254, 386);
            seferiptal.Name = "seferiptal";
            seferiptal.Size = new Size(113, 38);
            seferiptal.TabIndex = 1;
            seferiptal.Text = "Seferi İptal Et";
            seferiptal.UseVisualStyleBackColor = true;
            seferiptal.Click += seferiptal_Click;
            // 
            // plakatext
            // 
            plakatext.Location = new Point(148, 395);
            plakatext.Name = "plakatext";
            plakatext.Size = new Size(100, 23);
            plakatext.TabIndex = 2;
            // 
            // plaka
            // 
            plaka.AutoSize = true;
            plaka.Location = new Point(67, 398);
            plaka.Name = "plaka";
            plaka.Size = new Size(71, 15);
            plaka.TabIndex = 3;
            plaka.Text = "Plaka Giriniz";
            // 
            // plaka2
            // 
            plaka2.AutoSize = true;
            plaka2.Location = new Point(851, 52);
            plaka2.Name = "plaka2";
            plaka2.Size = new Size(71, 15);
            plaka2.TabIndex = 4;
            plaka2.Text = "Plaka Giriniz";
            // 
            // plakatext2
            // 
            plakatext2.Location = new Point(937, 49);
            plakatext2.Name = "plakatext2";
            plakatext2.Size = new Size(119, 23);
            plakatext2.TabIndex = 5;
            // 
            // seferekle
            // 
            seferekle.Location = new Point(937, 170);
            seferekle.Name = "seferekle";
            seferekle.Size = new Size(119, 33);
            seferekle.TabIndex = 6;
            seferekle.Text = "Sefer Ekle";
            seferekle.UseVisualStyleBackColor = true;
            seferekle.Click += seferekle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(863, 146);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 8;
            label1.Text = "Marka Girin";
            // 
            // seferyenile
            // 
            seferyenile.Location = new Point(397, 386);
            seferyenile.Name = "seferyenile";
            seferyenile.Size = new Size(113, 38);
            seferyenile.TabIndex = 9;
            seferyenile.Tag = "Seferleri Yenile";
            seferyenile.Text = "Seferleri Yenile";
            seferyenile.UseVisualStyleBackColor = true;
            seferyenile.Click += seferyenile_Click;
            // 
            // markatext
            // 
            markatext.Location = new Point(937, 138);
            markatext.Name = "markatext";
            markatext.Size = new Size(119, 23);
            markatext.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(830, 98);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 11;
            label2.Text = "Koltuk Sayısı Girin";
            // 
            // koltukstext
            // 
            koltukstext.Location = new Point(937, 98);
            koltukstext.Name = "koltukstext";
            koltukstext.Size = new Size(119, 23);
            koltukstext.TabIndex = 12;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1163, 472);
            Controls.Add(koltukstext);
            Controls.Add(label2);
            Controls.Add(markatext);
            Controls.Add(seferyenile);
            Controls.Add(label1);
            Controls.Add(seferekle);
            Controls.Add(plakatext2);
            Controls.Add(plaka2);
            Controls.Add(plaka);
            Controls.Add(plakatext);
            Controls.Add(seferiptal);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button seferiptal;
        private TextBox plakatext;
        private Label plaka;
        private Label plaka2;
        private Label label1;
        private Button seferyenile;
        private Label label2;
        public TextBox plakatext2;
        public Button seferekle;
        public TextBox markatext;
        public TextBox koltukstext;
        public DataGridView dataGridView1;
    }
}