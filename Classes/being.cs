using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace LivingBeings
{

    abstract public class being : MonoBehaviour
    {
        // Sizes of the being
        const int SIZE_SMALL = 1;
        const int SIZE_MED = 2;
        const int SIZE_BIG = 3;
        const int SIZE_HUGE = 4;

        // If is alive
        private bool alive = true;

        //The amount of live points
        private int HP = 100;

        // The size type of the being
        private int size_type = 0;

        // when this being was born
        public DateTime born { get; }


        // All subclasses will have to super this constructor
        public being() {
            // This is to know when it was created
            this.born = new DateTime();
            this.born = DateTime.UtcNow;
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
        public void setHP(int i) {
            this.HP = i;
            if ( this.HP <= 0 ) {
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
        public void substractHP( int i ) {
            this.HP -= i;
            if (this.HP <= 0)
            {
                this.HP = 0;
                this.killMe();
            }
        }

        // Set the size type
        public void setSizeType( int i) {
            this.size_type = i;
        }

        // Get the size type
        public int getSizeType() {
            return this.size_type;
        }

        // Get the total of seconds since the time this being was created
        public int getSecondsSinceBorn() {
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


        /*
         Abstract methods
        */

        abstract public void killAction();

    }
}