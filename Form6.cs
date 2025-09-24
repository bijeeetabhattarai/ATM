using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class TransferForm : Form
    {
        public static TransferForm instance;
        // OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\is345sp24\\Documents\\ATM.accdb");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ATM.accdb");


        public TransferForm()
        {
            InitializeComponent();
            instance = this;

            // Set default selection for transferFromComboBox
            transferFromComboBox.SelectedIndex = 0;
        }

        // Method to handle click event for transferring back to main form button
        private void transferBackToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method to handle click event for exiting account during transfer
        private void transferExitMyAccountButton_Click(object sender, EventArgs e)
        {
            // Clear card number and pin textboxes and focus on card number textbox
            Form1.instance.textboxCard.Clear();
            Form1.instance.textboxPin.Clear();
            Form1.instance.textboxCard.Focus();
            // Close the TransactionForm instance and this TransferForm instance
            TransactionForm.instance.CloseInstance();
            this.Close();
        }


        // Method to validate amount entered in transfer amount textbox
        public decimal ValidatingAmount()
        {
            if (string.IsNullOrEmpty(depositTransferAmountTextBox.Text))
            {

                return 0;
            }
            else
            {
                if (decimal.TryParse(depositTransferAmountTextBox.Text, out decimal validatedAmount))
                {
                    return validatedAmount;
                }
                else
                {

                    return 0;
                }
            }
        }
        string cardNum = Form1.instance.textboxCard.Text;

        // Method to check checking account balance from database
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

        // Method to check saving account balance from database
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

        /* public void updateCheckingBalance()
          {


              decimal amountToTransfer = ValidatingAmount();
              decimal checkingBalance = checkCheckingBalance();
              decimal newCheckingBalance = amountToTransfer + checkingBalance;
              decimal savingBalance = checkSavingBalance();
              decimal newSavingBalance = savingBalance - amountToTransfer;


              string balancetransferToQuery = "Update ATMUsers set CheckingAccount =@newCheckingBalance where CardNumber =@cardNum";
              OleDbCommand toCmd = new OleDbCommand(balancetransferToQuery, connection);
              toCmd.Parameters.AddWithValue("@newCheckingBalance", newCheckingBalance);

              toCmd.Parameters.AddWithValue("@cardNum", cardNum);

              connection.Open();

              try
              {
                  int rowAffected = toCmd.ExecuteNonQuery();
                  if (rowAffected > 0)
                  {
                      MessageBox.Show("Transfer Successful. Your New Checking Balance is: " + newCheckingBalance.ToString());
                  }
                  else
                  {
                      MessageBox.Show("Transfer Failed");
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);

              }
              connection.Close();
          }

          public void updateSavingBalance()
          {

              decimal amountToTransfer = ValidatingAmount();
              decimal checkingBalance = checkCheckingBalance();
              decimal newCheckingBalance = amountToTransfer + checkingBalance;
              decimal savingBalance = checkSavingBalance();
              decimal newSavingBalance = savingBalance - amountToTransfer;


              string balancetransferFromQuery = "Update ATMUsers set SavingAccount =@newSavingBalance where CardNumber =@cardNum";
              OleDbCommand fromCmd = new OleDbCommand(balancetransferFromQuery, connection);
              fromCmd.Parameters.AddWithValue("@newSavingBalance", newSavingBalance);

              fromCmd.Parameters.AddWithValue("@cardNum", cardNum);

              connection.Open();


              try
              {
                  int rowAffected = fromCmd.ExecuteNonQuery();
                  if (rowAffected > 0)
                  {
                      MessageBox.Show("Transfer Successful. Your New Saving Balance is: " + newSavingBalance.ToString());
                  }
                  else
                  {
                      MessageBox.Show("Transfer Failed");
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);

              }
              connection.Close();

          }*/

        // Method to handle click event for transfer button
        private void transferButton_Click(object sender, EventArgs e)
        {
            // If transferring from saving account to checking account
            if (transferFromComboBox.Text == "Saving Account To Checking Account")
            {
                decimal amountToTransfer = ValidatingAmount();
                decimal checkingBalance = checkCheckingBalance();
                decimal newCheckingBalance = amountToTransfer + checkingBalance;
                decimal savingBalance = checkSavingBalance();
                decimal newSavingBalance = savingBalance - amountToTransfer;

                // If saving balance is less than the amount to transfer, show insufficient funds message
                if (savingBalance < amountToTransfer)
                {
                    MessageBox.Show("Insufficient Funds");
                    transferFromComboBox.SelectedIndex = 0;
                    depositTransferAmountTextBox.Clear();
                }
                else
                {
                    // Update checking account balance in database
                    string balancetransferToQuery = "Update ATMUsers set CheckingAccount =@newCheckingBalance where CardNumber =@cardNum";
                    OleDbCommand toCmd = new OleDbCommand(balancetransferToQuery, connection);
                    toCmd.Parameters.AddWithValue("@newCheckingBalance", newCheckingBalance);

                    toCmd.Parameters.AddWithValue("@cardNum", cardNum);

                    connection.Open();

                    try
                    {
                        int rowAffected = toCmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Transfer Successful. Your New Checking Balance is: " + newCheckingBalance.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Transfer Failed");
                            transferFromComboBox.SelectedIndex = 0;
                            depositTransferAmountTextBox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    connection.Close();

                    // Update saving account balance in database
                    string balancetransferFromQuery = "Update ATMUsers set SavingAccount =@newSavingBalance where CardNumber =@cardNum";
                    OleDbCommand fromCmd = new OleDbCommand(balancetransferFromQuery, connection);
                    fromCmd.Parameters.AddWithValue("@newSavingBalance", newSavingBalance);

                    fromCmd.Parameters.AddWithValue("@cardNum", cardNum);

                    connection.Open();


                    try
                    {
                        int rowAffected = fromCmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Transfer Successful. Your New Saving Balance is: " + newSavingBalance.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Transfer Failed");
                            transferFromComboBox.SelectedIndex = 0;
                            depositTransferAmountTextBox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    connection.Close();

                }


                transferFromComboBox.SelectedIndex = 0;
                depositTransferAmountTextBox.Clear();

            }
            // If transferring from checking account to saving account
            else if (transferFromComboBox.Text == "Checking Account To Saving Account")
            {
                decimal amountToTransfer = ValidatingAmount();
                decimal checkingBalance = checkCheckingBalance();
                decimal newCheckingBalance = checkingBalance -amountToTransfer ;
                decimal savingBalance = checkSavingBalance();
                decimal newSavingBalance = savingBalance + amountToTransfer;

                // If checking balance is less than the amount to transfer, show insufficient funds message
                if (checkingBalance < amountToTransfer)
                {
                    MessageBox.Show("Insufficient Funds");
                    transferFromComboBox.SelectedIndex = 0;
                    depositTransferAmountTextBox.Clear();
                }
                else
                {
                    // Update checking account balance in database
                    string balancetransferToQuery = "Update ATMUsers set CheckingAccount =@newCheckingBalance where CardNumber =@cardNum";
                    OleDbCommand toCmd = new OleDbCommand(balancetransferToQuery, connection);
                    toCmd.Parameters.AddWithValue("@newCheckingBalance", newCheckingBalance);

                    toCmd.Parameters.AddWithValue("@cardNum", cardNum);

                    connection.Open();

                    try
                    {
                        int rowAffected = toCmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Transfer Successful. Your New Checking Balance is: " + newCheckingBalance.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Transfer Failed");
                            transferFromComboBox.SelectedIndex = 0;
                            depositTransferAmountTextBox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    connection.Close();

                    string balancetransferFromQuery = "Update ATMUsers set SavingAccount =@newSavingBalance where CardNumber =@cardNum";
                    OleDbCommand fromCmd = new OleDbCommand(balancetransferFromQuery, connection);
                    fromCmd.Parameters.AddWithValue("@newSavingBalance", newSavingBalance);

                    fromCmd.Parameters.AddWithValue("@cardNum", cardNum);

                    connection.Open();


                    try
                    {
                        int rowAffected = fromCmd.ExecuteNonQuery();
                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Transfer Successful. Your New Saving Balance is: " + newSavingBalance.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Transfer Failed");
                            transferFromComboBox.SelectedIndex = 0;
                            depositTransferAmountTextBox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                    connection.Close();

                }

                transferFromComboBox.SelectedIndex = 0;
                depositTransferAmountTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Transfer From : Invalid Selection");

                transferFromComboBox.SelectedIndex = 0;
                depositTransferAmountTextBox.Clear();
            }

        }
    }
}
