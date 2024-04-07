﻿// See https://aka.ms/new-console-template for more information

//Declare
List<string> names = new List<string>();
string name = string.Empty;

// Add value to list
names.Add("Sodiq");

Console.WriteLine("Enter Names: ");
//while (name != "-1")
//while (name.Equals("-1") == false)

while (!name.Equals("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    if(!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}  

//Print values in list
Console.WriteLine("Printing names via For Loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine("printing names via foreach loop");
 foreach (string item in names)
{
    Console.WriteLine(item);
}