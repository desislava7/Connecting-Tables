using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreesZaimov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "server = 10.6.0.127;" +
            "port=3306;" +
            "user=PC1;" +
            "password= 1111;" +
            "database=trees_zaimov";
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection now opend!");

            string insertSQL = "INSERT INTO trees_zaimov.razred (`name`, name_bg) " +
                "VALUES (@name,@name_bg)";

            MySqlCommand query = new MySqlCommand(insertSQL, connect);

            query.Parameters.AddWithValue("@name", txt1.Text);
            query.Parameters.AddWithValue("@name_bg", txt2.Text);

            query.ExecuteNonQuery();
            MessageBox.Show("dobavih v tablica razred");
            connect.Close();
        }
    }
}
