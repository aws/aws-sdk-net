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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the ListSearches operation. Lists the searches in
    /// a workspace, most recently started first. Results can be narrowed with optional filters
    /// (status, search type, group, and started-at time range) and are paginated: when <c>nextToken</c>
    /// is present, pass it on a subsequent call to retrieve the next page.
    /// </summary>
    public partial class ListSearchesRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property ListSearchesFilters. 
        /// <para>
        /// Optional filters that restrict which searches are returned.
        /// </para>
        /// </summary>
        public ListSearchesFilters ListSearchesFilters { get; set; }

        /// <summary>
        /// Checks to see if the ListSearchesFilters property is set.
        /// </summary>
        internal bool IsSetListSearchesFilters() => this.ListSearchesFilters != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of searches to return in a single page. Valid range is 1 to 1,000;
        /// if omitted, a service-defined default is used.
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
        /// The pagination token returned by a previous ListSearches call. Provide it to retrieve
        /// the next page; omit it to retrieve the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace whose searches are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;
    }
}
