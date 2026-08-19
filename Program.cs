using System;

class Program
{
    static void Main()
    {
    Char[] arr = new Char[] { '+', '/', '*', '-' };
    String num = Console.ReadLine();
    int index = num.IndexOfAny(arr);
    int a = int.Parse(num.Substring(0, index));
    int b = int.Parse(num.Substring(index + 1));
    if (num[index] == '+')
    {
        Console.WriteLine(a + b);
    }
    else if (num[index] == '-')
    {
        Console.WriteLine(a - b);
    }
    else if (num[index] == '*')
    {
        Console.WriteLine(a * b);
    }
    else if (num[index] == '/')
    {
        Console.WriteLine(a / b);
           
    }}}
