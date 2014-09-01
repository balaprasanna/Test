using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3._1
{
    class BankAccount
    {
        //tests
        int accountNumber;
        //String accountHolderName;
        //Customer AccountHolder;
        Customer AccountHolder;
        double balance;

        public BankAccount(int n, Customer holder, double bal)
        {
            this.accountNumber = n;
            this.AccountHolder = holder;
            this.balance = bal;
        }

        public BankAccount(int n, string name, double bal)
        {
            this.accountNumber = n;
            //    Customer c = find(name);
            //   if (c == null) 
            //      c = new Customer(name);
            // this.AccountHolder = c;
            this.balance = bal;
        }

        protected void withDraw(double amount)
        {
            if (amount < balance)
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
        protected void transferTo(BankAccount a, double amount)
        {
            
            withDraw(amount);
            if (balance < 0)
            {
                a.deposit(amount);
                // a.balance = a.balance + amount;
            }
          //  balance = balance - amount;

            Console.WriteLine("Your new balance is {0}", balance);

            Console.WriteLine("new balance of b {0}", a.balance);
        }



        static void Main(string[] args)
        {
            Customer c = new Customer();
            BankAccount a = new BankAccount(1001, c, 1000);
            Customer d = new Customer();
            BankAccount b = new BankAccount(1002, d, 2000);

            a.accountNumber = 123;
            a.AccountHolder.CustomerName = "A";
            DateTime dt = new DateTime(1992, 10, 08, 7, 47, 0);
            a.AccountHolder.dateOfBirth = dt;

            // Customer c1 = new Customer();
            // c1.CustomerName = "A";
            //a.AccountHolder = c1;


            //BankAccount b = new BankAccount(1001, c, 1000);
            b.accountNumber = 456;
            b.AccountHolder.CustomerName = "B";

            a.deposit(1000);
            b.deposit(100);

            int i = 0;

            // code to withdraw
            //while(a.balance!=0){
            //    int withDrawamount= Convert.ToInt32(Console.ReadLine());

            //    a.withDraw(withDrawamount);
            // i++;
            //}

            Console.WriteLine("account holder name>>" + a.AccountHolder.CustomerName);
            Console.WriteLine("account holder age>>" + a.AccountHolder.Age());

            while (a.balance != 0)
            {
                int transferAmount = Convert.ToInt32(Console.ReadLine());

                a.transferTo(b, transferAmount);

            }
        }
    }
}