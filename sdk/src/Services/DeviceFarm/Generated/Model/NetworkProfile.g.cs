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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// An array of settings that describes characteristics of a network profile.
    /// </summary>
    public partial class NetworkProfile
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the network profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the network profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DownlinkBandwidthBits. 
        /// <para>
        /// The data throughput rate in bits per second, as an integer from 0 to 104857600.
        /// </para>
        /// </summary>
        public long? DownlinkBandwidthBits { get; set; }

        /// <summary>
        /// Checks to see if the DownlinkBandwidthBits property is set.
        /// </summary>
        internal bool IsSetDownlinkBandwidthBits() => this.DownlinkBandwidthBits.HasValue;

        /// <summary>
        /// Gets and sets the property DownlinkDelayMs. 
        /// <para>
        /// Delay time for all packets to destination in milliseconds as an integer from 0 to
        /// 2000.
        /// </para>
        /// </summary>
        public long? DownlinkDelayMs { get; set; }

        /// <summary>
        /// Checks to see if the DownlinkDelayMs property is set.
        /// </summary>
        internal bool IsSetDownlinkDelayMs() => this.DownlinkDelayMs.HasValue;

        /// <summary>
        /// Gets and sets the property DownlinkJitterMs. 
        /// <para>
        /// Time variation in the delay of received packets in milliseconds as an integer from
        /// 0 to 2000.
        /// </para>
        /// </summary>
        public long? DownlinkJitterMs { get; set; }

        /// <summary>
        /// Checks to see if the DownlinkJitterMs property is set.
        /// </summary>
        internal bool IsSetDownlinkJitterMs() => this.DownlinkJitterMs.HasValue;

        /// <summary>
        /// Gets and sets the property DownlinkLossPercent. 
        /// <para>
        /// Proportion of received packets that fail to arrive from 0 to 100 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? DownlinkLossPercent { get; set; }

        /// <summary>
        /// Checks to see if the DownlinkLossPercent property is set.
        /// </summary>
        internal bool IsSetDownlinkLossPercent() => this.DownlinkLossPercent.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of network profile. Valid values are listed here.
        /// </para>
        /// </summary>
        public NetworkProfileType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UplinkBandwidthBits. 
        /// <para>
        /// The data throughput rate in bits per second, as an integer from 0 to 104857600.
        /// </para>
        /// </summary>
        public long? UplinkBandwidthBits { get; set; }

        /// <summary>
        /// Checks to see if the UplinkBandwidthBits property is set.
        /// </summary>
        internal bool IsSetUplinkBandwidthBits() => this.UplinkBandwidthBits.HasValue;

        /// <summary>
        /// Gets and sets the property UplinkDelayMs. 
        /// <para>
        /// Delay time for all packets to destination in milliseconds as an integer from 0 to
        /// 2000.
        /// </para>
        /// </summary>
        public long? UplinkDelayMs { get; set; }

        /// <summary>
        /// Checks to see if the UplinkDelayMs property is set.
        /// </summary>
        internal bool IsSetUplinkDelayMs() => this.UplinkDelayMs.HasValue;

        /// <summary>
        /// Gets and sets the property UplinkJitterMs. 
        /// <para>
        /// Time variation in the delay of received packets in milliseconds as an integer from
        /// 0 to 2000.
        /// </para>
        /// </summary>
        public long? UplinkJitterMs { get; set; }

        /// <summary>
        /// Checks to see if the UplinkJitterMs property is set.
        /// </summary>
        internal bool IsSetUplinkJitterMs() => this.UplinkJitterMs.HasValue;

        /// <summary>
        /// Gets and sets the property UplinkLossPercent. 
        /// <para>
        /// Proportion of transmitted packets that fail to arrive from 0 to 100 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? UplinkLossPercent { get; set; }

        /// <summary>
        /// Checks to see if the UplinkLossPercent property is set.
        /// </summary>
        internal bool IsSetUplinkLossPercent() => this.UplinkLossPercent.HasValue;
    }
}
