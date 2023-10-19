 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    public class AlarmLibrary
    {

        public string FileName { get; } = "alarms.txt";

        public BindingList<Alarm> AlarmList = new BindingList<Alarm>();

    }
}
