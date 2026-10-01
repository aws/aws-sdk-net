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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssets operation. Lists assets in the specified
    /// agent space
    /// </summary>
    public partial class ListAssetsRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space to list assets from
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AssetType. 
        /// <para>
        /// Filter results to only assets of this type
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AssetType { get; set; }

        /// <summary>
        /// Checks to see if the AssetType property is set.
        /// </summary>
        internal bool IsSetAssetType() => this.AssetType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single response
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token from a previous response to retrieve the next page of results
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property UpdatedAfter. 
        /// <para>
        /// Filter results to only assets updated after this timestamp
        /// </para>
        /// </summary>
        public DateTime? UpdatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAfter property is set.
        /// </summary>
        internal bool IsSetUpdatedAfter() => this.UpdatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBefore. 
        /// <para>
        /// Filter results to only assets updated before this timestamp
        /// </para>
        /// </summary>
        public DateTime? UpdatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBefore property is set.
        /// </summary>
        internal bool IsSetUpdatedBefore() => this.UpdatedBefore.HasValue;
    }
}
