using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class Reverse
    {     
        public static int FindReverse(int number)
        {
            int actualNumb = number;
            int reverse=0, remainder=0;
            while(number>0)
            {
                remainder = number % 10; //4 3 2 1
                reverse = (reverse * 10) + remainder; //4 43 432 4321
                number = number / 10;
            }
            Console.WriteLine("reverse number is:"+reverse);
            Palindrome.FindPalindrome(actualNumb, reverse);
            return reverse;
        }
    }
}
