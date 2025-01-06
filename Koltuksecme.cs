using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projee
{


    public partial class Koltuksecme : Form
    {
        public List<int> selectedsatis;
        public int secilenYolcu { get; set; }
        private Dictionary<Button, Color> buttonOriginalColors = new Dictionary<Button, Color>();
        private string text1;
        private string text2;
        private string v;

        public void UpdateSeatSelection()
        {
            // Veritabanından güncel verileri al
            List<(int koltukNo, string cinsiyet)> doluKoltuklar = GetDoluKoltuklar();

            // Tüm butonları güncelle
            foreach (Control control in this.Controls)
            {
                if (control is Button button && int.TryParse(button.Text, out int koltukNo))
                {
                    var doluKoltuk = doluKoltuklar.FirstOrDefault(k => k.koltukNo == koltukNo);
                    if (doluKoltuk != default)
                    {
                        if (doluKoltuk.cinsiyet == "Erkek")
                        {
                            button.BackColor = Color.Blue;
                        }
                        else if (doluKoltuk.cinsiyet == "Kadın")
                        {
                            button.BackColor = Color.Pink;
                        }
                        else
                        {
                            button.BackColor = Color.White;
                        }
                        button.Enabled = false;
                    }
                }
            }
        }


        public Koltuksecme()
        {
            InitializeComponent();
            selectedsatis = new List<int>();
           
        }

        public Koltuksecme(string text1, string text2, string v)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.v = v;
        }

        Musteribilgi Musteribilgi { get; set; }


        public void button1_Click(object sender, EventArgs e)
        {
            if (selectedsatis.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçin!");
                return;
            }

            Musteribilgi musteriBilgi = new Musteribilgi(selectedsatis, secilenYolcu);
            this.Close();
            musteriBilgi.ShowDialog();
            
        }
       
        private void Koltuksecme_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from otobus";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            List<(int koltukNo, string cinsiyet)> doluKoltuklar = GetDoluKoltuklar();

            foreach (Control control in this.Controls)
            {
                if (control is Button button && int.TryParse(button.Text, out int koltukNo))
                {
                    var doluKoltuk = doluKoltuklar.FirstOrDefault(k => k.koltukNo == koltukNo);
                    if (doluKoltuk != default)
                    {
                        if (doluKoltuk.cinsiyet == "Erkek")
                        {
                            button.BackColor = Color.Blue;
                        }
                        else if (doluKoltuk.cinsiyet == "Kadın")
                        {
                            button.BackColor = Color.Pink;
                        }
                        else
                        {
                            button.BackColor = Color.White;
                        }
                        button.Enabled = false;
                    }
                }
            }
                                                
        }
        private List<(int koltukNo, string cinsiyet)> GetDoluKoltuklar()
        {
            buttonOriginalColors[koltuk1] = koltuk1.BackColor;
            buttonOriginalColors[koltuk2] = koltuk1.BackColor;
            buttonOriginalColors[koltuk3] = koltuk1.BackColor;
            buttonOriginalColors[koltuk4] = koltuk1.BackColor;
            buttonOriginalColors[koltuk5] = koltuk1.BackColor;
            buttonOriginalColors[koltuk6] = koltuk1.BackColor;
            buttonOriginalColors[koltuk7] = koltuk1.BackColor;
            buttonOriginalColors[koltuk8] = koltuk1.BackColor;
            buttonOriginalColors[koltuk9] = koltuk1.BackColor;
            buttonOriginalColors[koltuk10] = koltuk1.BackColor;
            buttonOriginalColors[koltuk11] = koltuk1.BackColor;
            buttonOriginalColors[koltuk12] = koltuk1.BackColor;
            buttonOriginalColors[koltuk13] = koltuk1.BackColor;
            buttonOriginalColors[koltuk14] = koltuk1.BackColor;
            buttonOriginalColors[koltuk15] = koltuk1.BackColor;
            buttonOriginalColors[koltuk16] = koltuk1.BackColor;
            buttonOriginalColors[koltuk17] = koltuk1.BackColor;
            buttonOriginalColors[koltuk18] = koltuk1.BackColor;
            buttonOriginalColors[koltuk19] = koltuk1.BackColor;
            buttonOriginalColors[koltuk20] = koltuk1.BackColor;
            buttonOriginalColors[koltuk21] = koltuk1.BackColor;
            buttonOriginalColors[koltuk22] = koltuk1.BackColor;
            buttonOriginalColors[koltuk23] = koltuk1.BackColor;
            buttonOriginalColors[koltuk24] = koltuk1.BackColor;
            buttonOriginalColors[koltuk25] = koltuk1.BackColor;
            buttonOriginalColors[koltuk26] = koltuk1.BackColor;
            buttonOriginalColors[koltuk27] = koltuk1.BackColor;
            buttonOriginalColors[koltuk28] = koltuk1.BackColor;
            buttonOriginalColors[koltuk29] = koltuk1.BackColor;
            buttonOriginalColors[koltuk30] = koltuk1.BackColor;
            buttonOriginalColors[koltuk31] = koltuk1.BackColor;
            buttonOriginalColors[koltuk32] = koltuk1.BackColor;
            buttonOriginalColors[koltuk33] = koltuk1.BackColor;
            buttonOriginalColors[koltuk34] = koltuk1.BackColor;
            buttonOriginalColors[koltuk35] = koltuk1.BackColor;
            buttonOriginalColors[koltuk36] = koltuk1.BackColor;
            buttonOriginalColors[koltuk37] = koltuk1.BackColor;
            buttonOriginalColors[koltuk38] = koltuk1.BackColor;
            buttonOriginalColors[koltuk39] = koltuk1.BackColor;
            buttonOriginalColors[koltuk40] = koltuk1.BackColor;
            buttonOriginalColors[koltuk41] = koltuk1.BackColor;
            buttonOriginalColors[koltuk42] = koltuk1.BackColor;
            buttonOriginalColors[koltuk43] = koltuk1.BackColor;
            buttonOriginalColors[koltuk44] = koltuk1.BackColor;
            buttonOriginalColors[koltuk45] = koltuk1.BackColor;
            buttonOriginalColors[koltuk46] = koltuk1.BackColor;
            List<(int koltukNo, string cinsiyet)> doluKoltuklar = new List<(int, string)>();

            using (MySqlConnection connect = new MySqlConnection("server=localhost;Database=proje;Uid=root;Pwd=emiretis5334;"))
            {
                string query = "SELECT koltuk_no, cinsiyet FROM yolcular";
                MySqlCommand komut = new MySqlCommand(query, connect);

                try
                {
                    connect.Open();
                    MySqlDataReader reader = komut.ExecuteReader();
                    while (reader.Read())
                    {
                        int koltukNo = reader.IsDBNull(reader.GetOrdinal("koltuk_no")) ? -1 : reader.GetInt32("koltuk_no");
                        string cinsiyet = reader.IsDBNull(reader.GetOrdinal("cinsiyet")) ? "Belirtilmedi" : reader.GetString("cinsiyet");

                        if (koltukNo != -1)
                        {
                            doluKoltuklar.Add((koltukNo, cinsiyet));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }

            return doluKoltuklar;
        }

        private void koltuk1_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            int koltuk_no = Convert.ToInt32(btn.Text);          
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));               
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;               
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;               
            }

        }       

        private void koltuk2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk10_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk14_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk15_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk16_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk18_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk19_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk20_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk21_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk22_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk23_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk24_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk25_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk26_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk27_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk28_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk29_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk30_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk31_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk32_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk33_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk34_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk35_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk36_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk37_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk38_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk39_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk40_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk41_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk42_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk43_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk44_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk45_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void koltuk46_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = buttonOriginalColors[btn];
                selectedsatis.Remove(Convert.ToInt32(btn.Text));
                secilenYolcu--;
            }
            else
            {
                btn.BackColor = Color.Red;
                selectedsatis.Add(Convert.ToInt32(btn.Text));
                secilenYolcu++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ana_Form form = new Ana_Form();
            form.Show();
            this.Close();
        }
    }
}
