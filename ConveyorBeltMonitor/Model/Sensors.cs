using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConveyorBeltMonitor.Model
{
    class Sensors
    {
        private double _speedometer = 0;
        private double _gearVibrationSensor = 0;
        private double _bearingTemperatureSensor = 0;
        private double _motorTemperatureSensor = 0;
        private double _frictionCoefficientSensor = 0;

        public double Speedometer
        {
            get { return _speedometer; }
            set 
            {
                this._speedometer = value;
                this.UpdateSpeedometer(value);
            }
        }
        public double GearVibrationSensor
        {
            get { return _speedometer; }
            set
            {
                this._gearVibrationSensor = value;
                this.UpdateGearVibrationSensor(value);
            }
        }
        public double BearingTemperatureSensor
        {
            get { return _bearingTemperatureSensor; }
            set
            {
                this._bearingTemperatureSensor = value;
                this.UpdateBearingTemperatureSensor(value);
            }
        }
        public double MotorTemperatureSensor
        {
            get { return _motorTemperatureSensor; }
            set
            {
                this._motorTemperatureSensor = value;
                this.UpdateMotorTemperatureSensor(value);
            }
        }
        public double FrictionCoefficientSensor
        {
            get { return _frictionCoefficientSensor; }
            set
            {
                this._frictionCoefficientSensor = value;
                this.UpdateFrictionCoefficientSensor(value);
            }
        }

        public Sensors()
        {
            this.Speedometer = 10.00;
            this.GearVibrationSensor = 100.00;
            this.BearingTemperatureSensor = 40.00;
            this.MotorTemperatureSensor = 50.00;
            this.FrictionCoefficientSensor = 0.1;
        }

        private void UpdateFrictionCoefficientSensor(double p)
        {
            MachineProperties.PulleyFriction = p;
        }

        private void UpdateMotorTemperatureSensor(double p)
        {
            MachineProperties.MotorTemperature = p;
        }

        private void UpdateBearingTemperatureSensor(double p)
        {
            MachineProperties.BearingTemperature = p;
        }

        private void UpdateGearVibrationSensor(double p)
        {
            MachineProperties.GearVibration = p;
        }

        private void UpdateSpeedometer(double p)
        {
            MachineProperties.RotarySpeed = p;
        }
    }
}
