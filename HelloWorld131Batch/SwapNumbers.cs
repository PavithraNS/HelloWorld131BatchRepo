using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class SwapNumbers
    {
        public static int first, second,temp=0;

        public static void SwapTwoNumbers()
        {
            Console.WriteLine("please enter first number");
            first=Convert.ToInt32(Console.ReadLine()); //"10"
            Console.WriteLine("please enter second number");
            second = Convert.ToInt32(Console.ReadLine()); //"20"

            Console.WriteLine("Before swap");
            Console.WriteLine("First:{0} Second:{1}", first,second);
            temp=first;// temp=10;
            first = second; //first=20;
            second = temp; //second=10;
            Console.WriteLine("After swapped");
            Console.WriteLine("First:{0} Second:{1}", first, second);
        }
    }
}
