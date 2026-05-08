using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace eBanking
{
    public partial class eBanking : Form
    {
        public eBanking()
        {
            InitializeComponent();
        }

        string username, password;

        private void BUTTON_LOGIN_Click(object sender, EventArgs e)
        {
            string TABLE = "bank.customer";
            string Query = "SELECT COUNT(*) FROM " + TABLE + " WHERE UserName = @username AND UserPassword = @password";
            string MySQLConnectionString = "datasource=localhost;port=3306;username=root;password=;database=bank;";

            using (MySqlConnection connection = new MySqlConnection(MySQLConnectionString))
            {
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.Parameters.AddWithValue("@username", TEXTBOX_USERNAME.Text.ToLower());
                command.Parameters.AddWithValue("@password", TEXTBOX_PASSWORD.Text.ToLower());

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null && Convert.ToInt32(result) > 0)
                    {
                        string firstName = "";
                        string lastName = "";
                        decimal balance = 0;

                        string userQuery = "SELECT Firstname, Lastname, Balance FROM " + TABLE + " WHERE UserName = @username";
                        MySqlCommand userCommand = new MySqlCommand(userQuery, connection);
                        userCommand.Parameters.AddWithValue("@username", TEXTBOX_USERNAME.Text.ToLower());

                        using (MySqlDataReader userReader = userCommand.ExecuteReader())
                        {
                            if (userReader.Read())
                            {
                                firstName = userReader.GetString("Firstname");
                                lastName = userReader.GetString("Lastname");
                                balance = userReader.GetDecimal("Balance");
                            }
                        }

                        Toast message = new Toast();
                        message.ToastMessage("Login Successful!");

                        this.Hide();
                        Main_Customer f2 = new Main_Customer(TEXTBOX_USERNAME.Text, firstName, lastName, balance, TEXTBOX_USERNAME.Text);
                        f2.ShowDialog();
                    }
                    else
                    {
                        Toast message = new Toast();
                        message.ToastMessage("Credentials Are Incorrect.");
                        TEXTBOX_USERNAME.Text = "";
                        TEXTBOX_PASSWORD.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    Toast message = new Toast();
                    message.ToastMessage(ex.Message);
                }
            }
        }

        private void BUTTON_SIGNUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            NEW_ACCOUNT f3 = new NEW_ACCOUNT(TEXTBOX_USERNAME.Text);
            f3.ShowDialog();
        }

        private void eBanking_Load(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "bank";
            username = "root";
            password = "";
            string Query = "Select * from bank.customer";
            string MySQLConnectionString = "datasource=" + server + ";port=3306;username=" + username + ";password=" + password + ";database=" + database + ";";
            MySqlConnection connection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand command = new MySqlCommand(Query, connection);
            command.CommandTimeout = 60;

            try
            {
                connection.Open();
                MySqlDataReader MyReader = command.ExecuteReader();
                if (MyReader.HasRows)
                {
                    Toast message = new Toast();
                    message.ToastMessage("You Have Connected Successfully To The Database.");
                }
            }
            catch (Exception ex)
            {
                Toast message = new Toast();
                message.ToastMessage(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}