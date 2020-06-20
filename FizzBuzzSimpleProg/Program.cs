using System;

namespace FizzBuzzSimpleProg
{
    class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz
            // https://open.kattis.com/problems/fizzbuzz 
            // (MOD function)


            var parameters = Enter3Nums();

            var x = parameters[0];
            var y = parameters[1];
            var myCount = parameters[2];
            for (int q = 1; q <= myCount; q++)
            {
                Console.WriteLine(FizzBuzzFunction(q, x, y));
            }
        }
        private static string FizzBuzzFunction(int num, int x, int y)
        {
            if ((num % x == 0) && (num % y == 0))
                return "FizzBuzz";
            else if (num % x == 0)
                return "Fizz";
            else if (num % y == 0)
                return "Buzz";
            else
                return num.ToString();
        }

        private static bool Test3Ints(int[] numbers)
        {
            // X, Y, N
            // 1 <= X < Y <= N <= 100

            int x = numbers[0];
            int y = numbers[1];
            int n = numbers[2];

            if (x >= 1 && y > x && n >= y && n <= 100)
                return true;
            else return false;
        }
        private static int[] Enter3Nums()
        {
            string[] arr = new string[3] { "", "", "" };
            int[] res = new int[3] { 0, 0, 0 };
            try
            {
                arr = Console.ReadLine().Split(' ', 3);
                for (int i = 0; i < arr.Length; i++)
                {
                    res[i] = int.Parse(arr[i]);
                }
                if (Test3Ints(res) == false)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enter3Nums();
            }
            return res;
        }
    }
}
