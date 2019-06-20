using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Bird : Animal
    {
        public override int Legs { get; set; } = 2;

        public override bool Warmblooded { get; set; } = true;

        public override bool Strips { get; set; } = false;

        public override string Sleep()
        {
            return "I sleep in a nest";
        }
    }
}
