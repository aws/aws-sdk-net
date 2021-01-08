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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// This is the response object from the ListProgressUpdateStreams operation.
    /// </summary>
    public partial class ListProgressUpdateStreamsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProgressUpdateStreamSummary> _progressUpdateStreamSummaryList = new List<ProgressUpdateStreamSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more streams created than the max result, return the next token to be
        /// passed to the next call as a bookmark of where to start from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property ProgressUpdateStreamSummaryList. 
        /// <para>
        /// List of progress update streams up to the max number of results passed in the input.
        /// </para>
        /// </summary>
        public List<ProgressUpdateStreamSummary> ProgressUpdateStreamSummaryList
        {
            get { return this._progressUpdateStreamSummaryList; }
            set { this._progressUpdateStreamSummaryList = value; }
        }

        // Check to see if ProgressUpdateStreamSummaryList property is set
        internal bool IsSetProgressUpdateStreamSummaryList()
        {
            return this._progressUpdateStreamSummaryList != null && this._progressUpdateStreamSummaryList.Count > 0; 
        }

    }
}