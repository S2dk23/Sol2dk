// See https://aka.ms/new-console-template for more information

string firstName = "Sodiq";
string lastName = "Adetayo";
DateTime date = DateTime.Now;

// Prin to screen
Console.WriteLine(firstName);
Console.WriteLine("string being printed");

//Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My Full Name is " + lastName + " " + firstName);
Console.WriteLine($"My Full Name is {lastName}, {firstName}");
Console.WriteLine("My Full Name is {0}, {1}", lastName, firstName);

// string length
int zet1= firstName.Length;
int zet2= lastName.Length;
Console.WriteLine($"Your name is {zet1 + zet2} letters long");


// Replace string parts
string newname = firstName.Replace("q", "k");
 Console.WriteLine($"Oruko tuntun ni {newname}");

// Append to other string variable  
string Fullname = firstName + " " + lastName;
Console.WriteLine($"Your full name is {Fullname}");

// Split string
string[] splitName = Fullname.Split('d');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullstring; null;
string emptystring = ""; //string.empty
string whitespacestring = " ";

// Compare strings
if (string.IsNullOrEmpty(nullstring))
{
    Console.WriteLine("String is null");
}
if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int Compresult = string.Compare(firstName, lastName);
if(Compresult == 0)
{
    Console.WriteLine("String is null");
}
else
{
    Console.WriteLine("Names are not equal");
}
// Convert to string
string convertedString = string.Empty;
int number = 54;

convertedString = number.ToString();
convertedString = 54.ToString();

