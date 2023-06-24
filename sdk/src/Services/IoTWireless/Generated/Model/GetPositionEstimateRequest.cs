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
    /// Container for the parameters to the GetPositionEstimate operation.
    /// Get estimated position information as a payload in GeoJSON format. The payload measurement
    /// data is resolved using solvers that are provided by third-party vendors.
    /// </summary>
    public partial class GetPositionEstimateRequest : AmazonIoTWirelessRequest
    {
        private CellTowers _cellTowers;
        private Gnss _gnss;
        private Ip _ip;
        private DateTime? _timestamp;
        private List<WiFiAccessPoint> _wiFiAccessPoints = new List<WiFiAccessPoint>();

        /// <summary>
        /// Gets and sets the property CellTowers. 
        /// <para>
        /// Retrieves an estimated device position by resolving measurement data from cellular
        /// radio towers. The position is resolved using HERE's cellular-based solver.
        /// </para>
        /// </summary>
        public CellTowers CellTowers
        {
            get { return this._cellTowers; }
            set { this._cellTowers = value; }
        }

        // Check to see if CellTowers property is set
        internal bool IsSetCellTowers()
        {
            return this._cellTowers != null;
        }

        /// <summary>
        /// Gets and sets the property Gnss. 
        /// <para>
        /// Retrieves an estimated device position by resolving the global navigation satellite
        /// system (GNSS) scan data. The position is resolved using the GNSS solver powered by
        /// LoRa Cloud.
        /// </para>
        /// </summary>
        public Gnss Gnss
        {
            get { return this._gnss; }
            set { this._gnss = value; }
        }

        // Check to see if Gnss property is set
        internal bool IsSetGnss()
        {
            return this._gnss != null;
        }

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// Retrieves an estimated device position by resolving the IP address information from
        /// the device. The position is resolved using MaxMind's IP-based solver.
        /// </para>
        /// </summary>
        public Ip Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Optional information that specifies the time when the position information will be
        /// resolved. It uses the Unix timestamp format. If not specified, the time at which the
        /// request was received will be used.
        /// </para>
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WiFiAccessPoints. 
        /// <para>
        /// Retrieves an estimated device position by resolving WLAN measurement data. The position
        /// is resolved using HERE's Wi-Fi based solver.
        /// </para>
        /// </summary>
        public List<WiFiAccessPoint> WiFiAccessPoints
        {
            get { return this._wiFiAccessPoints; }
            set { this._wiFiAccessPoints = value; }
        }

        // Check to see if WiFiAccessPoints property is set
        internal bool IsSetWiFiAccessPoints()
        {
            return this._wiFiAccessPoints != null && this._wiFiAccessPoints.Count > 0; 
        }

    }
}