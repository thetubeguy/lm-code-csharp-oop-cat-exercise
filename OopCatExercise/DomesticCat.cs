using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise
{
    public class DomesticCat : Cat
    {
        public DomesticCat() : base(false)
        {
        }

        public override int AverageHeight => 23;
        public override string Setting => "domestic";

        public override string Eat()
        {
            return "Purrrrrrr";
        }
    }


}
