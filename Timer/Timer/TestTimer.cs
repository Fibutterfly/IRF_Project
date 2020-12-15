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
        public string Név { get; set; }

        public string idő { get; set; }

        public int MP { get; set; }
        private int spend_time { get; set; }
        private System.Timers.Timer timer { get; set; }
        abstract protected string soundname { get;}
        abstract protected SoundPlayer Player { get; set; }
        public void init()
        {
            WriteTime();
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        private void WriteTime()
        {
            int minute = CalIdő();
            this.idő = $"{minute}:{(MP - spend_time) - minute * 60}";
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("DEEEE");
            spend_time++;
            WriteTime();
            //this.idő = spend_time.ToString();
            if (spend_time == MP)
            {
                //System.Windows.Forms.MessageBox.Show("Test");
                Player.Play();
                stop();
            }

        }

        private int CalIdő()
        {
            int akttime = MP - spend_time;
            int perc = 60;
            int szorzo = 0;
            while (akttime - (perc* (szorzo+1)) > 0)
            {
                szorzo++;
            }
            int maradek = akttime - (perc * (szorzo));
            if (maradek >= perc)
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
            WriteTime();
        }

        abstract public object Clone();
    }
}
