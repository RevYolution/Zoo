using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Animal
    {
        public abstract int Legs { get; set; }

        public abstract bool Warmblooded { get; set; }

        public bool Strips { get; set; }

        public abstract string Eat();

        public abstract string Sleep();

        public abstract string Call();

        public abstract string Hunt();

        public abstract bool Migrate();
    }
}
