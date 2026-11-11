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
    /// Container for the parameters to the AssociateVpcCidrBlock operation. Associates a
    /// CIDR block with your VPC. You can associate a secondary IPv4 CIDR block, an Amazon-provided
    /// IPv6 CIDR block, or an IPv6 CIDR block from an IPv6 address pool that you provisioned
    /// through bring your own IP addresses (<a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">BYOIP</a>).
    /// <para> You must specify one of the following in the request: an IPv4 CIDR block, an
    /// IPv6 pool, or an Amazon-provided IPv6 CIDR block. </para> <para> For more information
    /// about associating CIDR blocks with your VPC and applicable restrictions, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-ip-addressing.html">IP
    /// addressing for your VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class AssociateVpcCidrBlockRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AmazonProvidedIpv6CidrBlock. 
        /// <para>
        /// Requests an Amazon-provided IPv6 CIDR block with a /56 prefix length for the VPC.
        /// You cannot specify the range of IPv6 addresses or the size of the CIDR block.
        /// </para>
        /// </summary>
        public bool? AmazonProvidedIpv6CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the AmazonProvidedIpv6CidrBlock property is set.
        /// </summary>
        internal bool IsSetAmazonProvidedIpv6CidrBlock() => this.AmazonProvidedIpv6CidrBlock.HasValue;

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// An IPv4 CIDR block to associate with the VPC.
        /// </para>
        /// </summary>
        public string CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the CidrBlock property is set.
        /// </summary>
        internal bool IsSetCidrBlock() => this.CidrBlock != null;

        /// <summary>
        /// Gets and sets the property Ipv4IpamPoolId. 
        /// <para>
        /// Associate a CIDR allocated from an IPv4 IPAM pool to a VPC. For more information about
        /// Amazon VPC IP Address Manager (IPAM), see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public string Ipv4IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpv4IpamPoolId() => this.Ipv4IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property Ipv4NetmaskLength. 
        /// <para>
        /// The netmask length of the IPv4 CIDR you would like to associate from an Amazon VPC
        /// IP Address Manager (IPAM) pool. For more information about IPAM, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        public int? Ipv4NetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the Ipv4NetmaskLength property is set.
        /// </summary>
        internal bool IsSetIpv4NetmaskLength() => this.Ipv4NetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlock. 
        /// <para>
        /// An IPv6 CIDR block from the IPv6 address pool. You must also specify <c>Ipv6Pool</c>
        /// in the request.
        /// </para>
        ///  
        /// <para>
        /// To let Amazon choose the IPv6 CIDR block for you, omit this parameter.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6CidrBlock property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlock() => this.Ipv6CidrBlock != null;

        /// <summary>
        /// Gets and sets the property Ipv6CidrBlockNetworkBorderGroup. 
        /// <para>
        /// The name of the location from which we advertise the IPV6 CIDR block. Use this parameter
        /// to limit the CIDR block to this location.
        /// </para>
        ///  
        /// <para>
        ///  You must set <c>AmazonProvidedIpv6CidrBlock</c> to <c>true</c> to use this parameter.
        /// </para>
        ///  
        /// <para>
        ///  You can have one IPv6 CIDR block association per network border group.
        /// </para>
        /// </summary>
        public string Ipv6CidrBlockNetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6CidrBlockNetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetIpv6CidrBlockNetworkBorderGroup() => this.Ipv6CidrBlockNetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property Ipv6IpamPoolId. 
        /// <para>
        /// Associates a CIDR allocated from an IPv6 IPAM pool to a VPC. For more information
        /// about Amazon VPC IP Address Manager (IPAM), see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public string Ipv6IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpv6IpamPoolId() => this.Ipv6IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property Ipv6NetmaskLength. 
        /// <para>
        /// The netmask length of the IPv6 CIDR you would like to associate from an Amazon VPC
        /// IP Address Manager (IPAM) pool. For more information about IPAM, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
        /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        public int? Ipv6NetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6NetmaskLength property is set.
        /// </summary>
        internal bool IsSetIpv6NetmaskLength() => this.Ipv6NetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Pool. 
        /// <para>
        /// The ID of an IPv6 address pool from which to allocate the IPv6 CIDR block.
        /// </para>
        /// </summary>
        public string Ipv6Pool { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Pool property is set.
        /// </summary>
        internal bool IsSetIpv6Pool() => this.Ipv6Pool != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
