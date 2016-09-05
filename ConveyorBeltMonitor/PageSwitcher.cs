using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConveyorBeltMonitor
{
    static class PageSwitcher
    {
        public static MainWindow MainPage { get; set; }

        public static void SwitchTo(Page page)
        {
            if(MainPage != null)
            {
                MainPage.Content = page;
                MainPage.Title = page.GetType().Name;
            }
        }

    }
}
