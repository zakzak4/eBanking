using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBanking
{
    public partial class Main_Customer : Form
    {
        private string firstName;
        private string lastName;
        private decimal balance;
        private string loggedInUsername;

        public Main_Customer(string text)
        {
            InitializeComponent();
            Text = text;
        }

        public Main_Customer(string text, string firstName, string lastName, decimal balance) : this(text)
        {
        }

        public Main_Customer(string text, string firstName, string lastName, decimal balance, string text1) : this(text)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
            this.loggedInUsername = loggedInUsername;

            LABEL_WLC.Text = "Welcome, " + firstName + " " + lastName + "!";
            LABEL_BALANCE.Text = balance.ToString("0.00", CultureInfo.GetCultureInfo("en-IE")) + " €";
        }

        private void BUTTON_LOG_OUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            eBanking f1 = new eBanking();
            f1.ShowDialog();
        }

        private void BUTTON_NEW_TRAN_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Transaction f4 = new New_Transaction(balance, loggedInUsername);
            f4.ShowDialog();
        }
    }
}
