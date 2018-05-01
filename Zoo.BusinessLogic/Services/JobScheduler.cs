using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class JobScheduler
    {
        private static JobScheduler instance;

        public static JobScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobScheduler();
                }

                return instance;
            }
        }
        public void AssignJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal.IsHungry())
                    {
                        //var name = animal["val1"];
                        //Console.WriteLine("Feeding the "+ animal +"...");
                        keeper.FeedAnimal(animal);
                    }
                    var groomableAnimal = animal as AnimalThatCanBeGroomed;

                    if (groomableAnimal != null)
                    {
                        //Console.WriteLine("Grooming the " + animal + "...");
                        keeper.GroomAnimal(groomableAnimal);
                    }

                  

                    var muckyAnimal = animal as IProduceMuck;

                    if (muckyAnimal != null)
                    {
                        //Console.WriteLine("Mucking out the " + animal + "...");
                        keeper.MuckOut(muckyAnimal);
                    }
                }
            }
        }
    }
}
