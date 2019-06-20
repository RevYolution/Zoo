using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    class Wolf : Canine
    {
        public override string Call()
        {
            return "I howl all night long";
        }

        public override string Sleep()
        {
            return "I sleep in a hollow";
        }


    }
}
