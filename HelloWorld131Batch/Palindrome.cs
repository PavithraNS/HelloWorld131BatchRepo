using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class Palindrome
    {
        public static void FindPalindrome(int inputNumb,int reverse)
        {
            // 1221  1221          
            if (reverse == inputNumb)
            {
                Console.WriteLine("Given number is palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
        }
    }
}
