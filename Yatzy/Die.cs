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
        public Die()
        {
            _ = Roll();
        }

        /// <summary>
        /// The hold status of the die
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// The current face value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// Rolls the Die and returns a random number between 1 and 6
        /// If the die is held, it will keep the current value.
        /// </summary>
        /// <returns>A value between 1 and 6 (inclusive)</returns>
        public byte Roll()
        {
            if (IsHeld)
            {
                return FaceValue;
            }
            var rand = new Random();
            byte randNum = Convert.ToByte(rand.Next(6) + 1);
            FaceValue = randNum;
            return randNum;
        }
    }
}
