﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class11
    {
        static void Main()
        {
            parent p = new parent();
            p.x();
            
            //p.x();
            child c = new child();
            c.x();
            c.y();
            //Coin mycoin = new Coin();
 
            //mycoin.flip();
            //Console.WriteLine(mycoin.getFace());

            monetarycoin mc = new monetarycoin(10,"dubai");
           // mc.getcountry();
           // mc.getValue();
           // mc.getFace();
           // mc.flip();
          //  mc.getFace();
          //  mc.flip();
        }

    }

    class monetarycoin : Coin
    {
        int valu;
        string country;
        public monetarycoin(int v, String c)
        {
            valu = v;
            country = c;
            Console.WriteLine("derived class constructor called");
        }
        public int getValue()
        {
            return valu;
        }
        public string getcountry()
        {
            return country;
        }
    }
    class parent
    {
         protected bool accessme = false;
        public void x()
        {
            Console.WriteLine("Parent x");
            accessme = true;
        }
    }
    class child : parent
    {
        private bool receive;
        public child()
        {
            receive = false;
           
            accessme = true;
        }
        public new void x()
        {
            Console.WriteLine("Child x");
        }
        public void y()
        {
            this.x();
            base.x();
        }

        // : is derived from
    }
}
