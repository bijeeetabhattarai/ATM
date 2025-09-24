
/*
 * Extra Credit Project
 * 
 * Members*
 * Bijita Bhattarai
 * Hannet Hammond Mensah
 * Chibuikem Mark Emenyonu
 * 
 This is an ATM Machine Application.
User cannot register form the application, they must have a card number and pin saved to the database before performing any transactions.  The card number and pin number are a 4 number digits, cannot be more or less than that. Once the user is saved into database, they can now use the application.

It has total of 6 forms.
1st form: This is the atm machine, which verifies the user saved card number and pin in the database and allow further transactions.
2nd form: This is the transactions form, which allows users to select any transaction to perform. They options are.
     Balance Inquiry
     Cash Withdrawal
     Deposits
     Transfer
     Exit

3rd form: This is Balance Inquiry form which allows user to check their balance on Checking and Saving Account.
4th form: This is Withdrawal form which allows user to withdraw cash from either Checking or Saving Accounts.
5th form: This is deposit form, and it allows user to deposit Cash to either Checking or Saving Accounts.
6th form: This is transfer form from where user can transfer from either checking to saving or saving to checking.

All the transaction’s form allows user to either go back to the ATM machine or Back to the transaction Menu form.


Please Use 1234 as a card number and pin 3851 to use the application to see how it works

 */


using System;
using System.Data.OleDb;
using System.Data;



namespace ATM
{
    public partial class Form1 : Form
    {

        public static Form1 instance;
       
        public TextBox textboxCard;
        public TextBox textboxPin;
        //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\is345sp24\\Documents\\ATM.accdb");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ATM.accdb");



        public Form1()
        {
            InitializeComponent();
           instance = this;
            textboxCard = cardNumberTextBox;
            textboxPin = pinTextBox;

        }


        // Method to handle key press event for card number text box
        private void cardNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a digit and not a control key, ignore it
                e.Handled = true;
            }

            // Check if the length of the text after adding the new character exceeds 4
            if (cardNumberTextBox.Text.Length >= 4  && !char.IsControl(e.KeyChar))
            {
                // If it exceeds 4 characters and the pressed key is not a control key, ignore it
                e.Handled = true;
            }
            

        }

        // Method to handle key down event for card number text box
        private void cardNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                pinTextBox.Focus();
            }
        }

        // Method to handle key press event for pin text box
        private void pinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If the pressed key is not a digit and not a control key, ignore it
                e.Handled = true;
            }

            // Check if the length of the text after adding the new character exceeds 4
            if (pinTextBox.Text.Length >= 4 && !char.IsControl(e.KeyChar))
            {
                // If it exceeds 4 characters and the pressed key is not a control key, ignore it
                e.Handled = true;
            }
            
        }

        // Method to handle key down event for pin text box
        private void pinTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterButton.Focus();
            }

        }

        // Method to handle click event for enter button
        private void enterButton_Click(object sender, EventArgs e)
        {
            // Declare variables to store card number and pin
            int atmCardNo = 0;
            int pinNumber = 0;

            // SQL query to check if the card number exists in the database
            string cardCheckQuery = "Select * from ATMUsers where [CardNumber] =@cardNum";
            OleDbCommand cmd  = new OleDbCommand(cardCheckQuery, connection);

            // Add parameter for card number to the command
            cmd.Parameters.AddWithValue("@cardNum", cardNumberTextBox.Text);
            try
            {
                // Open the database connection
                connection.Open();

                // Execute the SQL command to check if the card number exists
                OleDbDataReader cardReader = cmd.ExecuteReader();
                if (cardReader.HasRows)
                {
                    // If the card number exists in the database, read the data
                    while (cardReader.Read())
                    {
                        // Parse the ATM card number from the database
                        int.TryParse(cardReader[2].ToString(), out atmCardNo);
                        
                    }

                    // SQL query to check if the combination of card number and pin exists in the database
                    String query = "Select * from ATMUsers where [CardNumber] =@cardNum AND [PinNumber] =@pinNum";
                    OleDbCommand command = new OleDbCommand(query, connection);

                    // Add parameters for card number and pin to the command
                    command.Parameters.AddWithValue("@cardNum", cardNumberTextBox.Text);
                    command.Parameters.AddWithValue("@pinNum", pinTextBox.Text);

                    connection.Close();

                    try
                    {
                        // Open a new connection
                        connection.Open();

                        OleDbDataReader pinReader = command.ExecuteReader();

                        if (pinReader.HasRows)
                        {
                            // If the combination exists, read the data
                            while (pinReader.Read())
                            {
                                // Access data from the current row using reader["ColumnName"] or reader[index]
                                int.TryParse(pinReader[2].ToString(), out atmCardNo);

                                int.TryParse(pinReader[3].ToString(), out pinNumber);

                            }

                            int enteredPin;
                            int.TryParse(pinTextBox.Text, out enteredPin);

                            int enteredCardNum;
                            int.TryParse(cardNumberTextBox.Text, out enteredCardNum);

                            // Check if the entered pin and card number match the ones in the database
                            if (pinNumber == enteredPin && atmCardNo == enteredCardNum)
                            {
                                // If they match, show a success message and open the transaction form
                                MessageBox.Show("Loading Transaction panel", "Verification Complete");
                                TransactionForm transactionFrom = new TransactionForm();
                                transactionFrom.ShowDialog();
                               
                            }
                        }
                        else
                        {
                            // If the pin is invalid, show an error message and clear the pin textbox
                            MessageBox.Show("Invalid Pin Number");
                            pinTextBox.Clear();
                            pinTextBox.Focus();
                            return;
                        }
                        // Close the pin reader and the connection
                        pinReader.Close();
                        connection.Close();
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    // If the card number is invalid, show an error message and clear the card number textbox
                    MessageBox.Show("Invalid Card Number");
                    cardNumberTextBox.Clear();
                    cardNumberTextBox.Focus();

                    return;
                }
                // Close the card reader
                cardReader.Close();
              

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }


        // Method to handle click event for clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the textbox
            pinTextBox.Clear();
            cardNumberTextBox.Clear();
            // Focus the card textbox
            cardNumberTextBox.Focus();

        }

        // Method to handle click event for cancel button
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Exit the application
            this.Close();
        }
    }
}