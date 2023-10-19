using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    /// <summary>
    /// Class that acts as the controller
    /// </summary>
    public class AlarmManager
    {

        /// <summary>
        /// Private field used to access alarm library
        /// </summary>
        private AlarmLibrary library;
        
        /// <summary>
        /// Construtor that initializes the alarm manager 
        /// </summary>
        /// <param name="l"> Alarm library </param>
        public AlarmManager(AlarmLibrary l) 
        { 
            library = l;
        }

        /// <summary>
        /// Adds an alarm to alarm list
        /// </summary>
        /// <param name="alarm"> New alarm to add </param>
        public void AddAlarm(Alarm alarm)
        {
            library.AlarmList.Add(alarm);
        }

        /// <summary>
        /// Edits an alarm in the alarm list
        /// </summary>
        /// <param name="index"> Index of alarm being edited </param>
        /// <param name="alarm"> Alarm being edited</param>
        public void EditAlarm(int index, Alarm alarm)
        {
            if (index >= 0 && index < library.AlarmList.Count) { library.AlarmList[index] = alarm; }
        }

        /// <summary>
        /// Stops alarm that is ringing
        /// </summary>
        /// <param name="index"> Index of alarm that is ringing </param>
        public void StopAlarm(int index)
        {
            library.AlarmList[index].IsOn = false;
            library.AlarmList[index].AlarmStatus = Status.Stopped;
        }

        /// <summary>
        /// Snoozes an alarm that is ringing
        /// </summary>
        /// <param name="index"> Index of alarm that is ringing </param>
        /// <param name="minutes"> Snooze interval </param>
        public void SnoozeAlarm(int index, int minutes)
        {
            library.AlarmList[index].AlarmTime = DateTime.Now.AddSeconds(minutes * 60);
            library.AlarmList[index].AlarmStatus = Status.Snoozed;
        }

        /// <summary>
        /// Checks if an alarm is going off 
        /// </summary>
        /// <param name="alarms"> List of alarms in the alarm library </param>
        /// <returns></returns>
        public int CheckAlarms(BindingList<Alarm> alarms)
        {
            foreach (Alarm alarm in alarms)
            {
                if (alarm.AlarmTime.Hour == DateTime.Now.Hour
                    && alarm.AlarmTime.Minute == DateTime.Now.Minute
                    && alarm.AlarmTime.Second == DateTime.Now.Second
                    && alarm.IsOn)
                {
                    alarm.AlarmStatus = Status.Ringing;
                    return library.AlarmList.IndexOf(alarm);
                }
            }
            return -1;
        }

        /// <summary>
        /// Sets an alarm
        /// </summary>
        /// <param name="alarm"> Alarm being set </param>
        /// <param name="time"> Alarm time </param>
        /// <param name="on"> Whether of not the alarm is on </param>
        /// <param name="sound"> Alarm sound </param>
        /// <param name="interval"> Snooze interval </param>
        public void SetAlarm(Alarm alarm, DateTime time, bool on, Sound sound, int interval)
        {
            alarm.AlarmTime = time;
            alarm.IsOn = on;
            if (alarm.IsOn) { alarm.AlarmStatus = Status.Running; }
            else { alarm.AlarmStatus = Status.Stopped; }
            alarm.AlarmSound = sound;
            alarm.SnoozeInterval = interval;
        }
        

        /// <summary>
        /// Loads alarms from the provided text file and adds them to the alarm list
        /// </summary>
        public void LoadAlarmsFromFile()
        {
            if (File.Exists(library.FileName))
            {
                using (StreamReader sr = new StreamReader(library.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] info = line.Split(',');
                        DateTime time = DateTime.Parse(info[0]);
                        string status = info[1].Trim();
                        bool isOn = true;
                        Sound sound = (Sound)Enum.Parse(typeof(Sound), info[2].Trim());
                        int interval = int.Parse(info[3].Trim()); 
                        if (status.Equals("Off")) { isOn = false; }
                        Status alarmStatus = Status.Running;
                        if (!isOn) { alarmStatus = Status.Stopped; }
                        library.AlarmList.Add(new Alarm(time, alarmStatus, isOn, sound, interval));
                    }
                }
            }
        }
        
        /// <summary>
        /// Writes the alarm info from the alarm list to .txt file
        /// </summary>
        public void SaveAlarmsToFile()
        {
            using (StreamWriter sw = new StreamWriter(library.FileName))
            {
                foreach (Alarm alarm in library.AlarmList)
                {
                    if (alarm.IsOn) { sw.WriteLine(alarm.AlarmTime.ToString() + ", On" + ", " + alarm.AlarmSound.ToString() + ", " + alarm.SnoozeInterval.ToString()); }
                    else { sw.WriteLine(alarm.AlarmTime.ToString() + ", Off" + ", " + alarm.AlarmSound.ToString() + ", " + alarm.SnoozeInterval.ToString()); }
                }
            }
        }
    }

}
