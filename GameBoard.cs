using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {
    internal class GameBoard {

        private readonly int xSize;
        private readonly int ySize;
        readonly Tile[,]  gameBoard;

        public GameBoard(int x, int y) {
            this.xSize = x;
            this.ySize = y;
            this.gameBoard = populateBoard(10,xSize, ySize);

        }

        public static Tile[,] generateBoard(int x, int y) {
            Tile[,] board = new Tile[x + 2, y + 2];
            for (int i = 0; i < board.GetLength(0); i++) {
                for (int j = 0; j < board.GetLength(1); j++) {
                    board[i, j] = new NullTile(i, j);
                }
            }
            return board;
        }

        public static Tile[,] populateBoard(int bombs, int height, int length) {
            Tile[,] board = generateBoard(height, length);
            double probability = (double)10/25;
           System.Console.WriteLine(probability);
            var random = new Random();

            while (bombs > 0) {
                for (int i = 1; i < board.GetLength(0)-1; i++) {
                    for (int j = 1; j < board.GetLength(1)-1; j++) {
                        double var = random.NextDouble();
                        System.Console.WriteLine(var);
                        if (var < probability && board[i, j].getTileType() != "BOMB" && bombs != 0) {
                            board[i, j] = new Bomb(i, j);
                            bombs--;
                        } else {
                            board[i, j] = new Safe(i, j);
                        }
                    }
                }               
            }
            return board;
        }

            public void displayBoard() {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < gameBoard.GetLength(0); i++) {
                    for (int j = 0; j < gameBoard.GetLength(1); j++) {
                        Tile tile = gameBoard[i, j];
                        sb.Append(tile.getTileType());
                        sb.Append(',');
                    }
                    sb.Append('\n');
                }
                Console.WriteLine(sb.ToString());
            }
        }

    } 


