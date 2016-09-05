using IoTFAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConveyorBeltMonitor.UserControls
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        IoTFDevice _iotfdevice = null;        
        
        public Dashboard()
        {
            InitializeComponent();
            _iotfdevice = new IoTFDevice(this);
            this.btnConnStatusIdicator.Background = Brushes.Red;
            this.btnConnStatusIdicator.Click += btnConnStatusIdicator_Click;
        }
       
        void btnConnStatusIdicator_Click(object sender, RoutedEventArgs e)
        {
            _iotfdevice.Connect("d:bxzwrt:conveyor_motor:b2789i2uy2");
        }

    }
}
