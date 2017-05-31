using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingBeings.Animals
{
    abstract public class Animal : LivingBeings.being
    {
        // The type of feed they take
        public const int CARNIVOROUS = 1;
        public const int HERBIVOROUS = 2;
        public const int OMNIVORE = 3;

        // The sex of the animal

        const int SEX_MALE = 1;
        const int SEX_FEMALE = 2;

        // The type of feed of this animal
        private int feed_type = 0;

        // The sex type
        public int sex_type = 0;

        // In hunger, 100 means its full. Near 0% means is starving
        private int hunger = 0;

        // The energy of the animal
        private int energy = 100;

        // This indicates the reproduction rata of this being
        // This indicates when the pregnancy can start, and how much time it took
        private double pregnancy_start = 0.0;
        private double pregnancy_length = 0.0;
        private int pregnancy_change_min = 0;
        private int pregnancy_change_max = 0;

        // Eyes
        public int eyes { get; set; }

        // Legs
        public int legs { get; set; }

        // Arms
        public int arms { get; set; }

        // Indicares differente status of the animal
        protected struct statuses
        {
            public bool pregnant , sleeping, sick ;
        }
        statuses Statuses = new statuses();

        // Animal factors
        protected struct animal_factor {
            public double speed;
        }
        protected animal_factor AnimalFactor = new animal_factor();

        // Set the feed type
        public void setFeedType(int f)
        {
            this.feed_type = f;
        }

        //  Get the feed type
        public int getFeedType()
        {
            return this.feed_type;
        }

        // Set the sex type
        public void setSexType(int i) {
            this.sex_type = i;
        }

        // get the sex type
        public int getSexType()
        {
            return this.sex_type;
        }

        // get the hunger
        public int getHunger() {
            return this.hunger;
        }

        // Set the hunger
        public void setHunger(int i) {
            this.hunger = i;
        }

        // it will eat a porcent of its hunger. If it reach more than 100%, it will be reduce to 100
        public void eat(int i) {
            this.hunger += i;
            if (this.hunger > 100) {
                this.hunger = 100;
            }
        }

        // It will reduce the hunger. If it drops to 0 or less, it will die. It will return true if if is still alive or false if it dies
        public bool reduceHunger( int i ) {
            this.hunger -= i;
            if (this.hunger <= 0)
            {
                this.killMe();
                return false;
            }
            else {
                return true;
            }
        }

        // It sets all information about the pregnancy
        public void setPregnancy(double start, double length, int min, int max)
        {
            this.pregnancy_start = start;
            this.pregnancy_length = length;
            this.pregnancy_change_min = min;
            this.pregnancy_change_max = max;
        }

        // Gets the pregnancy start value
        public double getPregnancyStart()
        {
            return this.pregnancy_start;
        }

        // Gets the pregnancy length value
        public double getPregnancyLength()
        {
            return this.pregnancy_length;
        }
        // Gets the pregnancy change min value
        public int getPregnancyChangeMin() {
            return this.pregnancy_change_min;
        }
        // Gets the pregnancy change max value
        public int getPregnancyChangeMax()
        {
            return this.pregnancy_change_max;
        }
        // Sets the energy
        public void setEnergy(int i) {
            this.energy = i;
        }
        //Gets the energy of the animal
        public int getEnergy() {
            return this.energy;
        }
        // Returns if this animal is pregnant
        public bool isPregnant() {
            return this.Statuses.pregnant;
        }

    }
}
