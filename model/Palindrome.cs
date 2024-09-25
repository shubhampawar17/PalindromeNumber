using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber.model
{
    internal class Palindrome
    {
        public static bool IsPalindrome(int num)
        {
            int rev = 0, temp = num;

            while (num > 0)
            {
                int rem = num % 10;
                rev = (rev * 10) + rem;
                num /= 10;
            }
            return temp == rev;
        }
    }
}
