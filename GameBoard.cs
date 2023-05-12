using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            this.gameBoard = generateBoard(xSize,ySize);

        }

   public static Tile[,] generateBoard(int x, int y) {
            Tile[,] gameBoard = new Tile[x+2,y+2];
            for (int i = 0; i < gameBoard.GetLength(0); i++) {
                for(int j = 0; j < gameBoard.GetLength(1); j++) {
                    gameBoard[i,j] = new NullTile(i,j);
                }
            }
            return gameBoard;
        }
        public  void displayBoard() {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < gameBoard.GetLength(0); i++) {
                for(int j = 0; j < gameBoard.GetLength(1);j++) {
                    Tile tile = gameBoard[i,j];
                    sb.Append(tile.getTileType());
                    sb.Append(",");
                }
                sb.Append('\n');
            }
            Console.WriteLine(sb.ToString());
        }
    }


}
