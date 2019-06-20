using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Mammal : Animal, IRun
    {
        public override bool Warmblooded { get; set; } = true;
    }
}
