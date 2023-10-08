// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Assignment Operator --- (=)
//int i = 10;
//bool j = false;
//Arithmetic Operator ---(+,-,*,/,%)
//int x = 10;
//int y = 20;
//int addition = x + y;
//int sub = x - y;
//int multipication = x * y;
//int divition = x / y;
//float mod= x % y;
//Comparison Operator ---(==,!=,>,>=,<,<=)
//compere two number
//int a = 10;
//if (a==10) 
//{
//  Console.WriteLine("equal");
//}

//Conditional Operator = and(&&) or(||)
// two conditon 
//int number = 100;
//int number2 = 200;
//if(number==100 && number2==200)
//{
//  Console.WriteLine("And");
//}
// one condition 
//if(number==100 || number2==100)
//{
//  Console.WriteLine("Or");
//}
//-----------------------------------------------------------
//Ternary Operator --- ?:
//int num = 10;
//bool IsNumber10;
//if (num == 10)
//{
//  IsNumber10 = true;
//}
//else
//{
//  IsNumber10= false;
//}
//Console.WriteLine("Number == 10 is {0}", IsNumber10);
//
//bool IsNumber1= num == 10? true: false;
//Console.WriteLine("Number == 10 is {0}", IsNumber1);
//-----------------------------------------------------------
//Null Coalescing Operator --- ??
// nullable types in C#
//Null Coalescing Operator
//In the c# we can divide the value type and ref. type
//value type: int, float, double 
//reference type: interface , class , delegates, arrays
//By default reference type ---- null 
// By default  value type ---- some form of zero
//if you want to make value type nullable just add ? mark
// int i = null //not working
// int? i = null //working
//bool? AreYouMajor = true;
//if(AreYouMajor == true)
//{
  //  Console.WriteLine("User is Major");
//}
//else if(AreYouMajor.Value)
//{
  //  Console.WriteLine("User is not Major");
//}
//else
//{
  //  Console.WriteLine("User is did not answer the question");
//}
//Null Coalescing Operator;
int? TicketOnSale = 100;
int AvailableTickets = TicketOnSale??0;
//if(TicketOnSale != null)
//{
  //  AvailableTickets = 0;

//}
//else
//{
  //  AvailableTickets = (int)TicketOnSale;
//}
Console.WriteLine("AvailableTicket: {0}", AvailableTickets);







