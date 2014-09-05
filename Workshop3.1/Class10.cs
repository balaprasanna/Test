using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class10
    {
        public static void Main()
        {
            Driver d = new Driver();
         
        }
    }

    class Car
    {
        Driver theowner;

       public void setowner(Driver d)
        {
            theowner = d;
        }

    }
    class Driver
    {
        Car mycar;
        public void buy()
        {
            mycar = new Car();
            mycar.setowner(this);
        }
    }
}
