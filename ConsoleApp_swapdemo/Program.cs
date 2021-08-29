using System;

namespace ConsoleApp_swapdemo
{

    class swap
    {
        public void Swapping(ref int x, ref int y)
        {
            int tempswap = x;
            x = y;
            y = tempswap;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 1st number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value of num1 and num2 before swapping : ");
            Console.WriteLine("num1 = " + " " + num1);
            Console.WriteLine("num2 = " + " " + num2);
            swap obj = new swap();
            obj.Swapping(ref num1, ref num2);
            Console.WriteLine("Value of num1 and num2 after swapping : ");
            Console.WriteLine("num1 = " + " " + num1);
            Console.Write("num2 = " + " " + num2);
            
        }
    }
}
