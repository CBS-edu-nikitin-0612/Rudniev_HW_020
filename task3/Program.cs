using System;

namespace task3
{
    class Program
    {
        public delegate int MyDel();
        public delegate double MyDelegate(MyDel[] myDels);
        static void Main(string[] args)
        {
            MyDelegate add = (MyDel[] myDels) =>
            {
                int temp = 0;
                for (int i = 0; i < myDels.Length; i++)
                    temp += myDels[i]();
                return temp;
            };
            Console.WriteLine("Hello World!");
        }
    }
}
