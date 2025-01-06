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
    public partial class Form6 : Form
    {
        Musteribilgi musteribilgi = new Musteribilgi(secilenYolcu);
        private static int secilenYolcu;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            string komut = "select * from yolcular";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ygostermedata.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection("server='localhost';Database='proje';Uid='root';Pwd='emiretis5334';");
            connect.Open();
            string komut = $"delete from yolcular where y_tc = '{yolcutc.Text}'";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, connect);
            connect.Close();
            connect.Open();
            string komut1 = "select * from yolcular";
            MySqlDataAdapter de = new MySqlDataAdapter(komut1, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ygostermedata.DataSource = dt;
            connect.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void idlabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server = 'localhost';Database = 'proje';Uid = 'root';Pwd = 'emiretis5334'");
            connection.Open();
            string komut = "select * from yolcular";
            MySqlDataAdapter d = new MySqlDataAdapter(komut , connection);
            DataTable dt = new DataTable();
            d.Fill(dt);
            ygostermedata.DataSource= dt;
            connection.Close();

        }
    }
}
