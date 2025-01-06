namespace Projee
{
    partial class admin_giris
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
            adminkullanıcıadılabel = new Label();
            adminsifrelabel = new Label();
            admingirisbuton = new Button();
            adminkaditext = new TextBox();
            adminsifretext = new TextBox();
            SuspendLayout();
            // 
            // adminkullanıcıadılabel
            // 
            adminkullanıcıadılabel.AutoSize = true;
            adminkullanıcıadılabel.Location = new Point(32, 57);
            adminkullanıcıadılabel.Name = "adminkullanıcıadılabel";
            adminkullanıcıadılabel.Size = new Size(73, 15);
            adminkullanıcıadılabel.TabIndex = 0;
            adminkullanıcıadılabel.Text = "Kullanıcı Adı";
            // 
            // adminsifrelabel
            // 
            adminsifrelabel.AutoSize = true;
            adminsifrelabel.Location = new Point(74, 103);
            adminsifrelabel.Name = "adminsifrelabel";
            adminsifrelabel.Size = new Size(30, 15);
            adminsifrelabel.TabIndex = 1;
            adminsifrelabel.Text = "Şifre";
            // 
            // admingirisbuton
            // 
            admingirisbuton.Location = new Point(109, 152);
            admingirisbuton.Margin = new Padding(3, 2, 3, 2);
            admingirisbuton.Name = "admingirisbuton";
            admingirisbuton.Size = new Size(133, 33);
            admingirisbuton.TabIndex = 2;
            admingirisbuton.Text = "GİRİŞ";
            admingirisbuton.UseVisualStyleBackColor = true;
            admingirisbuton.Click += admingirisbuton_Click;
            // 
            // adminkaditext
            // 
            adminkaditext.Location = new Point(109, 54);
            adminkaditext.Margin = new Padding(3, 2, 3, 2);
            adminkaditext.Name = "adminkaditext";
            adminkaditext.Size = new Size(134, 23);
            adminkaditext.TabIndex = 3;
            // 
            // adminsifretext
            // 
            adminsifretext.Location = new Point(109, 98);
            adminsifretext.Margin = new Padding(3, 2, 3, 2);
            adminsifretext.Name = "adminsifretext";
            adminsifretext.PasswordChar = '*';
            adminsifretext.Size = new Size(134, 23);
            adminsifretext.TabIndex = 4;
            // 
            // admin_giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 290);
            Controls.Add(adminsifretext);
            Controls.Add(adminkaditext);
            Controls.Add(admingirisbuton);
            Controls.Add(adminsifrelabel);
            Controls.Add(adminkullanıcıadılabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "admin_giris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADMİN GİRİŞİ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminkullanıcıadılabel;
        private Label adminsifrelabel;
        private Button admingirisbuton;
        private TextBox adminkaditext;
        private TextBox adminsifretext;
    }
}