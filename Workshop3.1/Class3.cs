using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
      class Class3
    {
         static bool flag = true;
           int age;
           void setAge(int newage)
        {
            if (newage < 50)
            {
                age = newage;
                flag = false;
            }
            else
            {
                flag = true;
                Console.WriteLine("This is not in the limit, please enter a normal value"); 
            }
            
        }
           int getAge()
        {

            return age;
        }


        static void Main()
        {
            Class3 c3 = new Class3();
           // flag = false;
           while (flag)
          {
              Console.WriteLine("Flag status"+flag.ToString());
              int a = Convert.ToInt32(Console.ReadLine());
             
              c3.setAge(a);

            
              //c3.main();
          }
          Console.WriteLine(c3.getAge());
        }

        void main()
        {
            Console.WriteLine("test main, its a just a method");
        }

    }
}
