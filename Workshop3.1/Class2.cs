using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class2
    {
      
        static void Main()
        {

       /* Random r = new Random();
        int n = r.Next(2);
        Console.WriteLine(n);*/

// coin class

        Coin c = new Coin();
        Coin c1 = new Coin();
        Coin c2 = new Coin();
        c.flip();
        c1.flip();
        c2.flip();

        int n =c.getFace();
        Console.WriteLine(c.getFace() + "--" + c1.getFace() + "--" + c2.getFace());

        }
     }
  public class Coin
    {
      public Coin()
      {
          this.flip();
      }
      const int HEAD = 0;
      const int TAIL = 1;

        int face = HEAD;
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
