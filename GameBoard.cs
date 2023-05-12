using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {
    internal class GameBoard {

       private int xSize;
       private int ySize;
        Tile[,] gameBoard;

        public GameBoard(int x, int y) {
            this.xSize = x;
            this.ySize = y;
            this.gameBoard = new Tile[xSize, ySize];

        }

   public static Tile[,] generateBoard(int x, int y) {
            Tile[,] gameBoard = new Tile[x,y];
        }

    }


}
