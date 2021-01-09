using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool resultOne = LenghtPassCheck(password);
            bool resultTwo = PassCheckIsDigitIsLetter(password);
            bool resultThree = PassCheckIsTwoDigits(password);
            if (resultOne && resultTwo && resultThree)
            {
                Console.WriteLine("Password is valid");
            }
            if (!resultOne)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!resultTwo)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!resultThree)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        static bool LenghtPassCheck(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool PassCheckIsDigitIsLetter(string password)
        {
            return password.All(c => Char.IsLetterOrDigit(c));
        }
        static bool PassCheckIsTwoDigits(string password)
        {
            return password.Count(Char.IsDigit) >= 2;
            //int count = 0;
            //foreach (char c in password)
            //{
            //    if (char.IsDigit(c))
            //    {
            //        count++;
            //    }
            //}

            //if (count >= 2)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}