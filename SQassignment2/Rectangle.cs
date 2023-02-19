using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQassignment2
{
    internal class Rectangle
    {
        int lenght, widit;

        //Default constructor 
        public Rectangle()
        {
            lenght = 1;
            widit = 1;
        }

        //Main method
        public static void main()
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("The default : "+ (r.lenght * r.widit));
        }
    }
}
