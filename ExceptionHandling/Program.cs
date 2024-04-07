// See https://aka.ms/new-console-template for more information


/*
  try - a try blocks attemps an operation
    catch - catch any fatal error or exception
    finally - whether the try or the catch was successful, do this
    throw - end program execution with the error
*/


Console.WriteLine("Enter first number: "); int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: "); int num2 = Convert.ToInt32(Console.ReadLine());
try
{
    int qoutient = num1 / num2;
    Console.WriteLine("Result is: " + qoutient.ToString());
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"illegal operation: {ex.Message}");
}
catch (Exception ex)
{
    throw ex; 
}
finally
{
    Console.WriteLine("This is the finally block");
}



