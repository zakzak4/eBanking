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
    public partial class New_Transaction : Form
    {
        private decimal balance;

        public New_Transaction()
        {
            InitializeComponent();
        }
        public New_Transaction(decimal balance, string loggedInUsername)
        {
            InitializeComponent();
            this.balance = balance;

            LABEL_BALANCE.Text = balance.ToString("0.00", CultureInfo.GetCultureInfo("en-IE")) + " €";
        }

        private void BUTTON_SIGNUP_Click(object sender, EventArgs e)
        {
            // Get the receiver ID (iBank) and amount to transfer from the textboxes
            string receiverId = TEXTBOX_RECEIVER_ID.Text;
            decimal amount = decimal.Parse(TEXTBOX_AMOUNT.Text);

            // Perform the transaction logic here

            // Example: Display a message with the transaction details
            string message = $"Transferring {amount.ToString("0.00", CultureInfo.GetCultureInfo("en-IE"))} € to receiver ID: {receiverId}";
            MessageBox.Show(message, "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close the form or perform any other necessary actions
            this.Close();
        }
    }
}
