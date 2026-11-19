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
    /// Container for the parameters to the AllocateAddress operation. Allocates an Elastic
    /// IP address to your Amazon Web Services account. After you allocate the Elastic IP
    /// address you can associate it with an instance or network interface. After you release
    /// an Elastic IP address, it is released to the IP address pool and can be allocated
    /// to a different Amazon Web Services account. <para> You can allocate an Elastic IP
    /// address from one of the following address pools: </para> <ul> <li> <para> Amazon's
    /// pool of IPv4 addresses </para> </li> <li> <para> Public IPv4 address range that you
    /// own and bring to your Amazon Web Services account using <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
    /// Your Own IP Addresses (BYOIP)</a> </para> </li> <li> <para> An IPv4 IPAM pool with
    /// an Amazon-provided or BYOIP public IPv4 address range </para> </li> <li> <para> IPv4
    /// addresses from your on-premises network made available for use with an Outpost using
    /// a <a href="https://docs.aws.amazon.com/outposts/latest/userguide/routing.html#ip-addressing">customer-owned
    /// IP address pool</a> (CoIP pool) </para> </li> </ul> <para> For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon EC2 User Guide</i>. </para> <para> If you release
    /// an Elastic IP address, you might be able to recover it. You cannot recover an Elastic
    /// IP address that you released after it is allocated to another Amazon Web Services
    /// account. To attempt to recover an Elastic IP address that you released, specify it
    /// in this operation. </para> <para> You can allocate a carrier IP address which is a
    /// public IP address from a telecommunication carrier, to a network interface which resides
    /// in a subnet in a Wavelength Zone (for example an EC2 instance). </para>
    /// </summary>
    public partial class AllocateAddressRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The Elastic IP address to recover or an IPv4 address from an address pool.
        /// </para>
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of a customer-owned address pool. Use this parameter to let Amazon EC2 select
        /// an address from the address pool. Alternatively, specify a specific address from the
        /// address pool.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the CustomerOwnedIpv4Pool property is set.
        /// </summary>
        internal bool IsSetCustomerOwnedIpv4Pool() => this.CustomerOwnedIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The network (<c>vpc</c>).
        /// </para>
        /// </summary>
        public DomainType Domain { get; set; }

        /// <summary>
        /// Checks to see if the Domain property is set.
        /// </summary>
        internal bool IsSetDomain() => this.Domain != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of an IPAM pool which has an Amazon-provided or BYOIP public IPv4 CIDR provisioned
        /// to it. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/tutorials-eip-pool.html">Allocate
        /// sequential Elastic IP addresses from an IPAM pool</a> in the <i>Amazon VPC IPAM User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        ///  A unique set of Availability Zones, Local Zones, or Wavelength Zones from which Amazon
        /// Web Services advertises IP addresses. Use this parameter to limit the IP address to
        /// this location. IP addresses cannot move between network border groups.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The ID of an address pool that you own. Use this parameter to let Amazon EC2 select
        /// an address from the address pool. To specify a specific address from the address pool,
        /// use the <c>Address</c> parameter instead.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpv4Pool property is set.
        /// </summary>
        internal bool IsSetPublicIpv4Pool() => this.PublicIpv4Pool != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Elastic IP address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
