using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount();

            // Test the BankAccount - make some deposits and withdrawals,
            // and check that the balance behaves as expected
            //myAccount.GetBalance();
            //Console.WriteLine("Balance is now : {0}", myAccount.GetBalance());

            
           
            myAccount.Deposit(500);
            //myAccount.Deposit(-100);
           myAccount.Withdraw(-400);
            

            Console.WriteLine($"the balance is: {myAccount.GetBalance()} kr");


            // The LAST line of code should be ABOVE this line
        }
    }
}
