using System;

namespace Regex_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
           RegexProblem regex = new RegexProblem();
            regex.ValidFirstName("Vaibhav");
            regex.ValidLastName("Mehta");
            regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            regex.ValidatePhoneNumber("91 1234567890");
            regex.ValidatePassword("Vaibhav123");
            regex.ValidateString("Vaibhav");
            regex.ValidateNumericPassword("Vaibhav1");
            regex.ValidateSpecialCharacter("Vaibhav@123");
            Console.ReadLine();
        }
    }
}
