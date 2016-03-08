/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the FilterLogEvents operation.
    /// </summary>
    public partial class FilterLogEventsResponse : AmazonWebServiceResponse
    {
        private List<FilteredLogEvent> _events = new List<FilteredLogEvent>();
        private string _nextToken;
        private List<SearchedLogStream> _searchedLogStreams = new List<SearchedLogStream>();

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// A list of <code class="code">FilteredLogEvent</code> objects representing the matched
        /// events from the request.
        /// </para>
        /// </summary>
        public List<FilteredLogEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token obtained from a <code class="code">FilterLogEvents</code> response
        /// to continue paginating the FilterLogEvents results. This token is omitted from the
        /// response when there are no other events to display.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SearchedLogStreams. 
        /// <para>
        /// A list of <code class="code">SearchedLogStream</code> objects indicating which log
        /// streams have been searched in this request and whether each has been searched completely
        /// or still has more to be paginated.
        /// </para>
        /// </summary>
        public List<SearchedLogStream> SearchedLogStreams
        {
            get { return this._searchedLogStreams; }
            set { this._searchedLogStreams = value; }
        }

        // Check to see if SearchedLogStreams property is set
        internal bool IsSetSearchedLogStreams()
        {
            return this._searchedLogStreams != null && this._searchedLogStreams.Count > 0; 
        }

    }
}