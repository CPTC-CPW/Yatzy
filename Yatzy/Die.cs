using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    /// <summary>
    /// The Die class represents a single standard
    /// 6-sided die
    /// </summary>
    internal class Die
    {
        /// <summary>
        /// Holds the die, preventing it from being
        /// rolled when the player does their next roll
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Keep()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unholds the die, so it can be rolled again
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void UnKeep()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the current face value of the die
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public byte GetFaceValue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Roll return a random number between 1 and 6
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public byte Roll()
        {
            throw new NotImplementedException();
        }
    }
}
