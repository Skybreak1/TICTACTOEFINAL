using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOEFINAL
{
    public class Player
    {
        public string Name { get; }
        public char Marker { get; }
        public Player(string name, char marker)
        {
            Name = name;
            Marker = marker;
        }
    }
}
