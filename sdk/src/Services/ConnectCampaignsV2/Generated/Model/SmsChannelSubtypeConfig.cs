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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// SMS Channel Subtype config
    /// </summary>
    public partial class SmsChannelSubtypeConfig
    {
        private double? _capacity;
        private SmsOutboundConfig _defaultOutboundConfig;
        private SmsOutboundMode _outboundMode;

        /// <summary>
        /// Gets and sets the property Capacity.
        /// </summary>
        [AWSProperty(Max=1)]
        public double? Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultOutboundConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public SmsOutboundConfig DefaultOutboundConfig
        {
            get { return this._defaultOutboundConfig; }
            set { this._defaultOutboundConfig = value; }
        }

        // Check to see if DefaultOutboundConfig property is set
        internal bool IsSetDefaultOutboundConfig()
        {
            return this._defaultOutboundConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundMode.
        /// </summary>
        [AWSProperty(Required=true)]
        public SmsOutboundMode OutboundMode
        {
            get { return this._outboundMode; }
            set { this._outboundMode = value; }
        }

        // Check to see if OutboundMode property is set
        internal bool IsSetOutboundMode()
        {
            return this._outboundMode != null;
        }

    }
}