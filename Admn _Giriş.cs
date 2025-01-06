using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee
{
    public partial class admin_giris : Form
    {
        public admin_giris()
        {
            InitializeComponent();
        }

        private void admingirisbuton_Click(object sender, EventArgs e)
        {

            string adminkullaniciadi = "admin";
            string sifre = "12345";
            adminsifretext.Text = sifre.ToString();
            if (adminkaditext.Text == adminkullaniciadi && adminsifretext.Text == sifre)
            {
                MessageBox.Show("Admin girişi başarılı");
                admin admin_giris = new admin();
                admin_giris.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış, giriş başarısız");
                this.Close();
                Ana_Form fr = new Ana_Form();
                fr.Show();
                this.Hide();
            }
            
        }
    }
}
