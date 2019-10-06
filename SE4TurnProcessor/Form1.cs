using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE4TurnProcessor
{
    public partial class Form1 : Form
    {
        int gameIndex;

        public Form1()
        {
            InitializeComponent();

            txtBinPath.Text = Game.binPath;
            txtSavePath.Text = Game.savePath;

            cmbGames.DataSource = Program.games;

            gameIndex = cmbGames.SelectedIndex;
        }

        private void txtBinPath_TextChanged(object sender, EventArgs e)
        {
            Game.binPath = txtBinPath.Text;
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {
            Game.savePath = txtSavePath.Text;
        }

        private void cmbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameIndex = cmbGames.SelectedIndex;

            txt1Label.Text = Program.games[gameIndex].players[0].label;
            cb1Ready.Checked = Program.games[gameIndex].players[0].DoesPlayerFileExist();

            txt2Label.Text = Program.games[gameIndex].players[1].label;
            cb2Ready.Checked = Program.games[gameIndex].players[1].DoesPlayerFileExist();
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
