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
    }
}
                