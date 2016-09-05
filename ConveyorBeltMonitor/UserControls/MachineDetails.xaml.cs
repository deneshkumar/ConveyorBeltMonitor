using ConveyorBeltMonitor.Model;
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
    /// Interaction logic for MachineDetails.xaml
    /// </summary>
    public partial class MachineDetails : Page
    {
        public MachineDetails()
        {
            InitializeComponent();

            this.LoadData();
            this.btnStartMonitoring.Click += btnStartMonitoring_Click;
        }

        private void LoadData()
        {
            txtMachineId.Text = Machine.MachineId;
            txtMachineName.Text = Machine.MachineName;
            txtMachineLocation.Text = Machine.MachineLocation;
        }

        void btnStartMonitoring_Click(object sender, RoutedEventArgs e)
        {
            Machine.MachineId = txtMachineId.Text;
            Machine.MachineName = txtMachineName.Text;
            Machine.MachineLocation = txtMachineLocation.Text;

            if (!string.IsNullOrEmpty(Machine.MachineId) && !string.IsNullOrEmpty(Machine.MachineName))
            {
                PageSwitcher.SwitchTo(new Dashboard());
            }
           
        }
    }
}
