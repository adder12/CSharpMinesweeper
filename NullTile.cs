using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {
    internal class NullTile : Tile{
        public NullTile(int x, int y) : base(x,y,"NULL") { }
    }
}
