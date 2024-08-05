using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;

        Console.Write("Enter number 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 3: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        // Finding the Biggest
        if (num1 >= num2 && num1 >= num3)
        {
            Console.WriteLine(num1 + " is the biggest number!");
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            Console.WriteLine(num2 + " is the biggest number!");
        }
        else
        {
            Console.WriteLine(num3 + " is the biggest number!");
        }

        // Finding the Smallest
        if (num1 <= num2 && num1 <= num3)
        {
            Console.WriteLine(num1 + " is the smallest number!");
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            Console.WriteLine(num2 + " is the smallest number!");
        }
        else
        {
            Console.WriteLine(num3 + " is the smallest number!");
        }
    }
}