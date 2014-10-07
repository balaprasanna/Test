using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop2P1
{
    class workshop3
    {
        public static void Main()
        {
            DateTime dt1 = new DateTime(1992, 11, 08);
            customer cs1=new customer("Prasanna","2# jurong east","k1235592",dt1);
            
            BankAccount a = new BankAccount("1001",cs1,12500);

            DateTime dt2 = new DateTime(1992, 11, 08);
            customer cs2 = new customer("Ashiq", "2# jurong east", "Hui9800", dt2);
            BankAccount b = new BankAccount("1001", cs2, 50000);

            Console.WriteLine(a.calculateInterest().ToString());
             a = new BankAccount("1001", cs1, 12500);
           
            savingsAccount s = new savingsAccount("1001", cs1, 12500);

            currentAccount c = new currentAccount("1002", cs1, 12500);

            overDraftAccount o = new overDraftAccount("1003", cs1, 12500);
            Console.WriteLine(s.Balance.ToString());
            Console.WriteLine(s.calculateInterest().ToString());
            s.creditInterest();
            Console.WriteLine(s.Balance.ToString());
            Console.WriteLine(c.Balance.ToString());
            Console.WriteLine(c.calculateInterest().ToString());
            c.creditInterest();
            Console.WriteLine(c.Balance.ToString());
            Console.WriteLine(o.Balance.ToString());
            Console.WriteLine(o.calculateInterest().ToString());
            o.creditInterest();
            Console.WriteLine(o.Balance.ToString());
            BankAccount[] accs = new BankAccount[3];

            accs[0] = s;
            accs[1] = c;
            accs[2] = o;
            Console.WriteLine("Polymorphism test");
            for (int i = 0; i < accs.Length;i++ )
            {
                Console.WriteLine(accs[i].Balance.ToString());
                accs[i].WithDrawMoney(15000);
                Console.WriteLine(accs[i].Balance.ToString());
                Console.WriteLine(o.Balance.ToString());
                o.WithDrawMoney(15000);
                Console.WriteLine(o.Balance.ToString());

            }


            //    Console.WriteLine("With draw test");
            //o.WithDrawMoney(13000);
            //Console.WriteLine(o.Balance.ToString());
            //o.WithDrawMoney(1000);
            //Console.WriteLine(o.Balance.ToString());
            

            //s.calculateInterest().ToString();

            // work shop 3 solution
            //BankAccount b = new BankAccount("1002", "Ashiq", 1000);
            //Console.WriteLine(a.AccountHolder.CustomerName + "  " + a.Balance);
            //a.Deposit(1000);

            //Console.WriteLine(a.AccountHolder.CustomerName + "  " + a.Balance);
            //a.WithDrawMoney(50);
            //Console.WriteLine(a.AccountHolder.CustomerName + "  " + a.Balance);
            //a.TransferTo(b, 1000);
            //Console.WriteLine(a.AccountHolder.CustomerName + "  " + a.Balance);
            //Console.WriteLine(a.AccountHolder.CustomerName + "  " + b.Balance);
        }
    }
    public class BankAccount
    {
        string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public customer AccountHolder;

        //string accountHolderName;

        //public string AccountHolderName
        //{
        //    get { return accountHolderName; }
        //    set { accountHolderName = value; }
        //}
        double balance;

        public double Balance
        {
            get { return balance; }
           set { balance = value; }
        }


        public BankAccount(string accNum, customer customerObject, double bal){
            balance = bal;
            AccountHolder = customerObject;
            AccountNumber = accNum;

        }
        public double calculateInterest()
        {
            double interestAMOUNT = (balance )*((double)1/(100));
            return interestAMOUNT;
        }
        public void creditInterest()
        {
            Deposit(calculateInterest());
        }
       public void WithDrawMoney(double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Cannot with draw the amount specified. Due to insufficient fund");
            }
            else
            {
                balance = Balance - amount;
            }
        }

        public void Deposit(double amount)
        {
            balance = Balance + amount;
        }

        public void TransferTo(BankAccount receiver, double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Cannot with transfer the amount specified. Due to insufficient fund");
            }
            else
            {
            // deducting money from sender account
                balance = Balance - amount;
            // crediting money to receiver's account
                receiver.balance = receiver.Balance + amount;
  
            }
        }
    }

   public class customer
    {
        string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        string customerAddress;

        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        string passPortNumber;
        public string PassPortNumber
        {
            get { return passPortNumber; }
            set { passPortNumber = value; }
        }
        DateTime dob;

        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public customer(string custName,string custAddress,string psport,DateTime dateofbirth)
        {
            customerName = custName;
            customerAddress = custAddress;
            passPortNumber = psport;
            dob = dateofbirth;
        }
        public int Age()
        {
            int agevalue=0;
            DateTime current = new DateTime();
            agevalue = current.Year - Dob.Year;
            return agevalue;
        }


      
    }

    public class savingsAccount : BankAccount
    {

        public savingsAccount(string accNum, customer customerObject, double bal)
            : base(accNum, customerObject, bal)
        {

        }
        public new double calculateInterest()
        {
            double interestAMOUNT = Balance * ((double)(0.01));
            return interestAMOUNT;
        }

        public new void creditInterest()
        {
            Deposit(this.calculateInterest());
        }

        // balance may not be negative
        //public new void WithDrawMoney(double amount)
        //{
        //    if (amount > Balance)
        //    {
        //        Console.WriteLine("Cannot with draw the amount specified. Due to insufficient fund");
        //    }
        //    else
        //    {
        //        Balance = Balance - amount;

        //    }
        //}

    }

    public class currentAccount : BankAccount
    {

        public currentAccount(string accNum, customer customerObject, double bal)
            : base(accNum, customerObject, bal)
        {

        }

        public new double calculateInterest()
        {
            double interestAMOUNT = Balance * ((double)(0.25/100));
            return interestAMOUNT;
        }

        public new void creditInterest()
        {
            Deposit(this.calculateInterest());
        }

        // balance may not be negative
        //public new void WithDrawMoney(double amount)
        //{
        //    if (amount > Balance)
        //    {
        //        Console.WriteLine("Cannot with draw the amount specified. Due to insufficient fund");
        //    }
        //    else
        //    {
        //        Balance = Balance - amount;

        //    }
        //}

    }

    public class overDraftAccount : BankAccount
    {

        public overDraftAccount(string accNum, customer customerObject, double bal)
            : base(accNum, customerObject, bal)
        {

        }

        public new double calculateInterest()
        {
            double interestAMOUNT = Balance *(0.06);
            return interestAMOUNT;
        }

        public new void creditInterest()
        {
            Deposit(this.calculateInterest());
        }

        // balance may be negative
        public new void WithDrawMoney(double amount)
        {
            if (amount > Balance)
            {
                Balance = Balance - amount;
            }
            else
            {
                Balance = Balance - amount;

            }
        }

    }

  
}
