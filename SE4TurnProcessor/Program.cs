using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace SE4TurnProcessor
{
    static class Program
    {
        public static List<Game> games;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            games = new List<Game>();
            foreach(string game in ListGamesInFolder(Game.savePath))
            {
                games.Add(new Game(Path.GetFileName(game)));
            }

            // For each game...
            // Add maximum players, default to not caring about them.
            foreach(Game g in games)
            {
                for (int i = 0; i < 20; i++)
                {
                    g.AddPlayer();
                }
            }

            /*
            foreach (Player pl in game.players)
            {
                bool yesno = pl.DoesPlayerFileExist();
            }*/

            LoadPersistentData();
            //SavePersistentData();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static string GetSettingsPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SE4TurnProcessor");
        }

        static string GetSettingsFilePath()
        {
            return Path.Combine(GetSettingsPath(), "Settings.config");
        }

        static Game FindGame(string gameName)
        {
            for(int i = 0;i < games.Count;i++)
            {
                if (games[i].gameName == gameName)
                    return games[i];
            }

            return null;
        }

        public static void LoadPersistentData()
        {
            if(File.Exists(GetSettingsFilePath()))
            {
                using (StreamReader reader = new StreamReader(GetSettingsFilePath()))
                {
                    string ver = reader.ReadLine();
                    string[] verToks = ver.Split('\t');
                    float version;
                    if(!float.TryParse(verToks[1], out version))
                    {
                        throw new Exception("Unable to parse version!");
                    }

                    string line;
                    if(version == 1.0)
                    {
                        while((line = reader.ReadLine()) != null)
                        {
                            string[] tokens = line.Split('\t');

                            string gameName = tokens[0];
                            string playerNumber = tokens[1];
                            string playerFileName = tokens[2];
                            string playerLabel = tokens[3];

                            Game g = FindGame(gameName);
                            if (g != null)
                            {
                                int pNumber;
                                if (int.TryParse(playerNumber, out pNumber))
                                {
                                    g.players[pNumber - 1].label = playerLabel;
                                }
                            }
                        }
                    }
                    
                }
            }
        }

        public static void SavePersistentData()
        {
            if (!Directory.Exists(GetSettingsPath()))
            {
                Directory.CreateDirectory(GetSettingsPath());
            }
            using (StreamWriter writer = new StreamWriter(GetSettingsFilePath()))
            {
                writer.WriteLine(string.Format("Version\t{0}", 1));
                foreach (Game g in games)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        writer.WriteLine(string.Format("{0}\t{1}\t{2}\t{3}", g.gameName, g.players[i].number, g.players[i].playerFileName, g.players[i].label));
                    }
                }
            }
        }

        static List<string> ListFilesInFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(Environment.ExpandEnvironmentVariables(path));
            List<String> files = new List<String>();

            foreach(FileInfo fi in di.GetFiles())
            {
                files.Add(fi.FullName);
            }

            return files;
        }

        static List<string> ListGamesInFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(Environment.ExpandEnvironmentVariables(path));
            List<String> files = new List<String>();

            foreach (FileInfo fi in di.GetFiles("*.gam"))
            {
                files.Add(fi.FullName);
            }

            return files;
        }

        static List<string> ListPlayersInFolder(string path, string gamename)
        {
            DirectoryInfo di = new DirectoryInfo(Environment.ExpandEnvironmentVariables(path));
            List<String> files = new List<String>();

            foreach (FileInfo fi in di.GetFiles(string.Format("{0}*.plr", gamename)))
            {
                files.Add(fi.FullName);
            }

            return files;
        }
    }
}
