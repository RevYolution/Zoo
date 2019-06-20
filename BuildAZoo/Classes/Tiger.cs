using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Tiger : Feline
    {
        public override bool Strips { get; set; } = true;

        public override string Hunt()
        {
            return "I hunt alone";
        }

        public override string Sleep()
        {
            return "I sleep in trees";
        }
    }
}
