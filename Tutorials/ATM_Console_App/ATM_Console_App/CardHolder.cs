using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console_App
{
    public class CardHolder
    {
        

        String cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public CardHolder( String cardNum, int pin, string firstName, string lastName, double balance)
        {

            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

  
        public String getCardNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public double getBalance()
        {
            return balance;
        }


        public void setCardNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }
        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }


        // -- FUNCTIONS --
        public void deposit()
        {
            Console.WriteLine("how much money would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            setBalance(getBalance() + deposit);
            Console.WriteLine("thank you for your money, Your new balance is: {0}", getBalance());

        }

        public void withdraw()
        {
            Console.WriteLine("how much money would you like to withdraw: ");
            double withdrawal = Double.Parse(Console.ReadLine());
            // check if the user has enough money
            if (getBalance() >= withdrawal)
            {
                setBalance(getBalance() - withdrawal);
            }
            else
            {
                Console.WriteLine("sorry, you don't have enough money to withdraw {0}", withdrawal);
            }
            Console.WriteLine("thanks for choosing us today, your current balance is {0}", getBalance());
        }

        public void showBalance()
        {
            Console.WriteLine("Your balance is: {0}", getBalance());
        }

        public void exit()
        {
            Console.WriteLine("Thank you, have a nice day");
        }

        // -- END OF FUNCTIONS --
    }
}

