using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE4TurnProcessor
{
    class Game
    {
        public static string binPath = "%programfiles(x86)%\\Steam\\SteamApps\\common\\Space Empires IV Deluxe\\se4\\se4.exe";
        public static string savePath = "%programfiles(x86)%\\Steam\\SteamApps\\common\\Space Empires IV Deluxe\\se4\\SaveGame\\";
        public string gameName;

        public List<Player> players;

        public Game(string gameMasterName, string binaryPath = "", string saveGamePath = "")
        {
            if(!string.IsNullOrEmpty(binaryPath))
            {
                binPath = binaryPath;
            }

            if (!string.IsNullOrEmpty(saveGamePath))
            {
                savePath = saveGamePath;
            }

            gameName = gameMasterName;

            players = new List<Player>();
        }

        public void AddPlayer(string label = "", int number = 0)
        {
            if(number == 0)
            {
                number = players.Count + 1;
            }
            players.Add(new Player(number, label, gameName));
        }

        public override string ToString()
        {
            return gameName;
        }
    }
}
