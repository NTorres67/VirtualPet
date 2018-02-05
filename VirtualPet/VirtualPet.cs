using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        // fields

        private string animalType;
        private string name;
        private bool isHungry = true;
        private int exerciseLevel = 0;
        private int boredAmount = 100;
        private int playAmount = 0;
        private bool isThirsty = true;
        private int restLevel = 50;



        // Properties

        public string AnimalType
        {
            get { return this.animalType; }

        }

        public string Name
        {
            get { return this.name; }
        }

        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public int ExerciseLevel
        {
            get { return this.exerciseLevel; }
            set { this.exerciseLevel = value; }
        }

        public int BoredAmount
        {
            get { return this.boredAmount; }
            set { this.boredAmount = value; }
        }

        public int PlayAmount
        {
            get { return this.playAmount; }
            set { this.playAmount = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public int RestLevel
        {
            get { return this.restLevel; }
            set { this.restLevel = value; }
        }


        // Constructors

        public VirtualPet()
        {
            this.animalType = "I am the mythical phoenix.";
            this.name = "Aloha! My name is Emmalani.";
            this.boredAmount = 100;
            this.exerciseLevel = 100;
            this.restLevel = 100;
        }

        public VirtualPet(string name, string animalType)
        {
            this.name = name;
            this.animalType = animalType;
        }
        
        public VirtualPet(bool isHungry, int boredAmount, bool isThirsty)
        {
            this.isHungry = isHungry;
            this.boredAmount = boredAmount;
            this.isThirsty = isThirsty;
        }


        //Methods

        
        // To Feed

        public string FeedingTime()
        {
            if (isHungry == false)
            {
                isHungry = true;
                return "Thank you but I already ate.";
            }
            else if (isHungry == true)
            {
                isHungry = false;
                return "Please feed me.";
            }
            else
            {
                return "";
            }
        }

        // To increase exercise level

        public void EnergyIncrease()
        {
            this.exerciseLevel = exerciseLevel + 23;
            this.restLevel = restLevel - 15;
        }


        // To decrease exercise level
        public void EnergyDecrease()
        {
            this.exerciseLevel = exerciseLevel - 16;
            this.restLevel = restLevel + 20;
        }


        ////// Amount Played

        //public void AmountToPlay()
        //{
        //    this.boredAmount = boredAmount - playAmount;
        //    //boredAmount = startAmount - playAmount;


        //}

        //// Coninue playing

        public string PlayTime()
        {
            if (exerciseLevel >= 100)
            {
                return "I do not want to play right now.";

            }
            else if (exerciseLevel > 50)
            {
                return "Please let me out to fly around for 10 minutes.";
            }
            else if (exerciseLevel <= 49 && boredAmount >= 0)
            {
                return "Please set me free.";
            }
            else
            {
                return "";
            }

        }


        // To Water

        public string WateringTime()
        {
            if (isThirsty == false)
            {
                isThirsty = true;
                return "Not thirsty thanks.";
            }
            else if (isThirsty == true)
            {
                isThirsty = false;
                return "May I have something to drink?";
            }
            else
            {
                return "";
            }
            

        }

        // increase need to rest

        public void RestIncrease()
        {
            this.restLevel = restLevel + 16;
            this.exerciseLevel = exerciseLevel - 28;
        }

        // decrease need to rest
        public void RestDecrease()
        {
            this.restLevel = restLevel - 22;
            this.exerciseLevel = exerciseLevel - 5;
        }

        // Pet Status
        public void PetStatus()
        {
            //Console.WriteLine("");
            Console.WriteLine("My current status:");
            //Console.WriteLine("I am hungry. " + isHungry);
            Console.WriteLine("My energy level is " + exerciseLevel + ".");
            //Console.WriteLine("I am thirsty. " + isThirsty);
            Console.WriteLine("My need to rest level is " + restLevel + ".");
            Console.WriteLine("");
        }


        // Tick Method

        public void Tick()
        {
            //Increase Energy Level

            exerciseLevel = exerciseLevel + 5;
            restLevel = restLevel - 11;

        }

        ////public void Tick() // NOPE!
        ////{
        ////    Random random = new Random();
        ////    int[] triggerArray = new int[25];
        ////    for (int t = 0; t < 5; t++)
        ////    {
        ////        triggerArray[t] = random.Next(1, 30);
        ////    }
            
        ////}








        //// To stop program
        //public string StopProgram;



    }
}
