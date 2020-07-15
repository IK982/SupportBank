
using System.Collections.Generic;

namespace Support_Bank
{
    public class Account
    {
        public string name;
        public List<Transaction> incomingTransactions;
        public List<Transaction> outgoingTransactions;
        
        public Account(string name)
        {
            // the constructor asks us to supply a name when we create the account.
            // it then sets the name
            // and initialises the incoming and outgoing transactions as an empty list.
            this.name = name;
            incomingTransactions = new List<Transaction>();
            outgoingTransactions = new List<Transaction>();
        }
        
        public decimal GetTotalIncoming()
        {
            // loops through all of the incoming transactions,
            // and adds up the total value of the incoming transactions.
            var total = new decimal(0);

            foreach (var transaction in incomingTransactions)
            {
                total = total + transaction.amount;
            }

            return total;
        }

        public decimal GetTotalOutgoing()
        {
            // loops through all of the outgoing transactions,
            // and adds up the total value of the outgoing transactions.
            var total = new decimal(0);

            foreach (var transaction in outgoingTransactions)
            {
                total = total + transaction.amount;
            }

            return total;
        }

        public decimal GetTotalToPay()
        {
            // Get the total amount that the person needs to pay.
            // which is just all the money that they owe to others, minus all the money owed to them.
            return GetTotalOutgoing() - GetTotalIncoming();
        }
    }
}



        // public string name;
        // public int owe;
        // public int owed;


        // public void accountinfo()
            //Console.WriteLine("Account Name: " + name + " owes " + owe + " and is owed " + owed);

            // Account account = new Account(); 
            // Account.name line.from;

            //if(name = already an account name) {just add [4]} else add name to account
// and add amount [4] to name at [2] in var named "owed"
// If account for name already exists, add numbers at [4] to existing account

//At the end of reading lines, print total for each existing account in the format of:

// Account: Jon A
// Owe:
// Owed: 
// For each line, make an account for the name at [1] and [2]
// For each line, add the amount [4] to name at [1] in a var named "owe"