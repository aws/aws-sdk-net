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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// A CIDR provisioned to an IPAM pool.
    /// </summary>
    public partial class IpamPoolCidr
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR provisioned to the IPAM pool. A CIDR is a representation of an IP address
        /// and its associated network mask (or netmask) and refers to a range of IP addresses.
        /// An IPv4 CIDR example is <c>10.24.34.0/23</c>. An IPv6 CIDR example is <c>2001:DB8::/32</c>.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Details related to why an IPAM pool CIDR failed to be provisioned.
        /// </para>
        /// </summary>
        public IpamPoolCidrFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IpamPoolCidrId. 
        /// <para>
        /// The IPAM pool CIDR ID.
        /// </para>
        /// </summary>
        public string IpamPoolCidrId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolCidrId property is set.
        /// </summary>
        internal bool IsSetIpamPoolCidrId() => this.IpamPoolCidrId != null;

        /// <summary>
        /// Gets and sets the property NetmaskLength. 
        /// <para>
        /// The netmask length of the CIDR you'd like to provision to a pool. Can be used for
        /// provisioning Amazon-provided IPv6 CIDRs to top-level pools and for provisioning CIDRs
        /// to pools with source pools. Cannot be used to provision BYOIP CIDRs to top-level pools.
        /// "NetmaskLength" or "Cidr" is required.
        /// </para>
        /// </summary>
        public int? NetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the NetmaskLength property is set.
        /// </summary>
        internal bool IsSetNetmaskLength() => this.NetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the CIDR.
        /// </para>
        /// </summary>
        public IpamPoolCidrState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
