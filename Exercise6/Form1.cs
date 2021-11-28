using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author David Piatt
 * Date 4/10/21
 * Comments: I hope this week's code is much better quality than last week's.
 * I am still stuck thinking in Java but am feeling more comfortable in C#
 * I'd like some feedback on best practices in terms of how I have used getters and setters,
 * specifically if I'm being redundant, and if I'm using the right nomenclature (_name). 
 * This was a fun lab, thank you for your feedback and time. 
 */

namespace Exercise6
{
    public partial class Form1 : Form
    {
        //Hard code the account number and starting balance
        //Initialize a new bank account with those figures. 
        const int AccountNumber = 000302019;
        const decimal StartingBalance = 1362.59M;
        BankAccount BA = new BankAccount(AccountNumber, StartingBalance);

        public Form1()
        {
            InitializeComponent();
            //Set account number and balance from the bank account class.
            AccountNumberTextBox.Text = BA.getAccountNumber().ToString();
            AccountBalanceTextBox.Text = String.Format("{0:C2}", BA.GetAccountBalance());
        }

        private void transactionAmountTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        //Validate the data entered. If it is valid then perform withdrawal 
        //or deposit and update account value and transaction status.
        private void submit_Click(object sender, EventArgs e)
        {
            //Validate data:
            string amount = TransactionAmountTextbox.Text;
            decimal zero = 0M;
            Boolean IsInputValid = false;

            if (String.IsNullOrEmpty(amount))
            {
                MessageBox.Show("The inputs on this form cannot be empty.", "Input Left Empty");
            }
            else if (!Decimal.TryParse(amount, out zero))
            {
                MessageBox.Show("This input's value must be a valid decimal.", "Invalid Data Entered");
            }
            else
            {
                IsInputValid = true;
            }
            if (IsInputValid) { 
            //Determine if deposit or withdrawal 
            if (DepositRadioButton.Checked)
            {
                BA.Deposit(Decimal.Parse(TransactionAmountTextbox.Text));
                AccountBalanceTextBox.Text = String.Format("{0:C2}", BA.GetAccountBalance());
            }
            else if (WithdrawalRadioButton.Checked)
            {
                BA.Withdrawal(Decimal.Parse(TransactionAmountTextbox.Text));
                AccountBalanceTextBox.Text = String.Format("{0:C2}", BA.GetAccountBalance());
            }
            TransactionAmountTextbox.Text = "";

            //Now set the transaction status:
            BankAccount.StatusEnum tempStatus = BA.GetAccountStatus();

            string status = "Transaction Successful";

            if (tempStatus == BankAccount.StatusEnum.Overdrawn)
            {
                status = "Your account is overdrawn. Please make a deposit.";
            }
            else if (tempStatus == BankAccount.StatusEnum.InsufficientFunds)
            {
                status = "Your account has insufficient funds for this transaction.";
            }
            else if (tempStatus == BankAccount.StatusEnum.DepositTooLarge)
            {
                status = "The transaction amount is too large and cannot be submitted.";
            }
            TransactionStatusTextBox.Text = status;
        }
        }

        //GetHistory_Click iterates backwards over the transaction history so that it shows 
        //The most recent transactions first.
        //It appends all of the formatted values to a string then sets the text box equal to the string. 
        private void getHistory_Click(object sender, EventArgs e)
        {
            string history = "";
            List<decimal> trxns = BA.GetTransactions();
            for(int i = trxns.Count-1; i>=0; i--)
            {
                history += String.Format("{0:C2}", trxns[i]);
                history += "\r\n";
            }
            
            AccountHistoryTextBox.Text = history;
        }

        private void getStatus_Click(object sender, EventArgs e)
        {
            BankAccount.StatusEnum tempStatus = BA.GetAccountStatus();

            string status = "";

            if (tempStatus == BankAccount.StatusEnum.Overdrawn || tempStatus == BankAccount.StatusEnum.InsufficientFunds)
            {
                status = "Your account is overdrawn. Please make a deposit.";
            }
            
            else 
            {
                status = "Your account is in good standing!";
            }
            MessageBox.Show(status);
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
