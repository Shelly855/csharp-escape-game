using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCourseworkGUI
{
    internal class Inventory
    {
        public string name { get; set; }
        public string description { get; set; }
        public string rarity { get; set; }
        public string locationFound { get; set; }
    }
}

//reference = https://gamedev.stackexchange.com/questions/124802/c-how-to-add-inventory-to-player-npcs-and-in-game-objects