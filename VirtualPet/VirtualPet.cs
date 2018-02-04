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
        private int exerciseLevel = 10;
        private int boredAmount = 100;
        private int playAmount = 0;
        private bool isThirsty = true;


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


        // Constructors

        public VirtualPet()
        {
            this.animalType = "I am the mythical phoenix.";
            this.name = "My name is Emmalani.";
            this.boredAmount = 100;
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

        ////Get Name

        //public void Name()
        //{
        //    ConsoleWrieLine()
        //}

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
            this.exerciseLevel = exerciseLevel + 3;
        }


        // To decrease exercise level
        public void EnergyDecrease()
        {
            this.exerciseLevel = exerciseLevel - 6;
        }
        

        ////// Amount Played
        
        //public void AmountToPlay()
        //{
        //    this.boredAmount = boredAmount - playAmount;
        //    //boredAmount = startAmount - playAmount;
            

        //}

        //// Coninue playing

        //public string PlayTime()
        //{
        //    if (boredAmount >= 100)
        //    {
        //        return "I do not want to play right now.";

        //    }
        //    else if (boredAmount > 50 )
        //    {
        //        return "Please let me out to fly around for 10 minutes.";
        //    }
        //    else if (boredAmount <= 49 && boredAmount >= 0)
        //    {
        //        return "Please set me free.";
        //    }
        //    else
        //    {
        //        return "";
        //    }
            
        //}


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

        // Pet Status
        public void PetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine(animalType);
            Console.WriteLine(isHungry);
            Console.WriteLine(boredAmount);
            Console.WriteLine(isThirsty);
        }
           

        // Tick Method

        //public void Tick()
        //{
        //    Random r = new int[] { 1, 2, 3, 4, 5, 6 };
        //}






        //// To stop program
        //public string StopProgram;



    }
}
