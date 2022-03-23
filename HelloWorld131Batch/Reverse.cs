using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class Reverse
    {
        public static int FindReverse()
        {
            int reverse=0, remainder=0;
            Console.WriteLine("Enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine()); //1234
            while(number>0)
            {
                remainder = number % 10; //4 3 2 1
                reverse = (reverse * 10) + remainder; //4 43 432 4321
                number = number / 10;
            }
            Console.WriteLine("reverse number is:"+reverse);
            return reverse;
        }
    }
}
