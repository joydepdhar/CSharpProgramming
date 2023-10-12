namespace PathToClasses
{
    class Customer
    {
        string _firstName;
        string _lastName;
        public Customer() : this("No firstname","No lastName")
        {

        }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public Customer(string firstName , string lastName) 
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        public void PrintFullName()
        {
            Console.WriteLine("Full Name {0}",this._firstName+" "+this._lastName);
        }
        ~Customer()
        {
            //clean up code
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer x = new Customer("Joydep ","Dhar ");
           //Customer x = new Customer();//default parameter
            x.PrintFullName();
            Customer y = new Customer();
            y.PrintFullName();
        }
    }
}
//What is a class?
// a class consists of data and behavior class data is represented by it's fields and behavior is represented by its methods
//The purpose of a class contructor is to initialize class fields. A class contructor is automaticlly called when an instance of a class is created
//Constructor are not mandatory. if we donot provide a constructor, a default parameter less construtor is automatically provided
//Constructors can be overloaded by the numbers and type of parameters


