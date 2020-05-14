using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZCummings_SQL_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This was a mistake but cannot be removed without breaking everything.
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //should be called tableSwitch
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Users
            if (tableSwitch.SelectedIndex == 0)
            {

                //Generates Login details from DBConnect Class
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                DBConnect.USER_NAME + ";" + "PASSWORD=" +
                DBConnect.PASSWORD + ";" + "SslMode=" +
                DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                new MySqlConnection(connectionString))
                {
                    //Preps query and opens connection (May not work due to connection issues)
                    string query = "SELECT * FROM isad157_zcummings.users";
                    connection.Open();

                    //Gives query and returns with results
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UserDataTable = new DataTable();
                    sqlDA.Fill(UserDataTable);

                    //Clears grid and outputs results to grid
                    gridOutput.ClearSelection();
                    gridOutput.DataSource = UserDataTable;
                }
            }
            //Friendships
            if (tableSwitch.SelectedIndex == 1)
            {
                //Generates Login details from DBConnect Class
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                DBConnect.USER_NAME + ";" + "PASSWORD=" +
                DBConnect.PASSWORD + ";" + "SslMode=" +
                DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                new MySqlConnection(connectionString))
                {
                    //Preps query and opens connection
                    string query = "SELECT * FROM isad157_zcummings.friendships";
                    connection.Open();

                    //Gives query and returns with results
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessagesDataTable = new DataTable();
                    sqlDA.Fill(MessagesDataTable);

                    //Clears grid and outputs results to grid
                    gridOutput.ClearSelection();
                    gridOutput.DataSource = MessagesDataTable;
                }
            }
            //Messages
            if (tableSwitch.SelectedIndex == 2)
            {
                //Generates Login details from DBConnect Class
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                DBConnect.USER_NAME + ";" + "PASSWORD=" +
                DBConnect.PASSWORD + ";" + "SslMode=" +
                DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                new MySqlConnection(connectionString))
                {
                    //Preps query and opens connection
                    string query = "SELECT * FROM isad157_zcummings.messages";
                    connection.Open();

                    //Gives query and returns with results
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable MessageDataTable = new DataTable();
                    sqlDA.Fill(MessageDataTable);

                    //Clears grid and outputs results to grid
                    gridOutput.ClearSelection();
                    gridOutput.DataSource = MessageDataTable;
                }
            }
            //Universities
            if (tableSwitch.SelectedIndex == 3)
            {
                //Generates Login details from DBConnect Class
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                DBConnect.USER_NAME + ";" + "PASSWORD=" +
                DBConnect.PASSWORD + ";" + "SslMode=" +
                DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                new MySqlConnection(connectionString))
                {
                    //Preps query and opens connection
                    string query = "SELECT * FROM isad157_zcummings.universities";
                    connection.Open();

                    //Gives query and returns with results
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable UniDataTable = new DataTable();
                    sqlDA.Fill(UniDataTable);

                    //Clears grid and outputs results to grid
                    gridOutput.ClearSelection();
                    gridOutput.DataSource = UniDataTable;
                }
            }
            //Workplace
            else
            {
                //Generates Login details from DBConnect Class
                string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                DBConnect.USER_NAME + ";" + "PASSWORD=" +
                DBConnect.PASSWORD + ";" + "SslMode=" +
                DBConnect.SslMode + ";";


                using (MySqlConnection connection =
                new MySqlConnection(connectionString))
                {
                    //Preps query and opens connection
                    string query = "SELECT * FROM isad157_zcummings.workplace";
                    connection.Open();

                    //Gives query and returns with results
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable WorkDataTable = new DataTable();
                    sqlDA.Fill(WorkDataTable);

                    //Clears grid and outputs results to grid
                    gridOutput.ClearSelection();
                    gridOutput.DataSource = WorkDataTable;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tried to make the combo box read only, didn't work and now can't delete or everything breaks
            tableSwitch.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
