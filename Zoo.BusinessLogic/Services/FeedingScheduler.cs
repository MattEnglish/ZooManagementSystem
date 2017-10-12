using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public class FeedingScheduler : Scheduler
	{
		private static FeedingScheduler instance;
		public override string message { get; } = "Feeding the animals...";

		public static FeedingScheduler Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new FeedingScheduler();
				}

				return instance;
			}
		}

		private FeedingScheduler()
		{
		}

		public override void DoJob(Keeper keeper, Animal animal)
		{
			if (animal.IsHungry())
			{
				keeper.FeedAnimal(animal);
			}
		}


	}
}