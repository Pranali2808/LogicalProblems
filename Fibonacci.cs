using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;

namespace LogicalProgram
{
    internal class Fibonacci
    {
        public void Fibo()
        {
            int first = 0, second = 1, third = 0;
            Console.WriteLine("Enter the number of series :");
            int series = Convert.ToInt32(Console.ReadLine());
            if (series <= 1)
            {
                Console.WriteLine(first);
                return;
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < series; i++)
            {
                third = first + second;
                first = second;
                second = third;
                Console.WriteLine(third);
            }
        }
    }
}








