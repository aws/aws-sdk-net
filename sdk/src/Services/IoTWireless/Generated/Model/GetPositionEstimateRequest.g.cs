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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the GetPositionEstimate operation. Get estimated position
    /// information as a payload in GeoJSON format. The payload measurement data is resolved
    /// using solvers that are provided by third-party vendors.
    /// </summary>
    public partial class GetPositionEstimateRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property AdvancedConfiguration. 
        /// <para>
        /// Optional configuration for customizing position measurement data.
        /// </para>
        /// </summary>
        public AdvancedConfiguration AdvancedConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AdvancedConfiguration property is set.
        /// </summary>
        internal bool IsSetAdvancedConfiguration() => this.AdvancedConfiguration != null;

        /// <summary>
        /// Gets and sets the property CellTowers. 
        /// <para>
        /// Retrieves an estimated device position by resolving measurement data from cellular
        /// radio towers. The position is resolved using HERE's cellular-based solver.
        /// </para>
        /// </summary>
        public CellTowers CellTowers { get; set; }

        /// <summary>
        /// Checks to see if the CellTowers property is set.
        /// </summary>
        internal bool IsSetCellTowers() => this.CellTowers != null;

        /// <summary>
        /// Gets and sets the property Gnss. 
        /// <para>
        /// Retrieves an estimated device position by resolving the global navigation satellite
        /// system (GNSS) scan data. The position is resolved using the GNSS solver powered by
        /// LoRa Cloud. This field is mutually exclusive with the GnssMultiFrame field.
        /// </para>
        /// </summary>
        public Gnss Gnss { get; set; }

        /// <summary>
        /// Checks to see if the Gnss property is set.
        /// </summary>
        internal bool IsSetGnss() => this.Gnss != null;

        /// <summary>
        /// Gets and sets the property GnssMultiFrame. 
        /// <para>
        /// Retrieves an estimated device position by resolving multiple global navigation satellite
        /// system (GNSS) scan captures. The position is resolved using the multi-frame GNSS solver
        /// powered by LoRa Cloud. This field is mutually exclusive with the Gnss field.
        /// </para>
        /// </summary>
        public GnssMultiFrame GnssMultiFrame { get; set; }

        /// <summary>
        /// Checks to see if the GnssMultiFrame property is set.
        /// </summary>
        internal bool IsSetGnssMultiFrame() => this.GnssMultiFrame != null;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// Retrieves an estimated device position by resolving the IP address information from
        /// the device. The position is resolved using MaxMind's IP-based solver.
        /// </para>
        /// </summary>
        public Ip Ip { get; set; }

        /// <summary>
        /// Checks to see if the Ip property is set.
        /// </summary>
        internal bool IsSetIp() => this.Ip != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// Optional information that specifies the time when the position information will be
        /// resolved. It uses the Unix timestamp format. If not specified, the time at which the
        /// request was received will be used.
        /// </para>
        /// </summary>
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp.HasValue;

        /// <summary>
        /// Gets and sets the property WiFiAccessPoints. 
        /// <para>
        /// Retrieves an estimated device position by resolving WLAN measurement data. The position
        /// is resolved using HERE's Wi-Fi based solver.
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
