using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(false)
        {
        }

        public override int AverageHeight => 900;
        public override string Setting => "wild";

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}
