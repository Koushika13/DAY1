using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_off
{
    interface ATM
    {
       void Withdraw(int accountNumber, double Amount);
       void changePassword(int accountNumber, string oldPassword, string newPassword);
       void checkBalance();


    }

    class SbiAtm: ATM
    {
        void ATM.Withdraw(int accountNumber,double Amount)
        {
            double currentBalance;
            currentBalance = Convert.ToDouble(Console.ReadLine());
            double BalanceLeft = currentBalance - Amount;
            Console.WriteLine("Account Number:{0} || Balance:{1}", accountNumber, BalanceLeft);
        }

        void ATM.changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            string temp;
            temp = oldPassword;
            oldPassword = newPassword;
            newPassword = temp;
            Console.WriteLine("Password changed");
            Console.WriteLine("Current Password:{0}", oldPassword);
        }

        void ATM.checkBalance()
        {
            double Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Balance:{0}", Balance);
        }
    }

    class IciciAtm : ATM
    {
        void ATM.Withdraw(int accountNumber, double Amount)
        {
            try
            {
                if (Amount < 0)
                {
                    throw new InvalidAmountException("Amount should be greater than 1");
                }

                else
                {

                    double currentBalance;
                    currentBalance = Convert.ToDouble(Console.ReadLine());
                    double BalanceLeft = currentBalance - Amount;
                    Console.WriteLine("Account Number:{0} || Balance:{1}", accountNumber, BalanceLeft);

                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

        void ATM.changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            string temp;
            temp = oldPassword;
            oldPassword = newPassword;
            newPassword = temp;
            Console.WriteLine("Password changed");
            Console.WriteLine("Current Password:{0}", oldPassword);
        }

        void ATM.checkBalance()
        {
            double Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Balance:{0}", Balance);
        }

    }

    class ATMdetails
    {
        static void Main()
        {
            /*ATM sbi = new SbiAtm();
            sbi.Withdraw(625135598, 3000);
            sbi.changePassword(625135598, "koushi", "koushika");
            sbi.checkBalance();*/

            ATM icici = new IciciAtm();
            icici.Withdraw(38157872, -12);
            icici.changePassword(38157872, "hello", "hibye");
            icici.checkBalance();
            
        }
    }


}
