﻿using System;

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
            Console.ReadLine();
        }
    }
}
