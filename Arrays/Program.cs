// See https://aka.ms/new-console-template for more information


// Declare fixed size array
int[] grades = new int[6];
// 6 spaces of addresses - 0, 1, 2, 3, 4, 5
//if n is the size of the array, then your array has addresses btw 0 to n-1

// Add values to fixed size array
//grades[0] = 45;
//grades[1] = 22;
//grades[2] = 53;
//grades[3] = 43;
//grades[4] = 51;
//grades[5] = 16;

//grades = new int[] { 45, 22, 53, 43, 51, 16 };

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("ENTER ALL GRADES: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
//Print values in fixed size array
Console.WriteLine("THE GRADES YOU ENTERED ARE");
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine(grades[i]);
}

// Declare variable sized array
// Add values to variable sizex array
// Print values in variable sized array