// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//The structure of a method
// the difference between static and instance methods
//some knowledge about method
//method are also called as functions. these terms are used interchangeably
//Methods are extremely useful because they allow you to define your logic once and use it at many places
//Methods make the maintenance of your application easier
//structure of method
//[attributes]
// access-modifiers return type method-name (parameters)
//{
//method body
//}
// attribute and access modifiers  later
//Return type can be any valid date type or void
//method name can be any meaningfull name expect keyword

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // this is static method
            //Console.WriteLine("Hello World!");
            Program p = new Program();//method  invoke
            //p.EvenNumber();
            Program.EvenNumber(30);
            
            int k =p.add(10,50);
            Console.WriteLine("Sum: {0}", k);
        }
         public int add(int x, int y)
        {
            return x + y;

        }
        //public  static void EvenNumber()
        public  static void EvenNumber(int x)
        {
            //instant method
            int start = 0;
            while (start <= x)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}

