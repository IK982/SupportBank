using System.Collections.Generic;

namespace Support_Bank
{

    public class Bank
    {

        public static List<Account> GetAccounts(List<Transaction> transactions)
        {

            //find all of the unique names of people in the team.
            var names = GetUniqueNames(transactions);

            // then create an empty list of accounts
            var accounts = new List<Account>();

            // Loop through all of the names
            foreach (var name in names)
            {
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
    }
}