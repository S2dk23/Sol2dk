// See https://aka.ms/new-console-template for more information

//Varible declarations and Types
using System;

string FullName = string.Empty;
int age = 0;
double Salary = 0;
char gender = char.MinValue;
bool working;

Console.Write("Please enter your Name: ");
FullName = Console.ReadLine();

Console.Write("Please enter your Age: "); 
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your Salary: ");
Salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Gender (Abo tabi Ako): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (True or False): ");
working = Convert.ToBoolean(Console.ReadLine());

//Print Information
Console.WriteLine("Your Name is: " + FullName);//concatenation
Console.WriteLine("Your Age is: {0} ", age);
Console.WriteLine($"Your Salary is: N{Salary}");//interpolation
Console.WriteLine($"Your Gender is: {gender}");//interpolation
Console.WriteLine($"You are Employed: {working}");//interpolation