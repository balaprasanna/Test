using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class8
    {
        public static void Main()
        {
            int a = 8, b=9;
            A obj = new A();
           
            obj.p(a);
            obj.q(ref b);
            Console.WriteLine("Values are {0}--{1}",a,b);
            Console.WriteLine("--" + obj.GetType().ToString() + "--"+obj.GetHashCode().ToString());
            //Console.WriteLine("--" +  "--" + obj2.GetHashCode().ToString());
            obj = new A();
            Console.WriteLine("--" + obj.GetType().ToString() + "--" + obj.GetHashCode().ToString());
        }
    }

    class A
    {
        public void p(int v)
        {
            v = v + 1;
        }
        public void q(ref int w)
        {
            w = w + 1;
        }
    }
}
