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
            string firstName = "^[A-z]{1}[a-z]{2,}$";
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
            string lastName = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name is matching with Regex");
            }
            else
            {
                Console.WriteLine("Last name is not matching with Regex");
            }
        }
    }
}
                
