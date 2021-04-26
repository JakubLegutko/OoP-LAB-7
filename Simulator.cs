using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace OoP_LAB_7
{
    class Simulator
    {
        private List<Move> Moves = new List<Move>();
        public void Memorize()
        {

            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                if (consoleKeyInfo.Key == ConsoleKey.A)
                    Moves.Add(new MoveWest());
                else if (consoleKeyInfo.Key == ConsoleKey.S)
                    Moves.Add(new MoveSouth());
                else if (consoleKeyInfo.Key == ConsoleKey.D)
                    Moves.Add(new MoveEast());
                else if (consoleKeyInfo.Key == ConsoleKey.W)
                    Moves.Add(new MoveNorth());
                else if (consoleKeyInfo.Key == ConsoleKey.Backspace)
                    if (Moves.Count != 0)
                        Moves.RemoveAt(Moves.Count - 1);
                    else
                        Console.WriteLine("Cannot delete, list of moves empty");
                else if (consoleKeyInfo.Key == ConsoleKey.Enter)
                {
                    int currentTime = 1;
                    List<string> movesMade = new List<string>();

                    foreach (Move move in Moves)
                    {
                        string moveName = move.Execute(currentTime);
                        currentTime++;

                        if (currentTime >= 24)
                        {
                            currentTime = 1;
                        }

                        movesMade.Add(moveName);
                    }
                    Console.WriteLine();
                    movesMade.ForEach(Console.WriteLine);

                    using (TextWriter tw = new StreamWriter("CommandHistory.txt"))
                    {
                        foreach (string s in movesMade)
                            tw.WriteLine(s);
                    }
                    return;
                }
                
            }
            
        }
    }
}
