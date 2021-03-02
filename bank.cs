using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    class bank
    {
        private double balance = 200000;


        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    class fuctions
    {
        bank myBank = new bank();
        string name;
        int account;
        double withdraw, deposit, transfer, totalbal;

        public void func1()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            deposit = Convert.ToDouble(Console.ReadLine());
            totalbal = myBank.bal + deposit;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + totalbal);

        }
        public void func2()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= myBank.bal)
            {
                totalbal = myBank.bal - withdraw;
                Console.WriteLine("------------------------------\n");
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw Amount balnace is : " + totalbal);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }
        public void func3()
        {
            Console.WriteLine("Enter Name of the transferer :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Transfer Amount :");
            deposit = Convert.ToDouble(Console.ReadLine());
            totalbal = myBank.bal + deposit;

            Console.WriteLine("------------------------------\n");
            Console.WriteLine("Name of the transferer : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + totalbal);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char yn;
            do
            {
                fuctions B = new fuctions();
                int num;
                Console.WriteLine("Please Select Any Function: ");
                Console.WriteLine("\nPress 1 for Deposit an Amount. \nPress 2 for Withdraw an Amount. \nPress 3 for Transfer an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        B.func1();
                        break;
                    case 2:
                        B.func2();
                        break;
                    case 3:
                        B.func3();
                        break;
                    default:
                        Console.WriteLine("Invalid Operation!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (Y/N)");
                yn = Convert.ToChar(Console.ReadLine());

            } while (yn == 'Y');

            Console.ReadKey();
        }
    }
}