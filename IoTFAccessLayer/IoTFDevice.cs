using IoTFAccessLayer.EventArgsModel;
using MqttLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IoTFAccessLayer
{
    public class IoTFDevice 
    {

        #region Members
        private bool _isConnected = false;
        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
            set
            {
                _isConnected = value;               
            }
        }

        IMqtt _client;

        string _connectionString = null;
        string _clientId = null;
        string _authMode = null;
        string _authToken = null;

        Object CallingObject = null;

        #endregion

        public IoTFDevice(object callingObject)
        {
            this.IsConnected = false;
            this._connectionString = ConfigurationSettings.AppSettings["DefaultConnectionString"] as string;
            this._authMode = ConfigurationSettings.AppSettings["AuthMode"] as string;
            this._authToken = ConfigurationSettings.AppSettings["AuthToken"] as string;
            this.CallingObject = callingObject;
        }

        public void Connect(string clientId)
        {
            // Instantiate client using MqttClientFactory
            this._clientId = clientId;
            this._client = MqttClientFactory.CreateClient(this._connectionString, this._clientId, this._authMode, this._authToken);

            // Setup some useful client delegate callbacks
            this._client.Connected += new ConnectionDelegate(client_Connected);
            this._client.ConnectionLost += new ConnectionDelegate(client_ConnectionLost);
            this._client.PublishArrived += new PublishArrivedDelegate(client_PublishArrived);

            //instantiating the connection 
            _client.Connect(true);
        }  

        public void Disconnect()
        {
            this._client.Disconnect();
        }

        public void RegisterSubscriptions()
        {
            throw new NotImplementedException();
        }

        public void Publish(object payload)
        {
            _client.Publish("iot-2/evt/iotsensor/fmt/json", JsonConvert.SerializeObject(payload), QoS.BestEfforts, false);
        }

        #region event methods

        private bool client_PublishArrived(object sender, PublishArrivedArgs e)
        {
            throw new NotImplementedException();
        }

        private void client_ConnectionLost(object sender, EventArgs e)
        {
            this.IsConnected = false;
        }

        private void client_Connected(object sender, EventArgs e)
        {
            this.IsConnected = true;
        }

        #endregion
    }
}
