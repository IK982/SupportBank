using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NLog;

namespace Support_Bank
{
    public class FileReader
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public static List<Transaction> ReadTransactions()
        {
            Logger.Info("about to read files from DodgyTransactions2015");
            // Read all of the lines of text from the file.
            // (gets an array of strings - one string for each line)
            var linesFromFile = File.ReadAllLines("DodgyTransactions2015.csv");
            
            // create an empty list of transactions.
            var transactions = new List<Transaction>();
            
            // then loop through every line of the file, skipping the first line.
            foreach (var line in linesFromFile.Skip(1))
            {
                // for each line,
                // split it into the 5 parts by using the commas.
                var parts = line.Split(",");
                
                // Construct a new transaction
                // and populate all of its values using the parts of the string.
                var newTransaction = new Transaction();
                
                try{

                newTransaction.date = parts[0];

                }
                catch (FormatException incorrect)
                {
                    Logger.Error($"You entered {parts[0]} which is an invalid format");

                    continue;
                }
                
                newTransaction.from = parts[1];
                newTransaction.to = parts[2];
                newTransaction.narrative = parts[3];
                
                try{

                    newTransaction.amount = Convert.ToDecimal(parts[4]);

                }
                catch (FormatException mistake)
                {
                    Logger.Error($"You entered {parts[4]} which is an invalid format");
                
                
                    continue; // skip immediately to the next loop
                }


                // add our newly created transaction to the list of all transactions.
                transactions.Add(newTransaction);
            }

            // and finally return all of the transactions.
            return transactions;
        }
    }
}
    
           
           
           
           
           
           
           
            // (skipping the first one as its the headers)