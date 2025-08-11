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
    /// Container for the parameters to the ProvisionByoipCidr operation.
    /// Provisions an IPv4 or IPv6 address range for use with your Amazon Web Services resources
    /// through bring your own IP addresses (BYOIP) and creates a corresponding address pool.
    /// After the address range is provisioned, it is ready to be advertised using <a>AdvertiseByoipCidr</a>.
    /// 
    ///  
    /// <para>
    /// Amazon Web Services verifies that you own the address range and are authorized to
    /// advertise it. You must ensure that the address range is registered to you and that
    /// you created an RPKI ROA to authorize Amazon ASNs 16509 and 14618 to advertise the
    /// address range. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
    /// your own IP addresses (BYOIP)</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Provisioning an address range is an asynchronous operation, so the call returns immediately,
    /// but the address range is not ready to use until its status changes from <c>pending-provision</c>
    /// to <c>provisioned</c>. To monitor the status of an address range, use <a>DescribeByoipCidrs</a>.
    /// To allocate an Elastic IP address from your IPv4 address pool, use <a>AllocateAddress</a>
    /// with either the specific address from the address pool or the ID of the address pool.
    /// </para>
    /// </summary>
    public partial class ProvisionByoipCidrRequest : AmazonEC2Request
    {
        private string _cidr;
        private CidrAuthorizationContext _cidrAuthorizationContext;
        private string _description;
        private bool? _multiRegion;
        private string _networkBorderGroup;
        private List<TagSpecification> _poolTagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private bool? _publiclyAdvertisable;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The public IPv4 or IPv6 address range, in CIDR notation. The most specific IPv4 prefix
        /// that you can specify is /24. The most specific IPv6 address range that you can bring
        /// is /48 for CIDRs that are publicly advertisable and /56 for CIDRs that are not publicly
        /// advertisable. The address range cannot overlap with another address range that you've
        /// brought to this or another Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property CidrAuthorizationContext. 
        /// <para>
        /// A signed document that proves that you are authorized to bring the specified IP address
        /// range to Amazon using BYOIP.
        /// </para>
        /// </summary>
        public CidrAuthorizationContext CidrAuthorizationContext
        {
            get { return this._cidrAuthorizationContext; }
            set { this._cidrAuthorizationContext = value; }
        }

        // Check to see if CidrAuthorizationContext property is set
        internal bool IsSetCidrAuthorizationContext()
        {
            return this._cidrAuthorizationContext != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the address range and the address pool.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegion. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public bool MultiRegion
        {
            get { return this._multiRegion.GetValueOrDefault(); }
            set { this._multiRegion = value; }
        }

        // Check to see if MultiRegion property is set
        internal bool IsSetMultiRegion()
        {
            return this._multiRegion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// If you have <a href="https://docs.aws.amazon.com/local-zones/latest/ug/how-local-zones-work.html">Local
        /// Zones</a> enabled, you can choose a network border group for Local Zones when you
        /// provision and advertise a BYOIPv4 CIDR. Choose the network border group carefully
        /// as the EIP and the Amazon Web Services resource it is associated with must reside
        /// in the same network border group.
        /// </para>
        ///  
        /// <para>
        /// You can provision BYOIP address ranges to and advertise them in the following Local
        /// Zone network border groups:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// us-east-1-dfw-2
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-lax-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// us-west-2-phx-2
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You cannot provision or advertise BYOIPv6 address ranges in Local Zones at this time.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property PoolTagSpecifications. 
        /// <para>
        /// The tags to apply to the address pool.
        /// </para>
        /// </summary>
        public List<TagSpecification> PoolTagSpecifications
        {
            get { return this._poolTagSpecifications; }
            set { this._poolTagSpecifications = value; }
        }

        // Check to see if PoolTagSpecifications property is set
        internal bool IsSetPoolTagSpecifications()
        {
            return this._poolTagSpecifications != null && (this._poolTagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAdvertisable. 
        /// <para>
        /// (IPv6 only) Indicate whether the address range will be publicly advertised to the
        /// internet.
        /// </para>
        ///  
        /// <para>
        /// Default: true
        /// </para>
        /// </summary>
        public bool PubliclyAdvertisable
        {
            get { return this._publiclyAdvertisable.GetValueOrDefault(); }
            set { this._publiclyAdvertisable = value; }
        }

        // Check to see if PubliclyAdvertisable property is set
        internal bool IsSetPubliclyAdvertisable()
        {
            return this._publiclyAdvertisable.HasValue; 
        }

    }
}