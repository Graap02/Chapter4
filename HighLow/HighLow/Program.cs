using System;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(1, 10);
            int userEntry;
            String choice;

            Console.WriteLine("Please enter a number between 1 and 10");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if(userEntry == rndNumber)
            {
                Console.WriteLine("HOW DID YOU KNOW THAT IT WAS {0}!? ARE YOU PSYCHIC?!", userEntry);
                Console.WriteLine("You got lucky kid, I want a rematch!"); //Just reply with "Yes" for this, otherwise anything else will not work
                choice = Console.ReadLine();
                if (choice.Equals("Yes")) 
                {
                    Console.WriteLine("Ok hot shot, I won't go easy this time!");
                }
                else
                {
                    Console.WriteLine("Ugh, you idiot! I wanted to win against you!");
                }
            }
            else
            {
                Console.WriteLine("{0} is wrong, HA! I knew you couldn't beat me.", userEntry);
            }
        }
    }
}
