using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvoPolisBeta
{
    class Police : Person
    {
        public Police(int initialX, int initialY) : base(initialX, initialY)
        {
            X = initialX;
            Y = initialY;
            PersonMarker = "P ";
            PersonColor = ConsoleColor.Blue;
        }
    }
}
