using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extention_Nullable_Enum_tasks.Helpers.BaseExtentions
{
    public static class Extention
    {
        public static bool CheckEmail(this string email, string pattern)
        {
            bool result = Regex.IsMatch(email, pattern);
            return result;

        }
        public static string GetFullName(this string name, string surname)
        {
            return name + " " + surname;
        }
        public static int? CalculateNumbers(this int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Input array cannot be null or empty.");
                return null;
            }

            int multiply = 1;
            foreach (int number in numbers)
            {
                multiply *= number;
            }
            return multiply;
        }

    }
}
