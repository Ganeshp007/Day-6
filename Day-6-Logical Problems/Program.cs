// See https://aka.ms/new-console-template for more information


using Day_6_Logical_Problems;
    
Console.Write("Enter the number to check waeather it is Perfect or not:- ");
int n = int.Parse(Console.ReadLine());
FindPerfectNo obj = new FindPerfectNo();
obj.FindPerfect(n);


