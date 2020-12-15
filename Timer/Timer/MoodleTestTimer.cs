using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace Timer
{
    class MoodleTestTimer : TestTimer
    {
        protected override string soundname { get; }

        protected override SoundPlayer Player { get; }

        public MoodleTestTimer()
        {
            soundname = AppDomain.CurrentDomain.BaseDirectory + "//sounds//LYNC_ringing.wav";
            Player = new SoundPlayer(soundname);
        }
    }
}
