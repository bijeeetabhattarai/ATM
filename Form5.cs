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
    public partial class DepositForm : Form
    {
        public static DepositForm instance;
        //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\is345sp24\\Documents\\ATM.accdb");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ATM.accdb");


        public DepositForm()
        {
            InitializeComponent();
            instance = this;
        }

        // Method to validate the amount entered by the user
        public decimal ValidatingAmount()
        {
            if (string.IsNullOrEmpty(depositAmountTextBox.Text))
            {

                return 0;
            }
            else
            {
                if (decimal.TryParse(depositAmountTextBox.Text, out decimal validatedAmount))
                {
                    return validatedAmount;
                }
                else
                {

                    return 0;
                }
            }
        }

        // Card number obtained from the main form
        string cardNum = Form1.instance.textboxCard.Text;

        // Method to check the balance in the checking account
        public decimal checkCheckingBalance()
        {
            decimal checkingBalance = 0;

            string balanceCheckQuery = "Select * from ATMUsers where [CardNumber] =@cardNum";
            OleDbCommand readCmd = new OleDbCommand(balanceCheckQuery, connection);
            readCmd.Parameters.AddWithValue("@cardNum", cardNum);
            try
            {
                connection.Open();

                OleDbDataReader balanceReader = readCmd.ExecuteReader();


                while (balanceReader.Read())
                {
                    decimal.TryParse(balanceReader[4].ToString(), out checkingBalance);

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return checkingBalance;

        }
        // Method to check the balance in the saving account
        public decimal checkSavingBalance()
        {
            decimal savingBalance = 0;

            string balanceCheckQuery = "Select * from ATMUsers where [CardNumber] =@cardNum";
            OleDbCommand readCmd = new OleDbCommand(balanceCheckQuery, connection);
            readCmd.Parameters.AddWithValue("@cardNum", cardNum);
            try
            {
                connection.Open();

                OleDbDataReader balanceReader = readCmd.ExecuteReader();


                while (balanceReader.Read())
                {
                    decimal.TryParse(balanceReader[5].ToString(), out savingBalance);

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return savingBalance;

        }

        // Method to handle depositing amount into the checking account
        private void depositCheckingAccountButton_Click(object sender, EventArgs e)
        {
            decimal depositAmount = ValidatingAmount();
            decimal checkingBalance = checkCheckingBalance();
            decimal newCheckingBalance = depositAmount + checkingBalance;

            string depositCheckingQuery = "Update ATMUsers set CheckingAccount =@newCheckingBalance where CardNumber =@cardNum";
            
            OleDbCommand cmd = new OleDbCommand(depositCheckingQuery, connection);
            cmd.Parameters.AddWithValue("@newCheckingBalance", newCheckingBalance);
           
            cmd.Parameters.AddWithValue("@cardNum", cardNum);
           
            connection.Open();

            try
            {
                int rowAffected = cmd.ExecuteNonQuery();
                if(rowAffected > 0)
                {
                    MessageBox.Show("Deposit Successful");
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            depositAmountTextBox.Clear();
        }

        // Method to handle going back to the main form
        private void depositsBackToMainButton_Click(object sender, EventArgs e)
        {
           depositAmountTextBox.Text = "";
           this.Close();
        }

        // Method to handle exiting the account
        private void depositsExitMyAccountButton_Click(object sender, EventArgs e)
        {

            depositAmountTextBox.Text = "";
            Form1.instance.textboxCard.Clear();
            Form1.instance.textboxPin.Clear();
            Form1.instance.textboxCard.Focus();

            TransactionForm.instance.CloseInstance();
            this.Close();

        }

        // Method to handle depositing amount into the saving account
        private void depositsSavingAccountButton_Click(object sender, EventArgs e)
        {

            decimal depositAmount = ValidatingAmount();
            decimal savingBalance = checkSavingBalance();
            decimal newSavingBalance = depositAmount + savingBalance;

            string depositCheckingQuery = "Update ATMUsers set SavingAccount =@newSavingBalance where CardNumber =@cardNum";

            OleDbCommand cmd = new OleDbCommand(depositCheckingQuery, connection);
            cmd.Parameters.AddWithValue("@newSavingBalance", newSavingBalance);

            cmd.Parameters.AddWithValue("@cardNum", cardNum);

            connection.Open();

            try
            {
                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Deposit Successful");
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
            depositAmountTextBox.Clear();
        }
    }
}
