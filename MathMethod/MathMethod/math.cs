using System;

namespace MathMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int addTotal = 0;
            int minusTotal = 0;
            int multTotal = 0;
            int divideTotal = 0;
            int modulusRemainder = 0; //modulus returns the remainder

            Console.WriteLine("Enter a random number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another random number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            addTotal = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {addTotal}");
            
            minusTotal = Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = {minusTotal}");

            multTotal = Multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = {multTotal}");

            divideTotal = Divide(num1, num2);
            Console.WriteLine($"{num1} / {num2} = {divideTotal}");

            modulusRemainder = Modulus(num1, num2);
            Console.WriteLine($"{num1} / {num2} has a remainder of {modulusRemainder}");

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
