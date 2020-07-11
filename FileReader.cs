using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Support_Bank
{
    class FileReader {
        public static List<Transaction> ReadTransactions()
        {

            // Read all of the lines of text from the file.
            //(gets an array of strings - one string for each line)
            var linesFromFile = File.ReadAllLines("Data/Transactions2014.csv");

            //create an empty list of transactions.
            var transactions = new List<Transaction>();


            // Then loop through every line of the file
            // (skipping the first one as it's the headers)
            foreach (var line in linesFromFile.Skip(1))
            {
                // For each line,
                // split it into the 5 parts by using the commas.
                var parts = line.Split(",");

                // Construct a new transaction
                // and populate all of its values using the parts of the string.
                var newTransaction = new Transaction();
                newTransaction.date = parts[0];
                newTransaction.from = parts[1];
                newTransaction.to = parts[2];
                newTransaction.narrative = parts[3];
                newTransaction.amount = Convert.ToDecimal(parts[4]);

                // add our newly created transaction to the list of all transactions.
                transactions.Add(newTransaction);

            }

            return transactions;


            }

        }




    }
    