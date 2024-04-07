// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Diagnostics;

console.writeline("enter first number of apples: ");
int numberofapples = Convert.ToUInt32(Console.ReadLine());

console.writeline("enter second number of oranges: ");
int numberoforanges = Convert.ToInt32(Console.readline());

if statements(==, <, >, <=, >=, !=)
if (numberofapples > numberoforanges)
    {
        console.writeline("you have mor apples");
    }
    else if (numberofapples < numberoforanges)
    {
        console.writeline("you have more oranges");
    }
    else if (numberofapples == numberoforanges)
    {
        console.writeline("you have the same number of apple and oranges");
    }

Console.WriteLine("enter your grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

//Switch Statements

switch (grade)
{
    case int n when n >= 0 && n <= 59:
        Console.WriteLine("You failed");
        break;
    case int n when n >= 60 && n <= 100: //between 60 and 100

        Console.WriteLine("You passed");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}
//Ternary Operator
var message = numberOfApples > numberOfOranges ? "You have mor apples" : "You have more Oranges";