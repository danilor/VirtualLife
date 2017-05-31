using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace World
{
    public class Map
    {
        /**
         * This will hold the full MapStructure
         * */
        public WorldElement[,] MapStructure;

        /**
         * Constructor
         * It reads the width, the height and the deep.
         * The deep is still not being used, but in the future we will use it.
         * */
        public Map(int w , int h , int d) {
            this.MapStructure = new WorldElement[w,h];
        }


    }
}
