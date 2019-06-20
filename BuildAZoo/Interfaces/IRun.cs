using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    interface IRun
    {
        int Speed { get; set; }

        int Distance { get; set; }

        void Start();
        void Stop();

    }
}
