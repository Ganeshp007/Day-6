using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class FindCouponNo
    {
        public void  FindCouponNumber()
        {
            int couponStart, couponEnd, TotalCoupons;
            //Get range for coupon from user
            Console.WriteLine("Enter start range of coupon number");
            couponStart = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter End range of coupon number");
            couponEnd = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            Console.Write("How many Coupons do you want to generate:- ");
            TotalCoupons = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= TotalCoupons; i++)
            {
                int randomNumber = random.Next(couponStart, couponEnd);
                List<int> number = new List<int>();
                number.Add(randomNumber);
                List<int> distinct = number.Distinct().ToList();
                foreach (int j in distinct)
                {
                    Console.WriteLine(" Distinct coupon nummber " + i + " is :- " + j);
                }

            }

        }
    }
}
