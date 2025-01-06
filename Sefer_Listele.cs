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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from otobus";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void seferiptal_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = $"delete from otobus where plaka ='{plakatext.Text}'";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void seferyenile_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from otobus";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void seferekle_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            connect.Open();
            string komut = $"insert into otobus values('{plakatext2.Text}',{koltukstext.Text},'{markatext.Text}')";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            connect.Close();
            connect.Open();
            string komut1 = "select * from otobus";
            MySqlDataAdapter de = new MySqlDataAdapter(komut1, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
