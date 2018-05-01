using System;
using Zoo.BusinessLogic.Services;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : AnimalThatCanBeGroomed, IProduceMuck
  {
    public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
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