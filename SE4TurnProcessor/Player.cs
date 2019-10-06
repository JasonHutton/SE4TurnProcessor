using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace SE4TurnProcessor
{
    class Player
    {
        public int number;
        public string label;
        public string playerFileName;
        public bool CareAboutPlayer;

        public Player(int playerNumber, string playerLabel, string gameName)
        {
            number = playerNumber;
            label = playerLabel;
            CareAboutPlayer = false;

            playerFileName = GetPlayerFile(gameName);
        }

        private string GetPlayerFile(string gameName)
        {
            string temp = gameName.ToLower();
            temp = temp.Substring(0, temp.Length - 4);
            temp += "_" + number.ToString("D4") + ".plr";
            return temp;
        }

        public bool DoesPlayerFileExist() // This does not check if it's still being written to.
        {
            return File.Exists(Environment.ExpandEnvironmentVariables(Path.Combine(Game.savePath, playerFileName)));
        }
    }
}
