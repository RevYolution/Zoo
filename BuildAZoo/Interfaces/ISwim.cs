using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    public interface ISwim
    {
        int Depth { get; set; }

        int Speed { get; set; }

        void Dive();

        void Surface();
    }
}
