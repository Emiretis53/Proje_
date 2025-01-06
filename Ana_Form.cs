using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
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
    public partial class Ana_Form : Form
    {
        public string nereden;
        public string nereye;
        public Ana_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_giris admin_Giris = new admin_giris();
            admin_Giris.Show();
            this.Hide();
        }

        private void otobakb_Click(object sender, EventArgs e)
        {// ComboBox'ların boş olup olmadığını kontrol et
           
            nereden = combonereden.Text.ToString();
            nereye = combonereye.Text.ToString();
            if (string.IsNullOrWhiteSpace(combonereden.Text) ||
                string.IsNullOrWhiteSpace(combonereye.Text) ||
                string.IsNullOrWhiteSpace(tarihsec.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşlemi sonlandır
            }

            // Tüm alanlar doluysa işlemlere devam et
            MessageBox.Show("Otobüsler Firması Gösteriliyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Firma frm = new Firma();
            frm.Show();
            this.Hide();
        }

        private void combonereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void combonereye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ana_Form_Load(object sender, EventArgs e)
        {
            combonereden.Items.Add("Rize");
            combonereye.Items.Add("Amasya");
        }       

       
        
    }
}
