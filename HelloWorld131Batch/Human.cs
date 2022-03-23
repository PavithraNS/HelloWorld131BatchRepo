using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld131Batch
{
    class Human
    {
        //variables
        //access-modifier datatype variable name 
        public string name="ABc", address="bnglr";
        public double height=5.56;
        //public decimal a = 12.45M;

        //methods
        public void Speek()
        {
            Console.WriteLine("he/she can talk");
            Console.WriteLine("Name:{0} Address:{1} height:{2}", name, address, height);
        }
    }
}
