using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Lion : Feline
    {
        public override string Hunt()
        {
            return "I hunt with my pride";
        }

        public override bool Strips { get; set; } = false;

        public override string Sleep()
        {
            return "I sleep on the Savannah";
        }
    }
}
