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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// The device's position, IP address, and Wi-Fi access points.
    /// </summary>
    public partial class DeviceState
    {
        private PositionalAccuracy _accuracy;
        private CellSignals _cellSignals;
        private string _deviceId;
        private string _ipv4Address;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private DateTime? _sampleTime;
        private List<WiFiAccessPoint> _wiFiAccessPoints = AWSConfigs.InitializeCollections ? new List<WiFiAccessPoint>() : null;

        /// <summary>
        /// Gets and sets the property Accuracy.
        /// </summary>
        public PositionalAccuracy Accuracy
        {
            get { return this._accuracy; }
            set { this._accuracy = value; }
        }

        // Check to see if Accuracy property is set
        internal bool IsSetAccuracy()
        {
            return this._accuracy != null;
        }

        /// <summary>
        /// Gets and sets the property CellSignals. 
        /// <para>
        /// The cellular network infrastructure that the device is connected to.
        /// </para>
        /// </summary>
        public CellSignals CellSignals
        {
            get { return this._cellSignals; }
            set { this._cellSignals = value; }
        }

        // Check to see if CellSignals property is set
        internal bool IsSetCellSignals()
        {
            return this._cellSignals != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The device's Ipv4 address.
        /// </para>
        /// </summary>
        public string Ipv4Address
        {
            get { return this._ipv4Address; }
            set { this._ipv4Address = value; }
        }

        // Check to see if Ipv4Address property is set
        internal bool IsSetIpv4Address()
        {
            return this._ipv4Address != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The last known device position.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && (this._position.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The timestamp at which the device's position was determined. Uses <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601 </a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public DateTime? SampleTime
        {
            get { return this._sampleTime; }
            set { this._sampleTime = value; }
        }

        // Check to see if SampleTime property is set
        internal bool IsSetSampleTime()
        {
            return this._sampleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WiFiAccessPoints. 
        /// <para>
        /// The Wi-Fi access points the device is using.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WiFiAccessPoint> WiFiAccessPoints
        {
            get { return this._wiFiAccessPoints; }
            set { this._wiFiAccessPoints = value; }
        }

        // Check to see if WiFiAccessPoints property is set
        internal bool IsSetWiFiAccessPoints()
        {
            return this._wiFiAccessPoints != null && (this._wiFiAccessPoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}