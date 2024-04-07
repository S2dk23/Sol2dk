// See https://aka.ms/new-console-template for more information

//primitive datatypes: int, string, char, bool
//Object Oriented Programming - creating your own datatype
//Class - blueprint
//Single Responsibility Principle
class Person
{
    //Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Fields
    private double _salary { get; set; }  

    public void setSalary(double salary)
    {
        _salary = salary;
    }

    public double getSalary()
    {
        return _salary;
    }

    public string getFullname()
    {
        return $"{FirstName} {LastName}";
    }

    public string getFullname(string middlename)
    {
        return $"{FirstName} {middlename} {LastName}";
    }



}