using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World
{
    /**
     * This class is the one in charge of generating the MAP. The method "generate" 
     * should return the fully loaded map, and with that another class should construct the graphic part of it.
     * 
     * The first step is to build the map
     * 
     * */
    public class WordGenerator
    {
        // The values for width, height and deep
        private int w, h, d;

        // Added elelements
        private List<WorldElement> addedElements;

        /**
         * The available elements to put into the map
         * */
        private WorldElement[] avaliable;

        /**
         * The level of tolerance of the code. The higher the number, the more times it will
         * check the map to clean the spaces*/
        private int tolerance = 5;

        /**
         * The Map element
         * */
        private Map Map;

        // Constructor
        public WordGenerator(int w, int h, int d) {
            this.w = w;
            this.h = h;
            this.d = d;
            this.addedElements = new List<WorldElement>();
        }

        // This is the main function that will generate the map
        // This should go throught all posible map elements and randomly, put them into the map
        public Map generate() {
            this.avaliable = WorldElement.BasicWorldElements(); // We get the list of word elements
            this.Map = new Map(this.w, this.h , this.d); // We create the map object
            return this.Map;
        }


        /**
         * Returns if the MAP is full.
         * The logic is simple. We calculate how much elements we should add to have the map full, and if there are less
         * elements added than it should be, then the map is not full.
         * We can also check it agains the list of available spaces that I have to implement.
         * */

        public bool isFull()
        {
            int expected_elements_added = this.w * this.h;
            if (expected_elements_added < this.addedElements.Count)
            {
                return false;
            }
            else {
                return true;
            }
        }
    }
}
