using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Problems
{
    internal class FindFibonacci
    {
       
        
        public void  FindFibo(int n1,int n2,int num)
        {    

            int i,n3;
            for(i=1;i<=num-2;i++)
            {
                n3 = n1 + n2;
                Console.Write(n3);
                if(i >0 && i<num-2)
                {
                    Console.Write(",");
                }
                n1 = n2;
                n2 = n3;
            }
            
        }
    }
}
