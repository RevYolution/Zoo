using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Ostrich : Bird, IRun
    {
        public override string Eat()
        {
            return "I eat bugs";
        }

        public override string Call()
        {
            return "Squak";
        }

        public override string Hunt()
        {
            return "I forage";
        }

        public override bool Migrate()
        {
            return false;
        }
    }
}
