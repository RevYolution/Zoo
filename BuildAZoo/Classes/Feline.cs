using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Feline : Mammal
    {
        public override int Legs { get; set; } = 4;

        public override string Eat()
        {
            return "I eat meat";
        }

        public override bool Migrate()
        {
            return false;
        }

        public override string Call()
        {
            return "I roar";
        }
    }
}
