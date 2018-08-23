using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchiffeVersenken
{
    public class Options
    {
        public string charShip = "\u26F4";
        public string charWater = "\u2652";
        public string charHit = "\u2620";
        public string charMiss = "\u26F6";

        public int fieldSize = 10;
        public int countCarrier = 1;
        public int countBattleship = 2;
        public int countCruiser = 3;
        public int countSubmarine = 0;
        public int countDestroyer = 4;
        public int sizeCarrier = 5;
        public int sizeBattleship = 4;
        public int sizeCruiser = 3;
        public int sizeSubmarine = 3;
        public int sizeDestroyer = 2;

        public int totalShips;

        public int gameMode;

    }
}
