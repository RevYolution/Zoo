using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Eagle : Bird, IFly
    {
        public override string Eat()
        {
            return "I eat meat";
        }

        public override string Call()
        {
            return "Screech";
        }

        public override string Hunt()
        {
            return "I hunt alone";
        }

        public override bool Migrate()
        {
            return true;
        }
    }
}
