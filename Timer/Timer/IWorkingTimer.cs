﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Timer
{
    interface IWorkingTimer
    {
        string Név { get; }
        string idő {  get; }
        void start();
        void stop();
    }
}