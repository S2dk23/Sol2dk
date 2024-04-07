// See https://aka.ms/new-console-template for more information

//Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

//Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1996, 04, 23);
Console.WriteLine($" My date of birth is : {dateOfBirth}");

//Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"The time now is : {now}");

// Create a DateTime from string
DateTime datefromString = DateTime.Parse("5/23/1765", CultureInfo.InvariantCulture);
Console.WriteLine($"The date from string is: {datefromString}");

// Add Additional Time
now.AddHours(67);
Console.WriteLine($"SIXTY SEVEN HOURS FROM NOW IS: {now.AddHours(67)}");

//  Ticks from DateTime 
Console.WriteLine($"Time as a numeral: {now.Ticks}");

// Date only
DateOnly dateonlyofbirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine($"Date only: {dateonlyofbirth}");

// Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine($"Time only: {timeOnly}");
