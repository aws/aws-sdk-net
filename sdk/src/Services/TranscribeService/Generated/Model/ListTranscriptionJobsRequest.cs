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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Container for the parameters to the ListTranscriptionJobs operation.
    /// Lists transcription jobs with the specified status.
    /// </summary>
    public partial class ListTranscriptionJobsRequest : AmazonTranscribeServiceRequest
    {
        private string _jobNameContains;
        private int? _maxResults;
        private string _nextToken;
        private TranscriptionJobStatus _status;

        /// <summary>
        /// Gets and sets the property JobNameContains. 
        /// <para>
        /// When specified, the jobs returned in the list are limited to jobs whose name contains
        /// the specified string.
        /// </para>
        /// </summary>
        public string JobNameContains
        {
            get { return this._jobNameContains; }
            set { this._jobNameContains = value; }
        }

        // Check to see if JobNameContains property is set
        internal bool IsSetJobNameContains()
        {
            return this._jobNameContains != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of jobs to return in the response. If there are fewer results in
        /// the list, this response contains only the actual results.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If the result of the previous request to <code>ListTranscriptionJobs</code> was truncated,
        /// include the <code>NextToken</code> to fetch the next set of jobs.
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
        /// When specified, returns only transcription jobs with the specified status.
        /// </para>
        /// </summary>
        public TranscriptionJobStatus Status
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