using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTFAccessLayer.EventArgsModel
{
    public class ConnectionChangedEventArgs : EventArgs
    {
        public bool IsConnected { get; set; }
        public string Message { get; set; }

        public ConnectionChangedEventArgs(bool s)
        {
            IsConnected = s;
        }
    }
}
