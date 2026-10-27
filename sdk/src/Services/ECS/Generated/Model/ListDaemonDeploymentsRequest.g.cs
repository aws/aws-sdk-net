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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListDaemonDeployments operation. Returns a list
    /// of daemon deployments for a specified daemon. You can filter the results by status
    /// or creation time.
    /// </summary>
    public partial class ListDaemonDeploymentsRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// An optional filter to narrow the <c>ListDaemonDeployments</c> results by creation
        /// time. If you don't specify a time range, all deployments are returned.
        /// </para>
        /// </summary>
        public CreatedAt CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property DaemonArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the daemon to list deployments for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DaemonArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonArn property is set.
        /// </summary>
        internal bool IsSetDaemonArn() => this.DaemonArn != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of daemon deployment results that <c>ListDaemonDeployments</c>
        /// returned in paginated output. When this parameter is used, <c>ListDaemonDeployments</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>ListDaemonDeployments</c> request with the returned <c>nextToken</c> value.
        /// This value can be between 1 and 100. If this parameter isn't used, then <c>ListDaemonDeployments</c>
        /// returns up to 20 results and a <c>nextToken</c> value if applicable.
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
        /// The <c>nextToken</c> value returned from a <c>ListDaemonDeployments</c> request indicating
        /// that more results are available to fulfill the request and further calls will be needed.
        /// If <c>maxResults</c> was provided, it's possible for the number of results to be fewer
        /// than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional filter to narrow the <c>ListDaemonDeployments</c> results by deployment
        /// status. If you don't specify a status, all deployments are returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Status { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null && (this.Status.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
