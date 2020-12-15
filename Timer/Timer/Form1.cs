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
            context = new timer_dbEntities();
            this.nonActiveTimers = new BindingList<IWorkingTimer>();
            this.ActiveTimers = new BindingList<IWorkingTimer>();
            InitializeComponent();
            dgw_nonActive.DataSource = nonActiveTimers;
            getTimers();
            tb_keres.KeyUp += Tb_keres_KeyUp;
        }

        private void Tb_keres_KeyUp(object sender, KeyEventArgs e)
        {
            getTimers();
        }

        private void getTimers()
        {
            nonActiveTimers.Clear();
            var linq = (from x in context.Timers
                       where x.Name_Id.Contains(tb_keres.Text)
                       select x).ToList();
            foreach (var item in linq)
            {

                if (item.Theme == 1)
                {
                    MoodleTestTimer temp = new MoodleTestTimer
                    {
                        MP = item.SEC,
                        Név = item.Name_Id
                    };
                    temp.init();
                    nonActiveTimers.Add(temp);
                }
                else if (item.Theme == 2)
                {
                    MoodleTestTimer temp = new MoodleTestTimer
                    {
                        MP = item.SEC,
                        Név = item.Name_Id
                    };
                    temp.init();
                    nonActiveTimers.Add(temp);
                }
            }

        }

    }
}
