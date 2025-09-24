using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class BalanceInquiry : Form
    {
        public static BalanceInquiry instance;

        //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\is345sp24\\Documents\\ATM.accdb");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ATM.accdb");


        // Constructor for the Balance Inquiry form
        public BalanceInquiry()
        {
            InitializeComponent();
            instance = this;
           
        }

        // Method to handle click event for checking account button
        private void checkingAccountButton_Click(object sender, EventArgs e)
        {
            // Variable to store checking account balance
            decimal ChecckingBalance = 0;
            // Get the card number from the main form
            string cardNum = Form1.instance.textboxCard.Text;

            // SQL query to select checking account balance based on card number
            string balanceCheckQuery = "Select * from ATMUsers where [CardNumber] =@cardNum";
            OleDbCommand readCmd = new OleDbCommand(balanceCheckQuery, connection);
            readCmd.Parameters.AddWithValue("@cardNum", cardNum);

            try
            {
                connection.Open();
                OleDbDataReader balanceReader = readCmd.ExecuteReader();

                while (balanceReader.Read())
                {
                    decimal.TryParse(balanceReader[4].ToString(), out ChecckingBalance);
                }
                // Display checking account balance
                balanceCheckingDisplayLabel.Text = "Your Checking Balance is:  $" + ChecckingBalance;
                // Close database connection
                connection.Close();
            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // Method to handle click event for saving account button
        private void savingAccountButton_Click(object sender, EventArgs e)
        {

            // Variable to store saving account balance and get the card number from the main form
            decimal savingBalance = 0;
            string cardNum = Form1.instance.textboxCard.Text;

            // SQL query to select saving account balance based on card number
            string balanceCheckQuery = "Select * from ATMUsers where [CardNumber] =@cardNum";
            OleDbCommand cmd = new OleDbCommand(balanceCheckQuery, connection);
            cmd.Parameters.AddWithValue("@cardNum", cardNum);

            try
            {
                // Open database connection
                connection.Open();
                // Execute query and read results
                OleDbDataReader balanceReader = cmd.ExecuteReader();


                while (balanceReader.Read())
                {
                    // Parse saving account balance from database result
                    decimal.TryParse(balanceReader[5].ToString(), out savingBalance);

                }
                // Display saving account balance
                balanceSavingDisplayLabel.Text = "Your Saving Balance is:  $" + savingBalance;

                // Close database connection
                connection.Close();
            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // Method to handle click event for the back to main button
        private void balanceInquiryBackToMainButton_Click(object sender, EventArgs e)
        {
            // Clear balance labels and close the balance inquiry form
            balanceCheckingDisplayLabel.Text = "";
            balanceSavingDisplayLabel.Text = "";
            this.Close();
        }

        // Method to handle click event for the exit account button
        private void balanceIExitAccountbutton_Click(object sender, EventArgs e)
        {
            // Clear balance labels, clear card number and pin textboxes, and close the balance inquiry and transaction forms
            balanceCheckingDisplayLabel.Text = "";
            balanceSavingDisplayLabel.Text = "";
            Form1.instance.textboxCard.Clear();
            Form1.instance.textboxPin.Clear();
            Form1.instance.textboxCard.Focus();
            TransactionForm.instance.CloseInstance();
            this.Close();

        }
    }
}
