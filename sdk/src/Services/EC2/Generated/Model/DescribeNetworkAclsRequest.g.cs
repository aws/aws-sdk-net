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
    /// Container for the parameters to the DescribeNetworkAcls operation. Describes your
    /// network ACLs. The default is to describe all your network ACLs. Alternatively, you
    /// can specify specific network ACL IDs or filter the results to include only the network
    /// ACLs that match specific criteria. <para> For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-network-acls.html">Network
    /// ACLs</a> in the <i>Amazon VPC User Guide</i>. </para>
    /// </summary>
    public partial class DescribeNetworkAclsRequest : AmazonEC2Request
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
        ///  <c>association.association-id</c> - The ID of an association ID for the ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.network-acl-id</c> - The ID of the network ACL involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.subnet-id</c> - The ID of the subnet involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>default</c> - Indicates whether the ACL is the default network ACL for the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.cidr</c> - The IPv4 CIDR range specified in the entry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.icmp.code</c> - The ICMP code specified in the entry, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.icmp.type</c> - The ICMP type specified in the entry, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.ipv6-cidr</c> - The IPv6 CIDR range specified in the entry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.port-range.from</c> - The start of the port range specified in the entry.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.port-range.to</c> - The end of the port range specified in the entry. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.protocol</c> - The protocol specified in the entry (<c>tcp</c> | <c>udp</c>
        /// | <c>icmp</c> or a protocol number).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.rule-action</c> - Allows or denies the matching traffic (<c>allow</c> |
        /// <c>deny</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.egress</c> - A Boolean that indicates the type of rule. Specify <c>true</c>
        /// for egress rules, or <c>false</c> for ingress rules.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>entry.rule-number</c> - The number of an entry (in other words, rule) in the set
        /// of ACL entries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-acl-id</c> - The ID of the network ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the network
        /// ACL.
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
        ///  <c>vpc-id</c> - The ID of the VPC for the network ACL.
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
        /// Gets and sets the property NetworkAclIds. 
        /// <para>
        /// The IDs of the network ACLs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NetworkAclIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NetworkAclIds property is set.
        /// </summary>
        internal bool IsSetNetworkAclIds() => this.NetworkAclIds != null && (this.NetworkAclIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
    }
}
