using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Cougar : Feline
    {
        public override string Sleep()
        {
            return "I sleep in a tree";
        }

        public override bool Strips { get; set; } = false;

        public override string Hunt()
        {
            return "I hunt alone";
        }
    }
}
