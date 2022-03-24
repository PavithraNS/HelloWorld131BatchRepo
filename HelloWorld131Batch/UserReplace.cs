using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class UserReplace
    {
        public static void ReplaceUserName()
        {
            string line = "Hello <<UserName>>, How are you?";
            Console.WriteLine("Please enter username");
            string userName = Console.ReadLine();
            Console.WriteLine(line);
            //string updatedRes=line.Replace("<<UserName>>", userName);
            Console.WriteLine("After replace\n"+line.Replace("<<UserName>>", userName));
        }
    }
}
