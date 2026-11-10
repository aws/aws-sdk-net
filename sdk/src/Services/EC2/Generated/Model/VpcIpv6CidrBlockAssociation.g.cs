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
    /// Describes an IPv6 CIDR block associated with a VPC.
    /// </summary>
    public partial class VpcIpv6CidrBlockAssociation
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID for the IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property IpSource. 
        /// <para>
        /// The source that allocated the IP address space. <c>byoip</c> or <c>amazon</c> indicates
        /// public IP address space allocated by Amazon or space that you have allocated with
        /// Bring your own IP (BYOIP). <c>none</c> indicates private space.
        /// </para>
        /// </summary>
        public IpSource IpSource { get; set; }

        /// <summary>
        /// Checks to see if the IpSource property is set.
        /// </summary>
        internal bool IsSetIpSource() => this.IpSource != null;

        /// <summary>
        /// Gets and sets the property Ipv6AddressAttribute. 
        /// <para>
        /// Public IPv6 addresses are those advertised on the internet from Amazon Web Services.
        /// Private IP addresses are not and cannot be advertised on the internet from Amazon
        /// Web Services.
        /// </para>
        /// </summary>
        public Ipv6AddressAttribute Ipv6AddressAttribute { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6AddressAttribute property is set.
        /// </summary>
        internal bool IsSetIpv6AddressAttribute() => this.Ipv6AddressAttribute != null;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6CidrBlock property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlock() => this.Ipv6CidrBlock != null;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockState. 
        /// <para>
        /// Information about the state of the CIDR block.
        /// </para>
        /// </summary>
        public VpcCidrBlockState Ipv6CidrBlockState { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6CidrBlockState property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlockState() => this.Ipv6CidrBlockState != null;

        /// <summary>
        /// Gets and sets the property Ipv6Pool. 
        /// <para>
        /// The ID of the IPv6 address pool from which the IPv6 CIDR block is allocated.
        /// </para>
        /// </summary>
        public string Ipv6Pool { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Pool property is set.
        /// </summary>
        internal bool IsSetIpv6Pool() => this.Ipv6Pool != null;

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the unique set of Availability Zones, Local Zones, or Wavelength Zones
        /// from which Amazon Web Services advertises IP addresses, for example, <c>us-east-1-wl1-bos-wlz-1</c>.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;
    }
}
