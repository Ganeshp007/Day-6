// See https://aka.ms/new-console-template for more information


using Day_6_Logical_Problems;

Console.WriteLine("---- Welcome To Number Operations ----\n");
    
Console.Write("Enter the number to Reverse :- ");
int n = int.Parse(Console.ReadLine());
FindReverseNo obj = new FindReverseNo();
obj.FindReverse(n);


