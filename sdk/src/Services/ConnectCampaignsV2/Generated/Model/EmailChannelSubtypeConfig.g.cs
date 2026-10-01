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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Email Channel Subtype config
    /// </summary>
    public partial class EmailChannelSubtypeConfig
    {
        /// <summary>
        /// Gets and sets the property Capacity.
        /// </summary>
        [AWSProperty(Max = 1)]
        public double? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultOutboundConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public EmailOutboundConfig DefaultOutboundConfig { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOutboundConfig property is set.
        /// </summary>
        internal bool IsSetDefaultOutboundConfig() => this.DefaultOutboundConfig != null;

        /// <summary>
        /// Gets and sets the property OutboundMode.
        /// </summary>
        [AWSProperty(Required = true)]
        public EmailOutboundMode OutboundMode { get; set; }

        /// <summary>
        /// Checks to see if the OutboundMode property is set.
        /// </summary>
        internal bool IsSetOutboundMode() => this.OutboundMode != null;
    }
}
