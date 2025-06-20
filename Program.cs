using System;
using System.IO;
namespace RecapCSharp
{
    internal class Program
    {
        // ---------------- Functions ----------------
        static int AddTwoNumbers(int a, int b) => a + b;
        static bool IsEven(int number) => number % 2 == 0;
        static void GreetUser(string name) => Console.WriteLine($"Welcome, {name}!");
        static double Max(double a, double b) => (a > b) ? a : b;
        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
        // ---------------- Loops ----------------
        static void PrintNumbers1to10()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);
        }
        static void PrintEven2to20()
        {
            int i = 2;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
        static void DoWhilePassword()
        {
            string input;
            do
            {
                Console.Write("Enter password: ");
                input = Console.ReadLine();
            } while (input != "admin");
        }
        // ---------------- Arrays ----------------
        static void ArrayFirstLast()
        {
            int[] arr = { 5, 10, 15, 20 };
            Console.WriteLine($"First: {arr[0]}, Last: {arr[arr.Length - 1]}");
        }
        static void MaxInArray()
        {
            int[] arr = { 2, 7, 5, 9, 3 };
            int max = arr[0];
            foreach (int num in arr)
                if (num > max) max = num;
            Console.WriteLine($"Max: {max}");
        }
        static void ReverseInputNames()
        {
            string[] names = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            Array.Reverse(names);
            foreach (string name in names) Console.WriteLine(name);
        }
        static void SumArray()
        {
            int[] arr = { 3, 6, 9, 12 };
            int sum = 0;
            foreach (int x in arr) sum += x;
            Console.WriteLine($"Sum: {sum}");
        }
        static void CountOddNumbers()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int count = 0;
            foreach (int x in arr)
                if (x % 2 != 0) count++;
            Console.WriteLine($"Odd numbers: {count}");
        }
        // ---------------- Exceptions ----------------
        static void FormatExceptionDemo()
        {
            try
            {
                Console.Write("Enter an integer: ");
                int x = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format!");
            }
        }
        static void DivideByZeroDemo()
        {
            try
            {
                int x = 10, y = 0;
                int z = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        static void FileExistsCheck()
        {
            try
            {
                string path = "data.txt";
                if (File.Exists(path))
                    Console.WriteLine("File exists.");
                else
                    Console.WriteLine("File does not exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TryCatchFinallyDemo()
        {
            try
            {
                int x = int.Parse("123a");
            }
            catch
            {
                Console.WriteLine("Caught error.");
            }
            finally
            {
                Console.WriteLine("Finished");
            }
        }
        static void ValidateInput()
        {
            try
            {
                Console.Write("Enter number: ");
                int n = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid number.");
            }
        }
        // ---------------- Main ----------------
        static void Main(string[] args)
        {
            Console.WriteLine("C# Exercises Started...");
            Console.WriteLine($"5 + 7 = {AddTwoNumbers(5, 7)}");
            Console.WriteLine($"Is 6 even? {IsEven(6)}");
            GreetUser("Mohammed");
            Console.WriteLine($"Max of 3.5 and 4.2 = {Max(3.5, 4.2)}");
            Console.WriteLine($"Factorial of 5 = {Factorial(5)}");
            PrintNumbers1to10();
            PrintEven2to20();
            // DoWhilePassword();
            ArrayFirstLast();
            MaxInArray();
            // ReverseInputNames();
            SumArray();
            // CountOddNumbers();
            FormatExceptionDemo();
            DivideByZeroDemo();
            FileExistsCheck();
            TryCatchFinallyDemo();
            ValidateInput();
            Console.WriteLine("Done.");
        }
    }
}
