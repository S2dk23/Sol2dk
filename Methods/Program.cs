// See https://aka.ms/new-console-template for more information

// Prototype - defines the function (type, name and parameters)
// Definition - has the code. it contains the code block
// Function Call - 
// DRY - dont repeat yoursef


// Void function - complete a task and move along
using System;

void Addition(int num1, int num2)
{
    Console.WriteLine($"The Sum of {num1} and {num2} is {num1 + num2}");
}

// Value Returning Functions - complete a task, return result
int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if(largest < num2)
    {
        largest = num2;
    }
    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}
Console.WriteLine("enter first number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Addition(number1, number2);
//Console.WriteLine("enter second number 3: ");
//int number3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"The Largest Number is: {LargestNumber(number1, number2, number3)}");