using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Timer
{
    interface IWorkingTimer: ICloneable
    {
        string Név { get; }
        string idő {  get; }
        void init();
        void start();
        void stop();
        void Pause();
    }
}
