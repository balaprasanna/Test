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
            c.FaceValue1 = 10;
           // c.getFace();
            Console.WriteLine(c.getFace());
            Console.WriteLine(c.FaceValue1);
        }

    }
   class Coin1{

        int face;
        int FaceValue;

        public int FaceValue1
        {
            get { 
                return FaceValue; 
            }
            set { 
                FaceValue = value; 
            }
        }
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
