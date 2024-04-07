// See https://aka.ms/new-console-template for more information


using ClassesAndObjects;
using System;
using System.Transactions;

Person person = new();
string middlename = string.Empty;   

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());
person.setSalary(salary);

Console.WriteLine("Enter Middle Name: ");
middlename = Console.ReadLine();

if (string.IsNullOrEmpty(middlename))
{
    Console.WriteLine("Full Name is: " + person.getFullname());
}
else
{
    Console.WriteLine("Full Name is: " + person.getFullname(middlename));
}
Console.WriteLine("Age is: " + person.Age);
Console.WriteLine("Year of birth is: " + DateUtil.YearOfBirth(person.Age));
Console.WriteLine("Salary is: " + person.getSalary());
