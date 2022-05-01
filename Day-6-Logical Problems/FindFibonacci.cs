using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class FindFibonacci
    {
        public int n1 = 0;
        public int n2 = 1;


        public void  FindFibo()
        {
            int i,n3;
            for(i=1;i<=10;i++)
            {
                n3 = n1 + n2;
                Console.Write(n3);
                if(i >0 && i<10)
                {
                    Console.Write(",");
                }
                n1 = n2;
                n2 = n3;
            }
            
        }
    }
}
