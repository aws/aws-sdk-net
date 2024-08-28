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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private string _associationId;
        private IpSource _ipSource;
        private Ipv6AddressAttribute _ipv6AddressAttribute;
        private string _ipv6CidrBlock;
        private VpcCidrBlockState _ipv6CidrBlockState;
        private string _ipv6Pool;
        private string _networkBorderGroup;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The association ID for the IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property IpSource. 
        /// <para>
        /// The source that allocated the IP address space. <c>byoip</c> or <c>amazon</c> indicates
        /// public IP address space allocated by Amazon or space that you have allocated with
        /// Bring your own IP (BYOIP). <c>none</c> indicates private space.
        /// </para>
        /// </summary>
        public IpSource IpSource
        {
            get { return this._ipSource; }
            set { this._ipSource = value; }
        }

        // Check to see if IpSource property is set
        internal bool IsSetIpSource()
        {
            return this._ipSource != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6AddressAttribute. 
        /// <para>
        /// Public IPv6 addresses are those advertised on the internet from Amazon Web Services.
        /// Private IP addresses are not and cannot be advertised on the internet from Amazon
        /// Web Services.
        /// </para>
        /// </summary>
        public Ipv6AddressAttribute Ipv6AddressAttribute
        {
            get { return this._ipv6AddressAttribute; }
            set { this._ipv6AddressAttribute = value; }
        }

        // Check to see if Ipv6AddressAttribute property is set
        internal bool IsSetIpv6AddressAttribute()
        {
            return this._ipv6AddressAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock
        {
            get { return this._ipv6CidrBlock; }
            set { this._ipv6CidrBlock = value; }
        }

        // Check to see if Ipv6CidrBlock property is set
        internal bool IsSetIpv6CidrBlock()
        {
            return this._ipv6CidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockState. 
        /// <para>
        /// Information about the state of the CIDR block.
        /// </para>
        /// </summary>
        public VpcCidrBlockState Ipv6CidrBlockState
        {
            get { return this._ipv6CidrBlockState; }
            set { this._ipv6CidrBlockState = value; }
        }

        // Check to see if Ipv6CidrBlockState property is set
        internal bool IsSetIpv6CidrBlockState()
        {
            return this._ipv6CidrBlockState != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Pool. 
        /// <para>
        /// The ID of the IPv6 address pool from which the IPv6 CIDR block is allocated.
        /// </para>
        /// </summary>
        public string Ipv6Pool
        {
            get { return this._ipv6Pool; }
            set { this._ipv6Pool = value; }
        }

        // Check to see if Ipv6Pool property is set
        internal bool IsSetIpv6Pool()
        {
            return this._ipv6Pool != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the unique set of Availability Zones, Local Zones, or Wavelength Zones
        /// from which Amazon Web Services advertises IP addresses, for example, <c>us-east-1-wl1-bos-wlz-1</c>.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

    }
}