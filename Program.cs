using System;
using System.Text;

namespace C_Sharp_User_Input
{
    class C_Sharp_User_Input
    {
        static void Number_Guesser()
        {
            Random rnd = new Random();
            int Random_Number = rnd.Next(1, 100);
            Console.WriteLine(Random_Number);
            Console.WriteLine("Please enter your first guess");
            int Guess1 = int.Parse(Console.ReadLine());
            if (Guess1 == Random_Number)
            {
                Console.WriteLine("Youve guessed the correct number!");
            }
            else if (Guess1 != Random_Number)
            {
                while (Guess1 != Random_Number)
                {
                    Console.WriteLine("Try again...");
                    Guess1 = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Youve guessed the correct number!");
        }

        static void Username_Creator()
        {
            Console.WriteLine("Please enter your first and last name");
            string[] Name = Console.ReadLine().ToLower().Split(" ");
            Console.WriteLine("Please enter your date of birth in the form at dd/mm/yyyy...");
            Console.WriteLine("Suggested usernames are: " + Name[0] + Name[1] + Console.ReadLine().Remove(1, 6) + ", " + Name[0] + Name[1] + "_1" + ", XxX" + Name[1] + Name[0] + "XxX");
        }

        static void Automatic_Dispenser()
        {
            Console.WriteLine("Please enter what time of the day it is, breakfast, lunch or dinner...");
            string TOM = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the amount of hoppers of food desired...");
            int NOH = int.Parse(Console.ReadLine());
            if (TOM == "dinner")
            {
                Console.WriteLine(NOH + " dispenses of Hopper 1 has been dropped for dinner aswell as " + NOH + " dispenses of hopper 2");
            }
            else if (TOM == "lunch")
            {
                Console.WriteLine(NOH + " dispenses of Hopper 2 has been dropped for lunch");
            }
            else if (TOM == "breakfast")
            {
                Console.WriteLine(NOH + " dispenses of hopper 1 has been dropped for breakfast");
            }
            else
            {
                Console.WriteLine("Ive never heard of that meal time.");
            }
        }

        static void General_Conversion()
        {
            Console.WriteLine("Enter 1 for metres to feet \nEnter 2 for kilograms to pounds \nEnter 3 for grams to ounces");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please enter how many metres you wish to convert to feet...");
                Console.WriteLine(double.Parse(Console.ReadLine()) * 3.28 + "ft");
            }
            if (choice == 2)
            {
                Console.WriteLine("Please enter the amount of kilograms you wish to convert to pounds...");
                Console.WriteLine(double.Parse(Console.ReadLine()) * 2.2046 + "lb");
            }
            if (choice ==3)
            {
                Console.WriteLine("Please enter the amount of grams you wish to convert to ounces");
                Console.WriteLine(double.Parse(Console.ReadLine()) * 0.035 + "oz");
            }
        }

        static void Pin(int attempts = 2)
        {
            Console.WriteLine("Please start by saving a pin...");
            int PIN = int.Parse(Console.ReadLine());
            Console.WriteLine("Okay now you must login with your saved pin...");
            int Guessed_PIN = int.Parse(Console.ReadLine());
            if (Guessed_PIN == PIN)
            {
                Console.WriteLine("Welcome.");
            }
            while (Guessed_PIN != PIN && attempts > 0)
            {
                Console.WriteLine($"You have {attempts} more attempts.");
                Guessed_PIN = int.Parse(Console.ReadLine());
                attempts = attempts - 1;
                if (Guessed_PIN == PIN)
                {
                    Console.WriteLine("Welcome.");

                }
                else if (attempts == 0)
                {
                    Console.WriteLine("PIN locked.");
                }
            }
        }

        static void Adder()
        {
            List<float> Number_List = new List<float>();
            Console.WriteLine("Please begin by entering a number and when you wish to stop adding numbers simply do not enter anything...");
            while (Console.ReadLine() is { } v && !String.IsNullOrWhiteSpace(v) && float.TryParse(v, out var f))
            {
                Number_List.Add(f);
            }
            if (Number_List.Count() == 0)
            {   }
            else
            {
                Console.WriteLine("The highest number = " + Number_List.Max() + "\nThe sum of all the numbers added together = " + Number_List.Sum() + "\nThe average number = " + Number_List.Sum() / Number_List.Count());
            }
        }

        static void ValidPassword()
        {
            Console.WriteLine("please enter your password");
            string password = Console.ReadLine();
            if (password.Length >= 8 && password != password.ToLower() && password != password.ToUpper())
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }

        static void CarparkTicketCost()
        {
            Console.WriteLine("When did you arrive to the carpark in 24hr clock: ");
            int arriveTime = (int)Math.Ceiling(float.Parse(Console.ReadLine()));
            Console.WriteLine("When did you leave the carpark in 24hr clock: ");
            int leavingTime = (int)Math.Ceiling(float.Parse(Console.ReadLine()));
            Console.WriteLine("Are you a blue badge holder? Y/N");
            if (char.Parse(Console.ReadLine().ToLower()) == 'y' && Math.Abs(leavingTime - arriveTime) <= 3) { Console.WriteLine("Your stay was free."); }
            else if (arriveTime > 20 && leavingTime < 6){ Console.WriteLine("Your stay was free."); }
            else if (Math.Abs(leavingTime - arriveTime) == 1) { Console.WriteLine("You need to pay: £1.50"); }
            else if (Math.Abs(leavingTime - arriveTime) == 2) { Console.WriteLine("You need to pay: £2.90"); }
            else if (Math.Abs(leavingTime - arriveTime) == 3) { Console.WriteLine("You need to pay: £3.90"); }
            else if (Math.Abs(leavingTime - arriveTime) == 4) { Console.WriteLine("You need to pay: £4.50"); }
            else if (Math.Abs(leavingTime - arriveTime) > 4) { Console.WriteLine("You need to pay: £8"); }
        }

        static void RockPaperScissors()
        {
            Console.WriteLine("Rock, Paper, Scissor, SHOOT!");
            string user_Choice = Console.ReadLine().ToLower();
            Random rnd = new Random();
            int computer_Choice = rnd.Next(1, 3);
            if (computer_Choice == 1 && user_Choice == "scissors") { Console.WriteLine($"The Computer has chosen rock meaning you have lost"); }
            if (computer_Choice == 1 && user_Choice == "rock") { Console.WriteLine($"The Computer has chosen rock meaning you have drew"); }
            if (computer_Choice == 1 && user_Choice == "paper") { Console.WriteLine($"The Computer has chosen rock meaning you have won"); }
            if (computer_Choice == 2 && user_Choice == "scissors") { Console.WriteLine($"The Computer has chosen paper meaning you have won"); }
            if (computer_Choice == 2 && user_Choice == "rock") { Console.WriteLine($"The Computer has chosen paper meaning you have lost"); }
            if (computer_Choice == 2 && user_Choice == "paper") { Console.WriteLine($"The Computer has chosen paper meaning you have drew"); }
            if (computer_Choice == 3 && user_Choice == "scissors") { Console.WriteLine($"The Computer has chosen scissors meaning you have drew"); }
            if (computer_Choice == 3 && user_Choice == "rock") { Console.WriteLine($"The Computer has chosen scissors meaning you have won"); }
            if (computer_Choice == 3 && user_Choice == "paper") { Console.WriteLine($"The Computer has chosen scissors meaning you have lose"); }
        }

        static void Main()
        {
            Console.WriteLine("Enter 1 for number guesser, enter 2 for username creator, enter 3 for automatic dispense, enter 4 for general metric to imperial conversions, enter 5 for pin, enter 6 for adder, enter 7 for password checker, enter 8 for carpark ticket cost, enter 9 for rock paper scissors");
            int Decision = int.Parse(Console.ReadLine());
            if (Decision == 1)
            {
                Number_Guesser();
                Console.ReadLine();
            }
            if (Decision == 2)
            {
                Username_Creator();
                Console.ReadLine();
            }
            if (Decision == 3)
            {
                Automatic_Dispenser();
                Console.ReadLine();
            }
            if (Decision == 4)
            {
                General_Conversion();
                Console.ReadLine();
            }
            if (Decision == 5)
            {
                Pin();
                Console.ReadLine();
            }
            if (Decision == 6)
            {
                Adder();
                Console.ReadLine();
            }
            if (Decision == 7)
            {
                ValidPassword();
                Console.ReadLine();
            }
            if (Decision == 8)
            {
                CarparkTicketCost();
                Console.ReadLine();
            }
            if (Decision == 9)
            {
                RockPaperScissors();
                Console.ReadLine();
            }
        }
    }
}