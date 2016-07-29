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
        GenerateGroups generateGroups = new GenerateGroups(10);

        /// Init the form
        public Form1()
        {
            InitializeComponent();
           int x = generateGroups.count;
        }



        // global variaables for database
        private string conn;
        private MySqlConnection connect;



        //variables for the questions
         private void questionField(object sender, EventArgs e)
        {

            //string userName;
            string a = Q1.Text;
            string b = Q2.Text;
            //string c;
            //string d;
            //string e;
            //string f;
            //string g;
            //string h;
            //string i;
            //string j;

            int userValue = 0;
            string callName = "";


            userValue += calculateUser(a);
            userValue += calculateUser(b);


        }


        
        // function to calculate the points        
        public static int calculateUser(string userInput)
        {
            int score = 0;

            if (userInput == "yes")
            {
                return score += 10;
            }
            else if (userInput == "no")
            {
                return score -= 5;
            }
            else
            {
                return score -= 1;
            }
        }


        // function for the database connect
        public void db_connection()
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



        private void button1_Click(object sender, EventArgs e)
        {
            // connection with the database
            db_connection();
            MySqlCommand cmd = new MySqlCommand();

            // select the user where user is igual current user
            cmd.CommandText = "insert into people (name, score) Values ('joe', '5')";
            //cmd.Parameters.AddWithValue("@user", Q1);
            //cmd.Parameters.AddWithValue("@pass", Q2);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
        }

   
        // windows form function buttons

        private void Q1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Q2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
