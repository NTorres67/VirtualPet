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



            do
            {
                Console.WriteLine("");
                Console.WriteLine("Aloha! Welcome to the Virtual Pet application.");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("");
                Console.WriteLine("To get name, type 1");
                Console.WriteLine("");
                Console.WriteLine("To get pet type, type 2");
                Console.WriteLine("");
                Console.WriteLine("To feed your pet, type 3");
                Console.WriteLine("");
                Console.WriteLine("To exercise your pet, type 4 or 5");
                Console.WriteLine("");
                //Console.WriteLine("To continue exercising your pet, type 5");
                //Console.WriteLine("");
                Console.WriteLine("To water your pet, type 6 ");
                Console.WriteLine("");
                //Console.WriteLine("To    , type 7.");
                //Console.WriteLine("");
                Console.WriteLine("To obtain pet status, type 8");
                Console.WriteLine("");
                Console.WriteLine("To quit, type 0");
                Console.WriteLine("");

                userInput = int.Parse(Console.ReadLine());

                //int boredAmount = 100;
                //int playAmount = 0;

                userVirtualPet.PetStatus();

                switch (userInput)
                {
                    case 1:
                        // declare pet name
                        Console.WriteLine(userVirtualPet.Name);
                        break;

                    case 2:
                        // declare pet type
                        Console.WriteLine(userVirtualPet.AnimalType);
                        break;

                    case 3:
                        // To feed
                        Console.WriteLine("Should I be fed? Type \"true\" or \"false\".");
                        feedMe = Console.ReadLine();
                        feedMe = feedMe.ToLower();
                        Console.WriteLine(userVirtualPet.FeedingTime());
                        Console.WriteLine("");
                        break;

                    case 4:
                        // To increase exercise level
                        userVirtualPet.EnergyIncrease();
                        Console.WriteLine("Please exercise your pet.");

                        ////Amount You want to play
                        //Console.WriteLine("Amount to exercise? Please enter a numberical value.");
                        //playAmount = int.Parse(Console.ReadLine());
                        break;
                        

                    case 5:
                        // To decrease exercise level
                        userVirtualPet.EnergyDecrease();
                        Console.WriteLine("Please allow your pet to rest.");

                        //    //// Does Emmalani want to play?
                        //    //Console.WriteLine("Do you want to play with me? Please enter a numberical value.");
                        //    //playAmount = int.Parse(Console.ReadLine());
                        //    Console.WriteLine(userVirtualPet.PlayTime());
                        //    Console.WriteLine("");
                        break;

                    case 6:
                        // Does Emmalani need water?
                        Console.WriteLine("Should I be watered? Type \"True\" or \"false\".");
                        waterMe = Console.ReadLine();
                        Console.WriteLine(userVirtualPet.WateringTime());
                        Console.WriteLine("");
                        break;

                    case 7:
                        // To be determined
                        break;

                    case 8:
                        // To get pet status
                        //Console.WriteLine(userVirtualPet.PetStatus);
                        break;



                    // determine if user would like to continue

                    case 0:
                        Console.WriteLine("Thanks for playing with me today!");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;

                }
                Console.WriteLine("");



            } while (userInput != 0);
            


        }
    }
}
