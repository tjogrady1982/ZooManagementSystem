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