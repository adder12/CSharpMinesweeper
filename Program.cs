// See https://aka.ms/new-console-template for more information
using Minesweeper;

namespace main {
    class  GameLoop {

        public static void Main(String[] args) {
            GameBoard game = new GameBoard(5, 5);
            game.displayBoard();
        }


    }
}