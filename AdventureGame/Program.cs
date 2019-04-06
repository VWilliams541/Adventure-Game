using System;

namespace AdventureGame
{
    class Program
    {
        public class Player
        {
               public static string PlayerName;
               public static int PlayerHealth = 100;
               public static int PlayerAttack = 5;
        }   
        public class Snail
        {
            public static int SnailHealth = 25;
            public static int SnailAttack = 2;
        }
        static void Main(string[] args)
        { 
            Start:
            Console.WriteLine("Hello brave adventurer, are you prepared to embark on a journey of epic proportions?");
            Console.WriteLine("countless perils await you, but so does endless fame and fortune!");
            Console.WriteLine("");
            Console.WriteLine("(Press any key to continue)");
            Console.ReadLine();

            Console.WriteLine("Now before you go on your quest, tell me, what is your name?");
            Player.PlayerName = Console.ReadLine();
            Console.WriteLine("Go now, " + Player.PlayerName + " and seek your fortune");
            Console.ReadLine();

            Console.WriteLine("As you leave the saftey of your village, you can't help but to feel" +
                "a little nervous.");
            Console.ReadLine();

            Console.WriteLine("You are attacked by a vicious snail!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Battle Start!");
            Console.WriteLine("");
            Console.WriteLine("Snail Health : " + Snail.SnailHealth);
            Console.WriteLine("");
            Console.WriteLine("Player Health : " + Player.PlayerHealth);
            Console.ReadLine();

            while (Player.PlayerHealth > 0 && Snail.SnailHealth > 0) {
                Snail.SnailHealth = Snail.SnailHealth - Player.PlayerAttack;
                Player.PlayerHealth = Player.PlayerHealth - Snail.SnailAttack;
                Console.WriteLine("Snail Health : " + Snail.SnailHealth);
                Console.WriteLine("");
                Console.WriteLine("Player Health : " + Player.PlayerHealth);
                

                if (Player.PlayerHealth <= 0)
                {
                    Console.WriteLine("You died!");
                    Console.WriteLine("Would you like to start again?");
                    string Answer = Console.ReadLine();
                    if(Answer == "yes")
                    {
                        goto Start;
                    }
                    else
                    {
                        break;
                    }
               
                }
                else if (Snail.SnailHealth <= 0)
                {
                    Console.WriteLine("You won!");
                }
                Console.ReadLine();
            }

            
            
        }


    }
}
