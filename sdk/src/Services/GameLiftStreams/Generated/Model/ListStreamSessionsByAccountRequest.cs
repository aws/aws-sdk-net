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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreamSessionsByAccount operation.
    /// Retrieves a list of Amazon GameLift Streams stream sessions that this user account
    /// has access to.
    /// 
    ///  
    /// <para>
    /// In the returned list of stream sessions, the <c>ExportFilesMetadata</c> property only
    /// shows the <c>Status</c> value. To get the <c>OutpurUri</c> and <c>StatusReason</c>
    /// values, use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
    /// </para>
    ///  
    /// <para>
    /// We don't recommend using this operation to regularly check stream session statuses
    /// because it's costly. Instead, to check status updates for a specific stream session,
    /// use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>.
    /// </para>
    /// </summary>
    public partial class ListStreamSessionsByAccountRequest : AmazonGameLiftStreamsRequest
    {
        private ExportFilesStatus _exportFilesStatus;
        private int? _maxResults;
        private string _nextToken;
        private StreamSessionStatus _status;

        /// <summary>
        /// Gets and sets the property ExportFilesStatus. 
        /// <para>
        /// Filter by the exported files status. You can specify one status in each request to
        /// retrieve only sessions that currently have that exported files status.
        /// </para>
        /// </summary>
        public ExportFilesStatus ExportFilesStatus
        {
            get { return this._exportFilesStatus; }
            set { this._exportFilesStatus = value; }
        }

        // Check to see if ExportFilesStatus property is set
        internal bool IsSetExportFilesStatus()
        {
            return this._exportFilesStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of results to return. Use this parameter with <c>NextToken</c> to return
        /// results in sequential pages. Default value is <c>25</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The token that marks the start of the next set of results. Use this token when you
        /// retrieve results as sequential pages. To get the first page of results, omit a token
        /// value. To get the remaining pages, provide the token returned with the previous result
        /// set. 
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter by the stream session status. You can specify one status in each request to
        /// retrieve only sessions that are currently in that status.
        /// </para>
        /// </summary>
        public StreamSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}