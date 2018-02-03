using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        //private static string playAgain;

        static void Main(string[] args)
        {
            // Create a VirtualPet
            // Promt user to decide what activities to participate in
            // Call methods on VirtualPet object to do what the user wants

            int userInput;

            VirtualPet userVirtualPet = new VirtualPet();

            string feedMe = " ";
            string waterMe = " ";


            int boredAmount = 10;
            int playAmount = 0;

            do
            {
                Console.WriteLine("Aloha! Welcome to the Virtual Pet application.");
                Console.WriteLine("");
                Console.WriteLine("My name is Emmalani and I am a mythical phoenix!");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("");
                Console.WriteLine("To determine if I need to be fed, type l");
                Console.WriteLine("");
                Console.WriteLine("To determine amount played, type 2");
                Console.WriteLine("");
                Console.WriteLine("To determine if I want to play, type 3");
                Console.WriteLine("");
                Console.WriteLine("To determine if I need water, type 4 ");
                Console.WriteLine("");
                Console.WriteLine("To quit, type 5");
                Console.WriteLine("");

                userInput = int.Parse(Console.ReadLine());


                
                

                switch (userInput)
                {
                    case 1: 
                        // Does Emmalani need food?
                        Console.WriteLine("Is Emmalani hungry? Type \"true\" or \"false\".");
                        feedMe = Console.ReadLine();
                        feedMe = feedMe.ToLower();
                        Console.WriteLine(userVirtualPet.FeedingTime());
                        Console.WriteLine("");
                        break;

                    case 2: 
                        // Amount Played
                        Console.WriteLine("How long do you want to play with me? Please enter a value between 0 and 10.");
                        playAmount = int.Parse(Console.ReadLine());
                        break;

                    case 3: 
                        // Does Emmalani want to play?
                        //Console.WriteLine("How long do you want to play with me? Please enter a value between 1 and 10.");
                        //playAmount = int.Parse(Console.ReadLine());
                        Console.WriteLine(userVirtualPet.PlayTime());
                        Console.WriteLine("");
                        break;

                    case 4: 
                        // Does Emmalani need water?
                        Console.WriteLine("Is Emmalani thirsty? Type \"True\" or \"false\".");
                        waterMe = Console.ReadLine();
                        Console.WriteLine(userVirtualPet.WateringTime());
                        Console.WriteLine("");
                        break;

                    // determine if user would like to continue

                    case 5:
                        Console.WriteLine("Thanks for playing with me today.");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;
                }
                Console.WriteLine("");



            } while (userInput != 5);
            


        }
    }
}
