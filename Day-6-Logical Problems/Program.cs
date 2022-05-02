// See https://aka.ms/new-console-template for more information


using Day_6_Logical_Problems;

Console.WriteLine("---- Welcome To Prime NO Test ----\n");
    
Console.Write("Enter the number to check waeather it is Perime or not:- ");
int n = int.Parse(Console.ReadLine());
FindPrimeNo obj = new FindPrimeNo();
obj.FindPrime(n);


