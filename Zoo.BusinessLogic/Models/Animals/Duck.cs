using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Duck: Animal, ICanLayEggs, IProduceMuck
    {
        public Duck(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
        public void MuckOut()
        {
        }

        public void CheckForEggs()
        {

        }

    }
}
