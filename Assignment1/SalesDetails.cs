using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SalesDetails
    {
        int Salesno { get; set; }
        int Productno { get; set; }
        int Price { get; set; }
        DateTime dateofsale { get; set; }
        int Qty { get; set; }
        int TotalAmount { get; set; }

        public SalesDetails(int Salesno,int Productno, int Price, DateTime dateofsale, int Qty)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.dateofsale = dateofsale;
            this.Qty = Qty;
            
        }
        public void TotalAmount1()
        {
            //Console.WriteLine("Enter the price");
            //Price = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the quantity");
            //Qty = Convert.ToInt32(Console.ReadLine());
            TotalAmount = Qty * Price;
            Console.WriteLine("Total Amount is:{0}", TotalAmount);

        }

        public void Display()
        {
            Console.WriteLine("Sno:{0} || Product number:{1} || Price:{2} || Date of sale:{3} || Quantity:{4}", Salesno, Productno, Price, dateofsale, Qty);
        }

        static void Main()
        {
            int Sno;
            int prodno;
            int quantity;
            DateTime dateofsale1;
            int pricee;
            //SalesDetails sale = new SalesDetails();
            int n;
            Console.WriteLine("Number of Sales");
            n = Convert.ToInt32(Console.ReadLine());
            SalesDetails[] sale1 = new SalesDetails[n];

            for (int i = 0; i < n; i++)
            {
                //constructor
                Console.WriteLine("Enter the Sales no");
                Sno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the product no");
                prodno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the quantity");
                quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price");
                pricee = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the date");
                dateofsale1 = DateTime.Parse(Console.ReadLine());
                sale1[i] = new SalesDetails(Sno,prodno,pricee, dateofsale1,quantity);
            }
            
            for(int i = 0; i < n; i++) 
            {
                sale1[i].TotalAmount1();
                sale1[i].Display();

            }
            
        }


    }
}
