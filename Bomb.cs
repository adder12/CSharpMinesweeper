using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {
    internal class Bomb : Tile {
       private bool flagged;
        public Bomb(int a, int b) : base(a, b, "BOMB") { this.flagged = false; }

        public bool GetFlagged() { return this.flagged; }

        public void SetFlagged() {  this.flagged = !this.flagged; }
   
    }
}
