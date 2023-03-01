using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problems
{
    public class RegexProblem
    {
        public void ValidFirstName(string name)
        {
            string firstName = "^[A - Z][a - z]{ 3,}?";
            if (Regex.IsMatch(name, firstName))
            {
                Console.WriteLine("First name is matching with Regex");
            }
            else
            {
                Console.WriteLine("First name is not matching with Regex");
            }
        }
        public void ValidLastName(string name)
        {
            string lastName = "^[A - Z][a - z]{ 3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name is matching with Regex");
            }
            else
            {
                Console.WriteLine("Last name is not matching with Regex");
            }
        }
        public void ValidateEmail(string email)
        {
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";

            if (Regex.IsMatch(email, emailID))
            {
                Console.WriteLine("Email ID is matching with Regex");
            }
            else
            {
                Console.WriteLine("Email ID is not matching with Regex");
            }
        }
        public void ValidatePhoneNumber(string phoneNumber)
        {
            string phoneNum = @"[0-9]{2}\s[0-9]{10}";
            if (Regex.IsMatch(phoneNumber, phoneNum))
            {
                Console.WriteLine("Phone Number is matching with Regex");
            }
            else
            {
                Console.WriteLine("Phone Number is not matching with Regex");
            }
        }
        public void ValidatePassword(string pswrd)
        {
            string password = @"[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(pswrd, password))
            {
                Console.WriteLine("password is matching with Regex");
            }
            else
            {
                Console.WriteLine("password is not matching with Regex");
            }
        }
        public void ValidateString(string password)
        {
            string name = @"(?=.*[A-Z])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch((string)password, name))
            {
                Console.WriteLine("It is matching with Regex");
            }
            else
            {
                Console.WriteLine("It is not matching with Regex");
            }
        }
        public void ValidateNumericPassword(string numpassword)
        {
            string password = "[a-zA-Z][0-9]{1,}";
            if (Regex.IsMatch(numpassword, password))
            {
                Console.WriteLine("Numeric password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Numeric password is not matching with Regex");
            }
        }
        public void ValidateSpecialCharacter(string character)
        {
            string spclChar = "[0-9a-z][!@#$%&*]{1}";
            if (Regex.IsMatch(character, spclChar))
            {
                Console.WriteLine("Special character is matching with Regex");
            }
            else
            {
                Console.WriteLine("Special character is not matching with Regex");
            }
        }
    }
}
                