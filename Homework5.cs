namespace Homework5;

using System;

class Program
{
    // Q1: Method to return the largest of two numbers
    static int GetMax(int a, int b)
    {
        return a > b ? a : b;
    }

    static int RunGetMaxForTwo(out int a, out int b)
    {
        Console.Write("Enter the first number (a): ");
        a = int.TryParse(Console.ReadLine(), out int tempA) ? tempA : 0;

        Console.Write("Enter the second number (b): ");
        b = int.TryParse(Console.ReadLine(), out int tempB) ? tempB : 0;

        int largest = GetMax(a, b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largest}");
        return largest;
    }
    // Q2: Method to return the largest of the next two numbers 
    static int RunGetMaxForTwoMore(out int c, out int d)
    {
        Console.Write("Enter the third number (c): ");
        c = int.TryParse(Console.ReadLine(), out int tempC) ? tempC : 0;

        Console.Write("Enter the fourth number (d): ");
        d = int.TryParse(Console.ReadLine(), out int tempD) ? tempD : 0;

        int largest = GetMax(c, d);
        Console.WriteLine($"c = {c}; d = {d}");
        Console.WriteLine($"The largest number is: {largest}");
        return largest;
    }
    // Q3 - Bonus Question account creation
    static bool checkAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age >= 18;
    }

    static void CreateAccount()
    {
        Console.Write("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Your Password: ");
        string password = Console.ReadLine();

        Console.Write("Enter Your Password Again: ");
        string passwordAgain = Console.ReadLine();

        Console.Write("Enter Your Birthyear: ");
        int birthYear = int.TryParse(Console.ReadLine(), out int tempYear) ? tempYear : 0;

        if (checkAge(birthYear))
        {
            if (password == passwordAgain)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
    // Final Outputs
    static void Main()
    {
        Console.WriteLine("Find the largest of two numbers");
        int largestFromFirstTwo = RunGetMaxForTwo(out int a, out int b);

        Console.WriteLine("\nFind the largest of another two numbers");
        int largestFromSecondTwo = RunGetMaxForTwoMore(out int c, out int d);

        int largestOverall = GetMax(largestFromFirstTwo, largestFromSecondTwo); // To get the largest of Q1 & Q2 numbers and display in 4 digit output
        Console.WriteLine($"\na = {a}; b = {b}; c = {c}; d = {d}");
        Console.WriteLine($"The largest number of all is: {largestOverall}");

        Console.WriteLine("\nCreate an account");
        CreateAccount();
    }
}