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
using MySqlX.XDevAPI.Relational;

namespace eBanking
{
    public partial class NEW_ACCOUNT : Form
    {
        public NEW_ACCOUNT(string text)
        {
            InitializeComponent();
            c_username = "root";
            c_password = "";
        }
        string c_username, c_password;

        public static string server = "localhost";
        public static string database = "bank";
        public static string username = "root";
        public static string password = "";
        public static string TABLE = "customer";

        private void BUTTON_SIGNUP_Click(object sender, EventArgs e)
        {
            string id = null;
            string fname = TEXTBOX_NEW_FIRSTNAME.Text;
            string sname = TEXTBOX_NEW_SURNAME.Text;
            int age = int.Parse(TEXTBOX_NEW_AGE.Text);
            string usname = TEXTBOX_NEW_USERNAME.Text;
            string uspass = TEXTBOX_NEW_PASSWORD.Text;
            string new_gender = TEXTBOX_NEW_GENDER.Text;

            Random random = new Random();
            decimal bal = (decimal)(random.NextDouble() * 1000);

            string query = "INSERT INTO " + database + "." + TABLE + "(Firstname, Lastname, UserName, UserPassword, Age, Gender, Balance) VALUES(@fname, @sname, @usname, @uspass, @age, @new_gender, @bal)";
            string selectQuery = "SELECT * FROM " + database + "." + TABLE + " WHERE UserName = @usname";

            string mySqlConnectionString = "datasource=" + server + ";port=3306;username=" + c_username + ";password=" + c_password + ";database=" + database;

            using (MySqlConnection connection = new MySqlConnection(mySqlConnectionString))
            {
                connection.Open();

                MySqlCommand insertCommand = new MySqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@fname", fname);
                insertCommand.Parameters.AddWithValue("@sname", sname);
                insertCommand.Parameters.AddWithValue("@usname", usname);
                insertCommand.Parameters.AddWithValue("@uspass", uspass);
                insertCommand.Parameters.AddWithValue("@age", age);
                insertCommand.Parameters.AddWithValue("@new_gender", new_gender);
                insertCommand.Parameters.AddWithValue("@bal", bal);

                int rowsAffected = insertCommand.ExecuteNonQuery();
                Console.WriteLine("{0} rows affected!", rowsAffected);

                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@usname", usname);

                using (MySqlDataReader reader = selectCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string iBank = reader.GetString("iBank");
                        string firstName = reader.GetString("Firstname");
                        string lastName = reader.GetString("Lastname");
                        string username = reader.GetString("UserName");
                        int userAge = reader.GetInt32("Age");
                        string gender = reader.GetString("Gender");
                        decimal balance = reader.GetDecimal("Balance");

                        Toast message = new Toast();
                        message.ToastMessage("Account Was Created Successfully!");

                        this.Hide();
                        Main_Customer f3 = new Main_Customer(TEXTBOX_NEW_USERNAME.Text, firstName, lastName, balance);
                        f3.ShowDialog();
                    }
                    else
                    {
                        Toast message = new Toast();
                        message.ToastMessage("Failed to retrieve the inserted data.");
                    }
                }
            }
        }
    }
}