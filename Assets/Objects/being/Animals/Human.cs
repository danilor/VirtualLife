using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LivingBeings.Animals
{
    class Human : Animal
    {
        public Human()
        {
            this.eyes = 2;
            this.legs = 2;
            this.arms = 2;
        }


        public override void killAction() {
            throw new NotImplementedException();
        }

        public override void setUp()
        {
            throw new NotImplementedException();
        }
    }


}
