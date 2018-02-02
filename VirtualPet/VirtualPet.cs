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
        private string name;
        private bool isHungry = true;
        private bool isBored = true;
        private bool isDirty = true;


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

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public bool IsDirty
        {
            get { return this.isDirty; }
            set { this.isDirty = value; }
        }


        // Constructors

        public VirtualPet ()
        {
            //this.animalType = "phoenix";
            //this.name = "Emmalani";
        }

        public VirtualPet(bool isHungry, bool isBored, bool isDirty)
        {
            this.isHungry = isHungry;
            this.isBored = isBored;
            this.isDirty = isDirty;
        }


        //Methods

        // Do I need to feed Emmalani
        public string FeedingTime()
        {
            if (isHungry == false)
            {
                isHungry = true;
                return "Emmalani has already been fed.";

            }
            else
            {
                return "Please feed Emmalani.";
            }
        }

        // Do I need to play with Emmalani?

        public string PlayTime()
        {
            if (isBored == false)
            {
                isBored = true;
                return "Emmalani does not want to play.";
            }
            else
            {
                return "Please throw Emmalani a stuffed animal.";
            }
        }


        // Does Emmalani's next need to be cleaned?

        public string NestCleaning()
        {
            if (isDirty == false)
            {
                isDirty = true;
                return "Emmalani's next is already clean.";
            }
            else
            {
                return "Please change Emmalani's nesting material.";
            }

        }



    }
}
