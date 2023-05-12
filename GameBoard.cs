using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {
    internal class GameBoard {

        int xSize;
        int ySize;
        Tile[,] gameBoard;

        public GameBoard(int x, int y) {
            this.xSize = x;
            this.ySize = y;
            this.gameBoard = new Tile[xSize, ySize];

        }

   

    }


}
