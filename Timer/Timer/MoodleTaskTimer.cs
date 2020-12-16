using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class MoodleTaskTimer : TestTimer
    {
        protected override string soundname { get; }

        protected override SoundPlayer Player { get; set; }
        public MoodleTaskTimer()
        {
            soundname = AppDomain.CurrentDomain.BaseDirectory + "//sounds//LYNC_ringtone2.wav";
            Player = new SoundPlayer(soundname);
        }

        public override object Clone()
        {
            MoodleTaskTimer stop = new MoodleTaskTimer()
            {
                MP = this.MP,
                Név = this.Név,
                Player = this.Player
            };
            stop.init();
            return stop;
        }
    }
}
