namespace Projee
{
    partial class Firma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firma));
            button1 = new Button();
            ımageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageKey = "7ef24db3928b30fd17586d85d5c1e912.jpg";
            button1.ImageList = ımageList1;
            button1.Location = new Point(75, 98);
            button1.Name = "button1";
            button1.Size = new Size(184, 94);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "7ef24db3928b30fd17586d85d5c1e912.jpg");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Firma Seçimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 80);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Ciho Turizm";
            // 
            // Firma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(352, 300);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Firma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Firma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ImageList ımageList1;
        private Label label1;
        private Label label2;
    }
}