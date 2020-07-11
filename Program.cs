using System;
using System.IO;

namespace Support_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = FileReader.ReadTransactionsFromFile();
            Console.WriteLine(transactions);





        }
    }
}

//reader class file
//transaction class file
//Account class file
//Bank class file 
//Printer class file