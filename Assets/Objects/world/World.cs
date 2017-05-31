using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace World
{

    public class World /*: MonoBehaviour*/
    {

        // The default sizes. We are choosing small values to increase performance. In the future
        // we will determine if we need to increase this values
        private int size_height = 20, size_width = 20, size_deep = 5;

        // when this being was born
        public DateTime born { get; }

        private double version = 0.2;

        private WorldElement[,] MapElements;

        // Use this for initialization
        // This will work as a constructor (sadly)
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        // Sets the height
        public void setHeight(int i)
        {
            this.size_height = i;
        }
        // gets the height
        public int getHeight()
        {
            return this.size_height;
        }
        //Sets the width
        public void setWidth(int i)
        {
            this.size_width = i;
        }
        //Gets the width
        public int getWidth()
        {
            return this.size_width;
        }
        //sets the deep
        public void setDeep(int i)
        {
            this.size_deep = i;
        }
        //Gets the deep
        public int getDeep()
        {
            return this.size_height;
        }


        // This will initialize the map elements
        public void initializeMapElements()
        {
            this.MapElements = new WorldElement[this.getWidth(), this.getHeight()];
            for (int i = 0; i < this.getWidth(); i++)
            {
                for (int j = 0; j < this.getHeight(); j++)
                {
                    // We search every element.
                    // TODO; add the logic to create the map structure
                }
            }
        }

        // This method will fill the map with everything it needs.
        public void fillMap()
        {
            WordGenerator generator = new WordGenerator(this.size_width, this.size_height, this.size_deep);
            generator.generate();
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

        // Get the current version
        public double getVersion()
        {
            return this.version;
        }

        // Get the version as string
        public string getVersionString()
        {
            return this.version.ToString();
        }
    }

}