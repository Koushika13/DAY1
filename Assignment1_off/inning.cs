using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_off
{
    class inning
    {
        public void totalruns()
        {
            int sum=0,count0=0,count1=0,count2=0,count3=0,count4=0,count6=0;
            double strikerate;
            int run;
            var rand = new Random();
            int[] runs = new int[30];
            for(int i = 0; i < 30; i++)
            {
                runs[i] = rand.Next(0, 7);
                Console.WriteLine(runs[i]);
            }

            for(int j=0; j < 30; j++)
            {
                sum = sum + runs[j];
                
            }
            Console.WriteLine("Total runs:{0}", sum);

            for(int i=0;i<30;i++)
            {
                run = runs[i];
                if (run == 0)
                {
                    count0=count0 + 1;                    
                }

                else if (run == 1)
                {
                    count1 = count1 + 1;
                    
                }
                else if (run == 2)
                {
                    count2 = count2 + 1;
                    
                }
                else if (run == 3)
                {
                    count3 = count3 + 1;
                    
                }
                else if (run == 4)
                {
                    count4 = count4 + 1;
                    
                }
                else if (run == 6)
                {
                    count6 = count6 + 1;
                    
                }
            }
            Console.WriteLine("0s :{0}", count0);
            Console.WriteLine("1s :{0}", count1);
            Console.WriteLine("2s :{0}", count2);
            Console.WriteLine("3s:{0}", count3);
            Console.WriteLine("4s:{0}", count4);
            Console.WriteLine("6s:{0}", count6);

            strikerate = sum / 30;
            Console.WriteLine("Strike Rate:{0}", strikerate);


        }

        public void fiveinnings()
        {
            double avgstrikerate;
            int totsum = 0, totcount0 = 0, totcount1 = 0, totcount2 = 0, totcount3 = 0, totcount4 = 0, totcount6 = 0;
            double totstrikerate=0;
            int[] runs = new int[30];
            int run;
            var rand = new Random();
            double avgscore;
            double[] strikerate = new double[5];
            int[] count0 = new int[5];
            int[] count1 = new int[5];
            int[] count2 = new int[5];
            int[] count3 = new int[5];
            int[] count4 = new int[5];
            int[] count6 = new int[5];
            int[] sum = new int[5];
            for (int i = 0; i < 5; i++)
            {
                for (int h = 0; h < 30; h++)
                {
                    runs[h] = rand.Next(0, 7);
                    //Console.WriteLine(runs[i]);
                }

                for (int j = 0; j < 30; j++)
                {
                    sum[i] = sum[i] + runs[j];

                }
                //Console.WriteLine("Total runs:{0}", sum);

                for (int k = 0; k < 30; k++)
                {
                    run = runs[k];
                    if (run == 0)
                    {
                        count0[i] = count0[i] + 1;
                    }

                    else if (run == 1)
                    {
                        count1[i] = count1[i] + 1;

                    }
                    else if (run == 2)
                    {
                        count2[i] = count2[i] + 1;

                    }
                    else if (run == 3)
                    {
                        count3[i] = count3[i] + 1;

                    }
                    else if (run == 4)
                    {
                        count4[i] = count4[i] + 1;

                    }
                    else if (run == 6)
                    {
                        count6[i] = count6[i] + 1;

                    }
                }
                /*Console.WriteLine("0s :{0}", count0);
                Console.WriteLine("1s :{0}", count1);
                Console.WriteLine("2s :{0}", count2);
                Console.WriteLine("3s:{0}", count3);
                Console.WriteLine("4s:{0}", count4);
                Console.WriteLine("6s:{0}", count6);*/

                strikerate[i] = sum[i] / 30;
                //Console.WriteLine("Strike Rate:{0}", strikerate);
            }

            for(int i = 0; i < 5; i++)
            {
                totsum = totsum + sum[i];
                totcount0 = totcount0 + count0[i];
                totcount1 = totcount1 + count1[i];
                totcount2 = totcount2 + count2[i];
                totcount3 = totcount3 + count3[i];
                totcount4 = totcount4 + count4[i];
                totcount6 = totcount6 + count6[i];
                totstrikerate = totstrikerate + strikerate[i];

            }
            Console.WriteLine("total runs:{0}", totsum);
            avgscore = totsum / 5;
            Console.WriteLine("avg score is:{0}", avgscore);
            avgstrikerate = totstrikerate / 5;
            Console.WriteLine("average strike rate:{0}",avgstrikerate);
            Console.WriteLine("0s :{0}", totcount0);
            Console.WriteLine("1s :{0}", totcount1);
            Console.WriteLine("2s :{0}", totcount2);
            Console.WriteLine("3s:{0}", totcount3);
            Console.WriteLine("4s:{0}", totcount4);
            Console.WriteLine("6s:{0}", totcount6);
            

        }

      
      

        static void Main()
        {
            inning innings = new inning();
            //innings.totalruns();
            innings.fiveinnings();

            
            

        }
        




        

    }
}
