using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class GuineaFowl : Animal, IProduceMuck
    {
        public GuineaFowl(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
        private DateTime lastMuckedOut;
        public void MuckOut()
        {
            lastMuckedOut = DateTime.Now;
        }

        public override string ToString()
        {
            return base.ToString() + $"; Last Mucked Out {lastMuckedOut}";
        }

       
       
    }
}
