using System;
delegate char MyDelegate(int n);
namespace LambdaAsArgument
{
    class MyClass
    {
        public char symbol;
        public MyDelegate get;
        public MyClass(char s, MyDelegate md)
        {
            symbol=s;
            get=md;
        }
        public void set(MyDelegate md)
        {
            get=md;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание объекта (лямбда выражение в качестве аргумента)
            //---------------------------------------------------
            MyClass obj = new MyClass('K', n => (char)('A'+n));
            //---------------------------------------------------
            Console.WriteLine($"символ: \'{obj.get(3)}\'");

            //вызов метода, которому передано лямбда выражение
            //---------------------------------------------------
            obj.set(n => (char)(obj.symbol + n));
            //---------------------------------------------------
            Console.WriteLine($"символ: \'{obj.get(3)}\'");
        }
    }
}
