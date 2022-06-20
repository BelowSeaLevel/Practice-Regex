using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Regular_Expression
{
    class Program
    {
        static void Main()
        {
            UseRegex();

            Console.ReadKey();
        }

        private static void UseRegex()
        {
            // These patterns tell us what kind of input we allow.

            // First pattern has to start with a number between 1-9, followed by 3 numbers between 0-9.
            // \s means space is allowed. And then 2 chars of a-z, caps doesnt matter.
            string pattern = @"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$";
            string patternSecond = @"^[a-zA-Z]\s?[0-4]{2}$";


            Console.WriteLine("Please input 4 numbers and 2 letters for Regex 1");
            Console.WriteLine("Or input 1 letter and 2 numbers between 0 and 4 for Regex 2");

            string input = Console.ReadLine();
            RegexOptions options = RegexOptions.Multiline;


            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
            }

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Your pattern matches: Regex 1");
            }
            else if (Regex.IsMatch(input, patternSecond))
            {
                Console.WriteLine("You made an input for the Second pattern");
            }
            else
            {
                Console.WriteLine("Your input doesnt match any Regex...");
            }
        }
    }
}
