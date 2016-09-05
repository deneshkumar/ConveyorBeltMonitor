using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorBeltMonitor.Model
{
    static class MachineProperties
    {      
        public static double RotarySpeed { get; set;}
        public static double GearVibration { get; set; }
        public static double BearingTemperature { get; set; }
        public static double MotorTemperature { get; set; }
        public static double PulleyFriction { get; set; }
    }
}
