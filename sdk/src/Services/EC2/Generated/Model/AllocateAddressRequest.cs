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
    /// Container for the parameters to the AllocateAddress operation.
    /// Allocates an Elastic IP address to your Amazon Web Services account. After you allocate
    /// the Elastic IP address you can associate it with an instance or network interface.
    /// After you release an Elastic IP address, it is released to the IP address pool and
    /// can be allocated to a different Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// You can allocate an Elastic IP address from an address pool owned by Amazon Web Services
    /// or from an address pool created from a public IPv4 address range that you have brought
    /// to Amazon Web Services for use with your Amazon Web Services resources using bring
    /// your own IP addresses (BYOIP). For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
    /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you release an Elastic IP address, you might be able to recover it. You cannot
    /// recover an Elastic IP address that you released after it is allocated to another Amazon
    /// Web Services account. To attempt to recover an Elastic IP address that you released,
    /// specify it in this operation.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can allocate a carrier IP address which is a public IP address from a telecommunication
    /// carrier, to a network interface which resides in a subnet in a Wavelength Zone (for
    /// example an EC2 instance).
    /// </para>
    /// </summary>
    public partial class AllocateAddressRequest : AmazonEC2Request
    {
        private string _address;
        private string _customerOwnedIpv4Pool;
        private DomainType _domain;
        private bool? _dryRun;
        private string _ipamPoolId;
        private string _networkBorderGroup;
        private string _publicIpv4Pool;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The Elastic IP address to recover or an IPv4 address from an address pool.
        /// </para>
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerOwnedIpv4Pool. 
        /// <para>
        /// The ID of a customer-owned address pool. Use this parameter to let Amazon EC2 select
        /// an address from the address pool. Alternatively, specify a specific address from the
        /// address pool.
        /// </para>
        /// </summary>
        public string CustomerOwnedIpv4Pool
        {
            get { return this._customerOwnedIpv4Pool; }
            set { this._customerOwnedIpv4Pool = value; }
        }

        // Check to see if CustomerOwnedIpv4Pool property is set
        internal bool IsSetCustomerOwnedIpv4Pool()
        {
            return this._customerOwnedIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The network (<c>vpc</c>).
        /// </para>
        /// </summary>
        public DomainType Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of an IPAM pool which has an Amazon-provided or BYOIP public IPv4 CIDR provisioned
        /// to it. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/tutorials-eip-pool.html">Allocate
        /// sequential Elastic IP addresses from an IPAM pool</a> in the <i>Amazon VPC IPAM User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string IpamPoolId
        {
            get { return this._ipamPoolId; }
            set { this._ipamPoolId = value; }
        }

        // Check to see if IpamPoolId property is set
        internal bool IsSetIpamPoolId()
        {
            return this._ipamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        ///  A unique set of Availability Zones, Local Zones, or Wavelength Zones from which Amazon
        /// Web Services advertises IP addresses. Use this parameter to limit the IP address to
        /// this location. IP addresses cannot move between network border groups.
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

        /// <summary>
        /// Gets and sets the property PublicIpv4Pool. 
        /// <para>
        /// The ID of an address pool that you own. Use this parameter to let Amazon EC2 select
        /// an address from the address pool. To specify a specific address from the address pool,
        /// use the <c>Address</c> parameter instead.
        /// </para>
        /// </summary>
        public string PublicIpv4Pool
        {
            get { return this._publicIpv4Pool; }
            set { this._publicIpv4Pool = value; }
        }

        // Check to see if PublicIpv4Pool property is set
        internal bool IsSetPublicIpv4Pool()
        {
            return this._publicIpv4Pool != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the Elastic IP address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}