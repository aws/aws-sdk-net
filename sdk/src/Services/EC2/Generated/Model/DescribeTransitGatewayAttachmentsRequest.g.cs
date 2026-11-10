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
    /// Container for the parameters to the DescribeTransitGatewayAttachments operation. Describes
    /// one or more attachments between resources and transit gateways. By default, all attachments
    /// are described. Alternatively, you can filter the results by attachment ID, attachment
    /// state, resource ID, or resource owner.
    /// </summary>
    public partial class DescribeTransitGatewayAttachmentsRequest : AmazonEC2Request
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
        ///  <c>association.state</c> - The state of the association (<c>associating</c> | <c>associated</c>
        /// | <c>disassociating</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association.transit-gateway-route-table-id</c> - The ID of the route table for
        /// the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-id</c> - The ID of the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-owner-id</c> - The ID of the Amazon Web Services account that owns the
        /// resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-type</c> - The resource type. Valid values are <c>vpc</c> | <c>vpn</c>
        /// | <c>direct-connect-gateway</c> | <c>peering</c> | <c>connect</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the attachment. Valid values are <c>available</c> | <c>deleted</c>
        /// | <c>deleting</c> | <c>failed</c> | <c>failing</c> | <c>initiatingRequest</c> | <c>modifying</c>
        /// | <c>pendingAcceptance</c> | <c>pending</c> | <c>rollingBack</c> | <c>rejected</c>
        /// | <c>rejecting</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-attachment-id</c> - The ID of the attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-id</c> - The ID of the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-owner-id</c> - The ID of the Amazon Web Services account that
        /// owns the transit gateway.
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
        /// Gets and sets the property TransitGatewayAttachmentIds. 
        /// <para>
        /// The IDs of the attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TransitGatewayAttachmentIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentIds property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentIds() => this.TransitGatewayAttachmentIds != null && (this.TransitGatewayAttachmentIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
