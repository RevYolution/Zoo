using BuildAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Clown : Fish, ISwim
    {
        public override bool Strips { get; set; }
    }
}
