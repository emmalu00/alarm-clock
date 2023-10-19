using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public delegate void AddAlarm(Alarm alarm);
    public delegate void EditAlarm(int index, Alarm alarm);
    public delegate void StopAlarm(int index);
    public delegate void SnoozeAlarm(int index, int minutes);
    public delegate void LoadAlarms();
    public delegate void SaveAlarms();
    public delegate void SetAlarm(Alarm alarm, DateTime time, bool on, Sound sound, int interval);
    public delegate int CheckAlarms(BindingList<Alarm> list);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AlarmLibrary alarmLibrary = new AlarmLibrary();
            AlarmManager manager = new AlarmManager(alarmLibrary);
            Alarm501 view = new Alarm501(alarmLibrary, manager.AddAlarm, manager.EditAlarm, manager.StopAlarm, 
                manager.SnoozeAlarm, manager.LoadAlarmsFromFile, manager.SaveAlarmsToFile, manager.CheckAlarms, manager.SetAlarm);
            AddEditAlarm addEditAlarm = new AddEditAlarm(manager.SetAlarm);

            Application.Run(view);

            
        }
    }
}
