using Microsoft.VisualBasic;
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
    public partial class CashWithdrawal : Form
    {
        public static CashWithdrawal Instance;
        // OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\is345sp24\\Documents\\ATM.accdb");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ATM.accdb");


        public CashWithdrawal()
        {
            InitializeComponent();
            Instance = this;
        }

        // Method to validate the amount entered by the user
        public decimal ValidatingAmount()
        {
            if (string.IsNullOrEmpty(cashWTextBox.Text))
            {
               
                return 0;
            }
            else
            {
                if (decimal.TryParse(cashWTextBox.Text, out decimal validatedAmount))
                {
                    
                   return validatedAmount;  
                   
                }
                else
                {
                   
                    return 0;
                }
            }
        }

        // Method to check the balance in the checking account
        public decimal checkCheckingBalance()
        {
            decimal checkingBalance = 0;

            string cardNum = Form1.instance.textboxCard.Text;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

               return checkingBalance;
                
        }

        // Method to check the balance in the saving account
        public decimal checkSavingBalance()
        {
            decimal savingBalance = 0;

            string cardNum = Form1.instance.textboxCard.Text;
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

        // Method to handle click event for withdrawing from checking account
        private void CashWCheckingAccountButton_Click(object sender, EventArgs e)
        {

            decimal amountToWithraw = ValidatingAmount();
          

            if ( amountToWithraw == 0)
            {
                MessageBox.Show("Plesae Enter valid amount");
                return;
            }
            decimal availableBalance = checkCheckingBalance();


            decimal newBalance;
            
            string cardNum = Form1.instance.textboxCard.Text;
           

            
            if (amountToWithraw < availableBalance)
            {
                try
                {
                    connection.Open();
                    newBalance = availableBalance - amountToWithraw;
                    string balanceUpdateQuery = "Update ATMUsers set CheckingAccount =@newBalance Where CardNumber =@cardNum";
                    OleDbCommand updateCmd = new OleDbCommand(balanceUpdateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@cardNum", cardNum);
                   
                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        MessageBox.Show(" Amount Withdrawn, Your new Balance in checking account is: " + newBalance);

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Insufficient Funds");
            }
            cashWTextBox.Clear();
        }

        private void cashWBackToMainButton_Click(object sender, EventArgs e)
        {
            cashWTextBox.Text = "";
            this.Close();
        }

        private void cashWExitMyAccountButton_Click(object sender, EventArgs e)
        {
            cashWTextBox.Text = "";
            Form1.instance.textboxCard.Clear();
            Form1.instance.textboxPin.Clear();
            Form1.instance.textboxCard.Focus();

            TransactionForm.instance.CloseInstance();
            this.Close();
        }

        // Method to handle click event for withdrawing from saving account
        private void cashWlSavingAccountButton_Click(object sender, EventArgs e)
        {
            decimal amountToWithraw = ValidatingAmount();


            if (amountToWithraw == 0)
            {
                MessageBox.Show("Plesae Enter valid amount");
                return;
            }
            decimal availableBalance = checkSavingBalance();


            decimal newBalance;

            string cardNum = Form1.instance.textboxCard.Text;



            if (amountToWithraw < availableBalance)
            {
                try
                {
                    connection.Open();
                    newBalance = availableBalance - amountToWithraw;
                    string balanceUpdateQuery = "Update ATMUsers set SavingAccount =@newBalance Where CardNumber =@cardNum";
                    OleDbCommand updateCmd = new OleDbCommand(balanceUpdateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@newBalance", newBalance);
                    updateCmd.Parameters.AddWithValue("@cardNum", cardNum);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(" Amount Withdrawn, Your new Balance in Saving Account is: " + newBalance);

                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Insufficient Funds");
            }
            cashWTextBox.Clear();
        }
    }
}
