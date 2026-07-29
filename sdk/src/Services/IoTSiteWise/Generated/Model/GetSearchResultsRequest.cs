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
    /// Container for the parameters to the GetSearchResults operation.
    /// Retrieves the ranked results of a search, ordered by descending relevance score. Results
    /// are available only after the search has reached the <c>SUCCEEDED</c> status. Calling
    /// this on a search that exists but has not yet completed returns <c>InvalidRequestException</c>,
    /// while calling it on a search that does not exist returns <c>ResourceNotFoundException</c>.
    /// The response is paginated: when <c>nextToken</c> is present, pass it on a subsequent
    /// call to retrieve the next page.
    /// </summary>
    public partial class GetSearchResultsRequest : AmazonIoTSiteWiseRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _searchId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single page. Valid range is 1 to 10,000;
        /// if omitted, a service-defined default is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        /// The pagination token returned by a previous GetSearchResults call. Provide it to retrieve
        /// the next page of results; omit it to retrieve the first page.
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
        /// Gets and sets the property SearchId. 
        /// <para>
        /// The identifier of the search whose results are retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=23, Max=36)]
        public string SearchId
        {
            get { return this._searchId; }
            set { this._searchId = value; }
        }

        // Check to see if SearchId property is set
        internal bool IsSetSearchId()
        {
            return this._searchId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace the search belongs to.
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