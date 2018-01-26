/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNetworkProfile operation.
    /// Updates the network profile with specific settings.
    /// </summary>
    public partial class UpdateNetworkProfileRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private string _description;
        private long? _downlinkBandwidthBits;
        private long? _downlinkDelayMs;
        private long? _downlinkJitterMs;
        private int? _downlinkLossPercent;
        private string _name;
        private NetworkProfileType _type;
        private long? _uplinkBandwidthBits;
        private long? _uplinkDelayMs;
        private long? _uplinkJitterMs;
        private int? _uplinkLossPercent;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project for which you want to update network
        /// profile settings.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The descriptoin of the network profile about which you are returning information.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DownlinkBandwidthBits. 
        /// <para>
        /// The data throughput rate in bits per second, as an integer from 0 to 104857600.
        /// </para>
        /// </summary>
        public long DownlinkBandwidthBits
        {
            get { return this._downlinkBandwidthBits.GetValueOrDefault(); }
            set { this._downlinkBandwidthBits = value; }
        }

        // Check to see if DownlinkBandwidthBits property is set
        internal bool IsSetDownlinkBandwidthBits()
        {
            return this._downlinkBandwidthBits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownlinkDelayMs. 
        /// <para>
        /// Delay time for all packets to destination in milliseconds as an integer from 0 to
        /// 2000.
        /// </para>
        /// </summary>
        public long DownlinkDelayMs
        {
            get { return this._downlinkDelayMs.GetValueOrDefault(); }
            set { this._downlinkDelayMs = value; }
        }

        // Check to see if DownlinkDelayMs property is set
        internal bool IsSetDownlinkDelayMs()
        {
            return this._downlinkDelayMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownlinkJitterMs. 
        /// <para>
        /// Time variation in the delay of received packets in milliseconds as an integer from
        /// 0 to 2000.
        /// </para>
        /// </summary>
        public long DownlinkJitterMs
        {
            get { return this._downlinkJitterMs.GetValueOrDefault(); }
            set { this._downlinkJitterMs = value; }
        }

        // Check to see if DownlinkJitterMs property is set
        internal bool IsSetDownlinkJitterMs()
        {
            return this._downlinkJitterMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DownlinkLossPercent. 
        /// <para>
        /// Proportion of received packets that fail to arrive from 0 to 100 percent.
        /// </para>
        /// </summary>
        public int DownlinkLossPercent
        {
            get { return this._downlinkLossPercent.GetValueOrDefault(); }
            set { this._downlinkLossPercent = value; }
        }

        // Check to see if DownlinkLossPercent property is set
        internal bool IsSetDownlinkLossPercent()
        {
            return this._downlinkLossPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the network profile about which you are returning information.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of network profile you wish to return information about. Valid values are
        /// listed below.
        /// </para>
        /// </summary>
        public NetworkProfileType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UplinkBandwidthBits. 
        /// <para>
        /// The data throughput rate in bits per second, as an integer from 0 to 104857600.
        /// </para>
        /// </summary>
        public long UplinkBandwidthBits
        {
            get { return this._uplinkBandwidthBits.GetValueOrDefault(); }
            set { this._uplinkBandwidthBits = value; }
        }

        // Check to see if UplinkBandwidthBits property is set
        internal bool IsSetUplinkBandwidthBits()
        {
            return this._uplinkBandwidthBits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UplinkDelayMs. 
        /// <para>
        /// Delay time for all packets to destination in milliseconds as an integer from 0 to
        /// 2000.
        /// </para>
        /// </summary>
        public long UplinkDelayMs
        {
            get { return this._uplinkDelayMs.GetValueOrDefault(); }
            set { this._uplinkDelayMs = value; }
        }

        // Check to see if UplinkDelayMs property is set
        internal bool IsSetUplinkDelayMs()
        {
            return this._uplinkDelayMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UplinkJitterMs. 
        /// <para>
        /// Time variation in the delay of received packets in milliseconds as an integer from
        /// 0 to 2000.
        /// </para>
        /// </summary>
        public long UplinkJitterMs
        {
            get { return this._uplinkJitterMs.GetValueOrDefault(); }
            set { this._uplinkJitterMs = value; }
        }

        // Check to see if UplinkJitterMs property is set
        internal bool IsSetUplinkJitterMs()
        {
            return this._uplinkJitterMs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UplinkLossPercent. 
        /// <para>
        /// Proportion of transmitted packets that fail to arrive from 0 to 100 percent.
        /// </para>
        /// </summary>
        public int UplinkLossPercent
        {
            get { return this._uplinkLossPercent.GetValueOrDefault(); }
            set { this._uplinkLossPercent = value; }
        }

        // Check to see if UplinkLossPercent property is set
        internal bool IsSetUplinkLossPercent()
        {
            return this._uplinkLossPercent.HasValue; 
        }

    }
}