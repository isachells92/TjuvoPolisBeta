using System.Collections.Generic;
using TjuvoPolisTest;
using static System.Console;

namespace TjuvoPolisBeta
{
    class Game
    {
        private World Myworld;
        private Person APerson;
        private Thief t2;
        private Thief t3;
        private Police p1;
        private Police p2;
        private Police p3;
        private Thief t1;
        private Citizen c1;
        private Citizen c2;
        private Citizen c3;
        public void Start()
        {
            WriteLine("Game is starting");

            string[,] grid =
            {
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",  },
               { ". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ",". ", ". ",". ",". ",". ",". ",". ",". " }
            };
                                               // Inlämnad 19:47 01/10 av Isac Hellström. 
                                               // Kommentar från eleven: Hej! Blev tyvärr inte klar med uppgiften i tid, behöver jämnföra listor. Kommer att arbeta med denna under helgen.

            t1 = new Thief(10, 11);           // TestLogicAndProbability
            t2 = new Thief(10, 12);
            t3 = new Thief(10, 13);
            p1 = new Police(3, 1);
            p2 = new Police(3, 2);
            p3 = new Police(3, 3);
            c1 = new Citizen(16, 5);
            c2 = new Citizen(16, 6);
            c3 = new Citizen(16, 7);


            List<Person> population = new List<Person>();
            population.Add(t1);

            Myworld = new World(grid);
            APerson = new Person(5, 5);
            RunGameLoop();
        }

        private void DrawFrame()                // Ritar varje Frame \\
        {
            Clear();
            Myworld.Draw();
            APerson.Draw();
            APerson.MoveConstantlyInARandomDirection();
            t1.Draw();
            t1.MoveConstantlyInARandomDirection();
            t2.Draw();
            t2.MoveConstantlyInARandomDirection();
            t3.Draw();
            t3.MoveConstantlyInARandomDirection();

            p1.Draw();
            p1.MoveConstantlyInARandomDirection();
            p2.Draw();
            p2.MoveConstantlyInARandomDirection();
            p3.Draw();
            p3.MoveConstantlyInARandomDirection();


            c1.Draw();
            c1.MoveConstantlyInARandomDirection();
            c2.Draw();
            c2.MoveConstantlyInARandomDirection();
            c3.Draw();
            c3.MoveConstantlyInARandomDirection();
        }
        private void RunGameLoop()             // Ansvarar för loopen \\
        {
            while (true)
            {
                //draw everything
                DrawFrame();

                // Render Speed
                System.Threading.Thread.Sleep(200);     // Anger loophastighet \\
            }
        }
    }

}
