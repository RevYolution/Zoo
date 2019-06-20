using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Fish : Animal, ISwim
    {
        public override int Legs { get; set; } = 0;

        public override bool Warmblooded { get; set; } = false;
        public int Depth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Eat()
        {
            return "I eat plankton";
        }

        public override string Call()
        {
            return "Bubbles";
        }

        public override string Hunt()
        {
            return "I hunt as a school";
        }

        public override bool Migrate()
        {
            return false;
        }

        public override string Sleep()
        {
            return "I sleep in the water";
        }

        public void Dive()
        {
            throw new NotImplementedException();
        }

        public void Surface()
        {
            throw new NotImplementedException();
        }
    }
}
