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
    /// This is the response object from the GetWirelessDeviceStatistics operation.
    /// </summary>
    public partial class GetWirelessDeviceStatisticsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property LastUplinkReceivedAt. 
        /// <para>
        /// The date and time when the most recent uplink was received.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value is only valid for 3 months.
        /// </para>
        ///  </note>
        /// </summary>
        public string LastUplinkReceivedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUplinkReceivedAt property is set.
        /// </summary>
        internal bool IsSetLastUplinkReceivedAt() => this.LastUplinkReceivedAt != null;

        /// <summary>
        /// Gets and sets the property LoRaWAN. 
        /// <para>
        /// Information about the wireless device's operations.
        /// </para>
        /// </summary>
        public LoRaWANDeviceMetadata LoRaWAN { get; set; }

        /// <summary>
        /// Checks to see if the LoRaWAN property is set.
        /// </summary>
        internal bool IsSetLoRaWAN() => this.LoRaWAN != null;

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// MetaData for Sidewalk device.
        /// </para>
        /// </summary>
        public SidewalkDeviceMetadata Sidewalk { get; set; }

        /// <summary>
        /// Checks to see if the Sidewalk property is set.
        /// </summary>
        internal bool IsSetSidewalk() => this.Sidewalk != null;

        /// <summary>
        /// Gets and sets the property WirelessDeviceId. 
        /// <para>
        /// The ID of the wireless device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string WirelessDeviceId { get; set; }

        /// <summary>
        /// Checks to see if the WirelessDeviceId property is set.
        /// </summary>
        internal bool IsSetWirelessDeviceId() => this.WirelessDeviceId != null;
    }
}
