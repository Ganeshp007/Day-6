using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class FindPrimeNo
    {
        public void  FindPrime(int n)
        {
            int i,flag=0;

            if (n==0)
            {
                Console.WriteLine("\nPLease Enter a Valid No...");
            }
            else if(n==1)
            {
                Console.WriteLine("\nResult:- " + n + " is nor prime nor composite no...");

            }
            else
            {
                for(i=2;i<n/2;i++)
                {
                    if(n%i==0)
                    {   
                        flag=1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("\nResult:- " + n + " is Prime no");
                }
                else
                    Console.WriteLine("\nResult:- " + n + " is Composite no");
            }


        }
    }
}
