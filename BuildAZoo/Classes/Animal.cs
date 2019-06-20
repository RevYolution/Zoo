using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Animal
    {
        /// <summary>
        /// Gets or sets number of legs
        /// </summary>
        public abstract int Legs { get; set; }

        /// <summary>
        /// Sates if warmblooded or not
        /// </summary>
        public abstract bool Warmblooded { get; set; }

        /// <summary>
        /// States if has strips
        /// </summary>
        public abstract bool Strips { get; set; }

        /// <summary>
        /// Describes what animal eats
        /// </summary>
        /// <returns>String of what the animal eats</returns>
        public abstract string Eat();

        /// <summary>
        /// Describes where the animal sleeps
        /// </summary>
        /// <returns>String of where animal sleeps</returns>
        public abstract string Sleep();

        /// <summary>
        /// Describes the sounds the animal makes
        /// </summary>
        /// <returns>String of what the sound is</returns>
        public abstract string Call();

        /// <summary>
        /// Describes how the animal hunts
        /// </summary>
        /// <returns>Sting of hunting style</returns>
        public abstract string Hunt();

        /// <summary>
        /// Tells if the animal migrates
        /// </summary>
        /// <returns>Positive or negative if the animal migrates</returns>
        public abstract bool Migrate();
    }
}
