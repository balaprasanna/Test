using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class7
    {
        static void Main()
        {
            abc obj = new abc();
            Console.WriteLine("object 1 finished");
             abc obj1 = new abc(9);
             Console.WriteLine("object 2 finished");
             abc obj2 = new abc(9,10);
             Console.WriteLine("object 3 finished"); 
        }
    }
    class abc
    {
        int a, b;
        public abc():this(0)
        {
            Console.WriteLine("default constructor");
        }
        public abc(int a):this(a,0)
        {
            //this.a = a;
            Console.WriteLine("1 constructor" + this.a + "--" + this.b);
        }

        public abc(int a,int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("2 constructor"+this.a +"--"+ this.b);
        }
    }
}
