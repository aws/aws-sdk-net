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
    /// In IPAM, a pool is a collection of contiguous IP addresses CIDRs. Pools enable you
    /// to organize your IP addresses according to your routing and security needs. For example,
    /// if you have separate routing and security needs for development and production applications,
    /// you can create a pool for each.
    /// </summary>
    public partial class IpamPool
    {
        private AddressFamily _addressFamily;
        private int? _allocationDefaultNetmaskLength;
        private int? _allocationMaxNetmaskLength;
        private int? _allocationMinNetmaskLength;
        private List<IpamResourceTag> _allocationResourceTags = new List<IpamResourceTag>();
        private bool? _autoImport;
        private IpamPoolAwsService _awsService;
        private string _description;
        private string _ipamArn;
        private string _ipamPoolArn;
        private string _ipamPoolId;
        private string _ipamRegion;
        private string _ipamScopeArn;
        private IpamScopeType _ipamScopeType;
        private string _locale;
        private string _ownerId;
        private int? _poolDepth;
        private IpamPoolPublicIpSource _publicIpSource;
        private bool? _publiclyAdvertisable;
        private string _sourceIpamPoolId;
        private IpamPoolState _state;
        private string _stateMessage;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The address family of the pool.
        /// </para>
        /// </summary>
        public AddressFamily AddressFamily
        {
            get { return this._addressFamily; }
            set { this._addressFamily = value; }
        }

        // Check to see if AddressFamily property is set
        internal bool IsSetAddressFamily()
        {
            return this._addressFamily != null;
        }

        /// <summary>
        /// Gets and sets the property AllocationDefaultNetmaskLength. 
        /// <para>
        /// The default netmask length for allocations added to this pool. If, for example, the
        /// CIDR assigned to this pool is 10.0.0.0/8 and you enter 16 here, new allocations will
        /// default to 10.0.0.0/16.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int AllocationDefaultNetmaskLength
        {
            get { return this._allocationDefaultNetmaskLength.GetValueOrDefault(); }
            set { this._allocationDefaultNetmaskLength = value; }
        }

        // Check to see if AllocationDefaultNetmaskLength property is set
        internal bool IsSetAllocationDefaultNetmaskLength()
        {
            return this._allocationDefaultNetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllocationMaxNetmaskLength. 
        /// <para>
        /// The maximum netmask length possible for CIDR allocations in this IPAM pool to be compliant.
        /// The maximum netmask length must be greater than the minimum netmask length. Possible
        /// netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for IPv6 addresses
        /// are 0 - 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int AllocationMaxNetmaskLength
        {
            get { return this._allocationMaxNetmaskLength.GetValueOrDefault(); }
            set { this._allocationMaxNetmaskLength = value; }
        }

        // Check to see if AllocationMaxNetmaskLength property is set
        internal bool IsSetAllocationMaxNetmaskLength()
        {
            return this._allocationMaxNetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllocationMinNetmaskLength. 
        /// <para>
        /// The minimum netmask length required for CIDR allocations in this IPAM pool to be compliant.
        /// The minimum netmask length must be less than the maximum netmask length. Possible
        /// netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for IPv6 addresses
        /// are 0 - 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int AllocationMinNetmaskLength
        {
            get { return this._allocationMinNetmaskLength.GetValueOrDefault(); }
            set { this._allocationMinNetmaskLength = value; }
        }

        // Check to see if AllocationMinNetmaskLength property is set
        internal bool IsSetAllocationMinNetmaskLength()
        {
            return this._allocationMinNetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllocationResourceTags. 
        /// <para>
        /// Tags that are required for resources that use CIDRs from this IPAM pool. Resources
        /// that do not have these tags will not be allowed to allocate space from the pool. If
        /// the resources have their tags changed after they have allocated space or if the allocation
        /// tagging requirements are changed on the pool, the resource may be marked as noncompliant.
        /// </para>
        /// </summary>
        public List<IpamResourceTag> AllocationResourceTags
        {
            get { return this._allocationResourceTags; }
            set { this._allocationResourceTags = value; }
        }

        // Check to see if AllocationResourceTags property is set
        internal bool IsSetAllocationResourceTags()
        {
            return this._allocationResourceTags != null && this._allocationResourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoImport. 
        /// <para>
        /// If selected, IPAM will continuously look for resources within the CIDR range of this
        /// pool and automatically import them as allocations into your IPAM. The CIDRs that will
        /// be allocated for these resources must not already be allocated to other resources
        /// in order for the import to succeed. IPAM will import a CIDR regardless of its compliance
        /// with the pool's allocation rules, so a resource might be imported and subsequently
        /// marked as noncompliant. If IPAM discovers multiple CIDRs that overlap, IPAM will import
        /// the largest CIDR only. If IPAM discovers multiple CIDRs with matching CIDRs, IPAM
        /// will randomly import one of them only. 
        /// </para>
        ///  
        /// <para>
        /// A locale must be set on the pool for this feature to work.
        /// </para>
        /// </summary>
        public bool AutoImport
        {
            get { return this._autoImport.GetValueOrDefault(); }
            set { this._autoImport = value; }
        }

        // Check to see if AutoImport property is set
        internal bool IsSetAutoImport()
        {
            return this._autoImport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// Limits which service in Amazon Web Services that the pool can be used in. "ec2", for
        /// example, allows users to use space for Elastic IP addresses and VPCs.
        /// </para>
        /// </summary>
        public IpamPoolAwsService AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the IPAM pool.
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
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// The ARN of the IPAM.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamArn
        {
            get { return this._ipamArn; }
            set { this._ipamArn = value; }
        }

        // Check to see if IpamArn property is set
        internal bool IsSetIpamArn()
        {
            return this._ipamArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPoolArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamPoolArn
        {
            get { return this._ipamPoolArn; }
            set { this._ipamPoolArn = value; }
        }

        // Check to see if IpamPoolArn property is set
        internal bool IsSetIpamPoolArn()
        {
            return this._ipamPoolArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool.
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
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The Amazon Web Services Region of the IPAM pool.
        /// </para>
        /// </summary>
        public string IpamRegion
        {
            get { return this._ipamRegion; }
            set { this._ipamRegion = value; }
        }

        // Check to see if IpamRegion property is set
        internal bool IsSetIpamRegion()
        {
            return this._ipamRegion != null;
        }

        /// <summary>
        /// Gets and sets the property IpamScopeArn. 
        /// <para>
        /// The ARN of the scope of the IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string IpamScopeArn
        {
            get { return this._ipamScopeArn; }
            set { this._ipamScopeArn = value; }
        }

        // Check to see if IpamScopeArn property is set
        internal bool IsSetIpamScopeArn()
        {
            return this._ipamScopeArn != null;
        }

        /// <summary>
        /// Gets and sets the property IpamScopeType. 
        /// <para>
        /// In IPAM, a scope is the highest-level container within IPAM. An IPAM contains two
        /// default scopes. Each scope represents the IP space for a single network. The private
        /// scope is intended for all private IP address space. The public scope is intended for
        /// all public IP address space. Scopes enable you to reuse IP addresses across multiple
        /// unconnected networks without causing IP address overlap or conflict.
        /// </para>
        /// </summary>
        public IpamScopeType IpamScopeType
        {
            get { return this._ipamScopeType; }
            set { this._ipamScopeType = value; }
        }

        // Check to see if IpamScopeType property is set
        internal bool IsSetIpamScopeType()
        {
            return this._ipamScopeType != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the IPAM pool. In IPAM, the locale is the Amazon Web Services Region
        /// where you want to make an IPAM pool available for allocations. Only resources in the
        /// same Region as the locale of the pool can get IP address allocations from the pool.
        /// You can only allocate a CIDR for a VPC, for example, from an IPAM pool that shares
        /// a locale with the VPC’s Region. Note that once you choose a Locale for a pool, you
        /// cannot modify it. If you choose an Amazon Web Services Region for locale that has
        /// not been configured as an operating Region for the IPAM, you'll get an error.
        /// </para>
        /// </summary>
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the IPAM pool.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PoolDepth. 
        /// <para>
        /// The depth of pools in your IPAM pool. The pool depth quota is 10. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">Quotas
        /// in IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        public int PoolDepth
        {
            get { return this._poolDepth.GetValueOrDefault(); }
            set { this._poolDepth = value; }
        }

        // Check to see if PoolDepth property is set
        internal bool IsSetPoolDepth()
        {
            return this._poolDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicIpSource. 
        /// <para>
        /// The IP address source for pools in the public scope. Only used for provisioning IP
        /// address CIDRs to pools in the public scope. Default is <code>BYOIP</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/intro-create-ipv6-pools.html">Create
        /// IPv6 pools</a> in the <i>Amazon VPC IPAM User Guide</i>. By default, you can add only
        /// one Amazon-provided IPv6 CIDR block to a top-level IPv6 pool. For information on increasing
        /// the default limit, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">
        /// Quotas for your IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamPoolPublicIpSource PublicIpSource
        {
            get { return this._publicIpSource; }
            set { this._publicIpSource = value; }
        }

        // Check to see if PublicIpSource property is set
        internal bool IsSetPublicIpSource()
        {
            return this._publicIpSource != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAdvertisable. 
        /// <para>
        /// Determines if a pool is publicly advertisable. This option is not available for pools
        /// with AddressFamily set to <code>ipv4</code>.
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

        /// <summary>
        /// Gets and sets the property SourceIpamPoolId. 
        /// <para>
        /// The ID of the source IPAM pool. You can use this option to create an IPAM pool within
        /// an existing source pool.
        /// </para>
        /// </summary>
        public string SourceIpamPoolId
        {
            get { return this._sourceIpamPoolId; }
            set { this._sourceIpamPoolId = value; }
        }

        // Check to see if SourceIpamPoolId property is set
        internal bool IsSetSourceIpamPoolId()
        {
            return this._sourceIpamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the IPAM pool.
        /// </para>
        /// </summary>
        public IpamPoolState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// A message related to the failed creation of an IPAM pool.
        /// </para>
        /// </summary>
        public string StateMessage
        {
            get { return this._stateMessage; }
            set { this._stateMessage = value; }
        }

        // Check to see if StateMessage property is set
        internal bool IsSetStateMessage()
        {
            return this._stateMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <code>Owner</code> and the value <code>TeamA</code>,
        /// specify <code>tag:Owner</code> for the filter name and <code>TeamA</code> for the
        /// filter value.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}