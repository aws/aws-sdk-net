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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// The network settings for the input device.
    /// </summary>
    public partial class InputDeviceNetworkSettings
    {
        /// <summary>
        /// Gets and sets the property DnsAddresses. The DNS addresses of the input device.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsAddresses property is set.
        /// </summary>
        internal bool IsSetDnsAddresses() => this.DnsAddresses != null && (this.DnsAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Gateway. The network gateway IP address.
        /// </summary>
        public string Gateway { get; set; }

        /// <summary>
        /// Checks to see if the Gateway property is set.
        /// </summary>
        internal bool IsSetGateway() => this.Gateway != null;

        /// <summary>
        /// Gets and sets the property IpAddress. The IP address of the input device.
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property IpScheme. Specifies whether the input device has been configured
        /// (outside of MediaLive) to use a dynamic IP address assignment (DHCP) or a static IP
        /// address.
        /// </summary>
        public InputDeviceIpScheme IpScheme { get; set; }

        /// <summary>
        /// Checks to see if the IpScheme property is set.
        /// </summary>
        internal bool IsSetIpScheme() => this.IpScheme != null;

        /// <summary>
        /// Gets and sets the property SubnetMask. The subnet mask of the input device.
        /// </summary>
        public string SubnetMask { get; set; }

        /// <summary>
        /// Checks to see if the SubnetMask property is set.
        /// </summary>
        internal bool IsSetSubnetMask() => this.SubnetMask != null;
    }
}
