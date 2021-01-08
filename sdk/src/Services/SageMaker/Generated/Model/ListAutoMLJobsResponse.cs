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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the ListAutoMLJobs operation.
    /// </summary>
    public partial class ListAutoMLJobsResponse : AmazonWebServiceResponse
    {
        private List<AutoMLJobSummary> _autoMLJobSummaries = new List<AutoMLJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AutoMLJobSummaries. 
        /// <para>
        /// Returns a summary list of jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutoMLJobSummary> AutoMLJobSummaries
        {
            get { return this._autoMLJobSummaries; }
            set { this._autoMLJobSummaries = value; }
        }

        // Check to see if AutoMLJobSummaries property is set
        internal bool IsSetAutoMLJobSummaries()
        {
            return this._autoMLJobSummaries != null && this._autoMLJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, you receive this token. Use it in your next
        /// request to receive the next set of results.
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

    }
}