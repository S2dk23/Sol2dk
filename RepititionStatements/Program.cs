// See https://aka.ms/new-console-template for more information

// For loop(Counter Controlled)
for (int i = 0; i < 88; i++)
{
    console.writeline("i am in a loop");
    console.writeline();
    console.writeline();
    console.writeline($"counter value: {i}");
}
console.writeline();
console.writeline("for loop finished");
//while loop(condition controlled - pre check)

int n = 0;
while (n < 5)
{
    console.writeline("input a number: ");
    n = convert.toint32(console.readline());
    console.writeline($"you entered {n}: ");
}

console.writeline();
console.writeline("while loop finished");

//do ...while loop(condition controlled - post check)
int n = 0;
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}: ");
} while( n < 5);

