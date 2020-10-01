using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvoPolisBeta
{
    class Thief : Person
    {
        public Thief(int initialX, int initialY):base(initialX, initialY)
        {
            X = initialX;
            Y = initialY;
            PersonMarker = "T";
            PersonColor = ConsoleColor.Red;

        }

    }
}
