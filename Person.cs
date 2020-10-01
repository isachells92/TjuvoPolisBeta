using System;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

namespace TjuvoPolisBeta
{
    internal class Person
    {
        public int DX { get; set; }
        public int DY { get; set; }
        static Random r = new Random();
        public int X { get; set; }
        public int Y { get; set; }
        public string PersonMarker;
        public List<string> Inventory;
        public ConsoleColor PersonColor;
        public bool isMovingInADirection { get; set; } = false;

        public Person(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            PersonMarker = "P ";
            PersonColor = ConsoleColor.Blue;
        }

        public void Draw()
        {
            Console.ForegroundColor = PersonColor;

            //if (Y >= Console.BufferWidth)
            //    Console.WriteLine("X Oj!");

            //if (X >= Console.BufferHeight)
            //    Console.WriteLine("Y Oj!");

            Console.SetCursorPosition(X,Y);
            Console.Write(PersonMarker);
            Console.ResetColor();

        }
        

        public void MoveInRandomDirection()
        {


            int dx = 0;
            int dy = 0;
            int randomDirection = r.Next(1, 9);

            switch (randomDirection)
            {
                case 1:
                    dx = 1;
                    dy = 0;
                    break;
                case 2:
                    dx = 1;
                    dy = 1;
                    break;
                case 3:
                    dx = 1;
                    dy = 0;
                    break;
                case 4:
                    dx = -1;
                    dy = 0;
                    break;
                case 5:
                    dx = 0;
                    dy = -1;
                    break;
                case 6:
                    dx = -1;
                    dy = -1;
                    break;
                case 7:
                    dx = 1;
                    dy = -1;
                    break;
                case 8:
                    dx = -1;
                    dy = 1;
                    break;
                default:
                    break;
            }

            X += dx;
            Y += dy;

            if (X >= 28)
                X = 0;
            else
                if (X == -1)
                X = 27;

            if (Y >= 18)
                Y = 0;
            else
                if (Y == -1)
                Y = 17; //// 

        }
        public void MoveConstantlyInARandomDirection()
        {
            
            int randomDirection = r.Next(1, 9);

            if (!isMovingInADirection)
            {
                switch (randomDirection)
                {
                    case 1:
                        DX = 1;
                        DY = 0;
                        isMovingInADirection = true;
                        break;
                    case 2:
                        DX = 1;
                        DY = 1;
                        isMovingInADirection = true;
                        break;
                    case 3:
                        DX = 1;
                        DY = 0;
                        isMovingInADirection = true;
                        break;
                    case 4:
                        DX = -1;
                        DY = 0;
                        isMovingInADirection = true;
                        break;
                    case 5:
                        DX = 0;
                        DY = -1;
                        isMovingInADirection = true;
                        break;
                    case 6:
                        DX = -1;
                        DY = -1;
                        isMovingInADirection = true;
                        break;
                    case 7:
                        DX = 1;
                        DY = -1;
                        isMovingInADirection = true;
                        break;
                    case 8:
                        DX = -1;
                        DY = 1;
                        isMovingInADirection = true;
                        break;
                    default:
                        break;
                }
            }
            X += DX;
            Y += DY;

            if (X >= 28)
                X = 0;
            else
                if (X == -1)
                X = 27;

            if (Y >= 18)
                Y = 0;
            else
                if (Y == -1)
                Y = 17; //// 

        }
    }
}