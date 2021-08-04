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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// This is the response object from the ListCallAnalyticsJobs operation.
    /// </summary>
    public partial class ListCallAnalyticsJobsResponse : AmazonWebServiceResponse
    {
        private List<CallAnalyticsJobSummary> _callAnalyticsJobSummaries = new List<CallAnalyticsJobSummary>();
        private string _nextToken;
        private CallAnalyticsJobStatus _status;

        /// <summary>
        /// Gets and sets the property CallAnalyticsJobSummaries. 
        /// <para>
        /// A list of objects containing summary information for a transcription job.
        /// </para>
        /// </summary>
        public List<CallAnalyticsJobSummary> CallAnalyticsJobSummaries
        {
            get { return this._callAnalyticsJobSummaries; }
            set { this._callAnalyticsJobSummaries = value; }
        }

        // Check to see if CallAnalyticsJobSummaries property is set
        internal bool IsSetCallAnalyticsJobSummaries()
        {
            return this._callAnalyticsJobSummaries != null && this._callAnalyticsJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The operation returns a page of jobs at a time. The maximum size of the page is set
        /// by the <code>MaxResults</code> parameter. If there are more jobs in the list than
        /// the page size, Amazon Transcribe returns the <code>NextPage</code> token. Include
        /// the token in your next request to the operation to return next page of jobs.
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
        /// When specified, returns only call analytics jobs with that status. Jobs are ordered
        /// by creation date, with the most recent jobs returned first. If you don't specify a
        /// status, Amazon Transcribe returns all transcription jobs ordered by creation date.
        /// </para>
        /// </summary>
        public CallAnalyticsJobStatus Status
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