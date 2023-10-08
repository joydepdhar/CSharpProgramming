// See https://aka.ms/new-console-template for more information
//Conversion:
//Implicit Conversions
int i = 100;
float f = i;// converting int to float; small to big no conversion
Console.WriteLine(f);
//Implicit conversion is done by the compiler:
// when there is no loss of information if the conversion is done
// if there is no possibility of throwing exceptions during the conversion

//Explicit Conversions
float x = 10.002f;
//int j = x;//possiblity if overflow data 
//Console.WriteLine(j);
//compiler will not autometric convert this
//conversion two type 1. type cast and 2. dot net frame work convert class
//1. Type cast:
int j = (int)x;// big number can be the problem because int has a limit it will print minimum number of integer;

Console.WriteLine(j);// here we lose fractional part
//convert class
int k = Convert.ToInt32(x);// convert class...for big number it will give expections overflow

Console.WriteLine(k);

//Difference between Parse() and TryPrase() nothing more than another way...
string strnumber = "123";
//int i = strnumber; error thorw
int a = int.Parse(strnumber);
Console.WriteLine(a);
string str = "123mj";
int b = 0; 
bool IsConvertionSuccessful= int.TryParse(strnumber,out b);
if (IsConvertionSuccessful)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Please enter valid number;");
}



