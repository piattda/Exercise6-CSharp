using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{

    class BankAccount
    {

        //enums:
        public enum StatusEnum
        {
            Ok,
            Overdrawn,
            InsufficientFunds,
            DepositTooLarge
        }

        //List of type decimal of the transactions to display
        private List<decimal> transactions = new List<decimal>();
        private int _AccountNumber;
        private decimal _DepositMaximum = 10000M;
        //This shorthand feels awkward, 
        //I'm not sure if I'm using this right throughout my application. 
        //I'd appreciate any feedback pertaining to this.
        //Is it best practice to declare every private variable with _{variableName}?
        private decimal _AccountBalance { get; set; }
        private StatusEnum _Status;

        //constructor
        public BankAccount(int StartingAccountNumber, decimal StartingBalance)
        {
            //on init set the starting balance, account number, status, and add the first transaction.;
            _AccountBalance = StartingBalance;
            _AccountNumber = StartingAccountNumber;
            _Status = StatusEnum.Ok;
            transactions.Add(StartingBalance);
            
        }

        //Returns the private account number
        public int getAccountNumber()
        {
            return this._AccountNumber;
        }

        //Returns the private account balance
        public decimal GetAccountBalance()
        {
            return this._AccountBalance;
        }

        //Determine if transaction results in Ok or DepositTooLarge. 
        //Record in transaction log. 
        //Set account balance accordingly. 
        public StatusEnum Deposit(decimal dep)
        {
            //Accept the deposit if it is greater than 0 and less than the hard maximum+

            if(dep < this._DepositMaximum && dep > 0M)
            {
                this._AccountBalance += dep;
                transactions.Add(dep);
                this._Status = StatusEnum.Ok;
                return StatusEnum.Ok;
            }
            else
            {
                this._Status = StatusEnum.DepositTooLarge;
                return StatusEnum.DepositTooLarge;
            }
        }
       
        //Determine if withdrawal is ok, insufficient funds, or overdrawn
        //Set _AccountBalance accordingly
        //Record the transaciton
        //I know that wit is a stupid name
        public StatusEnum Withdrawal(decimal wit)
        {
            //Case where withdrawal brings acct < $0
            if(this._AccountBalance - wit < -100M)
            {
                this._Status = StatusEnum.InsufficientFunds;
                return StatusEnum.InsufficientFunds;

            } else if (this._AccountBalance - wit < 0M)
            {
                //The instructions do not say if we charge the overdraft fee every time or just once. 
                //I'm charging them every time. Hopefully this ATM will pay off my student loans. 
                this._AccountBalance = this._AccountBalance - wit - 35.75M;
                transactions.Add(wit);
                this._Status = StatusEnum.Overdrawn;
                return StatusEnum.Overdrawn;
            } else
            {
                this._AccountBalance = this._AccountBalance - wit;
                transactions.Add(wit);
                this._Status = StatusEnum.Ok;
                return StatusEnum.Ok;
            }
            
        }

        //Return the private account status.
        public StatusEnum GetAccountStatus()
        {
            return this._Status;
        }

        //Return the list of transactions. 
        public List<decimal> GetTransactions()
        {
            return this.transactions;
        }
     }



}
