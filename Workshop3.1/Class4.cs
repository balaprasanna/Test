using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class4
    {
        int age;

        public int Age
        {
            get {
                return age;
            }
            set { 
                age = value; 
            }
        }

        static void Main(){
            Class4 c4 = new Class4();
            c4.Age = 17;
            //new Class4().Age=6;
    }

    }
}
