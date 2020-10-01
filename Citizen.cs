using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvoPolisBeta
{
    class Citizen : Person
    {
        public Citizen(int initialX, int initialY) : base(initialX, initialY)
        {
            X = initialX;
            Y = initialY;
            PersonMarker = "M";
            PersonColor = ConsoleColor.White;
            //Inventory.Add("Nycklar");
            //Inventory.Add("MobilTelefon");
            //Inventory.Add("Nycklar");
            //Inventory.Add("Klocka");


        }
    }
}
