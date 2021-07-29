using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_off
{
    interface DAO
    {
        void addAnAccount(Account account);
        void withdraw(int accountNumber, double amount);
        void checkBalance();
        void changePassword(int accountNumber, string oldPassword, string newPassword);
        List<Account> viewAllAccounts();
        void getAccountDetails(int accountNumber);

    }

    class InMemoryAccountDaolmpl : DAO
    {
        void DAO.addAnAccount(Account account)
        {

            Console.WriteLine(account.accountNo + " " + account.accountBalance + " " + account.accountPassword + " " + account.bankName);

        }

        void DAO.withdraw(int accountNumber, double amount)
        {

            Console.WriteLine(amount + "Withdrawn from account" + accountNumber);
            double balance = Convert.ToDouble(Console.ReadLine());
            double remainingBalance = balance - amount;
            Console.WriteLine("Current balance is: {0}", remainingBalance);

        }

        void DAO.checkBalance()
        {
            Account account = new Account(23876593,6000.15,"koushi","ICICI");
            Console.WriteLine("Balance is: {0}",account.accountBalance);


        }

        void DAO.changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            Account account = new Account();
            account.accountPassword = newPassword;
            Console.WriteLine(account.accountNo + " " + account.accountBalance + " " + account.accountPassword + " " + account.bankName);
        }

        List<Account> DAO.viewAllAccounts()
        {

            Console.WriteLine("Number of accounts");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            List<Account> accounts = new List<Account>();

            for(int i=0; i < n; i++)
            {
                Console.WriteLine("Enter the account details");
                Console.WriteLine("Enter the account number");
                int acnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the account balance");
                double acbalance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the account password");
                string password = Console.ReadLine();
                Console.WriteLine("Enter the bank name");
                string bname = Console.ReadLine();

                accounts.Add(new Account(acnumber, acbalance, password, bname));
                /*foreach(var ac in accounts)
                {
                    Console.WriteLine(acnumber + " " + acbalance + " " + password + " " + bname);
                }*/

            }

            return accounts;
             

        }

        void DAO.getAccountDetails(int accountNumber)
        {
            Console.WriteLine("Enter the account balance");
            double acbalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the account password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter the bank name");
            string bname = Console.ReadLine();

            Console.WriteLine(accountNumber + " " + acbalance + " " + password + " " + bname);


        }

        static void Main()
        {
            DAO details = new InMemoryAccountDaolmpl();
            details.addAnAccount(new Account(732327, 70000.15, "nish", "Andhra"));
            details.withdraw(732327, 5000);
            details.checkBalance();
            details.changePassword(732327, "nish", "koush");
            details.viewAllAccounts();
            details.getAccountDetails(732327);
        }
    }
}
