using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    /// <summary>
    /// Main form of the program that allows users to manage up to 5 alarms
    /// </summary>
    public partial class Alarm501 : Form
    {
        /// <summary>
        /// Private field that allows access to the alarm library
        /// </summary>
        private AlarmLibrary model;

        /// <summary>
        /// Delegate for adding an alarm to the alarm library
        /// </summary>
        private AddAlarm addAlarmDel;

        /// <summary>
        /// Delegrate for editiing an alarm in the library
        /// </summary>
        private EditAlarm editAlarmDel;

        /// <summary>
        /// Delegate for stoping a ringing alarm
        /// </summary>
        private StopAlarm stopAlarmDel;

        /// <summary>
        /// Delegate for snoozing a ringing alrm
        /// </summary>
        private SnoozeAlarm snoozeAlarmDel;

        /// <summary>
        /// Delegate for loading alarms from a file
        /// </summary>
        private LoadAlarms loadAlarmsDel;

        /// <summary>
        /// Delegate for saving alarms to file
        /// </summary>
        private SaveAlarms saveAlarmsDel;

        /// <summary>
        /// Delegate for checking alarms in the library
        /// </summary>
        private CheckAlarms checkAlarmsDel;

        /// <summary>
        /// Delegate for setting an alarm
        /// </summary>
        private SetAlarm setAlarmsDel;

        /// <summary>
        /// Private field used as a timer for the program
        /// </summary>
        private static System.Timers.Timer _timer;

        /// <summary>
        /// Constructor to initialize Alarm501 form
        /// </summary>
        public Alarm501(AlarmLibrary m, AddAlarm add, EditAlarm edit, StopAlarm stop, 
            SnoozeAlarm snooze, LoadAlarms load, SaveAlarms save, CheckAlarms check, SetAlarm set)
        {
            InitializeComponent();

            model = m;
            addAlarmDel = add;
            editAlarmDel = edit;
            stopAlarmDel = stop;
            snoozeAlarmDel = snooze;
            loadAlarmsDel = load;
            saveAlarmsDel = save;
            checkAlarmsDel = check;
            setAlarmsDel = set;
       
            UxSnoozeBtn.Enabled = false;
            UxStopBtn.Enabled = false;
        
            loadAlarmsDel();
            UxAlarmList.DataSource = m.AlarmList;
            UxEditBtn.Enabled = UxAlarmList.Items.Count > 0;
            UxAddBtn.Enabled = !(UxAlarmList.Items.Count == 5);

            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += CheckEventHandler;
            _timer.SynchronizingObject = this;
            _timer.AutoReset = true;
            _timer.Start();
        }


        /// <summary>
        /// Event handler for the "+" button
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"></param>
        private void UxAddBtn_Click(object sender, EventArgs e)
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm(setAlarmsDel);
            if (addEditAlarm.ShowDialog() == DialogResult.OK)
            {
                addAlarmDel(addEditAlarm.Alarm); 
                UxEditBtn.Enabled = true;
            }
            UxAddBtn.Enabled = !(UxAlarmList.Items.Count == 5);
        }

        /// <summary>
        /// Event handler for the "Edit" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxEditBtn_Click(object sender, EventArgs e)
        {
            Alarm alarm = (Alarm) UxAlarmList.SelectedItem;
            AddEditAlarm addEditAlarm = new AddEditAlarm(alarm, setAlarmsDel);
            if (addEditAlarm.ShowDialog() == DialogResult.OK)
            {
                editAlarmDel(UxAlarmList.SelectedIndex, alarm); 
            }
        }

        /// <summary>
        /// Event handler to check if an alarm is supposed to go off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckEventHandler(object sender, EventArgs e)
        {
            int index = checkAlarmsDel(model.AlarmList);
            if (index != -1)
            {
                UxAlarmList.Enabled = false;
                UxEditBtn.Enabled = false;
                UxAlarmList.SelectedIndex = index;
                UxSnoozeBtn.Enabled = true;
                UxStopBtn.Enabled = true;
                uxRingingLabel.Text = "ALARM " + (index + 1) + " GOING OFF!";
            }
        }

        /// <summary>
        /// Event handler for the "Stop" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxStopBtn_Click(object sender, EventArgs e)
        {
            int index = UxAlarmList.SelectedIndex;
            stopAlarmDel(index);
            editAlarmDel(index, (Alarm)UxAlarmList.SelectedItem);
            uxRingingLabel.Text = " ";
            UxSnoozeBtn.Enabled = false;
            UxStopBtn.Enabled = false;
            UxEditBtn.Enabled = true;
            UxAlarmList.Enabled = true;
        }

        /// <summary>
        /// Event handler for the "Snooze" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxSnoozeBtn_Click(object sender, EventArgs e)
        {
            int index = UxAlarmList.SelectedIndex;
            snoozeAlarmDel(index, ((Alarm)UxAlarmList.SelectedItem).SnoozeInterval);
            uxRingingLabel.Text = "ALARM " + (index + 1) + " SNOOZED.";
        }

        /// <summary>
        /// Event handler for when the form is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Alarm501_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveAlarmsDel();
            _timer.Dispose();
        }

    }
}
