using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_13_RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "XX";
            Solution s1 = new Solution();
            Console.Write(s1.RomanToInt(input));
            var a = Console.ReadKey();
        }
    }
    public class Solution
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            if (s.Length == 0)
                return 0;
            int s1 = SingleChar(s[0]);
            if (s.Length == 1)
                return s1;
            int s2 = SingleChar(s[1]);
            if (s1 >= s2)
            {
                result = s1 + RomanToInt(s.Substring(1));
            }
            else
            {
                result = s2 - s1 + RomanToInt(s.Substring(2));
            }
            if (result >= 5000)
                result = 0;
            return result;
        }
        public int SingleChar(char c)
        {
            switch (c) {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }

        }
    }
}
