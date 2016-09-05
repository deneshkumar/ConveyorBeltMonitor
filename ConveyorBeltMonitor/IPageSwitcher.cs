using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorBeltMonitor
{
    interface IPageSwitcher
    {
        void Navigate(MainWindow thisMainWindow);
    }
}
