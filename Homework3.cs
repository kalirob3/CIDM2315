namespace Homework3;

class Program
{
    static void Main(string[] args)
    
    {
        // Q1 - Code:
        Console.Write("Input an integer to check if it is prime: ");
        int num = int.Parse(Console.ReadLine());

        if (IsPrime(num))
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");
        }

        // Q2 - Code:
        Console.Write("Assign an int value to N for the pattern: ");
        string inputQ2 = Console.ReadLine();
        
        if (int.TryParse(inputQ2, out int N_Q2) && N_Q2 > 0)
        {
            for (int i = 0; i < N_Q2; i++)  // rows
            {
                for (int j = 0; j < N_Q2; j++)  // columns
                {
                    Console.Write("#");
                }
                Console.WriteLine();  // move to the next line after each row
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }

        // Q3 - Code:
        Console.Write("Assign an int value to N for the triangle pattern: ");
        string inputQ3 = Console.ReadLine();
        
        if (int.TryParse(inputQ3, out int N_Q3) && N_Q3 > 0)
        {
            for (int i = 0; i < N_Q3; i++)  // rows
            {
                for (int j = 0; j <= i; j++)  // columns
                {
                    Console.Write("*");
                }
                Console.WriteLine();  // move to the next line after each row
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }

        // Bonus:
        Console.Write("Assign an int value to N for the number pattern: ");
        string inputBonus = Console.ReadLine();

        if (int.TryParse(inputBonus, out int N_Bonus) && N_Bonus > 0)
        {
            for (int i = 1; i <= N_Bonus; i++)  // rows
            {
                for (int j = 1; j <= i; j++)  // columns
                {
                    Console.Write(i);
                }
                Console.WriteLine();  // move to the next line after each row
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }

    // Function to check if a number is prime for code 1
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= number - 1; i++)  // Checking from 2 to N-1
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        
        return true;
    }
}  



