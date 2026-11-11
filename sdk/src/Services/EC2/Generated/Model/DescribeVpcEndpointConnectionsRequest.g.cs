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
    /// Container for the parameters to the DescribeVpcEndpointConnections operation. Describes
    /// the VPC endpoint connections to your VPC endpoint services, including any endpoints
    /// that are pending your acceptance.
    /// </summary>
    public partial class DescribeVpcEndpointConnectionsRequest : AmazonEC2Request
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
        ///  <c>ip-address-type</c> - The IP address type (<c>ipv4</c> | <c>ipv6</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-id</c> - The ID of the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-endpoint-owner</c> - The ID of the Amazon Web Services account ID that owns
        /// the endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-endpoint-region</c> - The Region of the endpoint or <c>cross-region</c> to
        /// find endpoints for other Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-endpoint-state</c> - The state of the endpoint (<c>pendingAcceptance</c> |
        /// <c>pending</c> | <c>available</c> | <c>deleting</c> | <c>deleted</c> | <c>rejected</c>
        /// | <c>failed</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpc-endpoint-id</c> - The ID of the endpoint.
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
        /// The maximum number of results to return for the request in a single page. The remaining
        /// results of the initial request can be seen by sending another request with the returned
        /// <c>NextToken</c> value. This value can be between 5 and 1,000; if <c>MaxResults</c>
        /// is given a value larger than 1,000, only 1,000 results are returned.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
