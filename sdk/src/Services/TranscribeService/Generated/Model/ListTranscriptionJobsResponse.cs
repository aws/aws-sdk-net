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
    /// This is the response object from the ListTranscriptionJobs operation.
    /// </summary>
    public partial class ListTranscriptionJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private TranscriptionJobStatus _status;
        private List<TranscriptionJobSummary> _transcriptionJobSummaries = new List<TranscriptionJobSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>ListTranscriptionJobs</code> operation returns a page of jobs at a time.
        /// The size of the page is set by the <code>MaxResults</code> parameter. If there are
        /// more jobs in the list than the page size, Amazon Transcribe returns the <code>NextPage</code>
        /// token. Include the token in the next request to the <code>ListTranscriptionJobs</code>
        /// operation to return in the next page of jobs.
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
        /// The requested status of the jobs returned.
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

        /// <summary>
        /// Gets and sets the property TranscriptionJobSummaries. 
        /// <para>
        /// A list of objects containing summary information for a transcription job.
        /// </para>
        /// </summary>
        public List<TranscriptionJobSummary> TranscriptionJobSummaries
        {
            get { return this._transcriptionJobSummaries; }
            set { this._transcriptionJobSummaries = value; }
        }

        // Check to see if TranscriptionJobSummaries property is set
        internal bool IsSetTranscriptionJobSummaries()
        {
            return this._transcriptionJobSummaries != null && this._transcriptionJobSummaries.Count > 0; 
        }

    }
}