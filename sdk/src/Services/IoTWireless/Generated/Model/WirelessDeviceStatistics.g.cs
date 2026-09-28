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
    /// Information about a wireless device's operation.
    /// </summary>
    public partial class WirelessDeviceStatistics
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name of the resource.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// The name of the destination to which the device is assigned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string DestinationName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationName property is set.
        /// </summary>
        internal bool IsSetDestinationName() => this.DestinationName != null;

        /// <summary>
        /// Gets and sets the property FuotaDeviceStatus.
        /// </summary>
        public FuotaDeviceStatus FuotaDeviceStatus { get; set; }

        /// <summary>
        /// Checks to see if the FuotaDeviceStatus property is set.
        /// </summary>
        internal bool IsSetFuotaDeviceStatus() => this.FuotaDeviceStatus != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the wireless device reporting the data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUplinkReceivedAt. 
        /// <para>
        /// The date and time when the most recent uplink was received.
        /// </para>
        ///  <note> 
        /// <para>
        /// Theis value is only valid for 3 months.
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
        /// LoRaWAN device info.
        /// </para>
        /// </summary>
        public LoRaWANListDevice LoRaWAN { get; set; }

        /// <summary>
        /// Checks to see if the LoRaWAN property is set.
        /// </summary>
        internal bool IsSetLoRaWAN() => this.LoRaWAN != null;

        /// <summary>
        /// Gets and sets the property McGroupId.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public int? McGroupId { get; set; }

        /// <summary>
        /// Checks to see if the McGroupId property is set.
        /// </summary>
        internal bool IsSetMcGroupId() => this.McGroupId.HasValue;

        /// <summary>
        /// Gets and sets the property MulticastDeviceStatus. 
        /// <para>
        /// The status of the wireless device in the multicast group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MulticastDeviceStatus { get; set; }

        /// <summary>
        /// Checks to see if the MulticastDeviceStatus property is set.
        /// </summary>
        internal bool IsSetMulticastDeviceStatus() => this.MulticastDeviceStatus != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Positioning. 
        /// <para>
        /// The integration status of the Device Location feature for LoRaWAN and Amazon Sidewalk
        /// enabled devices.
        /// </para>
        /// </summary>
        public PositioningConfigStatus Positioning { get; set; }

        /// <summary>
        /// Checks to see if the Positioning property is set.
        /// </summary>
        internal bool IsSetPositioning() => this.Positioning != null;

        /// <summary>
        /// Gets and sets the property Sidewalk. 
        /// <para>
        /// The Sidewalk account credentials.
        /// </para>
        /// </summary>
        public SidewalkListDevice Sidewalk { get; set; }

        /// <summary>
        /// Checks to see if the Sidewalk property is set.
        /// </summary>
        internal bool IsSetSidewalk() => this.Sidewalk != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The wireless device type.
        /// </para>
        /// </summary>
        public WirelessDeviceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
