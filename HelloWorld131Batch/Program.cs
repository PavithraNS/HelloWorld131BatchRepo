using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RFP-131Batch");
            //Console.WriteLine();
            //Console.WriteLine("Making changes from remote master");
            //Console.WriteLine("creating conflict from local");
            //Console.WriteLine("Creating conflict from remote");
            //className variable=new className();
            Human human = new Human();
            human.Speek();
            Console.Clear();
            Console.WriteLine("Enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine()); //1234
            //SwapNumbers.SwapTwoNumbers();
            int res=Reverse.FindReverse(number);
            //Palindrome.FindPalindrome(number, res);
            Console.ReadLine();
        }
    }
}
