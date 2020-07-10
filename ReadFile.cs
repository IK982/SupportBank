using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Support_Bank
{
    class FileReader {
        public static List<Transaction> ReadTransactionsFromFile()
        {
            var transactions = new List<Transaction>();



            //Get all the lines but skip the first line

            var csvLines = File.ReadAllLines("Transactions2014").Skip(1);

            // loop through each of these lines
            foreach(var line in csvLines) {
                // line here is one single line from or file.
                // that line represnts a single transaction.

                var parts = line.Split(",");
                Console.WriteLine(parts);

                var date = parts[0];
                var from = parts[1];
                var to = parts[2];
                var narrative = parts[3];
                var amount = parts[4];

                Console.WriteLine(parts);

            }

            return transactions;
        }




    }
    





        }