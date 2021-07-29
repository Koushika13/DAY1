using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_off
{
    class Account
    {
        internal int accountNo { get; set; }
        internal double accountBalance { get; set; }
        internal string accountPassword { get; set; }
        internal string bankName { get; set; }

       internal Account()
        {
            bankName = "Andhra Bank";
        }

        internal Account(int accountNo, double accountBalance, string accountPassword, string bankName)
        {
            this.accountNo = accountNo;
            this.accountBalance = accountBalance;
            this.accountPassword = accountPassword;
            this.bankName = bankName;
        }

        public virtual void displayAccount()
        {
            Console.WriteLine("Account number:{0} || Account balance:{1} || Account password:{2} || Bank Name:{3}",accountNo, accountBalance, accountPassword, bankName);
            

        }

        //abstract public void Withdraw(int amount);


        static void Main()
        {
            //Account account1 = new Account(1,545.12,"kOUSHIKA","icici");
            //account1.displayAccount();

            /*SavingsAccount savingsAccount = new SavingsAccount(1, 545.12, "kOUSHIKA", "icici", 200.13);
            savingsAccount.displayAccount();
            savingsAccount.Withdraw(50);


            CurrentAccount currentAccount = new CurrentAccount(1, 545.12, "kOUSHIKA", "icici", 300);
            currentAccount.displayAccount();
            currentAccount.Withdraw(100);*/




        }

    }

    class SavingsAccount :Account
    {
        internal double minimumBalance { get; set; }

        internal SavingsAccount(int accountNo, double accountBalance, string accountPassword, string bankName, double minimumBalance) : base(accountNo, accountBalance, accountPassword, bankName)
        {
            this.minimumBalance = minimumBalance;
        }

       /* public override void Withdraw(int amount)
        {
            try {

                if (base.accountBalance < amount)
                {
                    throw new InsufficientFundException("You have insufficient funds");
                }

                else {
                    double balance;
                    balance = base.accountBalance - amount;
                    Console.WriteLine("Account balance is :{0}", balance);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                Console.WriteLine("Transaction done");
            }
        }*/

        public override void displayAccount()
        {
            base.displayAccount();
            Console.WriteLine("Minimum Balance:{0}", minimumBalance);
        }
    }

    class CurrentAccount :Account
    {
       internal double overdraftLimitAmount { get; set; }

        internal CurrentAccount(int accountNo, double accountBalance, string accountPassword, string bankName, double overdraftLimitAmount):base(accountNo, accountBalance, accountPassword, bankName)
        {
            this.overdraftLimitAmount = overdraftLimitAmount;
        }

        /*public override void Withdraw(int amount)
        {

            double overdraftbal;
            overdraftbal = base.accountBalance - amount;
            Console.WriteLine("Account balance is :{0}", overdraftbal);
        }*/
        public override void displayAccount()
        {
            base.displayAccount();
            Console.WriteLine("Over draft limit Ammount:{0}", overdraftLimitAmount);
        }
    }
 
}
