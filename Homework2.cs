namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1 // ran code through AI to see what I missed as kept getting errors. I mistyped Upper and my else ifs were incorrect. I was just using if - fixed. 
        Console.Write("Please input a letter grade: "); 
        string grade = Console.ReadLine().ToUpper(); // converts to uppercase so if you enter lowercase it still reads
        int gpaPoints;

        if (grade == "A")
        {
            gpaPoints = 4;
            Console.WriteLine("GPA point:" + gpaPoints);
        }
        else if (grade == "B")
        {
            gpaPoints = 3;
            Console.WriteLine("GPA point:" + gpaPoints);
        }
        else if (grade == "C")
        {
            gpaPoints = 2;
            Console.WriteLine("GPA point:" + gpaPoints);
        }
        else if (grade == "D")
        {
            gpaPoints = 1;
            Console.WriteLine("GPA point:" + gpaPoints);
        }
        else if (grade == "F")
        {
            gpaPoints = 0;
            Console.WriteLine("GPA point:" + gpaPoints);
        }
        else // if incorrect character entered, shows wrong letter output
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        {
        // code for Q2 // This one took me a bit. the if statements and <= values were tricky. 
        Console.Write("Please input the first number:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second number:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the third number:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
        }
        else 
        {
            smallest = num3;
        }
        Console.WriteLine("The smallest value is: " + smallest);

        }
        {
        //Code for Q3 

        Console.Write("Please input a year: ");
        int year = Convert.ToInt16(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
            else
        {
            Console.WriteLine($"{year} is not a Leap Year.");
        }        
        
        }
    }
}
