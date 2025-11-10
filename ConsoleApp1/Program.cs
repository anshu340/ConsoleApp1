namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operators operators = new Operators();
            Console.WriteLine("add:" + operators.add(4, 4));
            Console.WriteLine("Subtract:"+operators.Subtract(4, 5));
            Console.WriteLine("Multiply:" +operators.Multiply(4, 5));
            Console.WriteLine("Divide:" +operators.Divide(4, 5));
            operators.OddEven(7);
            operators.Input(20);
            operators.Day(8);
            operators.Sum(5);
            operators.PrintNumbers();
            int[] numbers = { 10, 20, 30, 40 };
            operators.ArraySum(numbers);
            operators.ConvertToInt("123");
            operators.ConvertToInt("abc");
            operators.ValidatePassword("hi");  
            operators.ValidatePassword("hello123");

            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullChecks();
            nullOps.CheckWithNullCoalescing();
            //{
            //    string userName = "Anshu Karki";
            //    int luckyNumber = 5;
            //    string a = string.Format("hello, {0}! your lucker number is {1}.", userName, luckyNumber);
            //    Console.WriteLine(a);
            //}
        }
    }
}
