using System;

namespace AdventureGame
{
    class Program
    {

        /*TODO
         Add more text
         Add different choices for players
         Make Health reset on game reset or fight with new monster of same type
         */
        public class Player
        {
               public static string Name;
               public static int Health = 100;
               public static int Attack = 5;
        }   
        public class Snail
        {
            public static int Health = 25;
            public static int Attack = 2;
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
            Player.Name = Console.ReadLine();
            Console.WriteLine("Go now, " + Player.Name + " and seek your fortune");
            Console.ReadLine();

            Console.WriteLine("As you leave the saftey of your village, you can't help but to feel" +
                " a little nervous.");
            Console.ReadLine();

            Console.WriteLine("You are attacked by a vicious snail!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Battle Start!");
            Console.WriteLine("");
            Console.WriteLine("Snail Health : " + Snail.Health);
            Console.WriteLine("");
            Console.WriteLine("Player Health : " + Player.Health);
            Console.ReadLine();

            while (Player.Health > 0 && Snail.Health > 0) {
                Snail.Health = Snail.Health - Player.Attack;
                Player.Health = Player.Health - Snail.Attack;
                Console.WriteLine("Snail Health : " + Snail.Health);
                Console.WriteLine("");
                Console.WriteLine("Player Health : " + Player.Health);
                

                if (Player.Health <= 0)
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
                else if (Snail.Health <= 0)
                {
                    Console.WriteLine("You won!");
                }
                Console.ReadLine();
            }

            
            
        }


    }
}
