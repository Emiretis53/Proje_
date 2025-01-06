namespace Projee
{
    partial class Form2
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
            biletiptalb = new Button();
            label1 = new Label();
            tcgiriptal = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // biletiptalb
            // 
            biletiptalb.Location = new Point(73, 150);
            biletiptalb.Name = "biletiptalb";
            biletiptalb.Size = new Size(123, 23);
            biletiptalb.TabIndex = 0;
            biletiptalb.Text = "Bileti İptal Et";
            biletiptalb.UseVisualStyleBackColor = true;
            biletiptalb.Click += biletiptalb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 91);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "TC'nizi Giriniz";
            // 
            // tcgiriptal
            // 
            tcgiriptal.Location = new Point(73, 109);
            tcgiriptal.Name = "tcgiriptal";
            tcgiriptal.Size = new Size(123, 23);
            tcgiriptal.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(222, 12);
            button1.Name = "button1";
            button1.Size = new Size(45, 32);
            button1.TabIndex = 3;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(279, 285);
            Controls.Add(button1);
            Controls.Add(tcgiriptal);
            Controls.Add(label1);
            Controls.Add(biletiptalb);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button biletiptalb;
        private Label label1;
        public TextBox tcgiriptal;
        private Button button1;
    }
}