using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class CoupenNumber
    {
        public static int[] distCouponNum = new int[4] { 2,15,25,38 };
        public static Random random = new Random();
        public static int[] randomCount = new int[4];
        public static int totaCount = 0, i = 0;
        public static void CheckCouponNumbers()
        {
            foreach (var coupon in distCouponNum)
            {
                while (coupon != random.Next(0, 40))
                {
                    randomCount[i]++;
                    totaCount++;
                }
                Console.WriteLine("Random numbers generated to get " + coupon + " are: " + randomCount[i]);
                i++;
            }
            Console.WriteLine("Total random numbers generated to get all distinct numbers :" + totaCount);
        }
    }
}