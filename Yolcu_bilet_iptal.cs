using Azure.Core.GeoJson;
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
    public partial class Form2 : Form
    {
        Form8 fr = new Form8();
        Form6 fr1 = new Form6();
        Koltuksecme Koltuksecme = new Koltuksecme();
        public Form2()
        {
            InitializeComponent();
        }

        private void biletiptalb_Click(object sender, EventArgs e)
        {
            string tcKimlik = tcgiriptal.Text;

            if (string.IsNullOrWhiteSpace(tcKimlik))
            {
                MessageBox.Show("Lütfen geçerli bir TC Kimlik numarası girin.");
                return;
            }

            using (MySqlConnection connect = new MySqlConnection("server=localhost;Database=proje;Uid=root;Pwd=emiretis5334;"))
            {
                try
                {
                    connect.Open();

                    // Koltuk numarasını ve satır bilgilerini al
                    string getKoltukQuery = "SELECT koltuk_no FROM yolcular WHERE y_tc = @tc";
                    MySqlCommand getKoltukCmd = new MySqlCommand(getKoltukQuery, connect);
                    getKoltukCmd.Parameters.AddWithValue("@tc", tcKimlik);
                    object result = getKoltukCmd.ExecuteScalar();

                    if (result != null)
                    {
                        int koltukNo = Convert.ToInt32(result);

                        // Yolcu kaydını veritabanından sil
                        string deleteQuery = "DELETE FROM yolcular WHERE y_tc = @tc";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connect);
                        deleteCmd.Parameters.AddWithValue("@tc", tcKimlik);
                        deleteCmd.ExecuteNonQuery();

                        // DataGridView'den de silme işlemi
                        foreach (DataGridViewRow row in fr1.ygostermedata.Rows)
                        {
                            if (row.Cells["y_tc"].Value != null && row.Cells["y_tc"].Value.ToString() == tcKimlik)
                            {
                                fr1.ygostermedata.Rows.RemoveAt(row.Index);
                                break;
                            }
                        }

                        MessageBox.Show("Bilet başarıyla iptal edildi.");

                        // Koltuk rengi eski haline dönecek (Eğer açık olan form varsa)
                        Form koltukSecmeFormu = Application.OpenForms["Koltuksecme"];
                        if (koltukSecmeFormu != null)
                        {
                            foreach (Control control in koltukSecmeFormu.Controls)
                            {
                                if (control is Button button && button.Text == koltukNo.ToString())
                                {
                                    button.BackColor = Color.White;
                                    button.Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu TC Kimlik numarasına ait kayıt bulunamadı.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_Form a = new Ana_Form();
            a.Show();
            this.Close();
        }
    }
}
