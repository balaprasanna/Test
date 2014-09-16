using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class13
    {
        static void Main()
        {
            cat mycat = new cat();
            mycat.P();

            Animal myanimal = new Animal();
            myanimal.P();
           
            Animal newanimal= new cat();
            newanimal.P();

            cat newcat = (cat)newanimal;
            newcat.P();

            Animal a2;
            a2 = mycat;
            a2.P();
          //  Console.WriteLine(newanimal.GetType());
            
        }
    }
    class Animal
    {
        public Animal()
        {
          //  Console.WriteLine("Animal constructor");
        }
        //public void P()
        //{
        //    Console.WriteLine("Animal class");
        //}
        public virtual void P()
        {
            Console.WriteLine("Cat class");
        }
    }
    class cat : Animal
    {
        public cat() {
          //  Console.WriteLine("Cat constructor");
        }
        //public new void P()
        //{
        //    Console.WriteLine("Cat class");
        //}
        public override void P()
        {
            Console.WriteLine("Cat class");
        }
    }
}
