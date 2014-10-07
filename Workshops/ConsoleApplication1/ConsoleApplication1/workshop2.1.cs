using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2P1
{
    class workshop2
    { 
         static void Main()
        {
            Triangle myTriangle = new Triangle(5,4,3);
            StringBuilder s = new StringBuilder();
            s.Append("Area" + myTriangle.Area());

            s.Append("\n Circumference" +myTriangle.Circumference());
            s.Append("\n isEquilateral" + myTriangle.isEquilateral());
            s.Append("\n isIsosceles" + myTriangle.isIsosceles());
            s.Append("\n isRightAngle" + myTriangle.isRightAngle());

            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 10;
            myRectangle.Breadth = 15;
            s.Append("\nArea" + myRectangle.area());
            s.Append("\nCircumference" + myRectangle.Circumference());
            s.Append("\nDiagonal" + myRectangle.Diagonal());
            Console.WriteLine(s);
            Console.Read();
            
        }
    }
    class Triangle
    {

        
        public Triangle(){
            side1 = 0;
            side2 = 0;
            side3 = 0;
        }

        public Triangle(double s1,double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        double side1, side2, side3;

        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }

        public double Side3
        {
            get { return side3; }
            set { side3 = value; }
        }
       
       
        public double Area()
        {
            double p = perimeter();
            double area = Math.Sqrt((p * (p - side1) * (p - side2) * (p - side3)));
            return area;
        }

        public double perimeter()
        {
            return ((side1 + side2 + side3) / 2);
        }

        public double Circumference()
        {
            return (side3 + side2 + side1);
        }
      
        public bool isRightAngle()
        {
            bool isRightAng= false;
           if(pythogorous(side1,side2,side3)){
               isRightAng=true;
            }
           else if (pythogorous(side2, side1, side3))
           {
               isRightAng = true;
           }
           else if(pythogorous(side3, side1, side2))
           {
               isRightAng = true;
           }
           else
           {
               isRightAng = false;
           }

           return isRightAng;
        }
        bool pythogorous(double s1,double s2, double s3){
            bool istrue= false;
            if((s1*s1)==(s2*s2)+(s3*s3))
            {
                istrue=true;
            }
            else
            {
                istrue = false;
            }
            return  istrue;
        }
        public bool isIsosceles()
        {
           return checkIsosceles(side1,side2,side3);
        }
        bool checkIsosceles(double s1, double s2, double s3)
        {
          //  bool iso= false;
           //ool is =false;
           //iso= iso?((s1 == s2) || (s1== s3)||(s2== s3)):false;
           return ((s1 == s2) || (s1 == s3) || (s2 == s3));
        }
        public bool isEquilateral()
        {
            return ((side1 == side2) && (side1 == side3) && (side2 == side3));

        }
    }
}
