using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Ant : Animal, ICanLayEggs
    {
        public Ant(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
        public void CheckForEggs()
        {

        }
    }
}
