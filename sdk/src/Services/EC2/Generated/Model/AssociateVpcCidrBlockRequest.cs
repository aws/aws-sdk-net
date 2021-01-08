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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateVpcCidrBlock operation.
    /// Associates a CIDR block with your VPC. You can associate a secondary IPv4 CIDR block,
    /// an Amazon-provided IPv6 CIDR block, or an IPv6 CIDR block from an IPv6 address pool
    /// that you provisioned through bring your own IP addresses (<a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">BYOIP</a>).
    /// The IPv6 CIDR block size is fixed at /56.
    /// 
    ///  
    /// <para>
    /// You must specify one of the following in the request: an IPv4 CIDR block, an IPv6
    /// pool, or an Amazon-provided IPv6 CIDR block.
    /// </para>
    ///  
    /// <para>
    /// For more information about associating CIDR blocks with your VPC and applicable restrictions,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html#VPC_Sizing">VPC
    /// and Subnet Sizing</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateVpcCidrBlockRequest : AmazonEC2Request
    {
        private bool? _amazonProvidedIpv6CidrBlock;
        private string _cidrBlock;
        private string _ipv6CidrBlock;
        private string _ipv6CidrBlockNetworkBorderGroup;
        private string _ipv6Pool;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AmazonProvidedIpv6CidrBlock. 
        /// <para>
        /// Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC.
        /// You cannot specify the range of IPv6 addresses, or the size of the CIDR block.
        /// </para>
        /// </summary>
        public bool AmazonProvidedIpv6CidrBlock
        {
            get { return this._amazonProvidedIpv6CidrBlock.GetValueOrDefault(); }
            set { this._amazonProvidedIpv6CidrBlock = value; }
        }

        // Check to see if AmazonProvidedIpv6CidrBlock property is set
        internal bool IsSetAmazonProvidedIpv6CidrBlock()
        {
            return this._amazonProvidedIpv6CidrBlock.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// An IPv4 CIDR block to associate with the VPC.
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// An IPv6 CIDR block from the IPv6 address pool. You must also specify <code>Ipv6Pool</code>
        /// in the request.
        /// </para>
        ///  
        /// <para>
        /// To let Amazon choose the IPv6 CIDR block for you, omit this parameter.
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
        /// Gets and sets the property Ipv6CidrBlockNetworkBorderGroup. 
        /// <para>
        /// The name of the location from which we advertise the IPV6 CIDR block. Use this parameter
        /// to limit the CIDR block to this location.
        /// </para>
        ///  
        /// <para>
        ///  You must set <code>AmazonProvidedIpv6CidrBlock</code> to <code>true</code> to use
        /// this parameter.
        /// </para>
        ///  
        /// <para>
        ///  You can have one IPv6 CIDR block association per network border group.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlockNetworkBorderGroup
        {
            get { return this._ipv6CidrBlockNetworkBorderGroup; }
            set { this._ipv6CidrBlockNetworkBorderGroup = value; }
        }

        // Check to see if Ipv6CidrBlockNetworkBorderGroup property is set
        internal bool IsSetIpv6CidrBlockNetworkBorderGroup()
        {
            return this._ipv6CidrBlockNetworkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Pool. 
        /// <para>
        /// The ID of an IPv6 address pool from which to allocate the IPv6 CIDR block.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}