using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    class SnakeCell
    {
        public int x { get; set; }
        public int y { get; set; }
        public SnakeCell(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
    }
}
