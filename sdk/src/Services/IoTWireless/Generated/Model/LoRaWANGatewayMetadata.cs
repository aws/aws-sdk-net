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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWAN gateway metatdata.
    /// </summary>
    public partial class LoRaWANGatewayMetadata
    {
        private string _gatewayEui;
        private double? _rssi;
        private double? _snr;

        /// <summary>
        /// Gets and sets the property GatewayEui. 
        /// <para>
        /// The gateway's EUI value.
        /// </para>
        /// </summary>
        public string GatewayEui
        {
            get { return this._gatewayEui; }
            set { this._gatewayEui = value; }
        }

        // Check to see if GatewayEui property is set
        internal bool IsSetGatewayEui()
        {
            return this._gatewayEui != null;
        }

        /// <summary>
        /// Gets and sets the property Rssi. 
        /// <para>
        /// The RSSI value.
        /// </para>
        /// </summary>
        public double? Rssi
        {
            get { return this._rssi; }
            set { this._rssi = value; }
        }

        // Check to see if Rssi property is set
        internal bool IsSetRssi()
        {
            return this._rssi.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Snr. 
        /// <para>
        /// The SNR value.
        /// </para>
        /// </summary>
        public double? Snr
        {
            get { return this._snr; }
            set { this._snr = value; }
        }

        // Check to see if Snr property is set
        internal bool IsSetSnr()
        {
            return this._snr.HasValue; 
        }

    }
}