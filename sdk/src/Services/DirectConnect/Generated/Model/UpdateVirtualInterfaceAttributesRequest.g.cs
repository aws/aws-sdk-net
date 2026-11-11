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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateVirtualInterfaceAttributes operation. Updates
    /// the specified attributes of the specified virtual private interface. <para> Setting
    /// the MTU of a virtual interface to 8500 (jumbo frames) can cause an update to the underlying
    /// physical connection if it wasn't updated to support jumbo frames. Updating the connection
    /// disrupts network connectivity for all virtual interfaces associated with the connection
    /// for up to 30 seconds. To check whether your connection supports jumbo frames, call
    /// <a>DescribeConnections</a>. To check whether your virtual interface supports jumbo
    /// frames, call <a>DescribeVirtualInterfaces</a>. </para>
    /// </summary>
    public partial class UpdateVirtualInterfaceAttributesRequest : AmazonDirectConnectRequest
    {
        /// <summary>
        /// Gets and sets the property EnableSiteLink. 
        /// <para>
        /// Indicates whether to enable or disable SiteLink.
        /// </para>
        /// </summary>
        public bool? EnableSiteLink { get; set; }

        /// <summary>
        /// Checks to see if the EnableSiteLink property is set.
        /// </summary>
        internal bool IsSetEnableSiteLink() => this.EnableSiteLink.HasValue;

        /// <summary>
        /// Gets and sets the property Mtu. 
        /// <para>
        /// The maximum transmission unit (MTU), in bytes. The supported values are 1500 and 8500.
        /// The default value is 1500.
        /// </para>
        /// </summary>
        public int? Mtu { get; set; }

        /// <summary>
        /// Checks to see if the Mtu property is set.
        /// </summary>
        internal bool IsSetMtu() => this.Mtu.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolAllocatedCountIpv4. 
        /// <para>
        /// The number of inbound IPv4 route prefixes to allocate to the virtual interface. Not
        /// applicable to public virtual interfaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolAllocatedCountIpv4 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolAllocatedCountIpv4 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolAllocatedCountIpv4() => this.PrefixPoolAllocatedCountIpv4.HasValue;

        /// <summary>
        /// Gets and sets the property PrefixPoolAllocatedCountIpv6. 
        /// <para>
        /// The number of inbound IPv6 route prefixes to allocate to the virtual interface. Not
        /// applicable to public virtual interfaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? PrefixPoolAllocatedCountIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the PrefixPoolAllocatedCountIpv6 property is set.
        /// </summary>
        internal bool IsSetPrefixPoolAllocatedCountIpv6() => this.PrefixPoolAllocatedCountIpv6.HasValue;

        /// <summary>
        /// Gets and sets the property RateLimit. 
        /// <para>
        /// The rate limit (bandwidth allocation) to apply to the virtual interface. Use this
        /// to update the bandwidth allocation on an existing virtual interface.
        /// </para>
        /// </summary>
        public string RateLimit { get; set; }

        /// <summary>
        /// Checks to see if the RateLimit property is set.
        /// </summary>
        internal bool IsSetRateLimit() => this.RateLimit != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual private interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VirtualInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceId property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceId() => this.VirtualInterfaceId != null;

        /// <summary>
        /// Gets and sets the property VirtualInterfaceName. 
        /// <para>
        /// The name of the virtual private interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualInterfaceName property is set.
        /// </summary>
        internal bool IsSetVirtualInterfaceName() => this.VirtualInterfaceName != null;
    }
}
