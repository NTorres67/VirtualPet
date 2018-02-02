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
        private int isHungry;
        private int isBored;
        private int isThirsty;


        // Properties

        public string AnimalType
        {
            get { return this.animalType; }

        }

        public string Name
        {
            get { return this.name; }
        }

        public int IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public int IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public int IsThirsty
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

        public VirtualPet(int isHungry, int isBored, int isThirsty)
        {
            this.isHungry = isHungry;
            this.isBored = isBored;
            this.isThirsty = isThirsty;
        }


        //Methods

        // Do I need to feed Emmalani?
        public string FeedingTime()
        {
            if (isHungry >= 10)
            {
                return "already fed";

            }
            else if (isHungry > 5)
            {
                return "feed half portion";
            }
            else
            {
                return "feed full portion";
            }
        }

        // Do I need to play with Emmalani?

        public string PlayTime()
        {
            if (isBored >= 10)
            {
                return "Emmalani does not want to play.";
            }
            else if (isBored >5)
            {
                return "Please let Emmalani out to fly around for 10 minutes.";
            }
            else
            {
                return "Please let Emmalani out to fly around for 60 minutes.";
            }
            
        }


        // Does Emmalani's nest need to be cleaned?

        public string WateringTime()
        {
            if (isThirsty >= 10)
            {
                
                return "not thirsty";
            }
            else if (isThirsty > 5)
            {
                return "give 1 cup of water";
            }
            else
            {
                return "give 1 gallon of water";
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
