using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        BindingList<IWorkingTimer> nonActiveTimers;
        BindingList<IWorkingTimer> ActiveTimers;
        timer_dbEntities context;
        public Form1()
        {
            this.nonActiveTimers = new BindingList<IWorkingTimer>();
            this.ActiveTimers = new BindingList<IWorkingTimer>();
            InitializeComponent();
            dgw_nonActive.DataSource = nonActiveTimers;
        }
    }
}
