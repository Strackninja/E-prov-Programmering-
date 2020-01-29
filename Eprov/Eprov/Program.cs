using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eprov
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intanser av de valbara karaktärerna, används för att kunna printa ut statsen av dessa karaktärer innan spelaren tar sitt beslut.



            // De två karaktärerna spelarna ska välja
            Superhero p1 = new Superhero();
            

            Console.WriteLine("SUPERHERO ACADEMY");
            //Sätter en delay mellan Console writeline
            Thread.Sleep(600);
            Console.WriteLine("");
            Console.WriteLine("TO CONTINUE PRESS ANY BUTTON");
            Console.ReadLine();
            // Rensar konsollen
            Console.Clear();

            Console.WriteLine("THESE ARE THE AVAILABLE CHARACTERS");
            Superhero stats1 = new Alien();
            Console.WriteLine("");
            Thread.Sleep(1000);
            Superhero stats2 = new Android();
            Console.WriteLine("");
            Thread.Sleep(1000);
            Superhero stats3 = new Human();
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Thread.Sleep(400);
            Console.WriteLine("PLAYER 1: CHOOSE YOUR CHARACTER");
            int heroanswer = Answers();

            if (heroanswer == 1)
            {
                p1 = new Alien();
            }

            else if (heroanswer == 2)
            {
                p1 = new Android();
            }

            else if (heroanswer == 3)
            {
                p1 = new Human();
            }

            Console.WriteLine("TIME TO CHOOSE A NAME FOR YOUR CHARACTER");
            string charactername = Console.ReadLine();
            p1.name = charactername;
            Console.Clear();

            Thread.Sleep(600);
            Console.WriteLine("THIS IS YOUR CHARACTERS STATS:");
            Thread.Sleep(400);
            p1.Getstats();





            Console.ReadLine();
        }
        // En metod som kontrollerar ifall spelaren väljer en siffra mellan 1-3
        // Ifall spelaren väljer en siffra som inte är mellan 1-3 kommer spelet att fråga om ett svar igen
        static int Answers()
        {
            int playerchoice = 0;//Det värde som kommer att användas i val av spelare
            string playeranswer = Console.ReadLine();//Spelarens input
            int.TryParse(playeranswer, out playerchoice);//Konverterar spelarens string input till en int
            bool correct = int.TryParse(playeranswer, out playerchoice);//Ser till att konverteringen blev korrekt

            while (correct == false || playerchoice != 1 && playerchoice != 2 && playerchoice != 3)
            {
                Console.WriteLine("Please enter a number between 1-3");

                playerchoice = 0;
                playeranswer = Console.ReadLine();
                correct = int.TryParse(playeranswer, out playerchoice);
            }

            if (playerchoice == 1)//Ifall spelaren klickar 1 kommer spelet returnera värdet 1 och välja den första spelaren
            {
                return 1;
            }
            else if (playerchoice == 2)// Samma sak fast för 2
            {
                return 2;
            }
            else if (playerchoice == 3)//Samma sak fast för 3
            {
                return 3;
            }

            return 0;

        }

    }
}
