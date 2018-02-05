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

            int playAmount = 0;
            int sitAmount = 0;
            int napTimeAmount = 0;


            do
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Aloha! Welcome to the Virtual Pet application.");
                Console.WriteLine("What would you like to do today?");
                Console.WriteLine("To get your pets name, type 1");
                Console.WriteLine("To get your pets animal type, type 2");
                Console.WriteLine("To feed your pet, type 3");
                Console.WriteLine("To increase your pet's energy level, type 4");
                Console.WriteLine("To decrease your pets's energy level, type 5");
                //Console.WriteLine("To continue exercising your pet, type 5");
                //Console.WriteLine("");
                Console.WriteLine("To water your pet, type 6 ");
                Console.WriteLine("To increase your pet's need to rest, type 7.");
                Console.WriteLine("To decrease your pet's need to rest, type 8.");
                Console.WriteLine("To quit, type 0");
                Console.WriteLine("");
                Console.WriteLine("");

                userInput = int.Parse(Console.ReadLine());

                //int boredAmount = 100;
                //int playAmount = 0;

                //userVirtualPet.PetStatus();

                switch (userInput)
                {
                    case 1:
                        // declare pet name
                        Console.WriteLine(userVirtualPet.Name);
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        break;

                    case 2:
                        // declare pet type
                        Console.WriteLine(userVirtualPet.AnimalType);
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        break;

                    case 3:
                        // To feed
                        Console.WriteLine("Should I be fed? Type \"true\" or \"false\".");
                        feedMe = Console.ReadLine();
                        feedMe = feedMe.ToLower();
                        Console.WriteLine(userVirtualPet.FeedingTime());
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        break;

                    case 4:
                        // To increase exercise level
                        Console.WriteLine("How much energy would you like increase your pet's energy level by?");
                        playAmount = int.Parse(Console.ReadLine());
                        userVirtualPet.EnergyIncrease();
                        Console.WriteLine(userVirtualPet.PlayTime());
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();

                        ////Amount You want to play
                        //Console.WriteLine("Amount to exercise? Please enter a numberical value.");
                        //playAmount = int.Parse(Console.ReadLine());
                        break;
                        

                    case 5:
                        // To decrease exercise level
                        Console.WriteLine("How much would you like to decrease your pet's energy level by?");
                        sitAmount = int.Parse(Console.ReadLine());
                        userVirtualPet.EnergyDecrease();
                        Console.WriteLine(userVirtualPet.PlayTime());
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        
                        //    //// Does Emmalani want to play?
                        //    //Console.WriteLine("Do you want to play with me? Please enter a numberical value.");
                        //    //playAmount = int.Parse(Console.ReadLine());
                        //    Console.WriteLine(userVirtualPet.PlayTime());
                        //    Console.WriteLine("");
                        break;

                    case 6:
                        // Does Emmalani need water?
                        Console.WriteLine("Should I be given water? Type \"True\" or \"false\".");
                        waterMe = Console.ReadLine();
                        Console.WriteLine(userVirtualPet.WateringTime());
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        break;

                    case 7:
                        // increase rest level
                        Console.WriteLine("How much would you like to increase your pet's need to rest level by?");
                        napTimeAmount = int.Parse(Console.ReadLine());
                        userVirtualPet.RestIncrease();
                        Console.WriteLine("May I please take a nap?");
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        break;

                    case 8:
                        // decrease rest level
                        Console.WriteLine("How much would you like to decrease your pet's need to rest level by?");
                        napTimeAmount = int.Parse(Console.ReadLine());
                        userVirtualPet.RestDecrease();
                        Console.Write("But I don't want to nap!");
                        Console.WriteLine("");
                        //userVirtualPet.PetStatus();
                        break;

                    
                        
                    // determine if user would like to continue

                    case 0:
                        Console.WriteLine("Thanks for playing with me today!");
                        Console.ReadLine();
                        Console.WriteLine();
                        break;

                }

                Console.WriteLine("");
                userVirtualPet.Tick();
                //Console.WriteLine(userVirtualPet.PlayTime());
                userVirtualPet.PetStatus();


            } while (userInput != 0);

            

        }
    }
}
