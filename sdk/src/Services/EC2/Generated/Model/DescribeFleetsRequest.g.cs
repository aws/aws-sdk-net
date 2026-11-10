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
    /// Container for the parameters to the DescribeFleets operation. Describes the specified
    /// EC2 Fleet or all of your EC2 Fleets. <important> <para> If a fleet is of type <c>instant</c>,
    /// you must specify the fleet ID in the request, otherwise the fleet does not appear
    /// in the response. </para> </important> <para> For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/manage-ec2-fleet.html#monitor-ec2-fleet">Describe
    /// your EC2 Fleet</a> in the <i>Amazon EC2 User Guide</i>. </para>
    /// </summary>
    public partial class DescribeFleetsRequest : AmazonEC2Request
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
        ///  <c>activity-status</c> - The progress of the EC2 Fleet ( <c>error</c> | <c>pending-fulfillment</c>
        /// | <c>pending-termination</c> | <c>fulfilled</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>excess-capacity-termination-policy</c> - Indicates whether to terminate running
        /// instances if the target capacity is decreased below the current EC2 Fleet size (<c>true</c>
        /// | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fleet-state</c> - The state of the EC2 Fleet (<c>submitted</c> | <c>active</c>
        /// | <c>deleted</c> | <c>failed</c> | <c>deleted-running</c> | <c>deleted-terminating</c>
        /// | <c>modifying</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>replace-unhealthy-instances</c> - Indicates whether EC2 Fleet should replace unhealthy
        /// instances (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - The type of request (<c>instant</c> | <c>request</c> | <c>maintain</c>).
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
        /// Gets and sets the property FleetIds. 
        /// <para>
        /// The IDs of the EC2 Fleets.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a fleet is of type <c>instant</c>, you must specify the fleet ID, otherwise it
        /// does not appear in the response.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FleetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FleetIds property is set.
        /// </summary>
        internal bool IsSetFleetIds() => this.FleetIds != null && (this.FleetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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
