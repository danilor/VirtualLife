using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingBeings.Animals
{
    public class Wolf : Animal
    {


        public override void killAction()
        {
            //throw new NotImplementedException();
        }

        public override void setUp()
        {
            // This is according to http://animals.mom.me/life-expectancy-wolves-7898.html
            this.setLifeExpectation(10); 
            // Lets set the wolf that its reproduction is sexual
            this.setReproductionType( being.REPRODUCTION_SEXUAL ); 
            // Also, lets set up that this is carnivorous
            this.setFeedType(Animal.CARNIVOROUS);
            // Lets set the hunger
            this.setHunger( 100 );
            // Also, lets set the HP. Since we don't have any
            // biological information about it, lets have this one as a metric.
            this.setHP( 70 );
            // Now lets set the pregnancy information
            // Taken from: http://www.wolfworlds.com/wolf-reproduction/
            // The first number is the start year of pregnan capability, the second number is how much it takes to give birth
            // In this case, 2 monts of pregnancy are equivalent to 0.16
            // The last 2 numbers are the min and max values of puppies the wolf will have
            this.setPregnancy(2.00, 0.16 , 1 , 6);
            // Lets set the size of the animal (right now it doesn't matter, but to have the information. 
            // The wolf is medium size
            this.setSizeType( being.SIZE_MED);
            // Now lets setup the food factor
            this.foodFactor.food = 0.5;
            // Now set up the animal factor
            this.AnimalFactor.speed = 2; // This indicates the amount of Word squares it can run in an app cycle
            // Now lets set up the chance of mutation for this animal. %
            this.setMutateChance( 0.5 );
            // Now lets set up the enviromental type
            this.setEnviromentalType(LivingBeings.being.ENVIORONMENT_TERRESTRIAL);
            // About the sex (male or female) we are going to set it up once the 
            // real object is created
        }
    }
}
