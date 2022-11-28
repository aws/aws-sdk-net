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
    /// Container for the parameters to the ListCallAnalyticsJobs operation.
    /// Provides a list of Call Analytics jobs that match the specified criteria. If no criteria
    /// are specified, all Call Analytics jobs are returned.
    /// 
    ///  
    /// <para>
    /// To get detailed information about a specific Call Analytics job, use the operation.
    /// </para>
    /// </summary>
    public partial class ListCallAnalyticsJobsRequest : AmazonTranscribeServiceRequest
    {
        private string _jobNameContains;
        private int? _maxResults;
        private string _nextToken;
        private CallAnalyticsJobStatus _status;

        /// <summary>
        /// Gets and sets the property JobNameContains. 
        /// <para>
        /// Returns only the Call Analytics jobs that contain the specified string. The search
        /// is not case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// The maximum number of Call Analytics jobs to return in each page of results. If there
        /// are fewer results than the value that you specify, only the actual results are returned.
        /// If you don't specify a value, a default of 5 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// If your <code>ListCallAnalyticsJobs</code> request returns more results than can be
        /// displayed, <code>NextToken</code> is displayed in the response with an associated
        /// string. To get the next page of results, copy this string and repeat your request,
        /// including <code>NextToken</code> with the value of the copied string. Repeat as needed
        /// to view all your results.
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
        /// Returns only Call Analytics jobs with the specified status. Jobs are ordered by creation
        /// date, with the newest job first. If you don't include <code>Status</code>, all Call
        /// Analytics jobs are returned.
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