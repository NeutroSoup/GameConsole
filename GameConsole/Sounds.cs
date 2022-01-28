using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Media;
namespace GameConsole
{

    class Sounds
    {
        public MediaPlayer sound = new MediaPlayer();
        SoundPlayer song = new SoundPlayer(@"C:\Users\Admin\Desktop\asfas\GameConsole\Resources\GameConsoleSprites\bcSong.wav");
        public bool boolSounds = true;
        public bool boolSong = true;
        public Sounds()
        {

        }
        public void Song()
        {
            if (boolSong)
            {
                song.PlayLooping();
            }
            else
            {
                song.Stop();
            }
        }
        public void SelectSound()
        {
            if (boolSounds)
            {
                sound.Open(new Uri(@"C:\Users\Admin\Desktop\asfas\GameConsole\Resources\GameConsoleSprites\blipSelect.wav"));
                sound.Play();
            }
        }
        public void AppleSound()
        {
            if (boolSounds)
            {
                sound.Open(new Uri(@"C:\Users\Admin\Desktop\asfas\GameConsole\Resources\GameConsoleSprites\apple.wav"));
                sound.Play();
            }
        }
        public void ChangeVolume(double Volume)
        {
            sound.Volume = Volume;
        }
    }
}
