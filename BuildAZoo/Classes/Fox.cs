using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Fox : Canine
    {
        public override string Call()
        {
            return "I yip";
        }

        public override string Sleep()
        {
            return "I sleep in a den";
        }


    }
}
