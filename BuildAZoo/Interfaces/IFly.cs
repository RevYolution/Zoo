using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Interfaces
{
    public interface IFly
    {
        /// <summary>
        /// Gets or sets the altitude flying at
        /// </summary>
        int Altitude { get; set; }

        /// <summary>
        /// Gets or sets the speed flying at
        /// </summary>
        int Speed { get; set; }

        /// <summary>
        /// Allows for taking off
        /// </summary>
        void TakeOff();

        /// <summary>
        /// Allows for gliding
        /// </summary>
        void Glide();

        /// <summary>
        /// Allows for a landing
        /// </summary>
        void Land();

        /// <summary>
        /// Tells of a crash
        /// </summary>
        void Crash();
    }
}
