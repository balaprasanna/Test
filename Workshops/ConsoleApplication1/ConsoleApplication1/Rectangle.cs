using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2P1
{
    class Rectangle
    {
        double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        double breadth;

        public double Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }
        public Rectangle(){

            length = 1;
            breadth = 1.5;

   
           }
        public double area()
        {
            return length * breadth;
        }
        public double Circumference()
        {
            return 2*(length + breadth);
        }
        public double Diagonal()
        {
            return Math.Sqrt((length * length) + (breadth * breadth));
        }

}
}
