// See https://aka.ms/new-console-template for more information
//If statement
//Console.WriteLine("Enter A number:");
//int x = int.Parse(Console.ReadLine());
//if (x == 1)
//{
//  console.writeline("your number is one");
//}
//else if (x == 2)
//{
//  console.writeline("your number is one");
//}
//else if (x == 3)
//{
//  console.writeline("your number is one");
//}
//else if (x == 4)
//{
//  console.writeline("your number is one");
//}
//else
//if (x != 1 && x != 2)
//{
//  console.writeline("your number is not one ");
//}
//if else statement
//Difference between && and & ?
//single & will check all the expression 
// double && will check it will the check next condition
// Difference between || and |?
//swtich statement
//Console.WriteLine("Please enter a number: ");
//int UserName = int.Parse(Console.ReadLine());
//switch(UserName)
//{
//    case 10:
//      Console.WriteLine("Input 10");
//    break;
//case 20: Console.WriteLine("Input 20");
//  break;
//case 30:
//  Console.WriteLine("Input 20");
// break;
//default: Console.WriteLine("Wrong input");
//  break
//case 10:
//case 20:
//case 30:
//  Console.WriteLine("Your number is {0}",UserName); break;   
//default: Console.WriteLine("Your number is not 10 or 20 or 20");
//  break;
//;
//}
//break
// go to statement

int TotalCoffeeCost = 0;
Start://level 
Console.WriteLine("Please select Your Coffee Size:" +
    " 1 - Small ,2 - Medium, 3 - Large");
int UserChoice = int.Parse(Console.ReadLine());
switch(UserChoice)
{
    case 1:
        TotalCoffeeCost += 1; break;
    case 2:
        TotalCoffeeCost += 2; break;
    case 3:
        TotalCoffeeCost += 3; break;
    default:
        Console.WriteLine("Your Choice {0} is invalid", UserChoice);
        goto Start;//break;//
}
Decide:
Console.WriteLine("Do you want to buy another coffee - Yes or No");
string UserDecision = Console.ReadLine();
switch(UserDecision.ToUpper())
{
    case "YES":
        goto Start;//to jump another statement// it should be avoided (bad programming) make program more complex
    case "NO":
        break;
    default:
        Console.WriteLine("Your Choice {0} is invalid. Please try again...",UserDecision);
        goto Decide;
}
Console.WriteLine("Thank you for shopping with us");
Console.WriteLine("Bill amount= {0}",TotalCoffeeCost);

