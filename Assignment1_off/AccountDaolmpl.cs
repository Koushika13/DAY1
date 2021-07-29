using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Assignment1_off
{
    class AccountDaolmpl :DAO
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source = DESKTOP-IM16U2B; Initial Catalog = assignment; Integrated Security = true");
            con.Open();
            return con;
        }
        void DAO.addAnAccount(Account account)
        {
            con = GetConnection();
            /*Console.WriteLine("Enter account number");
           int @acnumber= Convert.ToInt32(Console.ReadLine());
           double @acbalance = Convert.ToDouble(Console.ReadLine());
            string @password = Console.ReadLine();
            string @bname = Console.ReadLine();*/

            cmd = new SqlCommand("insert into Account(accountNo,accountBalance,accountPassword,bankName) values (@acnumber,@acbalance,@password,@bname)",con);
            cmd.Parameters.AddWithValue("acnumber", account.accountNo);
            cmd.Parameters.AddWithValue("acbalance", account.accountBalance);
            cmd.Parameters.AddWithValue("password", account.accountPassword);
            cmd.Parameters.AddWithValue("bname", account.bankName);


            int j = cmd.ExecuteNonQuery(); //returns int
            Console.WriteLine("No of Rows Affected :{0}", j); 


        }


        void DAO.withdraw(int accountNumber, double amount)
        {
            con = GetConnection();
            
            
            cmd = new SqlCommand("update Account set accountBalance=accountBalance-@amount where accountNo=@accountNumber", con);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@accountNumber", accountNumber);

            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("No of rows updated is {0}", i);

        }

        void DAO.checkBalance()
        {
            
            Console.WriteLine("Enter the account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            con = GetConnection();
            SqlDataReader dr;
            cmd = new SqlCommand("select accountBalance from Account where accountNo=@acno",con);
            cmd.Parameters.AddWithValue("acno", accountNumber);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["accountBalance"]);
            }


        }

        void DAO.changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            con = GetConnection();

            cmd = new SqlCommand("update Account set accountPassword=@newPassword where accountNo=@accountNumber",con);
            cmd.Parameters.AddWithValue("@newPassword", newPassword);
            cmd.Parameters.AddWithValue("@accountNumber", accountNumber);

            int k = cmd.ExecuteNonQuery();
            Console.WriteLine("No of rows updated is {0}", k);

        }

        List<Account> DAO.viewAllAccounts()
        {
            List<Account> accounts = new List<Account>(); 
            con = GetConnection();
            SqlDataReader dr;

            cmd = new SqlCommand("select * from Account", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                accounts.Add(new Account((int)dr[0], (double)dr[1], (string)dr[2], (string)dr[3]));
            }

          

            return accounts;
            
        }

        void DAO.getAccountDetails(int accountNumber)
        {

            con = GetConnection();
            SqlDataReader dr;

            cmd = new SqlCommand("select * from Account where accountNo=@accountNumber", con);
            cmd.Parameters.AddWithValue("@accountNumber", accountNumber);

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);
            }



        }

        static void Main()
        {
            DAO details1 = new AccountDaolmpl();
            //details1.addAnAccount(new Account(12348, 70000.15, "nish", "Andhra"));
            //details1.withdraw(12345, 1000);
            //details1.changePassword(12347, "deeps", "deepika");
            //details1.getAccountDetails(12348);
            //details1.checkBalance();
            //details1.viewAllAccounts();
            foreach(var acc in details1.viewAllAccounts())
            {
                Console.WriteLine("Account Number: {0} || Account Balance: {1} || Account password: {2} || Bank Name: {3}", acc.accountNo, acc.accountBalance, acc.accountPassword, acc.bankName);
            }
        }
    }
}
