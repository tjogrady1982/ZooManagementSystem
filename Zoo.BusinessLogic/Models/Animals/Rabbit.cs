using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : AnimalThatCanBeGroomed, IProduceMuck
  {
    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }
    public override void Feed()
    {
      Console.WriteLine("<Munch, munch>");
      base.Feed();
    }

        public void MuckOut()
        {
            //throw new NotImplementedException();
        }

     
    }
}