using System;

namespace CSharpBasics
{
    class Program
    {
        // Main function
        static void Main(string[] args)
        {
            // 1. Printing Hello World
            Console.WriteLine("Hello, World!"); // Using WriteLine
            Console.Write("Welcome to C# Basics."); // Using Write
            Console.WriteLine("\n");

            // 2. Variables and Data Types
            int age = 25; // Integer
            float height = 5.9f; // Float
            double weight = 72.5; // Double
            char grade = 'A'; // Character
            string name = "John Doe"; // String
            bool isStudent = true; // Boolean

            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Weight: {weight}, Grade: {grade}, Is Student: {isStudent}");

            // 3. Size of Data Types
            Console.WriteLine($"\nSize of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes\n");

            // 4. Typecasting
            double number = 5.67;
            float convertedFloat = (float)number; // Explicit casting
            Console.WriteLine($"Double: {number}, Converted to Float: {convertedFloat}");

            int num = 10;
            double autoConvert = num; // Implicit casting
            Console.WriteLine($"Int: {num}, Auto-Converted to Double: {autoConvert}");

            string strNumber = "123";
            int parsedInt = int.Parse(strNumber); // Using Parse Method
            Console.WriteLine($"String: {strNumber}, Parsed to Int: {parsedInt}\n");

            // 5. Taking User Input
            Console.Write("Enter your favorite color: ");
            string color = Console.ReadLine();
            Console.WriteLine($"Your favorite color is {color}.\n");

            // 6. Arithmetic Operators
            int a = 10, b = 3;
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Modulus: {a % b}\n");

            // 7. Assignment Operators
            int x = 5;
            x += 3; // x = x + 3
            Console.WriteLine($"After += operator, x = {x}");
            x *= 2; // x = x * 2
            Console.WriteLine($"After *= operator, x = {x}\n");

            // 8. Logical Operators
            bool cond1 = true, cond2 = false;
            Console.WriteLine($"cond1 && cond2: {cond1 && cond2}");
            Console.WriteLine($"cond1 || cond2: {cond1 || cond2}");
            Console.WriteLine($"!cond1: {!cond1}\n");

            // 9. Comparison Operators
            Console.WriteLine($"Is a > b? {a > b}");
            Console.WriteLine($"Is a < b? {a < b}");
            Console.WriteLine($"Is a == b? {a == b}\n");

            // 10. Math Class
            Console.WriteLine($"Square Root of 16: {Math.Sqrt(16)}");
            Console.WriteLine($"Absolute of -10: {Math.Abs(-10)}");
            Console.WriteLine($"Power: 2^3 = {Math.Pow(2, 3)}\n");

            // 11. String Methods
            string sample = "Hello C# World";
            Console.WriteLine($"Length of string: {sample.Length}");
            Console.WriteLine($"To Upper: {sample.ToUpper()}");
            Console.WriteLine($"Substring: {sample.Substring(6, 2)}\n");

            // 12. Escape Sequence Characters
            Console.WriteLine("This is a tab:\tTab Space");
            Console.WriteLine("This is a new line:\nNew Line\n");

            // 13. If-Else Statement
            if (age > 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }
            Console.WriteLine();

            // 14. Loops
            Console.WriteLine("For Loop Example:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            Console.WriteLine("\nWhile Loop Example:");
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine($"Count: {count}");
                count++;
            }
            Console.WriteLine();

            // 15. Methods
            Console.WriteLine("Calling Method:");
            PrintMessage("This is a custom method!");
            Console.WriteLine($"Sum of 5 and 10: {AddNumbers(5, 10)}\n");

            // 16. Object-Oriented Programming
            Person person = new Person("Alice", 22);
            person.DisplayInfo();
        }

        // Custom Method
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Method with Return Value
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    // OOP Example: Class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
