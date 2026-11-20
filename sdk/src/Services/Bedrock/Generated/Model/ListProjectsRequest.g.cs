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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListProjects operation. Lists the account's projects.
    /// Results are paginated: when the response includes <c>nextToken</c>, pass it in the
    /// next request to fetch the following page. Page size is 1-100, default 20. By default
    /// every project is returned regardless of status; set <c>statusFilter</c> to list only
    /// active or only archived projects.
    /// </summary>
    public partial class ListProjectsRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of projects to return in one response, from 1 to 100. The default
        /// is 20.
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
        /// Continuation token from a previous ListProjects response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StatusFilter. 
        /// <para>
        /// Returns only the projects in this lifecycle status. When absent, no status filtering
        /// is applied and every project is returned. New lifecycle states extend the <c>ProjectStatus</c>
        /// enum, and with it this filter, compatibly.
        /// </para>
        /// </summary>
        public ProjectStatus StatusFilter { get; set; }

        /// <summary>
        /// Checks to see if the StatusFilter property is set.
        /// </summary>
        internal bool IsSetStatusFilter() => this.StatusFilter != null;
    }
}
