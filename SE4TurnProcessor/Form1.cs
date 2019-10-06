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
        public Form1()
        {
            InitializeComponent();

            txtBinPath.Text = Game.binPath;
            txtSavePath.Text = Game.savePath;
        }

        private void txtBinPath_TextChanged(object sender, EventArgs e)
        {
            Game.binPath = txtBinPath.Text;
        }

        private void txtSavePath_TextChanged(object sender, EventArgs e)
        {
            Game.savePath = txtSavePath.Text;
        }
    }
}
