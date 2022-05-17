using System;
namespace OopCatExercise
{
	public abstract class Cat : ICat
	{
		public Boolean IsAsleep { get; set; }
		public abstract int AverageHeight { get; }
		public abstract string Setting { get; }

		public Cat(Boolean isasleep)
        {
			IsAsleep = isasleep;	

        }

		public abstract string Eat();
		
		public void WakeUp()
        {
			this.IsAsleep = false;
		}
		public void GoToSleep()
        {
			this.IsAsleep = true;
	
        }
	}
}
