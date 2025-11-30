using System;

class Program
{
    static void Main()
    {
        bool running = true;
        Banking bank = null;
        int input;

        while (running == true)
        {

            Console.WriteLine("What would u Like to Do ? ");
            Console.WriteLine("[1] Create Bank");
            Console.WriteLine("[2] Withdraw");
            Console.WriteLine("[3] Deposit");
            Console.WriteLine("[4] Watch");
            Console.WriteLine("[5] Exit");

            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Give your Bank a Name : ");
                string bankName = Console.ReadLine();
                bank = new Banking(bankName, 5000);
                Console.Clear();
                Console.WriteLine($"Bank '{bankName}' was created with $5000!");

            }
            else if (input == 2)
            {
                if (bank == null)
                {
                    Console.Clear();
                    Console.WriteLine("You must create a bank first!");
                    continue;
                }
                Console.Clear();

                Console.WriteLine("Withdraw Amout: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                bank.Withdraw(amount);
            }
            else if (input == 3)
            {
                if (bank == null)
                {
                    Console.Clear();
                    Console.WriteLine("You must create a bank first!");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("Deposit Amout: ");
                int amount = Convert.ToInt32(Console.ReadLine());
                bank.Deposit(amount);
            }
            else if (input == 4)
            {
                if (bank == null)
                {
                    Console.Clear();
                    Console.WriteLine("You must create a bank first!");
                    continue;
                }
                Console.Clear();
                bank.Watch();
            }
            else if (input == 5)
            {
                Console.Clear();
                running = false;
                Console.WriteLine("GoodBye!");
            }

        }

    }
}
class Banking
{
    private int startingcredit;
    public string Name;


    public Banking(string name, int value)
    {
        Name = name;
        startingcredit = value;
    }
    public void Withdraw(int value)
    {
        if (value > startingcredit)
        {
            Console.WriteLine("Not enough credit");
            return;
        }
        if (value <= 0)
        {
            Console.WriteLine("Invalid amount");
            return;
        }

        startingcredit -= value;
        Console.WriteLine($"You have just withdrawn ${value} ");
        Console.WriteLine($"New Balance : ${startingcredit}");
    }
    public void Deposit(int value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Unavailable");
            return;
        }
        startingcredit += value;
        Console.WriteLine($"You have just deposited ${value}");
        Console.WriteLine($"New Balance : ${startingcredit}");
    }
    public void Watch()
    {
        Console.WriteLine($"Balance : ${startingcredit}");
    }
}