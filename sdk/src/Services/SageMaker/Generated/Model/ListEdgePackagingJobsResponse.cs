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
    /// This is the response object from the ListEdgePackagingJobs operation.
    /// </summary>
    public partial class ListEdgePackagingJobsResponse : AmazonWebServiceResponse
    {
        private List<EdgePackagingJobSummary> _edgePackagingJobSummaries = new List<EdgePackagingJobSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property EdgePackagingJobSummaries. 
        /// <para>
        /// Summaries of edge packaging jobs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EdgePackagingJobSummary> EdgePackagingJobSummaries
        {
            get { return this._edgePackagingJobSummaries; }
            set { this._edgePackagingJobSummaries = value; }
        }

        // Check to see if EdgePackagingJobSummaries property is set
        internal bool IsSetEdgePackagingJobSummaries()
        {
            return this._edgePackagingJobSummaries != null && this._edgePackagingJobSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to use when calling the next page of results.
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