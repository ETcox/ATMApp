public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    }

    public String getNum()
    {
        return cardNum;
    }

    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getLastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }


    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        void deposit(cardHolder currentUser)
        {
            while (true) { 
            try {  

            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit);
            Console.WriteLine("Thank you for your $$. Your new balance is " + currentUser.getBalance());
                    { break; }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only use numbers :)");
                
            }
            }
        }
       
        
        void withdraw(cardHolder currentUser)
        {

            while(true){ 
                try { 
            
                Console.WriteLine("How much $$ would you like to withdraw?: ");
                double withdrawal = Double.Parse(Console.ReadLine());
                //Check if the user has enough money
                if(currentUser.getBalance() < withdrawal)
                {
                    Console.WriteLine("Insufficient balance :(");
                }
                else
                {
                
                    currentUser.setBalance(currentUser.getBalance() - withdrawal);
                    Console.WriteLine("You're good to go, thank you!");
                    { break; }    
                }
              }catch (FormatException)
                    {
                        Console.WriteLine("Please only use numbers :)");
                }    
            }
       
        
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        List<cardHolder> cardHolders = new List<cardHolder>();
        
        cardHolders.Add(new cardHolder("1234567890123456", 1234, "John", "Doe", 1000.50));
        cardHolders.Add(new cardHolder("9876543210987654", 4321, "Jane", "Smith", 500.75));
        cardHolders.Add(new cardHolder("5678901234567890", 1111, "Alice", "Johnson", 250.30));
        cardHolders.Add(new cardHolder("0987654321098765", 9999, "Bob", "Williams", 750.90));
        cardHolders.Add(new cardHolder("1357902468135790", 8888, "Emily", "Brown", 1500.25));


    



        //prompt user
        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debitcard: ");
        String debitCardNum = "";
        cardHolder currentUser;

        
        while (true)
        {
            try {
                debitCardNum = Console.ReadLine();

                //check against our db
                currentUser = cardHolders.FirstOrDefault(a => a.cardNum == debitCardNum);
                if (currentUser != null) { break;}
                else {Console.WriteLine("Card not recognized. Please try again.");}
             }
            catch { Console.WriteLine("Card not recognized. Please try again"); }



        }

        Console.WriteLine("Card accepted! Please enter your pin");

        int userPin = 0;

        while (true)
        {
            try
            {
                userPin = int.Parse(Console.ReadLine());

                
                
                if (currentUser.getPin() == userPin) { break; }
                else { Console.WriteLine("Incorrect pin. Please try again."); }
            }
            catch { Console.WriteLine("Incorrect pin. Please try again"); }



        }




        Console.WriteLine("Welcome " + currentUser.getFirstName() +" :)");
        int option = 0;
        do
        {

            printOptions();
            try
            {
               option = int.Parse(Console.ReadLine());
            }
            catch { }
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else {option = 0; }

        } while (option != 4);
        Console.WriteLine("Thank you! Have a nice day!");
    }


}  




                   