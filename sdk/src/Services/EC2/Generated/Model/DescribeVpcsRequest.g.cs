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
    /// Container for the parameters to the DescribeVpcs operation. Describes your VPCs. The
    /// default is to describe all your VPCs. Alternatively, you can specify specific VPC
    /// IDs or filter the results to include only the VPCs that match specific criteria.
    /// </summary>
    public partial class DescribeVpcsRequest : AmazonEC2Request
    {
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>cidr</c> - The primary IPv4 CIDR block of the VPC. The CIDR block you specify
        /// must exactly match the VPC's CIDR block for information to be returned for the VPC.
        /// Must contain the slash followed by one or two digits (for example, <c>/28</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cidr-block-association.cidr-block</c> - An IPv4 CIDR block associated with the
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cidr-block-association.association-id</c> - The association ID for an IPv4 CIDR
        /// block associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cidr-block-association.state</c> - The state of an IPv4 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dhcp-options-id</c> - The ID of a set of DHCP options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.ipv6-cidr-block</c> - An IPv6 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.ipv6-pool</c> - The ID of the IPv6 address pool from
        /// which the IPv6 CIDR block is allocated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.association-id</c> - The association ID for an IPv6
        /// CIDR block associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ipv6-cidr-block-association.state</c> - The state of an IPv6 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>is-default</c> - Indicates whether the VPC is the default VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the VPC (<c>pending</c> | <c>available</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c> - The key/value combination of a tag assigned to the resource. Use the
        /// tag key in the filter name and the tag value as the filter value. For example, to
        /// find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-id</c> - The ID of the VPC.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property VpcIds. 
        /// <para>
        /// The IDs of the VPCs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcIds property is set.
        /// </summary>
        internal bool IsSetVpcIds() => this.VpcIds != null && (this.VpcIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
