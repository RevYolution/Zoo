using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Eagle : Bird, IFly
    {
        public int Altitude { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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

        public void TakeOff()
        {
            throw new NotImplementedException();
        }

        public void Glide()
        {
            throw new NotImplementedException();
        }

        public void Land()
        {
            throw new NotImplementedException();
        }

        public void Crash()
        {
            throw new NotImplementedException();
        }

        
    }
}
