using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool IsOdd(int n)
        {
            if(n % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int n)
        {
            if(n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for(int i = 2; i < n; i++)
            {
                return false;
            }
            return true;
        }
        //input: Float x
        //output: int a that is smallest but not smaller than x
        //idea: a =(int) x then a = a + 1
        //if x is negative then a is unchanged
       public static int Ceil(float x)
        {
            int a = (int) x;
            if (x > 0)
                if (x > a)
                    a = a + 1;
            return a;

        }
        // Input: float x
        // Output: int a that is largest but not larger than x
        // Idea: a = (Int) x 
        // If x is negative then a = a-1
        // if x == a then is unchange
        public static int Floor(float x)
        {
            int a = (int)x;
            if (x < 0 && x != a)
                a = a - 1;
            return a;
        }


    }
}
