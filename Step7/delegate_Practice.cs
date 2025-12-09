using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step7
{
    public delegate void BankWorkProcessing(string Bank);

    class BankSystem
    {
        public void CreatingAccountsDetails(string Bank)
        {
            Console.WriteLine($"Account is created in : {Bank}");
        }


        public void TransactionDetails(string Bank)
        {
            Console.WriteLine($"Transaction details are fully fetched in :{Bank}");
        }


        public void CheckingAccountDetails(string Bank)
        {
            Console.WriteLine($"Account details are verified in : {Bank}");
        }

    }
    class BankHolder
    {
        static void Main()
        {
            BankSystem system = new BankSystem();
            BankWorkProcessing workprocess;
            
            Console.WriteLine("\nBankHolder checks all the Details in different banks...");
            // BankSystem system = new BankSystem();
            Console.WriteLine("\nBank holder create the account in hdfc bank...");
            workprocess = system.CreatingAccountsDetails;
            workprocess("HDFC");
            Console.WriteLine("\nBank holder checks the transaction details in sbi bank...");
            workprocess = system.TransactionDetails;
            workprocess("SBI");
            Console.WriteLine("\nBank holder checks the account details in icici bank...");
            workprocess = system.CheckingAccountDetails;
            workprocess("ICICI");


        }







    }
}

