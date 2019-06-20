using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Canine : Mammal
    {
        public override int Legs { get; set; } = 4;

        public override string Eat()
        {
            return "I eat all the meats!!";
        }

        public override string Hunt()
        {
            return "I hunt in a pack.";
        }

        public override bool Migrate()
        {
            return false;
        }
    }
}
