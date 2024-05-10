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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the ListTranscriptionJobs operation.
    /// </summary>
    public partial class ListTranscriptionJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private TranscriptionJobStatus _status;
        private List<TranscriptionJobSummary> _transcriptionJobSummaries = AWSConfigs.InitializeCollections ? new List<TranscriptionJobSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <c>NextToken</c> is present in your response, it indicates that not all results
        /// are displayed. To view the next set of results, copy the string associated with the
        /// <c>NextToken</c> parameter in your results output, then run your request again including
        /// <c>NextToken</c> with the value of the copied string. Repeat as needed to view all
        /// your results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Lists all transcription jobs that have the status specified in your request. Jobs
        /// are ordered by creation date, with the newest job first.
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
        /// Provides a summary of information about each result.
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
            return this._transcriptionJobSummaries != null && (this._transcriptionJobSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}