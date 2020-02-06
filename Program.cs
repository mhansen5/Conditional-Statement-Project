using System;

namespace Conditional_Statement_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type any number minus the % sign");
            int m;

            while (!int.TryParse(Console.ReadLine(), out m ))
            {
                Console.WriteLine("You must enter a number only!");
            }
            

            if (m >= 98 && m <= 100)
            {
                Console.WriteLine("A+");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 92 && m <= 97)
            {
                Console.WriteLine("A");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 90 && m <= 91)
            {
                Console.WriteLine("A-");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 88 && m <= 89)
            {
                Console.WriteLine("B+");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 82 && m <= 87)
            {
                Console.WriteLine("B");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 80 && m <= 81)
            {
                Console.WriteLine("B-");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 78 && m <= 79) 
            {
                Console.WriteLine("C+");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 72 && m <= 77)
            {
                Console.WriteLine("C");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 70 && m <= 71)
            {
                Console.WriteLine("C-");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 68 && m <= 69)
            {
                Console.WriteLine("D+");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 62 && m <= 67)
            {
                Console.WriteLine("D");
                Console.WriteLine("You typed:" + m);
            }
            else if (m >= 60 && m <= 61)
            {
                Console.WriteLine("D-");
                Console.WriteLine("You typed:" + m);
            }
            else if (m < 60)
            {
                Console.WriteLine("F");
                Console.WriteLine("You typed:" + m);
            }
        }
    }
}
