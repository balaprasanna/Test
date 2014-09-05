using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class6
    {

        static void Main()
        {
           // Calculate c = new Calculate();
           // Calculate c1 = new Calculate(3,4);
            Calculate c2 = new Calculate(3.5,6,7);
            //Console.WriteLine("test");
        }
    }

    class Calculate {

            public Calculate()
            {
                Console.WriteLine("Default");
            }


            public Calculate(int a, int b)
            {
                Console.WriteLine("Cal" + a + b);
            }

            public  Calculate(double a, int a1, int b)
            {
                Console.WriteLine("Cal"+a+a1+b);
            }

           
    }
   }

