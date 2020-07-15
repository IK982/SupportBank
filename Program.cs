using System;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace Support_Bank
{
    
    class Program
    {
            private static void ConfigureLogger()
            {
                var config = new LoggingConfiguration(); //created new logging config
                var target = new FileTarget { FileName = @"SupportBank.log", Layout = @"${longdate} ${level} - ${logger}: ${message}" };
                //place tp keep all the logs ^ file target to send all the logs to (log.txt).
                //each message in the log file should have the date, the log file and the message
                config.AddTarget("File Logger", target); //ass target to config target
                var consoleTarget = new ColoredConsoleTarget {Layout =  @"${level} - ${logger}: ${message}"};
                config.AddTarget("Console Logger", consoleTarget);
                config.LoggingRules.Add(new LoggingRule("*", LogLevel.Debug, target)); // add new log rul. * = literally anything
                //anything tht is loglevel.debug or more important gets sent to the log.(things we want in the log)
                // loggin rle is another class, creating another loggin rule taking 3 argumets
                //pattern (anything), minlevel(anythign thats logged at this level or higher, taget (where we send these things e.g. log file))
                config.LoggingRules.Add( new LoggingRule("*", LogLevel.Error, target));
                LogManager.Configuration = config; 
            }
        static void Main(string[] args)
        {
            ConfigureLogger();


            // Read all the transactions from  the file.
            var transactions = FileReader.ReadTransactions();

            // and then use those transactions to create the accounts we will need.

        var accounts = Bank.GetAccounts(transactions);

        foreach (var account in accounts)
        {
            Console.WriteLine(account.name);
        }
        var updatedAccounts = Bank.updatedAccounts(transactions, accounts);

        Console.WriteLine(updatedAccounts);
    
            

        }
    }
}














// 
//reader class file
//transaction class file
//Account class file
//Bank class file 
//Printer class file