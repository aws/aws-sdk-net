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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Accuracy.
        /// </summary>
        public PositionalAccuracy Accuracy { get; set; }

        /// <summary>
        /// Checks to see if the Accuracy property is set.
        /// </summary>
        internal bool IsSetAccuracy() => this.Accuracy != null;

        /// <summary>
        /// Gets and sets the property CellSignals. 
        /// <para>
        /// The cellular network infrastructure that the device is connected to.
        /// </para>
        /// </summary>
        public CellSignals CellSignals { get; set; }

        /// <summary>
        /// Checks to see if the CellSignals property is set.
        /// </summary>
        internal bool IsSetCellSignals() => this.CellSignals != null;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The device identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property Ipv4Address. 
        /// <para>
        /// The device's Ipv4 address.
        /// </para>
        /// </summary>
        public string Ipv4Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4Address property is set.
        /// </summary>
        internal bool IsSetIpv4Address() => this.Ipv4Address != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The last known device position.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SampleTime. 
        /// <para>
        /// The timestamp at which the device's position was determined. Uses <a href="https://www.iso.org/iso-8601-date-and-time-format.html">
        /// ISO 8601 </a> format: <c>YYYY-MM-DDThh:mm:ss.sssZ</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public DateTime? SampleTime { get; set; }

        /// <summary>
        /// Checks to see if the SampleTime property is set.
        /// </summary>
        internal bool IsSetSampleTime() => this.SampleTime.HasValue;

        /// <summary>
        /// Gets and sets the property WiFiAccessPoints. 
        /// <para>
        /// The Wi-Fi access points the device is using.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WiFiAccessPoint> WiFiAccessPoints { get; set; } = AWSConfigs.InitializeCollections ? new List<WiFiAccessPoint>() : null;

        /// <summary>
        /// Checks to see if the WiFiAccessPoints property is set.
        /// </summary>
        internal bool IsSetWiFiAccessPoints() => this.WiFiAccessPoints != null && (this.WiFiAccessPoints.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
