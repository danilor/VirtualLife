using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingBeings.Animals
{
    public class Bunny : Animal
    {
        public override void killAction()
        {
            //throw new NotImplementedException();
        }

        public override void setUp()
        {
            // This is according to https://www.google.com/search?num=20&safe=off&rlz=1C1CHBF_esCR731CR731&q=life+expectancy+bunny&spell=1&sa=X&ved=0ahUKEwjC4v3vuPXTAhVM7SYKHbBiBnEQvwUIIygA
            // and http://www.bio.miami.edu/hare/scary.html
            // Home bunnies can live up to 10 years, and wild ones up to 3 years. So 4 its a good number for any bunny
            this.setLifeExpectation(4);
            // Lets set the wolf that its reproduction is sexual
            this.setReproductionType(being.REPRODUCTION_SEXUAL);
            // Also, lets set up that this is carnivorous
            this.setFeedType(Animal.HERBIVOROUS);
            // Lets set the hunger
            this.setHunger(100);
            // Also, lets set the HP. Since we don't have any
            // biological information about it, lets have this one as a metric.
            this.setHP(20);
            // Now lets set the pregnancy information
            // Taken from: https://animals.onehowto.com/article/how-long-is-a-rabbit-pregnant-before-giving-birth-1643.html
            // The first number is the start year of pregnan capability, the second number is how much it takes to give birth
            // Bunnies can have childs since the 6 month of living, that is 0.5 in the first parameter
            // In this case, 1 mont of pregnancy are equivalent to 0.1
            // The last 2 numbers are the min and max values of bunnies the bunny will have
            this.setPregnancy(0.5, 0.1, 1, 14);
            // Lets set the size of the animal (right now it doesn't matter, but to have the information. 
            // The wolf is medium size
            this.setSizeType(being.SIZE_SMALL);
            // Now lets set up the factors of food
            this.foodFactor.food = 0.8;
            // Now set up the animal factor
            this.AnimalFactor.speed = 1.5; // This indicates the amount of Word squares it can run in an app cycle
            // Now lets set up the chance of mutation for this animal. %
            this.setMutateChance(2);
            // Now lets set up the enviromental type
            this.setEnviromentalType(LivingBeings.being.ENVIORONMENT_TERRESTRIAL);
            // About the sex (male or female) we are going to set it up once the 
            // real object is created
        }
    }
}
