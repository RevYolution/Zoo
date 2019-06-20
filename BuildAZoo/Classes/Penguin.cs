using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Penguin : Bird, ISwim
    {
        public int Depth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Eat()
        {
            return "I eat fish";
        }

        public override string Call()
        {
            return "Squeak";
        }

        public override string Hunt()
        {
            return "I hunt in a pack";
        }

        public override bool Migrate()
        {
            return true;
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
