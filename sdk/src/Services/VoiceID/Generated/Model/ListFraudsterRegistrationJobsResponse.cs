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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// This is the response object from the ListFraudsterRegistrationJobs operation.
    /// </summary>
    public partial class ListFraudsterRegistrationJobsResponse : AmazonWebServiceResponse
    {
        private List<FraudsterRegistrationJobSummary> _jobSummaries = new List<FraudsterRegistrationJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobSummaries. 
        /// <para>
        /// A list containing details about each specified fraudster registration job.
        /// </para>
        /// </summary>
        public List<FraudsterRegistrationJobSummary> JobSummaries
        {
            get { return this._jobSummaries; }
            set { this._jobSummaries = value; }
        }

        // Check to see if JobSummaries property is set
        internal bool IsSetJobSummaries()
        {
            return this._jobSummaries != null && this._jobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If <code>NextToken</code> is returned, there are more results available. The value
        /// of <code>NextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

    }
}