using System;

class Program
{
    static void Main()
    {
        double num1, num2, sum;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        sum = num1 + num2;
       

        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
   

        Console.ReadLine();
    }
}
