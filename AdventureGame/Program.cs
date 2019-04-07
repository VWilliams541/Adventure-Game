using System;

namespace AdventureGame
{
    class Program
    {

        /*TODO
         Add more text
         Add different choices for players
         */
        public class Player
        {
               public  string Name;
               public  int Health = 100;
               public  int Attack = 5;
        }   
        public class Snail
        {
            public int Health = 25;
            public int Attack = 50;
        }
        static void Main(string[] args)
        {
        Start:
            Player P1 = new Player { };
            Console.WriteLine("Hello brave adventurer, are you prepared to embark on a journey of epic proportions?");
            Console.WriteLine("countless perils await you, but so does endless fame and fortune!");
            Console.WriteLine("");
            Console.WriteLine("(Press any key to continue)");
            Console.ReadLine();

            Console.WriteLine("Now before you go on your quest, tell me, what is your name?");
            P1.Name = Console.ReadLine();
            Console.WriteLine("Go now, " + P1.Name + " and seek your fortune");
            Console.ReadLine();

            Console.WriteLine("As you leave the saftey of your village, you can't help but to feel" +
                " a little nervous.");
            Console.ReadLine();

            Console.WriteLine("You are attacked by a vicious snail!");
            Console.ReadLine();
            Console.Clear();
            Snail S1 = new Snail { };

            Console.WriteLine("Battle Start!");
            Console.WriteLine("");
            Console.WriteLine("Snail Health : " + S1.Health);
            Console.WriteLine("");
            Console.WriteLine("Player Health : " + P1.Health);
            Console.ReadLine();

            while (P1.Health > 0 && S1.Health > 0) {
                S1.Health = S1.Health - P1.Attack;
                P1.Health = P1.Health - S1.Attack;
                Console.WriteLine("Snail Health : " + S1.Health);
                Console.WriteLine("");
                Console.WriteLine("Player Health : " + P1.Health);
                

                if (P1.Health <= 0)
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
                else if (S1.Health <= 0)
                {
                    Console.WriteLine("You won!");
                }
                Console.ReadLine();
            }

            
            
        }


    }
}
