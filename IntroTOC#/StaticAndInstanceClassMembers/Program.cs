namespace StaticAndInstanceClassMembers
{
    class Circle
    {
    //  float pi = 3.141f;
        //static float pi = 3.141f;
         public static float pi = 3.141f;
        int _Radius;
        static Circle()
        {
            //by default it is private
            //static constructor
            //why i need this ?
            //to initialize static field
            Circle.pi = 3.1416f;
            Console.WriteLine("Static Constructor Called");

        }
        public Circle(int radius)
        {
            Console.WriteLine("Instance constructor called");
            this._Radius = radius;
        }
        public static void print()
        {
            //
        }
        public float CalculateAreaMethod() 
        {

            //return this.pi*this._Radius*this._Radius;
            return Circle.pi*this._Radius*this._Radius;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Circle c = new Circle(5);
            //float Area1 =c.CalculateAreaMethod();
            //Console.WriteLine("Area1: {0}",Area1);
            //Circle c2 = new Circle(6);
            //float Area2 =c2.CalculateAreaMethod();
            //Console.WriteLine("Area2: {0}",Area2);
            //Circle.print();
            Console.WriteLine(Circle.pi);
        }
    }
}
//some note :
//when a class member includes a static modifier, the member is called as static member
//when no static modifirer is present the member is called as non-static member or instance member
//Static members are invoker using class name, where as instance members are invoked using instances (object) of the class.
//A instance member belongs to specific instance(object) of a class. If I create 3 objects of a class I will have 3 sets of instance members in the memory where as there will ever be only one copy of a static member, no matter how many instance of a class are created
//**Class member -- fields, methods, properties, events, indexers, constructors
//static Constructor:Static Constructor are used to initialize static fields in a class
//you declare a static constructor by using the keyword static in front of the constructor 
//Static constructor is called only once no matter how many instances you create
//Static Constructor are called before instance constructors
