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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Game> games = new List<Game>();
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


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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
