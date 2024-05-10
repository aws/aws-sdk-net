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
    /// Container for the parameters to the AssociateSubnetCidrBlock operation.
    /// Associates a CIDR block with your subnet. You can only associate a single IPv6 CIDR
    /// block with your subnet.
    /// </summary>
    public partial class AssociateSubnetCidrBlockRequest : AmazonEC2Request
    {
        private string _ipv6CidrBlock;
        private string _ipv6IpamPoolId;
        private int? _ipv6NetmaskLength;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// The IPv6 CIDR block for your subnet.
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
        /// Gets and sets the property Ipv6IpamPoolId. 
        /// <para>
        /// An IPv6 IPAM pool ID.
        /// </para>
        /// </summary>
        public string Ipv6IpamPoolId
        {
            get { return this._ipv6IpamPoolId; }
            set { this._ipv6IpamPoolId = value; }
        }

        // Check to see if Ipv6IpamPoolId property is set
        internal bool IsSetIpv6IpamPoolId()
        {
            return this._ipv6IpamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6NetmaskLength. 
        /// <para>
        /// An IPv6 netmask length.
        /// </para>
        /// </summary>
        public int? Ipv6NetmaskLength
        {
            get { return this._ipv6NetmaskLength; }
            set { this._ipv6NetmaskLength = value; }
        }

        // Check to see if Ipv6NetmaskLength property is set
        internal bool IsSetIpv6NetmaskLength()
        {
            return this._ipv6NetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of your subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}