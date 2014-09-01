using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
   
    class Class5
    {
    }
   class Coin1{

       protected int temp = 0;
        public int face=0;
        int FaceValue;

        public Coin1()
        {
            face = 1;
            Console.WriteLine("default constructor coin  " + face);
            // this is called everytime when an object is created,
        } 

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
      
        static void Main()
        {
           
            Coin1 c = new Coin1();
             c.FaceValue1 = 10;
           
            // c.getFace();
            Console.WriteLine(c.getFace());
            Console.WriteLine(c.FaceValue1);
        }
       
    }
}
