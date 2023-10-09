// See https://aka.ms/new-console-template for more information
//While loop
Console.WriteLine("Please Enter Your target: ");
int UserTarget =int.Parse(Console.ReadLine());
int start = 0;//loop start
while(start <= UserTarget)//condition check
{
    Console.Write(start + " ");
    start = start + 2;//never ending loop or infinity loop 
}