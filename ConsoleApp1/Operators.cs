using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Operators
    {
        //Task 1
        public int add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public void OddEven(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }

        //Task 3
        public void Input(int age)
        {
            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20)
            {
                Console.WriteLine("Adult");
            }
        }
        //Task 4
        public void Day(int day)
        {

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
        //Task 5
        public void Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum: {sum}");
        }

        public void PrintNumbers()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 15)
                {
                    break;
                }

                Console.WriteLine(i);
                i++;
            }
        }

        public void ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine($"Array Sum: {sum}");
        }

        //Task 6 
        public void ConvertToInt(string input)
        {
            try
            {
                int number = int.Parse(input);
                Console.WriteLine("Converted number: " + number);
            }
            catch
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        public void ValidatePassword(string password)
        {
            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }
                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
