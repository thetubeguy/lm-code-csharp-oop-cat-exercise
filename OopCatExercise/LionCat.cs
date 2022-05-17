using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class LionCat : Cat
    {
        public LionCat() : base(false)
        {
        }

        public override int AverageHeight => 1100;
        public override string Setting => "wild";

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}
