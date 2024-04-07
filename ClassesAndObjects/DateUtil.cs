using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects;

internal static class DateUtil
{
    public static int YearOfBirth(int age)
    {
        return DateTime.Now.Year - age;
    }

    public static int YearOfBirth(DateTime dateofbirth)
    {
        if (dateofbirth == null)
            return 0;
        return dateofbirth.Year;

    }
}