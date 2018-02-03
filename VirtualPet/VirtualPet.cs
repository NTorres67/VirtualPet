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

        private string animalType = "phoenix";
        private string name = "Emmalani";
        private bool isHungry = true;
        private int boredAmount;
        private int startAmount;
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

        public int BoredAmount
        {
            get { return this.boredAmount; }
            set { this.boredAmount = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }


        // Constructors

        public VirtualPet()
        {
            this.animalType = "phoenix";
            this.name = "Emmalani";
        }

        public VirtualPet(bool isHungry, int boredAmount, bool isThirsty)
        {
            this.isHungry = isHungry;
            this.boredAmount = boredAmount;
            this.isThirsty = isThirsty;
        }


        //Methods

        // Does Emmalani need to eat?
        
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

        

        // Amount Played

        public void AmountToPlay(int playAmount)
        {
            //boredAmount -= playAmount;
            boredAmount -= playAmount;
            
        }

        // Do I need to play with Emmalani?

        public string PlayTime()
        {
            if (boredAmount >= 10)
            {
                return "I do not want to play right now.";
            }
            else if (boredAmount >= 5 )
            {
                return "Please let me out to fly around for 10 minutes.";
            }
            else
            {
                return "Please s" +
                    "et me free.";
            }
            
        }


        // Does Emmalani need water?

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

        //// Tick Method

        //public void Tick()
        //{

        //}






        //// To stop program
        //public string StopProgram;



    }
}
