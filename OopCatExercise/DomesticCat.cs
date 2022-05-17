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
            Random r1 = new Random();
            int _randnum = r1.Next(5);
            if (_randnum == 3)
                return "It will do I suppose";
            else
                return "Purrrrrrr";
        }
    }


}
