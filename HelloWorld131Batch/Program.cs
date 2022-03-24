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
            Console.WriteLine("1:Human\n2:SwapNumbers\n3:Reverse or palindrom\n4:UserReplace\n5:FlipCoin");
            int option = Convert.ToInt32(Console.ReadLine()); //"1"
            switch (option)
            {
                case 1:
                    // code block
                    Human human = new Human();
                    human.Speek();
                    break;
                case 2:
                    // code block
                    SwapNumbers.SwapTwoNumbers();
                    break;
                case 3:
                    // code block
                    Console.WriteLine("Enter number to reverse");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Reverse.FindReverse(number);
                    break;
                
                case 4:
                    // code block
                    UserReplace.ReplaceUserName();
                    break;
                case 5:
                    FlipCoin.FindFlipCoinCount();
                    break;
                default:
                    // code block
                    Console.WriteLine("Please choose program/number between 1 to 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
