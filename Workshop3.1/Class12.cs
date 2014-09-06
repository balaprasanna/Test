using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Class12
    {
        static void Main()
        {
            rectangle r = new rectangle(5, 4);
            parallelogram p = new parallelogram(5,4,20);
            Console.WriteLine("finally Area"+r.getArea()+"-perimeter"+r.getPerimeter());
            Console.WriteLine("finally Area" + p.getArea() + "-perimeter" + p.getPerimeter());
            // parallelogram q = new parallelogram(10, 5, 34);
            //q.method1(q);
        }
    }
    class rectangle
    {
      private int length;
      private int width;
      public rectangle(int len,int wid)
      {
          length = len;
          width = wid;
      }
      public void setProperties(int l, int w){
          length = l;
          width = w;
      }
      public int getlength()
      {
          return length;
      }
      public int getwidth()
      {
          return width;
      }
      public int getArea()
      {
          return length * width;
      }
      public int getPerimeter()
      {
          return 2 * (length + width);
      }

    }

    class parallelogram : rectangle
    {
        private int angle;
        public parallelogram(int l,int w,int angle):base(l,w)
        {
            this.angle = angle;
           // base.getArea();
           // base.getPerimeter();
           //Console.WriteLine("Area" + "length "+this.getlength()+"width"+this.getwidth()+ "Area is"+  this.getArea() + "-perimeter" + this.getPerimeter());
           //method1(this);
        }
        public new int getArea()
        {

            return (int)(getlength() * getwidth() * Math.Sin(angle * (Math.PI / 180)));
        }
        public new int getPerimeter()
        {

            return 2*(getlength() + getwidth());
        }
        //public void method1(parallelogram pm)
        //{
        //    pm.setProperties(2, 2);
        //    Console.WriteLine("Area" + pm.getArea() + "-perimeter" + pm.getPerimeter());
            
        //}
    } 
}
