using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes.Animals
{
    

    abstract class Animal : LivingBeings.being
    {
        // The type of feed they take
        const int CARNIVOROUS = 1;
        const int HERBIVOROUS = 2;
        const int OMNIVORE = 3;

        // The type of feed of this animal
        private int feed_type = 0;

        // Eyes
        public int eyes{ get; set; }
        
        // Legs
        public int legs{ get; set; }

        // Arms
        public int arms { get; set; }

        // Set the feed type
        public void setFeedType(int f) {
            this.feed_type = f;
        }



        //  Get the feed type
        public int getFeedType() {
            return this.feed_type;
        }

    }
}
