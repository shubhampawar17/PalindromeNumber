using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber.model
{
    internal class Palindrome
    {
        public static bool IsPalindrome(int number)
        {
            int reverse = 0, temp = number;

            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return temp == reverse;
        }
    }
}
