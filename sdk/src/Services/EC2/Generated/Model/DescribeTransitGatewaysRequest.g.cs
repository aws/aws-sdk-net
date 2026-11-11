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
    /// Container for the parameters to the DescribeTransitGateways operation. Describes one
    /// or more transit gateways. By default, all transit gateways are described. Alternatively,
    /// you can filter the results.
    /// </summary>
    public partial class DescribeTransitGatewaysRequest : AmazonEC2Request
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
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>options.propagation-default-route-table-id</c> - The ID of the default propagation
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.amazon-side-asn</c> - The private ASN for the Amazon side of a BGP session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.association-default-route-table-id</c> - The ID of the default association
        /// route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.auto-accept-shared-attachments</c> - Indicates whether there is automatic
        /// acceptance of attachment requests (<c>enable</c> | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.default-route-table-association</c> - Indicates whether resource attachments
        /// are automatically associated with the default association route table (<c>enable</c>
        /// | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.default-route-table-propagation</c> - Indicates whether resource attachments
        /// automatically propagate routes to the default propagation route table (<c>enable</c>
        /// | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.dns-support</c> - Indicates whether DNS support is enabled (<c>enable</c>
        /// | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>options.vpn-ecmp-support</c> - Indicates whether Equal Cost Multipath Protocol
        /// support is enabled (<c>enable</c> | <c>disable</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the transit
        /// gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the transit gateway (<c>available</c> | <c>deleted</c>
        /// | <c>deleting</c> | <c>modifying</c> | <c>pending</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-id</c> - The ID of the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key </c>- The key/value combination of a tag assigned to the resource. Use
        /// the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
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
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
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
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayIds. 
        /// <para>
        /// The IDs of the transit gateways.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TransitGatewayIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TransitGatewayIds property is set.
        /// </summary>
        internal bool IsSetTransitGatewayIds() => this.TransitGatewayIds != null && (this.TransitGatewayIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
