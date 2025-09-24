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
    public partial class TransactionForm : Form
    {
        public static TransactionForm instance;
        // OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\is345sp24\\Documents\\ATM.accdb");
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ATM.accdb");

        public TransactionForm()
        {
            InitializeComponent();
            instance = this;
           
        }


        // Method to close the TransactionForm instance
        public void CloseInstance()
        {
            this.Close();
           
        }

        // Method to handle click event for balance inquiry button
        private void balanceInqueryButton_Click(object sender, EventArgs e)
        {
            // Open BalanceInquiry form
            BalanceInquiry balanceInquiryform = new BalanceInquiry();
            balanceInquiryform.ShowDialog();
            
        }

        // Method to handle click event for cash withdrawal button
        private void cashwithdrawalButton_Click(object sender, EventArgs e)
        {
            // Open CashWithdrawal form
            CashWithdrawal cashWithdrawalForm = new CashWithdrawal();
            cashWithdrawalForm.ShowDialog();
        }

        // Method to handle click event for deposits button
        private void depositsButton_Click(object sender, EventArgs e)
        {
            // Open DepositForm form
            DepositForm depositForm = new DepositForm();
            depositForm.ShowDialog();
        }

        // Method to handle click event for transfer button
        private void transferButton_Click(object sender, EventArgs e)
        {
            // Open TransferForm form
            TransferForm transferForm  = new TransferForm();
            transferForm.ShowDialog();
        }

        // Method to handle click event for exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Clear card number and pin textboxes in Form1 instance
            Form1.instance.textboxCard.Clear();
            Form1.instance.textboxPin.Clear();
            
            // Focus on card number textbox in Form1 instance
            Form1.instance.textboxCard.Focus();
            
            // Close the TransactionForm instance
            this.Close();
        }
    }
}
