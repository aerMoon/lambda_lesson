using System;
delegate int Alpha(int n);
delegate void Bravo(string t);

namespace lambda_lesson
{
    class MyClass
    {
        public int number;
        public MyClass(int n)
        {
            number = n;
        }
        public Alpha Method;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass(100);
            MyClass b = new MyClass(200);

            //полю объекта значением присваивается лямбла выражение
            //---------------------------------------------------
            a.Method = n => a.number + n;
            b.Method = (int n) =>
            {
                return b.number - n;
            };
            //---------------------------------------------------
            int x = 80;
            Console.WriteLine($"a.Method {x} = {a.Method(x)}");
            a.number = 300;
            Console.WriteLine($"b.Method {x} = {b.Method(x)}");

            Bravo Show;
            //присваивание переменной лямбда выражения
            //---------------------------------------------------
            Show = t => Console.WriteLine($"текст: \"{t}\"");
            //---------------------------------------------------
            Show("Bravo");

            //присваивание переменной лямбда выражения
            //---------------------------------------------------
            Show = (string t) =>
            {
                for (int i = 0; i < t.Length; i++)
                {
                    Console.Write($"|{t[i]}");
                }
                Console.WriteLine("|");
            };
            //---------------------------------------------------
            Show("Bravo");
        }
    }
}
