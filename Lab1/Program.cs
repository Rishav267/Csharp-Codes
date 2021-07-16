using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Account Acc = new Account();    // creating a instance for class account having account as datatype

		    Console.WriteLine("Performing Account Transactions using Account Manager 1..."); //printing on screen
		    AccountManager1 Manager1 = new AccountManager1(); // creating first istance for class AccountManager1
            Manager1.FillAccountData(Acc);    //calling the method which exist inside class AccountManager and filling the details available
            Manager1.DisplayAccountData(Acc); // calling the method which exist inside class AccountManager and displaying filled details


             Console.WriteLine();  // giving gap of a line

            Console.WriteLine("Performing Account Transactions using Account Manager 2...");
            AccountManager2 Manager2 = new AccountManager2();
            Manager2.FillAccountData(Acc);
            Manager2.DisplayAccountData(Acc);
            
            Console.ReadLine();
        }
    }
}
