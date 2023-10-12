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
/*using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            this is static method
            Console.WriteLine("Hello World!");
            Program p = new Program();//method  invoke
            p.EvenNumber();
            Program.EvenNumber(30);

            int k = p.add(10, 50);
            Console.WriteLine("Sum: {0}", k);
        }
        public int add(int x, int y)
        {
            return x + y;

        }
        public static void EvenNumber()
        public static void EvenNumber(int x)
        {
            instant method
            int start = 0;
            while (start <= x)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
//static vs instance methods
//When a method declaration includes a static modifier that method is said to be a static method.
//When no static modifier is present the modifier is said to be an instance method
//Static Method is involved using the class name where as an instance method is involved using an instance of the class
// the difference between instance method and static methods is that multiple instances of a class can be created (or instantiated ) and each instance has its own separate method, However, when a method is static . there are no instances of that method and you can invole only the one defination of the static method
*/
//Console.WriteLine("Hello World");
//Difference type of method(4 type of method parameters)
//1. Value Parameters: Create a copy of the parameter passed so modification does not affect each other
//2. Reference Parameters: The ref method parameter causes a method to refer to the same variable that was passed into the method. Any changes made to the parameter in the method will be reflected in that variable when control passes back to calling method
//3. Out Parameters: Use when you want a method to return more than one value.
//4. Parameter array: "params" keyword lets you specify method parameter that takes a variable number of arguments. You can send a comma-separated list of arguments or an array or n
// Method parameters vs Method Arguments
//using System;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//internal class Program
//{
//public static void Main(string[] args)
//{
//int i= 0;
//simpleMethod(i); //i and j are pointing to different memory locations. Operations one variable will not affected the value of other  variable
//simpleMethod(ref i);// I and J are pointing same memory location operations one variable will affect the value of the other variable
//  Console.WriteLine(i);


//}
//public static void simpleMethod( int j)
//public static void simpleMethod( ref int j)
//{
//   j = 101;
// Console.WriteLine(j);
//int Total = 0;
//int product = 0;
//Calculate(20, 10,out Total, out product);
//Console.WriteLine("Sum = {0} && Product = {1}",Total, product);

//}
//public static void Calculate(int fn, int sn, out int sum, out int product)
//{
//    sum=fn+sn;
//      product = fn*sn;
//    }
//  }
//}
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] Numbers = new int[3];
            Numbers[0] = 101;
            Numbers[1] = 102;
            Numbers[2] = 103;
            ParamsMethod(1, 2, 3, 4, 5, 6);
            //ParamsMethod(Numbers);
        }
        public static void ParamsMethod(params int[] number)
        {
            Console.WriteLine("There are {0} elements",number.Length);
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//method parameter vs Method Argument

//Important key words
//var
//dynamic
//param //last parameter 
//ref
//for each
//static
//out
//<> generic