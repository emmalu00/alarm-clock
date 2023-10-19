using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    /// <summary>
    /// Form that allows users to choose alarm time and state
    /// </summary>
    public partial class AddEditAlarm : Form
    {
        /// <summary>
        /// Alarm instance for the AddEditAlarm form 
        /// </summary>
        public Alarm Alarm { get; set; } = new Alarm(DateTime.Now, Status.Running, false, Sound.Radar, 0);

        /// <summary>
        /// Delegate for setting an alarm
        /// </summary>
        private SetAlarm setAlarmDel;

        /// <summary>
        /// Constructor that intializes the AddEditAlarm form for editing alarm
        /// </summary>
        /// <param name="alarm"> Alarm being passed into the form.</param>
        /// <param name="set"> Delegate to set alarm </param>
        public AddEditAlarm(Alarm alarm, SetAlarm set)
        {
            InitializeComponent();
            Alarm = alarm;
            UxAlarmTime.Value = alarm.AlarmTime;
            UxAlarmOn.Checked = alarm.IsOn;
            foreach (Sound sound in Enum.GetValues(typeof(Sound)))
            {
                UxAlarmSounds.Items.Add(sound);
            }
            UxAlarmSounds.SelectedIndex = 0;
            UxSnoozeInterval.Minimum = 0;
            UxSnoozeInterval.Maximum = 30;
            UxSnoozeInterval.Value = alarm.SnoozeInterval;
            setAlarmDel = set;
        }

        /// <summary>
        /// Constructor that initializes a the AddEditAlarm form for adding an alarm
        /// </summary>
        /// <param name="set"> Delegate to set alarm </param>
        public AddEditAlarm(SetAlarm set)
        {
            InitializeComponent();
            UxAlarmTime.Value = DateTime.Now;
            UxAlarmOn.Checked = false;
            foreach (Sound sound in Enum.GetValues(typeof(Sound)))
            {
                UxAlarmSounds.Items.Add(sound);
            }
            UxAlarmSounds.SelectedIndex = 0;
            UxSnoozeInterval.Minimum = 0;
            UxSnoozeInterval.Maximum = 30;
            UxSnoozeInterval.Value = 0;
            setAlarmDel = set;

        }

        /// <summary>
        /// Event handler for the "Set" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UXSetAlarmBtn_Click(object sender, EventArgs e)
        {
            // ADD DELEGATE
            setAlarmDel(Alarm, UxAlarmTime.Value, UxAlarmOn.Checked, (Sound)UxAlarmSounds.SelectedItem, (int)UxSnoozeInterval.Value);
            //Alarm.AlarmTime = dateTimePicker1.Value;
           // Alarm.IsOn = checkBox1.Checked;
            //if (Alarm.IsOn) { Alarm.AlarmStatus = Status.Running; }
            //else { Alarm.AlarmStatus = Status.Stopped; }
            //Alarm.AlarmSound = (Sound)UxAlarmSounds.SelectedItem;
            //Alarm.SnoozeInterval = (int)UxSnoozeInterval.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Event handler for the "Cancel" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxCancelEditAlarmBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
