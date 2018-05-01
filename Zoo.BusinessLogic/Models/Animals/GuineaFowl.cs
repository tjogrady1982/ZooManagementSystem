﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class GuineaFowl : Animal, ICanLayEggs, IProduceMuck
    {
        public GuineaFowl(DateTime dateOfBirth) : base(dateOfBirth)
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
