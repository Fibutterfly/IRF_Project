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
            dgw_nonActive.MultiSelect = false;
            dgw_nonActive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgw_active.DataSource = ActiveTimers;
            dgw_active.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            System.Windows.Forms.Timer active_refresh = new System.Windows.Forms.Timer();
            active_refresh.Interval = 250;
            active_refresh.Tick += Active_refresh_Tick; ;
            active_refresh.Start();
            getTimers();

            tb_keres.KeyUp += Tb_keres_KeyUp;
            but_active.Click += But_active_Click;
            but_deactive.Click += But_deactive_Click;
            but_act_start.Click += But_act_start_Click;
            but_act_stop.Click += But_act_stop_Click;
        }

        private void Active_refresh_Tick(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            dgw_active.Refresh();
        }

        private void But_act_stop_Click(object sender, EventArgs e)
        {
            if (dgw_active.SelectedRows.Count > 0)
            {
                ActiveTimers[dgw_active.CurrentCellAddress.Y].stop();
            }
            dgw_active.Refresh();
        }

        private void But_act_start_Click(object sender, EventArgs e)
        {
            if (dgw_active.SelectedRows.Count > 0)
            {
                ActiveTimers[dgw_active.CurrentCellAddress.Y].start();
            }
            dgw_active.Refresh();
        }

        private void But_deactive_Click(object sender, EventArgs e)
        {
            if (dgw_active.SelectedRows.Count > 0)
            {
                ActiveTimers.RemoveAt(dgw_active.CurrentCellAddress.Y);
            }
            dgw_active.Refresh();
        }

        private void But_active_Click(object sender, EventArgs e)
        {
            if (dgw_nonActive.SelectedRows.Count > 0)
            {
                //var asd = nonActiveTimers[dgw_nonActive.CurrentCellAddress.Y];
                ActiveTimers.Add((IWorkingTimer)nonActiveTimers[dgw_nonActive.CurrentCellAddress.Y].Clone());
                
            }
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
