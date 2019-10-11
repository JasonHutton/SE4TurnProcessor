using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

using System.IO;
//using System.Security.Permissions;

namespace SE4TurnProcessor
{
    public partial class Form1 : Form
    {
        int gameIndex;
        FileSystemWatcher watcher;

        public Form1()
        {
            InitializeComponent();

            txtBinPath.Text = Game.binPath;
            txtSavePath.Text = Game.savePath;

            cmbGames.DataSource = Program.games;

            gameIndex = cmbGames.SelectedIndex;

            StartWatchingForChanges();
        }

        private void StartWatchingForChanges()
        {
            watcher = new FileSystemWatcher();
            watcher.Path = Environment.ExpandEnvironmentVariables(Game.savePath);

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            watcher.NotifyFilter = NotifyFilters.LastAccess
                                    | NotifyFilters.LastWrite
                                    | NotifyFilters.FileName
                                    | NotifyFilters.DirectoryName;

            watcher.Filter = "*.plr"; // Only look at player files.

            // Add event handlers.
            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnChanged;

            // Begin watching.
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            UpdateFileExistences(gameIndex); // Only going to update the game we're currently watching. This is wrong, needs correcting, but later.
        }

        private void txtBinPath_TextChanged(object sender, EventArgs e)
        {
            Game.binPath = txtBinPath.Text;
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {
            Game.savePath = txtSavePath.Text;
            if (watcher != null)
            {
                watcher.Path = Environment.ExpandEnvironmentVariables(Game.savePath); // Update the watcher as well.
            }
        }

        private void UpdateFileExistences(int gameIndex)
        {
            // This should be done better, it's probably missing a ton of stuff for games that aren't selected currently...
            txt1Label.Text = Program.games[gameIndex].players[0].label;
            cb1Ready.Checked = Program.games[gameIndex].players[0].DoesPlayerFileExist();

            txt2Label.Text = Program.games[gameIndex].players[1].label;
            cb2Ready.Checked = Program.games[gameIndex].players[1].DoesPlayerFileExist();
        }

        private void cmbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameIndex = cmbGames.SelectedIndex;

            UpdateFileExistences(gameIndex);
        }

        private void txt1Label_TextChanged(object sender, EventArgs e)
        {
            Program.games[gameIndex].players[0].label = txt1Label.Text;
        }

        private void txt2Label_TextChanged(object sender, EventArgs e)
        {
            Program.games[gameIndex].players[1].label = txt2Label.Text;
        }
    }
}
