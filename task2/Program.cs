using System;

namespace task2
{
    class Program
    {
        public delegate double MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            MyDelegate add = (int a, int b) => a + b;
            MyDelegate sub = (int a, int b) => a - b;
            MyDelegate mul = (int a, int b) => a * b;
            MyDelegate div = (int a, int b) => { if (b != 0) return a / b; else return 0; };

            Console.Write("Напишите простую арифметическую операцию (3 + 5): ");
            string[] item = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(item[0]);
            int b = Convert.ToInt32(item[2]);
            double result = (Convert.ToChar(item[1])) switch
            {
                '+' => add(a, b),
                '-' => sub(a, b),
                '*' => mul(a, b),
                '/' => div(a, b),
                _ => 0,
            };
            Console.WriteLine("Ответ: " +  result);
        }
    }
}
