// For each line, make an account for the name at [1] and [2]
// For each line, add the amount [4] to name at [1] in a var named "owe"
// and add amount [4] to name at [2] in var named "owed"
// If account for name already exists, add numbers at [4] to existing account

//At the end of reading lines, print total for each existing account in the format of:

// Account: Jon A
// Owe:
// Owed: 


using System;

namespace Support_Bank {

    public class Account {

        public string name;
        public int owe;
        public int owed;

        public void accountinfo()
        {
        
            Console.WriteLine("Account Name: " + name + " owes " + owe + " and is owed " + owed);

            // Account account = new Account(); 
            // Account.name line.from;

            //if(name = already an account name) {just add [4]} else add name to account
        }



        
    }



}