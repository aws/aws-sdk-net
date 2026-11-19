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
    /// Container for the parameters to the CreateIpamPool operation. Create an IP address
    /// pool for Amazon VPC IP Address Manager (IPAM). In IPAM, a pool is a collection of
    /// contiguous IP addresses CIDRs. Pools enable you to organize your IP addresses according
    /// to your routing and security needs. For example, if you have separate routing and
    /// security needs for development and production applications, you can create a pool
    /// for each. <para> For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-top-ipam.html">Create
    /// a top-level pool</a> in the <i>Amazon VPC IPAM User Guide</i>. </para>
    /// </summary>
    public partial class CreateIpamPoolRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddressFamily. 
        /// <para>
        /// The IP protocol assigned to this IPAM pool. You must choose either IPv4 or IPv6 protocol
        /// for a pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AddressFamily AddressFamily { get; set; }

        /// <summary>
        /// Checks to see if the AddressFamily property is set.
        /// </summary>
        internal bool IsSetAddressFamily() => this.AddressFamily != null;

        /// <summary>
        /// Gets and sets the property AllocationDefaultNetmaskLength. 
        /// <para>
        /// The default netmask length for allocations added to this pool. If, for example, the
        /// CIDR assigned to this pool is 10.0.0.0/8 and you enter 16 here, new allocations will
        /// default to 10.0.0.0/16.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? AllocationDefaultNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the AllocationDefaultNetmaskLength property is set.
        /// </summary>
        internal bool IsSetAllocationDefaultNetmaskLength() => this.AllocationDefaultNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property AllocationMaxNetmaskLength. 
        /// <para>
        /// The maximum netmask length possible for CIDR allocations in this IPAM pool to be compliant.
        /// The maximum netmask length must be greater than the minimum netmask length. Possible
        /// netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for IPv6 addresses
        /// are 0 - 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? AllocationMaxNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the AllocationMaxNetmaskLength property is set.
        /// </summary>
        internal bool IsSetAllocationMaxNetmaskLength() => this.AllocationMaxNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property AllocationMinNetmaskLength. 
        /// <para>
        /// The minimum netmask length required for CIDR allocations in this IPAM pool to be compliant.
        /// The minimum netmask length must be less than the maximum netmask length. Possible
        /// netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for IPv6 addresses
        /// are 0 - 128.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? AllocationMinNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the AllocationMinNetmaskLength property is set.
        /// </summary>
        internal bool IsSetAllocationMinNetmaskLength() => this.AllocationMinNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property AllocationResourceTags. 
        /// <para>
        /// Tags that are required for resources that use CIDRs from this IPAM pool. Resources
        /// that do not have these tags will not be allowed to allocate space from the pool. If
        /// the resources have their tags changed after they have allocated space or if the allocation
        /// tagging requirements are changed on the pool, the resource may be marked as noncompliant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequestIpamResourceTag> AllocationResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestIpamResourceTag>() : null;

        /// <summary>
        /// Checks to see if the AllocationResourceTags property is set.
        /// </summary>
        internal bool IsSetAllocationResourceTags() => this.AllocationResourceTags != null && (this.AllocationResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public bool? AutoImport { get; set; }

        /// <summary>
        /// Checks to see if the AutoImport property is set.
        /// </summary>
        internal bool IsSetAutoImport() => this.AutoImport.HasValue;

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// Limits which service in Amazon Web Services that the pool can be used in. "ec2", for
        /// example, allows users to use space for Elastic IP addresses and VPCs.
        /// </para>
        /// </summary>
        public IpamPoolAwsService AwsService { get; set; }

        /// <summary>
        /// Checks to see if the AwsService property is set.
        /// </summary>
        internal bool IsSetAwsService() => this.AwsService != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the IPAM pool.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamScopeId. 
        /// <para>
        /// The ID of the scope in which you would like to create the IPAM pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamScopeId { get; set; }

        /// <summary>
        /// Checks to see if the IpamScopeId property is set.
        /// </summary>
        internal bool IsSetIpamScopeId() => this.IpamScopeId != null;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale for the pool should be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region where you want this IPAM pool to be available for allocations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The network border group for an Amazon Web Services Local Zone where you want this
        /// IPAM pool to be available for allocations (<a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html#byoip-zone-avail">supported
        /// Local Zones</a>). This option is only available for IPAM IPv4 pools in the public
        /// scope.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Possible values: Any Amazon Web Services Region or supported Amazon Web Services Local
        /// Zone. Default is <c>none</c> and means any locale.
        /// </para>
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property PublicIpSource. 
        /// <para>
        /// The IP address source for pools in the public scope. Only used for provisioning IP
        /// address CIDRs to pools in the public scope. Default is <c>byoip</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/intro-create-ipv6-pools.html">Create
        /// IPv6 pools</a> in the <i>Amazon VPC IPAM User Guide</i>. By default, you can add only
        /// one Amazon-provided IPv6 CIDR block to a top-level IPv6 pool if PublicIpSource is
        /// <c>amazon</c>. For information on increasing the default limit, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">
        /// Quotas for your IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public IpamPoolPublicIpSource PublicIpSource { get; set; }

        /// <summary>
        /// Checks to see if the PublicIpSource property is set.
        /// </summary>
        internal bool IsSetPublicIpSource() => this.PublicIpSource != null;

        /// <summary>
        /// Gets and sets the property PubliclyAdvertisable. 
        /// <para>
        /// Determines if the pool is publicly advertisable. The request can only contain <c>PubliclyAdvertisable</c>
        /// if <c>AddressFamily</c> is <c>ipv6</c> and <c>PublicIpSource</c> is <c>byoip</c>.
        /// </para>
        /// </summary>
        public bool? PubliclyAdvertisable { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAdvertisable property is set.
        /// </summary>
        internal bool IsSetPubliclyAdvertisable() => this.PubliclyAdvertisable.HasValue;

        /// <summary>
        /// Gets and sets the property SourceIpamPoolId. 
        /// <para>
        /// The ID of the source IPAM pool. Use this option to create a pool within an existing
        /// pool. Note that the CIDR you provision for the pool within the source pool must be
        /// available in the source pool's CIDR range.
        /// </para>
        /// </summary>
        public string SourceIpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpamPoolId property is set.
        /// </summary>
        internal bool IsSetSourceIpamPoolId() => this.SourceIpamPoolId != null;

        /// <summary>
        /// Gets and sets the property SourceResource. 
        /// <para>
        /// The resource used to provision CIDRs to a resource planning pool.
        /// </para>
        /// </summary>
        public IpamPoolSourceResourceRequest SourceResource { get; set; }

        /// <summary>
        /// Checks to see if the SourceResource property is set.
        /// </summary>
        internal bool IsSetSourceResource() => this.SourceResource != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
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
