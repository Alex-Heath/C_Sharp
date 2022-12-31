using System;
using System.Linq.Expressions;

namespace ATM_Console_App
{
    public class program
    {

        // ----- FUNCTIONS -----
        public static void printOptions()
        {
            Console.WriteLine("please choose from one of the following options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }




        // ----- END OF FUNCTIONS -----

        public static void Main(String[] args)
        {
            List<CardHolder> CardHolders = new List<CardHolder>();
            CardHolders.Add(new CardHolder("6585215684635440", 4220, "Alex", "Heath", 28743.65));
            CardHolders.Add(new CardHolder("6189573640291180", 4030, "Sheila", "Heath", 69714.65));
            CardHolders.Add(new CardHolder("3057686755969340", 2349, "Zach", "Heath", 36736.65));
            CardHolders.Add(new CardHolder("7604528376230660", 8568, "Charlotte", "Hill", 3571.65));
            CardHolders.Add(new CardHolder("1096111086564670", 3458, "Mum", "Heath", 47379.65));
            CardHolders.Add(new CardHolder("7321193989798590", 6341, "Dad", "Heath", 13780.65));

            // prompt user 
            Console.WriteLine("Welcome to simple atm");
            Console.WriteLine("Please insert your debit card number: ");

            String debitCardNum = "";
            CardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    //  check agaisnt our db
                    currentUser = CardHolders.FirstOrDefault(a => a.getCardNum() == debitCardNum);
                    if (currentUser != null) { break; }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please try again");
                    }
                }
                catch { Console.WriteLine("Card not recognized. Please try again"); }
                }
            Console.WriteLine("please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin) { break; }
                    else{Console.WriteLine("Incorrect pin. Please try again");}
                }
                catch { Console.WriteLine("Incorrect pin. Please try again"); }
            }

            Console.WriteLine("Welcome {0}.", currentUser.getFirstName());
            int option = 0;
            do
            {
                printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if(option == 1) { currentUser.deposit(); }
                if(option == 2) { currentUser.withdraw(); }
                if(option == 3) { currentUser.showBalance(); }
                if(option == 4) { currentUser.exit(); break; }
            }
            while (option != 4);
            Console.WriteLine("Thank you, have a nice day.");
        
        }
    }
}