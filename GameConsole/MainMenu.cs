using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace GameConsole
{
    public partial class MainMenu : Form
    {
        Sounds Sounds = new Sounds();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            PanelMenuButtons.Location = new Point(310, 100);
            PanelGames.Location = new Point(310, 100);
            PanelSnakeDiff.Location = new Point(310, 100);
            PanelOptions.Location = new Point(310, 100);
            Sounds.Song();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            PanelMenuButtons.Visible = false;
            PanelGames.Visible = true;
            btnBack.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            PanelMenuButtons.Visible = true;
            PanelGames.Visible = false;
            btnBack.Visible = false;
            PanelSnakeDiff.Visible = false;
            PanelOptions.Visible = false;
        }

        private void btnSnakeGame_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            PanelGames.Visible = false;
            PanelSnakeDiff.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            PanelMenuButtons.Visible = false;
            PanelOptions.Visible = true;
            btnBack.Visible = true;
        }
        private void btnSnEasy_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            SnakeGameDifficulty(200);
        }
        private void btnSnMedium_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            SnakeGameDifficulty(150);

        }
        private void btnSnHard_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            SnakeGameDifficulty(100);
        }
        public void SnakeGameDifficulty(int diff)
        {
            Sounds.SelectSound();
            SnakeGame sg = new SnakeGame(diff);
            this.Visible = false;
            sg.Show();
        }

        private void btnWindowMode_Click(object sender, EventArgs e)
        {
            Sounds.SelectSound();
            if (btnWindowMode.Text == "WINDOW MODE: MINIMIZED") { btnWindowMode.Text = "WINDOW MODE: MAXIMIZED"; this.WindowState = FormWindowState.Maximized; }
            else if (btnWindowMode.Text == "WINDOW MODE: MAXIMIZED") { btnWindowMode.Text = "WINDOW MODE: MINIMIZED"; this.WindowState = FormWindowState.Normal; }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (btnVolume.Text == "VOLUME: 100%") { btnVolume.Text = "VOLUME: 0%"; Sounds.sound.Volume = 0; }
            else if (btnVolume.Text == "VOLUME: 0%") { btnVolume.Text = "VOLUME: 25%"; Sounds.sound.Volume = 0.25; }
            else if (btnVolume.Text == "VOLUME: 25%") { btnVolume.Text = "VOLUME: 50%"; Sounds.sound.Volume = 0.5; }
            else if (btnVolume.Text == "VOLUME: 50%") { btnVolume.Text = "VOLUME: 75%"; Sounds.sound.Volume = 0.75; }
            else if (btnVolume.Text == "VOLUME: 75%") { btnVolume.Text = "VOLUME: 100%"; Sounds.sound.Volume = 1; }
            Sounds.SelectSound();
        }

        private void btnSoundEffects_Click(object sender, EventArgs e)
        {
            if (btnSoundEffects.Text == "SOUND EFFECTS: ON") { btnSoundEffects.Text = "SOUND EFFECTS: OFF"; Sounds.boolSounds = false; }
            else if(btnSoundEffects.Text == "SOUND EFFECTS: OFF") { btnSoundEffects.Text = "SOUND EFFECTS: ON"; Sounds.boolSounds = true; }
            Sounds.SelectSound();

        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            if (btnMusic.Text == "MUSIC: ON") { btnMusic.Text = "MUSIC: OFF"; Sounds.boolSong = false; }
            else if (btnMusic.Text == "MUSIC: OFF") { btnMusic.Text = "MUSIC: ON"; Sounds.boolSong = true;}
            Sounds.SelectSound();
            Sounds.Song();

        }
    }
}