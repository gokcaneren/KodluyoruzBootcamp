using System;

namespace MethodPratikleri
{
    class Program
    {
        static void Main(string[] args)
        {

            helloWorld();

            int num1 = 10;
            int num2 = 20;

            int resultAA = sum(num1, num2);
            Console.WriteLine(resultAA);

            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            var res = isPrime(num);

            if (!res)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime");
            }


        }


        static void helloWorld()
        {
            Console.WriteLine("Hello World!");
        }


        /// <summary>
        /// Sum Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int sum(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// This Method Will Check The Number is Prime or Not
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static bool isPrime(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i ==0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
