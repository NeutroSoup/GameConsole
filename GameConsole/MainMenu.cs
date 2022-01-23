using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameConsole
{
    public partial class MainMenu : Form
    {

        int x = 900;
        int y = 900;
        public MainMenu()
        {
            InitializeComponent();
            PanelMenuButtons.Location = new Point(310,100);
            PanelGames.Location = new Point(310,100);
            PanelSnakeDiff.Location = new Point(310,100);
            PanelOptions.Location = new Point(310,100);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PanelMenuButtons.Visible = false;
            PanelGames.Visible = true;
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelMenuButtons.Visible = true;
            PanelGames.Visible = false;
            btnBack.Visible = false;
            PanelSnakeDiff.Visible = false;
        }

        private void btnSnakeGame_Click(object sender, EventArgs e)
        {
            PanelGames.Visible = false;
            PanelSnakeDiff.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }
        private void btnSnEasy_Click(object sender, EventArgs e)
        {
            SnakeGameDifficulty(200);
        }
        private void btnSnMedium_Click(object sender, EventArgs e)
        {
            SnakeGameDifficulty(150);

        }
        private void btnSnHard_Click(object sender, EventArgs e)
        {
            SnakeGameDifficulty(100);

        }
        public void SnakeGameDifficulty(int diff)
        {
            SnakeGame sg = new SnakeGame(diff);
            this.Visible = false;
            sg.Show();
        }
    }
}