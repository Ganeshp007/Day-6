using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class FindReverseNo
    {
        public void  FindReverse(int n)
        {
            int i, remainder, ReverseNo = 0;
            int temp = n;
            while(temp != 0)
            {
                remainder = temp % 10;
                ReverseNo = (ReverseNo * 10) + remainder;
                temp = temp / 10;
            }

            Console.WriteLine("Result:- Reversed Number = " +ReverseNo);   

        }
    }
}
