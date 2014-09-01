using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class2
    {
        static void Main(){

       /* Random r = new Random();
        int n = r.Next(2);
        Console.WriteLine(n);*/

// coin class
        Coin c = new Coin();
        c.flip();
        int n =c.getFace();
        Console.WriteLine(c.getFace());

        }
     }
    class Coin
    {
        int face;
       public void flip()
        {
            face = (new Random()).Next(2);
        }
        public int getFace()
        {
            return face;
        }
    }
}
