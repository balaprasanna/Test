using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class Customer
    {
       public String CustomerName;
       public String CustomerAddress;
       public String PassportNumber;
       public DateTime dateOfBirth;
       //DateTime date1 = new DateTime(2008, 6, 1, 7, 47, 0);
       // 6/1/2008 7:47:00 AM 
      public int Age(){
            
           // int age = 0;
            DateTime today = DateTime.Today;
            int y = today.Year - dateOfBirth.Year;
            int m = today.Month - dateOfBirth.Month;
            int d = today.Day - dateOfBirth.Day;
            return y;
      }
    }
}
