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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
    /// Container for the parameters to the ListSearches operation.
    /// Lists the searches in a workspace, most recently started first. Results can be narrowed
    /// with optional filters (status, search type, group, and started-at time range) and
    /// are paginated: when <c>nextToken</c> is present, pass it on a subsequent call to retrieve
    /// the next page.
    /// </summary>
    public partial class ListSearchesRequest : AmazonIoTSiteWiseRequest
    {
        private ListSearchesFilters _listSearchesFilters;
        private int? _maxResults;
        private string _nextToken;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ListSearchesFilters. 
        /// <para>
        /// Optional filters that restrict which searches are returned.
        /// </para>
        /// </summary>
        public ListSearchesFilters ListSearchesFilters
        {
            get { return this._listSearchesFilters; }
            set { this._listSearchesFilters = value; }
        }

        // Check to see if ListSearchesFilters property is set
        internal bool IsSetListSearchesFilters()
        {
            return this._listSearchesFilters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of searches to return in a single page. Valid range is 1 to 1,000;
        /// if omitted, a service-defined default is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token returned by a previous ListSearches call. Provide it to retrieve
        /// the next page; omit it to retrieve the first page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace whose searches are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}