using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public class GroomingScheduler: Scheduler
	{
		private static GroomingScheduler instance;

		public override string message { get; } = "Grooming the animals...";

		public static GroomingScheduler Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new GroomingScheduler();
				}

				return instance;
			}
		}

		private GroomingScheduler()
		{
		}

		public override void DoJob(Keeper keeper, Animal animal)
		{

			var groomableAnimal = animal as AnimalThatCanBeGroomed;

			if (groomableAnimal != null)
			{
				keeper.GroomAnimal(groomableAnimal);
			}
		}


	}
}