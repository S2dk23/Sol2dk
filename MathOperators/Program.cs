// See https://aka.ms/new-console-template for more information

//Basic Assignment Operator
using System;

int num = 3;

// Arithmetic Operator
int num1 = 23;
int num2 = 24;
int num3 =30;

Console.WriteLine($"Addition: {num1 + num3}");
Console.WriteLine($"Subtraction: {num3 - num2}");
Console.WriteLine($"Division: {num3 / num1}");
Console.WriteLine($"Multiplication: {num2 * num1}");
Console.WriteLine($"Modulos: {num3 % num1}");

num1 += 5;//Compound Assignment Operator
Console.WriteLine("New value of num1: " + num1);
Console.WriteLine($"Subtraction: {num3 - num2}");
Console.WriteLine($"Division: {num3 / num1}");
Console.WriteLine($"Multiplication: {num2 * num1}");
Console.WriteLine($"Modulos: {num3 % num1}");


