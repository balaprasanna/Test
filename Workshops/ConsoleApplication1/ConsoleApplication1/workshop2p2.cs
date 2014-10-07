using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2P1
{
    class workshop2p2
    {
    }



    public class Dice
    {
        private int FaceUp;

        public int GetFace()
        {
            return FaceUp ;
        }

        public void Throw()
        {
            Random a = new Random();
           FaceUp = a.Next(1,6);
         //   face = ISSMath.RNDInt(2);
        }

        public Dice()
        {
            Throw();
        }

        public string StrFace
        {
            get
            {
                //if (GetFace() == 0) return FaceUp.ToString();
                //else return "TAIL";
                return FaceUp.ToString();
            }
        }
    }


    public class Dice1
    {
        private int FaceUp;

        public int GetFace()
        {
            return FaceUp;
        }

        public void Throw()
        {
            Random a = new Random();
            FaceUp = a.Next(1, 6);
            //   face = ISSMath.RNDInt(2);
        }

        public Dice1()
        {
            Throw();
        }

        public string StrFace
        {
            get
            {
                //if (GetFace() == 0) return FaceUp.ToString();
                //else return "TAIL";
                return FaceUp.ToString();
            }
        }
    }

    public class DiceApp
    {
        public static void Main()
        {
            Dice dice = new Dice();
            Dice1 dice1 = new Dice1();
           // Dice dice1 = new Dice();
            dice.Throw(); Console.WriteLine("\n " + dice.StrFace);
            dice1.Throw(); Console.WriteLine("\n " +dice1.StrFace);
           // dice.Throw(); Console.WriteLine("\n " + dice.StrFace);
           // dice.Throw(); Console.WriteLine("\n " + dice.StrFace);


            //dice.Throw();
            int count = 0;
            int sum=dice.GetFace();
            for (int i = 0; i < 100000; i++)
            {
                dice.Throw();
                int num1 = dice.GetFace();
                dice.Throw();
                sum = dice.GetFace() + num1;
                if (sum == 8)
                {
                    count++;
                }


            }
            Console.WriteLine("Probability "+ sum+ "--"+ (double)sum / 100000);
            Console.WriteLine("Theory Probability " + (double)5 / 35);
          ///  dice1.Throw(); Console.WriteLine("\n " + dice1.StrFace);
        }
    }

}