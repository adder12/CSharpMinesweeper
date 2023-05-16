using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper {

    internal class Tile {
        public Tile(int x, int y, String type) {
            this.xCoord = x; 
            this.yCoord = y;
            this.status = 0;
            this.tileType = type;
        }
        public Tile() { }
       private int xCoord;
       private int yCoord;
       private int status;
        private  string tileType;

        public int getXCoord() { return this.xCoord; }
        public int getYCoord() { return this.yCoord; }
        public int getStatus() { return this.status;}

        public string getTileType() { return this.tileType; }

        public void setXCoord(int xCoord) {  this.xCoord = xCoord; } 
        public void setYCoord(int yCoord) {  this.yCoord = yCoord; }
        public void setStatus(int status) { this.status = status; }
        

    }
  
}
