using System;

namespace aditionalTask
{
    public delegate double MyDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = (int a, int b, int c) => (a + b + c) / 3;
            Console.WriteLine($"среднее арифметическое чисел 3, 5 и 7 = {myDelegate(3, 5, 7)}");
        }
    }
}
