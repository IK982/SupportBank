using System;
using System.IO;

namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all the transactions from  the file.
            var transactions = FileReader.ReadTransactions();

            // and then use those transactions to create the accounts we will need.

        var accounts = Bank.GetAccounts(transactions);
    
            Console.WriteLine(accounts);

        }
    }
}

//reader class file
//transaction class file
//Account class file
//Bank class file 
//Printer class file