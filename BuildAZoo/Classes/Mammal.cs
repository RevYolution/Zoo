using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Mammal : Animal, IRun
    {
        public override bool Warmblooded { get; set; } = true;
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Distance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
