using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class9
    {
       public static void Main()
        {
            ParamTester p = new ParamTester();
            p.PrintValues();
           
           Mynum mynum=new Mynum(10);
           
            p.setParms(7, mynum);
            p.PrintValues();

            mynum.setValue(5);
            p.setParms(7, mynum);
            p.PrintValues();
        }

    }
    class Mynum
    {
        private int val;
        public Mynum(int initval)
        {
            val = initval;
            Console.WriteLine("constructor called" + val);
        }

        public void setValue(int value)
        {
            val = value;
        }
        public int getValue()
        {
            return val;
        }
    }
    class ParamTester
    {
        int value1, value2;
        public ParamTester()
        {
            value1 = 0;
            value2 = 0;
            Console.WriteLine("constructor called" + value1+value2); 
        }
        public void setParms(int num, Mynum mynum)
        {
            value1 = num;
            value2 = mynum.getValue();
           
        }

        public void PrintValues()
        {
            Console.WriteLine("The values are"+value1+"--"+value2);
        }

    }
}
