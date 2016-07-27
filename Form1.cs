using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // using mysql

namespace leaderTest
{
    public partial class Form1 : Form
    {


        // global variaables
        private string conn;
        private MySqlConnection connect;


        public Form1()
        {
            InitializeComponent();
        }


        // function for the database connect
        private void db_connection()
        {
            try
            {
                conn = "server=127.0.0.1;userid=root;password=root;database=windows-form; port=3306;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }




    }
}
