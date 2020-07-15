using System.Collections.Generic;
using NLog;

namespace Support_Bank
{

    public class Bank
    {

        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
        public static List<Account> GetAccounts(List<Transaction> transactions)
        {
            Logger.Info("Getting the Unique Names");

            //find all of the unique names of people in the team.
            var names = GetUniqueNames(transactions);

            // then create an empty list of accounts
            var accounts = new List<Account>();

            // Loop through all of the names
            foreach (var name in names)
            {

                Logger.Debug($" Creating Account for {name}");

                // Logger.Trace($" Creating Account for {name}");
                // and for each name, create the new account 
                var account = new Account(name);

                // and then add the new account to the list.
                accounts.Add(account);
            }

            // finally return all the accounts.
            return accounts;
        }

        private static HashSet<string> GetUniqueNames(List<Transaction> transactions)
        {
            // create a new empty set to hold all our names.
            // making list of accounts.
            var names = new HashSet<string>();

            // then loop through all of the transactions.
            foreach (var transaction in transactions)
            {
                // for each transaction, ass the from and to names to the set.
                // the set will handle all the duplicates for us and ensure everything is unique.
                names.Add(transaction.from);
                names.Add(transaction.to);
            }

            // and then return all the names
            return names;
        }
        //create new method called updatedAccounts using the Account class,
        //created new list called upDatedAccounts which passes the parameters 
        //"transactions" and "accounts" so we can join them together 
        public static List<Account> updatedAccounts(List<Transaction> transactions, List<Account> accounts)
        {
            foreach (var transaction in transactions)
            {
                var account = findAccount(transaction.from, accounts);
                account.outgoingTransactions.Add(transaction);
                //looping through all transactions, for each transactions which is called transaction, we work out 
                //who the from person was for each, then we use that name to look up to find the account for that name
                //then add the outgoing transactions to tha account.


            }
            foreach (var transaction in transactions)
            {
                var account = findAccount(transaction.from, accounts);
                account.incomingTransactions.Add(transaction);

                // do the same thing for incoming transactions.
            }

            return accounts;
        }
        public static Account findAccount(string name, List<Account> accounts)
        {
            foreach(var account in accounts)
            {
                if (name == account.name)
                {
                    return account;
                }
            }
            return null; 
            //name is just a string e.g. sarah t. accounts is a list of our account. Account holds
            //and instance of the account.
            //if the instance account is equal to account.name (just the name of our account). 
            //otherwise return nothing.

        }

        
        //find acount asociated with a particular person. Trying to figure out the account 
        //we're working on. Got a transaction, would like to work out whose account it comes from 
        //then add the outgoing transactions to that account
        //account has from and to, only want to find account with from. 
    }
}

//we needed to get the list of accounts to make a new list called updated accounts. in order
//to do that we needed to iterate through each transactions in the transaction section
//looking for the from name of our transaction and add it onto the outgoing transactions account
// add it = transaction, the name of the transaction the from bit 
//do the the same for the incoming. We made a method called findaccount. takes the name part of transaction
// 
//if the name is an exact match to the instance that we're looking for for the account
//we return the account
//if we don't it return nothing.