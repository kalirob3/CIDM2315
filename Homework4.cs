namespace Homework4;

using System;

class Program
{
    // Q1: Method GetValidInteger to ask for two numbers and determine the largest
    static int GetValidInteger(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number)) return number;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
// Method GetValidShape to ask for triangle shape left of right 
    static string GetValidShape()
    {
        while (true)
        {
            Console.Write("Enter the triangle shape (left or right): ");
            string shape = Console.ReadLine()?.ToLower() ?? "";
            if (shape == "left" || shape == "right") return shape;
            Console.WriteLine("Invalid input. Please enter 'left' or 'right'.");
        }
    }

    // Q2: Method PrintTriangle to print a triangle based on N and shape selections
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine($"N: {N}, Shape: {shape}");
        bool isLeft = shape == "left";

        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(isLeft ? new string('*', i) : new string(' ', N - i) + new string('*', i));
        }
    }

    static void Main()
    {
        // Q1: Get user inputs with methods GetValidInteger and GetValidShape
        int a = GetValidInteger("Enter the first number: ");
        int b = GetValidInteger("Enter the second number: ");
        string shape = GetValidShape();

        // Q1: Determine the largest number and print the result
        int largest = Math.Max(a, b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largest}");

        // Q2: Use the largest number as N for the selected triangle shape
        PrintTriangle(largest, shape);
    }
}