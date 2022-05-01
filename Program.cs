using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Fibonacci  \n 2. PerfectNumber \n 3. PrimeNumber \n 4. ReverseNumber \n 5. Stopwatch  \n 6. CoupenNumber \n 7. Exit");
                
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Fibonacci series = new Fibonacci();
                        series.Fibo();
                        break;
                    case 2:
                        PerfectNumber obj = new PerfectNumber();
                        obj.Perfect();
                        break;
                    case 3:
                        PrimeNumber Number = new PrimeNumber();
                        Number.Prime();
                        break;
                    case 4:
                        ReverseNumber number = new ReverseNumber();
                        number.Reverse();
                        break;
                   
                    
                    case 5:
                        StopwatchTime.Elapsed();
                       // Console.ReadLine();
                        break;

                    case 6:
                        CoupenNumber.CheckCouponNumbers();
                        Console.ReadLine();
                        break;

                    case 7:
                        flag = false;
                        
                        break;
                }
            }
        }
    }
}
