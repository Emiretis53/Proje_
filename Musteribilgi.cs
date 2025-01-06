using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projee
{
    public partial class Musteribilgi : Form
    {
        //yolcu_kontrol yk = new yolcu_kontrol();
        
        Koltuksecme koltuksecme;
        private List<int> selectedKoltuklar;
        Ana_Form frm1 = new Ana_Form();
        public Musteribilgi(List<int> selectedKoltuklar, int secilenYolcu)
        {
            InitializeComponent();
            this.selectedKoltuklar = selectedKoltuklar;
            this.SecilenYolcu = secilenYolcu;
        }

        public Musteribilgi(int secilenYolcu)
        {
            SecilenYolcu = secilenYolcu;
        }

        public int SecilenYolcu { get; set; }
              
        private void yisimtext_TextChanged(object sender, EventArgs e)
        {
            string isim = yisimtext.Text;

        }

        private void ysatinal_Click(object sender, EventArgs e)
        {
            // Eğer koltuk ve yolcu seçilmişse işlem başlasın
            if (SecilenYolcu >= 1 && selectedKoltuklar.Count > 0)
            {
                string connectionString = "server=localhost;Database=proje;Uid=root;Pwd=emiretis5334;";

                try
                {
                    using (MySqlConnection connect = new MySqlConnection(connectionString))
                    {
                        connect.Open();

                        // Her seçilen koltuk için döngü
                        foreach (int koltukNo in selectedKoltuklar.ToList())
                        {
                            // Koltuk daha önce alınmış mı kontrolü
                            MySqlCommand checkCommand = new MySqlCommand("SELECT COUNT(*) FROM yolcular WHERE koltuk_no = @koltukNo", connect);
                            checkCommand.Parameters.AddWithValue("@koltukNo", koltukNo);
                            int koltukCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                            if (koltukCount > 0)
                            {
                                MessageBox.Show($"Koltuk No: {koltukNo} zaten alınmış!");
                                continue;
                            }

                            // Kullanıcı onayı al
                            DialogResult result = MessageBox.Show($"Koltuk No: {koltukNo} için bilgileri girmek ister misiniz?", "Yolcu Kaydı", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                // Boş alan kontrolü
                                if (string.IsNullOrWhiteSpace(yisimtext.Text) ||
                                    string.IsNullOrWhiteSpace(ysoyisimtext.Text) ||
                                    string.IsNullOrWhiteSpace(ytelefontext.Text) ||
                                    string.IsNullOrWhiteSpace(ymailtext.Text) ||
                                    string.IsNullOrWhiteSpace(ytctext.Text) ||
                                    string.IsNullOrWhiteSpace(ykreditext.Text))
                                {
                                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                                    continue;
                                }

                                // Yolcu bilgilerini ekle
                                string insertQuery = @"
                        INSERT INTO yolcular 
                        (y_isim, y_soyisim, y_telefon, y_mail, y_tc, y_kredi, cinsiyet, koltuk_no, nereden, nereye, tarih, firma, sefer_saati) 
                        VALUES 
                        (@isim, @soyisim, @telefon, @mail, @tc, @kredi, @cinsiyet, @koltuk_no, @nereden, @nereye, @tarih, @firma, @sefer_saati)";

                                using (MySqlCommand komut = new MySqlCommand(insertQuery, connect))
                                {
                                    komut.Parameters.AddWithValue("@isim", yisimtext.Text);
                                    komut.Parameters.AddWithValue("@soyisim", ysoyisimtext.Text);
                                    komut.Parameters.AddWithValue("@telefon", ytelefontext.Text);
                                    komut.Parameters.AddWithValue("@mail", ymailtext.Text);
                                    komut.Parameters.AddWithValue("@tc", ytctext.Text);
                                    komut.Parameters.AddWithValue("@kredi", ykreditext.Text);
                                    komut.Parameters.AddWithValue("@koltuk_no", koltukNo);
                                    komut.Parameters.AddWithValue("@cinsiyet", cinsiyetkombo.SelectedItem?.ToString() ?? "Belirtilmedi");
                                    komut.Parameters.AddWithValue("@nereden", "Rize");
                                    komut.Parameters.AddWithValue("@nereye", "Amasya");
                                    komut.Parameters.AddWithValue("@tarih", frm1.tarihsec.Value.ToString("yyyy-MM-dd"));
                                    komut.Parameters.AddWithValue("@firma", "Ciho Turizm");
                                    komut.Parameters.AddWithValue("@sefer_saati", "13:00:00");

                                    komut.ExecuteNonQuery();
                                }

                                // Form Alanlarını Temizle
                                yisimtext.Clear();
                                ysoyisimtext.Clear();
                                ytelefontext.Clear();
                                ymailtext.Clear();
                                ytctext.Clear();
                                ykreditext.Clear();
                                cinsiyetkombo.SelectedIndex = -1;

                                // Seçilen Yolcu Sayısını Güncelle
                                SecilenYolcu--;
                                selectedKoltuklar.Remove(koltukNo);
                                label1.Text = SecilenYolcu.ToString();

                                if (SecilenYolcu == 0)
                                {
                                    MessageBox.Show("Tüm koltuklar başarıyla kaydedildi!");
                                    Koltuksecme k = new Koltuksecme();
                                    this.Hide();
                                    k.Show();
                                    return;
                                }
                                else
                                {
                                    MessageBox.Show("Bir sonraki koltuk için bilgileri giriniz.");
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen koltuk seçimi yapın ve yolcu sayısını belirleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }






        private void yiptal_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Satın alma işlemini iptal etmek istiyor musunuz ?", "İptal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Ana_Form ana_Form = new Ana_Form();
                ana_Form.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void ysoyisimtext_TextChanged(object sender, EventArgs e)
        {
            string soyisim = ysoyisimtext.Text;
        }

        private void ytelefontext_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int telefon = ytelefontext.Text.Length;
        }
        private void ymailtext_TextChanged(object sender, EventArgs e)
        {
            string mail = ymailtext.Text;
        }

        private void ytctext_TextChanged(object sender, EventArgs e)
        {

        }

        private void Musteribilgi_Load(object sender, EventArgs e)
        {
            cinsiyetkombo.Items.Add("Erkek");
            cinsiyetkombo.Items.Add("Kadın");           
            MessageBox.Show($"Seçilen yolcu sayısı: {SecilenYolcu}");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cinsiyetkombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            koltuksecme = (Koltuksecme)Application.OpenForms["Koltuksecme"];           
        }
    }
}
