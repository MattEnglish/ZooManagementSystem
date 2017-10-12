using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
	public abstract class Scheduler
	{
		public abstract string message { get; }

		public virtual void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
		{
			foreach (var keeper in keepers)
			{
				foreach (var animal in keeper.GetResponsibleAnimals())
				{
					DoJob(keeper, animal);
				}
			}

		}

		public abstract void DoJob(Keeper keeper, Animal animal);

	}
}
