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
    /// Container for the parameters to the CreateIpamPool operation.
    /// Create an IP address pool for Amazon VPC IP Address Manager (IPAM). In IPAM, a pool
    /// is a collection of contiguous IP addresses CIDRs. Pools enable you to organize your
    /// IP addresses according to your routing and security needs. For example, if you have
    /// separate routing and security needs for development and production applications, you
    /// can create a pool for each.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-top-ipam.html">Create
    /// a top-level pool</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CreateIpamPoolRequest : AmazonEC2Request
    {
        private AddressFamily _addressFamily;
        private int? _allocationDefaultNetmaskLength;
        private int? _allocationMaxNetmaskLength;
        private int? _allocationMinNetmaskLength;
        private List<RequestIpamResourceTag> _allocationResourceTags = new List<RequestIpamResourceTag>();
        private bool? _autoImport;
        private IpamPoolAwsService _awsService;
        private string _clientToken;
        private string _description;
        private string _ipamScopeId;
        private string _locale;
        private IpamPoolPublicIpSource _publicIpSource;
        private bool? _publiclyAdvertisable;
        private string _sourceIpamPoolId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The IP protocol assigned to this IPAM pool. You must choose either IPv4 or IPv6 protocol
        /// for a pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        public List<RequestIpamResourceTag> AllocationResourceTags
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the IPAM pool.
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
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope in which you would like to create the IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamScopeId
        {
            get { return this._ipamScopeId; }
            set { this._ipamScopeId = value; }
        }

        // Check to see if IpamScopeId property is set
        internal bool IsSetIpamScopeId()
        {
            return this._ipamScopeId != null;
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// In IPAM, the locale is the Amazon Web Services Region where you want to make an IPAM
        /// pool available for allocations. Only resources in the same Region as the locale of
        /// the pool can get IP address allocations from the pool. You can only allocate a CIDR
        /// for a VPC, for example, from an IPAM pool that shares a locale with the VPC’s Region.
        /// Note that once you choose a Locale for a pool, you cannot modify it. If you do not
        /// choose a locale, resources in Regions others than the IPAM's home region cannot use
        /// CIDRs from this pool.
        /// </para>
        ///  
        /// <para>
        /// Possible values: Any Amazon Web Services Region, such as us-east-1.
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
        /// Gets and sets the property PublicIpSource. 
        /// <para>
        /// The IP address source for pools in the public scope. Only used for provisioning IP
        /// address CIDRs to pools in the public scope. Default is <code>byoip</code>. For more
        /// information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/intro-create-ipv6-pools.html">Create
        /// IPv6 pools</a> in the <i>Amazon VPC IPAM User Guide</i>. By default, you can add only
        /// one Amazon-provided IPv6 CIDR block to a top-level IPv6 pool if PublicIpSource is
        /// <code>amazon</code>. For information on increasing the default limit, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">
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
        /// Determines if the pool is publicly advertisable. This option is not available for
        /// pools with AddressFamily set to <code>ipv4</code>.
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
        /// The ID of the source IPAM pool. Use this option to create a pool within an existing
        /// pool. Note that the CIDR you provision for the pool within the source pool must be
        /// available in the source pool's CIDR range.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <code>Owner</code> and the value <code>TeamA</code>,
        /// specify <code>tag:Owner</code> for the filter name and <code>TeamA</code> for the
        /// filter value.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}