using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class FindPerfectNo
    {
        public void  FindPerfect(int n)
        {
            int i,check=0;
            for(i=1;i<n;i++)
            {
                int result = n % i;
                if (result == 0 )
                {
                    Console.Write(i);
                    check += i;
                   
                }
                else
                    continue;
            }


            if (check == n)
            {
                Console.WriteLine("Result:- " + n + " is Perfect no");
            }
            else
            {
                Console.WriteLine("Result:- " + n + " is not Perfect no");

            }


        }
    }
}
