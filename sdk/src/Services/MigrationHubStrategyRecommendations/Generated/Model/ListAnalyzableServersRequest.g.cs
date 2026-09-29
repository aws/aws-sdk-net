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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the ListAnalyzableServers operation. Retrieves a list
    /// of all the servers fetched from customer vCenter using Strategy Recommendation Collector.
    /// </summary>
    public partial class ListAnalyzableServersRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. The maximum number of items to include in the
        /// response. The maximum value is 100.
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. The token from a previous call that you use
        /// to retrieve the next set of results. For example, if a previous call to this action
        /// returned 100 items, but you set maxResults to 10. You'll receive a set of 10 results
        /// along with a token. You then use the returned token to retrieve the next set of 10.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Sort. Specifies whether to sort by ascending (ASC) or descending
        /// (DESC) order.
        /// </summary>
        public SortOrder Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;
    }
}
