namespace InheriatanceSolve
{
    //public class Employee
    //{
    //    public string firstName;
    //    public string lastName;
    //    public string Email;
    //    public void PrintFullName() 
    //    {
    //        //
    //        Console.WriteLine("Full Name:{0} {1}",firstName,lastName);
    //        Console.WriteLine("Email: {0}",Email);

    //    }
    //}
    //public class FulltimeEmployee:Employee
    //{
    //    public float YearlySalary;
    //}
    //public class ParttimeEmployee:Employee
    //{
    //    public float HourlySalary;
    //}
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent Class constructor");
        }
        public ParentClass(string msg) 
        {
            Console.WriteLine(msg);
        }
    }
    public class ChildClass:ParentClass
    {
        public ChildClass():base("Derived class controlling Parent Class")
        {
            Console.WriteLine("Child Class constructor called");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //FulltimeEmployee e = new FulltimeEmployee();
            //e.firstName = "Joydep";
            //e.lastName = "Dhar";
            //e.YearlySalary = 100000;
            //e.Email = "joydep.dhar@gmail.com";
            //e.PrintFullName();
            //ParttimeEmployee parttime = new ParttimeEmployee();
            //parttime.firstName = "Joy";
            //parttime.lastName = "Dep";
            //parttime.Email = "Joy@gmail.com";
            //parttime.HourlySalary = 20;
            //parttime.PrintFullName();
            //Console.WriteLine("Hello World");
            ChildClass x= new ChildClass();
            //ChildClass y= new ChildClass();
        }
    }
}
//note:
//In this example Derived class inherits from parentClass
//C# supports only single class inheritance
//C# support multiple interface inheritance
//child class is a specialization of base class
//base classes are automatically instantiated before derived classes
//parent class constructor executes before child class constructor 