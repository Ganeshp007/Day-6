// See https://aka.ms/new-console-template for more information
using Day_6_Logical_Problems;

 int n1 = 0;
 int n2 = 1;

Console.WriteLine("How many number of Fibonacci series you want to print:- ");
int num=Convert.ToInt32(Console.ReadLine());
FindFibonacci obj = new FindFibonacci();
Console.Write("Fibonacci Series:- "+n1+","+n2+",");
obj.FindFibo(n1,n2,num);
Console.ReadKey();



