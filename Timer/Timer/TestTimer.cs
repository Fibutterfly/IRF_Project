using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace Timer
{
    abstract class TestTimer : IWorkingTimer
    {
        public string Név { get; }

        public string idő { get; }

        private int MP { get; }
        private int spend_time { get; set; }
        private System.Timers.Timer timer { get; }
        abstract protected string soundname { get;}
        private SoundPlayer Player;

        public TestTimer(string _Name, int _Sec)
        {
            this.Név = _Name;
            this.MP = _Sec;
            int minute = CalIdő();
            this.idő = $"{minute}:{MP-minute*60}";
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            Player = new SoundPlayer(soundname);
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            spend_time++;
            CalIdő();
            if(spend_time == MP)
            {
                stop();
            }
        }

        private int CalIdő()
        {
            int perc = 60;
            int szorzo = 0;
            while (MP - perc* szorzo > 0)
            {
                szorzo++;
            }
            return szorzo;

        }
        public void start()
        {
            spend_time = 0;
            timer.Start();
        }

        public void stop()
        {
            timer.Stop();
            spend_time = 0;
        }
    }
}
