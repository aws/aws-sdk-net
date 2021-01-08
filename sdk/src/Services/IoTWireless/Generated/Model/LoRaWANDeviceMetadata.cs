/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWAN device metatdata.
    /// </summary>
    public partial class LoRaWANDeviceMetadata
    {
        private int? _dataRate;
        private string _devEui;
        private int? _fPort;
        private int? _frequency;
        private List<LoRaWANGatewayMetadata> _gateways = new List<LoRaWANGatewayMetadata>();
        private string _timestamp;

        /// <summary>
        /// Gets and sets the property DataRate. 
        /// <para>
        /// The DataRate value.
        /// </para>
        /// </summary>
        public int DataRate
        {
            get { return this._dataRate.GetValueOrDefault(); }
            set { this._dataRate = value; }
        }

        // Check to see if DataRate property is set
        internal bool IsSetDataRate()
        {
            return this._dataRate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DevEui. 
        /// <para>
        /// The DevEUI value.
        /// </para>
        /// </summary>
        public string DevEui
        {
            get { return this._devEui; }
            set { this._devEui = value; }
        }

        // Check to see if DevEui property is set
        internal bool IsSetDevEui()
        {
            return this._devEui != null;
        }

        /// <summary>
        /// Gets and sets the property FPort. 
        /// <para>
        /// The FPort value.
        /// </para>
        /// </summary>
        public int FPort
        {
            get { return this._fPort.GetValueOrDefault(); }
            set { this._fPort = value; }
        }

        // Check to see if FPort property is set
        internal bool IsSetFPort()
        {
            return this._fPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        /// The device's channel frequency in Hz.
        /// </para>
        /// </summary>
        public int Frequency
        {
            get { return this._frequency.GetValueOrDefault(); }
            set { this._frequency = value; }
        }

        // Check to see if Frequency property is set
        internal bool IsSetFrequency()
        {
            return this._frequency.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gateways. 
        /// <para>
        /// Information about the gateways accessed by the device.
        /// </para>
        /// </summary>
        public List<LoRaWANGatewayMetadata> Gateways
        {
            get { return this._gateways; }
            set { this._gateways = value; }
        }

        // Check to see if Gateways property is set
        internal bool IsSetGateways()
        {
            return this._gateways != null && this._gateways.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The date and time of the metadata.
        /// </para>
        /// </summary>
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}