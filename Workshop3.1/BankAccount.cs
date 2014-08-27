using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class BankAccount
    {
        int accountNumber;
        String accountHolderName;
        double balance;

       protected void withDraw(double amount)
        {
            if(amount<balance)
            {
                balance = balance - amount;
                Console.WriteLine("Your new balance is {0}", balance);
            }
            else
            {
                Console.WriteLine("Insufficeint Fund to withdraw");
            }

        }

       protected void deposit(double amount)
       {
           balance = balance + amount;
           Console.WriteLine("Your new balance is {0}", balance);
       }
       protected void transferTo(BankAccount a,double amount)
       {

           a.balance = a.balance + amount;

           balance = balance - amount;

           Console.WriteLine("Your new balance is {0}", balance);

           Console.WriteLine("new balance of b {0}", a.balance);
       }



        static void Main(string[] args)
        {

            BankAccount a = new BankAccount();
            a.accountNumber = 123;
            a.accountHolderName = "A";

            BankAccount b = new BankAccount();
            b.accountNumber = 456;
            b.accountHolderName = "B";

            a.deposit(1000);
            b.deposit(100);

            int i = 0;
          
            // code to withdraw
            //while(a.balance!=0){
            //    int withDrawamount= Convert.ToInt32(Console.ReadLine());

            //    a.withDraw(withDrawamount);
            // i++;
            //}

            while(a.balance!=0){
                int transferAmount= Convert.ToInt32(Console.ReadLine());

                a.transferTo(b, transferAmount);
           
            }
            



        }
    }
}
