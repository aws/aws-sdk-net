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
    /// Container for the parameters to the AllocateIpamPoolCidr operation. Allocate a CIDR
    /// from an IPAM pool. The Region you use should be the IPAM pool locale. The locale is
    /// the Amazon Web Services Region where this IPAM pool is available for allocations.
    /// <para> In IPAM, an allocation is a CIDR assignment from an IPAM pool to another IPAM
    /// pool or to a resource. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/allocate-cidrs-ipam.html">Allocate
    /// CIDRs</a> in the <i>Amazon VPC IPAM User Guide</i>. </para> <note> <para> This action
    /// creates an allocation with strong consistency. The returned CIDR will not overlap
    /// with any other allocations from the same pool. </para> </note>
    /// </summary>
    public partial class AllocateIpamPoolCidrRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AllowedCidrs. 
        /// <para>
        /// Include a particular CIDR range that can be returned by the pool. Allowed CIDRs are
        /// only allowed if using netmask length for allocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedCidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedCidrs property is set.
        /// </summary>
        internal bool IsSetAllowedCidrs() => this.AllowedCidrs != null && (this.AllowedCidrs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The CIDR you would like to allocate from the IPAM pool. Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If there is no DefaultNetmaskLength allocation rule set on the pool, you must specify
        /// either the NetmaskLength or the CIDR.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DefaultNetmaskLength allocation rule is set on the pool, you can specify either
        /// the NetmaskLength or the CIDR and the DefaultNetmaskLength allocation rule will be
        /// ignored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Possible values: Any available IPv4 or IPv6 CIDR.
        /// </para>
        /// </summary>
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

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
        /// A description for the allocation.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisallowedCidrs. 
        /// <para>
        /// Exclude a particular CIDR range from being returned by the pool. Disallowed CIDRs
        /// are only allowed if using netmask length for allocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DisallowedCidrs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DisallowedCidrs property is set.
        /// </summary>
        internal bool IsSetDisallowedCidrs() => this.DisallowedCidrs != null && (this.DisallowedCidrs.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool from which you would like to allocate a CIDR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property NetmaskLength. 
        /// <para>
        /// The netmask length of the CIDR you would like to allocate from the IPAM pool. Note
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If there is no DefaultNetmaskLength allocation rule set on the pool, you must specify
        /// either the NetmaskLength or the CIDR.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the DefaultNetmaskLength allocation rule is set on the pool, you can specify either
        /// the NetmaskLength or the CIDR and the DefaultNetmaskLength allocation rule will be
        /// ignored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Possible netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for
        /// IPv6 addresses are 0 - 128.
        /// </para>
        /// </summary>
        public int? NetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the NetmaskLength property is set.
        /// </summary>
        internal bool IsSetNetmaskLength() => this.NetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property PreviewNextCidr. 
        /// <para>
        /// A preview of the next available CIDR in a pool.
        /// </para>
        /// </summary>
        public bool? PreviewNextCidr { get; set; }

        /// <summary>
        /// Checks to see if the PreviewNextCidr property is set.
        /// </summary>
        internal bool IsSetPreviewNextCidr() => this.PreviewNextCidr.HasValue;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  
        /// <para>
        /// If you specify tags, the request is authorized against the allocation resource in
        /// addition to the pool resource.
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
