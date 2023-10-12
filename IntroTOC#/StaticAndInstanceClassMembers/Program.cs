namespace StaticAndInstanceClassMembers
{
    class Circle
    {
        float pi = 3.141f;
        int _Radius;
        public Circle(int radius)
        {
            this._Radius = radius;
        }
        public float CalculateAreaMethod() 
        {

            return this.pi*this._Radius*this._Radius;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Circle c = new Circle(5);
            float Area1 =c.CalculateAreaMethod();
            Console.WriteLine("Area1: {0}",Area1);
            Circle c2 = new Circle(6);
            float Area2 =c2.CalculateAreaMethod();
            Console.WriteLine("Area2: {0}",Area2);
        }
    }
}