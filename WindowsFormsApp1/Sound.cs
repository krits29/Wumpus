using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Sound
{
    public partial class Sound : Form
    {
        public Sound()
        {

            InitializeComponent();
        }
        public string soundName { get; set; }
        public int soundVolume { get; set; }
    
    
        public Sound(string name, int volume)
        {
            soundName = name;
            soundVolume = volume;
        }

        private void Bats_Click(object sender, EventArgs e)
        {
            SoundPlayer mySound = new SoundPlayer(@"E:\APCS\Visual Studio 2017\Sound\Sound\batflyby.wav");
            mySound.Play();
        }

        private void Wumpus_Click(object sender, EventArgs e)
        {
            SoundPlayer mySound = new SoundPlayer(@"E:\APCS\Visual Studio 2017\Sound\Sound\wumpuscloseby.wav");
            mySound.Play();
        }
    }
    }

