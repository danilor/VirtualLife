using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace LivingBeings
{

    abstract public class being : MonoBehaviour
    {
        // Sizes of the being
        public const int SIZE_SMALL = 1;
        public const int SIZE_MED = 2;
        public const int SIZE_BIG = 3;
        public const int SIZE_HUGE = 4;

        // REPRODUCTION TYPES
        public const int REPRODUCTION_ASEXUAL = 1;
        public const int REPRODUCTION_SEXUAL = 2;

        // ENVIRONMENT TYPE
        public const int ENVIORONMENT_TERRESTRIAL = 1;
        public const int ENVIORONMENT_AQUATIC = 1;
        public const int ENVIORONMENT_AIR = 1;

        // If is alive
        private bool alive = true;

        //The amount of live points
        private int HP = 100;

        // The size type of the being
        private int size_type = 0;

        // when this being was born
        public DateTime born { get; }

        // The list of enviorements it feels confortable with
        public WorldElement[] enviorements { get; set; }

        // This indicates the life expectation of an animal or plant. It should be 1 minute equivalent to 
        // 1 year. So for example, if an animal lives 10 years, this value should be 10 and in the simulation 
        // should live 10 minutes
        private int life_expectation = 0;

        // This indicates the type of reproduction for this being. 
        // Per default, its 0
        private int type_of_reproduction = 0;

        // Indicates the change (%) of generate a mutation when reproducing
        private double mutate_chance = 0;

        // Food factors. Indicates the food factors of each living being, including
        // the food he "gives" when eaten
        public struct food_factor
        {
            public double food; // The factor as a food
        }

        protected food_factor foodFactor = new food_factor();


        private int enviromental_type = 0;

        // All subclasses will have to super this constructor
        public being()
        {
            // This is to know when it was created
            this.born = new DateTime();
            this.born = DateTime.UtcNow;
            this.setUp();
        }


        // Lets see if it is alive
        public bool isAlive()
        {
            return this.alive;
        }

        // Kill this being
        public void killMe()
        {
            this.HP = 0;
            this.alive = false;
            this.killAction();

        }

        // Set the HP
        public void setHP(int i)
        {
            this.HP = i;
            if (this.HP <= 0)
            {
                this.HP = 0;
                this.killMe();
            }
        }

        // Get the HP
        public int getHP()
        {
            return this.HP;
        }

        // Reduce the amount of HP. If its 0 or less then we are going to kill this being
        public void substractHP(int i)
        {
            this.HP -= i;
            if (this.HP <= 0)
            {
                this.HP = 0;
                this.killMe();
            }
        }

        // Set the size type
        public void setSizeType(int i)
        {
            this.size_type = i;
        }

        // Get the size type
        public int getSizeType()
        {
            return this.size_type;
        }

        // Get the total of seconds since the time this being was created
        public int getSecondsSinceBorn()
        {
            DateTime aux = DateTime.UtcNow;
            var seconds = (this.born < aux) ? (this.born - aux).TotalSeconds : (this.born - aux).TotalSeconds;
            return Int32.Parse(seconds.ToString());
        }

        // Get the total of minutes since the time this being was created
        public int getMinutesSinceBorn()
        {
            DateTime aux = DateTime.UtcNow;
            var minutes = (this.born < aux) ? (this.born - aux).TotalSeconds : (this.born - aux).TotalMinutes;
            return Int32.Parse(minutes.ToString());
        }

        // Get the total of hours since the time this being was created
        public int getHoursSinceBorn()
        {
            DateTime aux = DateTime.UtcNow;
            var hours = (this.born < aux) ? (this.born - aux).TotalSeconds : (this.born - aux).TotalHours;
            return Int32.Parse(hours.ToString());
        }

        // Sets the life expectation
        public void setLifeExpectation( int i ) {
            this.life_expectation = i;
        }

        // Gets the life expectations
        public int getLifeExpectation() {
            return this.life_expectation;
        }

        // Sets the reproduction type
        public void setReproductionType( int i ) {
            this.type_of_reproduction = i;
        }

        // Gets the reproduction type
        public int getReproductionType( int i ) {
            return this.type_of_reproduction = i;
        }

        // Sets the mutate change
        public void setMutateChance(double i) {
            this.mutate_chance = i;
        }

        // Gets the mutate change
        public double getMutateChange() {
            return this.mutate_chance;
        }

        // Sets the enviromental type
        public void setEnviromentalType(int i) {
            this.enviromental_type = i;
        }
        // Gets the enviromental type
        public int getEnviromentalType() {
            return this.enviromental_type;
        }

        /*
         Abstract methods
        */
        abstract public void killAction();
        // All objects should have this method and it will be used for set up all variables
        abstract public void setUp();

    }
}