using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class5
    {

        static void Main()
        {
            Coin1 c = new Coin1();
           // c.getFace();
            Console.WriteLine(c.getFace());
        }

    }
   class Coin1{

        int face;
       public int getFace()
        {
            return face;
        }

        //Constructor
        //default instance constructor
        public Coin1()
        {
            face = 1;
            Console.WriteLine("default constructor coin  " + face);
            // this is called everytime when an object is created,
        }
      

    }
}
