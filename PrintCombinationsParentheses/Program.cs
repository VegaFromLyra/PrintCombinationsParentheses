using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCombinationsParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine("Parentheses combinations with input {0}", n);

            HashSet<string> result = GetParentheses(3);

            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }

        // Time Complexity - O(n) ?
        // Space complexity - O(n) ?
        static HashSet<string> GetParentheses(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please provide a value greater than 0");
                return null;
            }

            HashSet<string> result = new HashSet<string>();

            if (n == 1)
            {
                result.Add("()");
                return result;
            }

            HashSet<string> patterns = GetParentheses(n - 1);

            foreach (string pattern in patterns)
            {
                string result1 = "(" + pattern + ")";
                string result2 = "()" + pattern;
                string result3 = pattern + "()";

                result.Add(result1);
                result.Add(result2);
                result.Add(result3);
            }

            return result;
        }
    }
}
