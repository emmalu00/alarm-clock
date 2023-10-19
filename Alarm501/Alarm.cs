using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Alarm501
{
    /// <summary>
    /// Represents an Alarm object
    /// </summary>
    public class Alarm : INotifyPropertyChanged
    {
        /// <summary>
        /// Hanldes property changed events for the alarm
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing field for AlarmTime property
        /// </summary>
        private DateTime _time;

        /// <summary>
        /// Time of the alarm
        /// </summary>
        public DateTime AlarmTime
        {
            get
            {
                return _time;
            }
            set 
            { 
                _time = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AlarmTime)));
            }
        }

        /// <summary>
        /// Private backing field for AlarmStatus property
        /// </summary>
        private Status _alarmStatus;

        /// <summary>
        /// Status of the alarm
        /// </summary>
        public Status AlarmStatus
        {
            get
            {
                return _alarmStatus;
            }
            set
            {
                _alarmStatus = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AlarmStatus)));
            }
        }

        /// <summary>
        /// Private backing field for IsOn property
        /// </summary>
        private bool _isOn;

        /// <summary>
        /// Whether or not the alarm is On
        /// </summary>
        public bool IsOn
        {
            get
            {
                return _isOn;
            }
            set
            {
                _isOn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsOn)));
            }
        }

        /// <summary>
        /// Private backing field for AlarmSound property
        /// </summary>
        private Sound _alarmSound;

        /// <summary>
        /// Sound of alarm
        /// </summary>
        public Sound AlarmSound
        {
            get { return _alarmSound; }
            set 
            { 
                _alarmSound = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AlarmSound)));
            }
        }

        /// <summary>
        /// Private backing field for SnoozeInterval property
        /// </summary>
        private int _snoozeInterval;

        /// <summary>
        /// Snooze interval in minutes 
        /// </summary>
        public int SnoozeInterval
        {
            get { return _snoozeInterval; }
            set
            {
                _snoozeInterval = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SnoozeInterval)));
            }
        }

        /// <summary>
        /// Constructor to initialize an alarm object
        /// </summary>
        /// <param name="alarmTime">Time of alarm</param>
        /// <param name="status">Status of alarm</param>
        /// <param name="on">Whether or not the alarm is on</param>
        public Alarm(DateTime time, Status status, bool on, Sound sound, int interval)
        {
            AlarmTime = time;
            AlarmStatus = status;
            IsOn = on;
            AlarmSound = sound;
            SnoozeInterval= interval;
        }

        /// <summary>
        /// Displays the alarm
        /// </summary>
        /// <returns>String that displays the alarm.</returns>
        public override string ToString()
        {
            string AMPM;
            if (AlarmTime.Hour < 12) { AMPM = "AM"; }
            else { AMPM = "PM"; }

            string OnOff;
            if (IsOn) { OnOff = "On"; }
            else { OnOff = "Off"; }
            
            string hour = ((AlarmTime.Hour + 12) % 12).ToString();
            if (AlarmTime.Hour == 12 || AlarmTime.Hour == 0) { hour = "12"; }
            else if (((AlarmTime.Hour + 12) % 12) < 10)
            {
                hour = "0" + hour;
            }
            string minutes = AlarmTime.Minute.ToString();
            if (AlarmTime.Minute < 10)
            {
                minutes = "0" + minutes;
            }

            string alarm = hour + ":" + minutes + " " + AMPM + " (" + OnOff + ")  -  " 
                + AlarmStatus.ToString() + "  -  " + AlarmSound.ToString() + "          Snooze = " + SnoozeInterval.ToString() + " min";
            return alarm;
        }
    }
}
