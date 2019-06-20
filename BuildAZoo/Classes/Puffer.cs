using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Puffer : Fish, ISwim
    {
        public override bool Strips { get; set; } = false;
    }
}
