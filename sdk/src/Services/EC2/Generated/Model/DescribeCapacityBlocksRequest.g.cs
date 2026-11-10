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
    /// Container for the parameters to the DescribeCapacityBlocks operation. Describes details
    /// about Capacity Blocks in the Amazon Web Services Region that you're currently using.
    /// </summary>
    public partial class DescribeCapacityBlocksRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CapacityBlockIds. 
        /// <para>
        /// The IDs of the Capacity Blocks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CapacityBlockIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CapacityBlockIds property is set.
        /// </summary>
        internal bool IsSetCapacityBlockIds() => this.CapacityBlockIds != null && (this.CapacityBlockIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        ///  One or more filters. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>capacity-block-id</c> - The ID of the Capacity Block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ultraserver-type</c> - The Capacity Block type. The type can be <c>instances</c>
        /// or <c>ultraservers</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone of the Capacity Block.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start-date</c> - The date and time at which the Capacity Block was started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>end-date</c> - The date and time at which the Capacity Block expires. When a Capacity
        /// Block expires, all instances in the Capacity Block are terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>create-date</c> - The date and time at which the Capacity Block was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the Capacity Block (<c>active</c> | <c>expired</c> |
        /// <c>unavailable</c> | <c>cancelled</c> | <c>failed</c> | <c>scheduled</c> | <c>payment-pending</c>
        /// | <c>payment-failed</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tags</c> - The tags assigned to the Capacity Block.
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
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
