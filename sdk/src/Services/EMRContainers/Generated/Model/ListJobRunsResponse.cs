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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// This is the response object from the ListJobRuns operation.
    /// </summary>
    public partial class ListJobRunsResponse : AmazonWebServiceResponse
    {
        private List<JobRun> _jobRuns = new List<JobRun>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobRuns. 
        /// <para>
        /// This output lists information about the specified job runs.
        /// </para>
        /// </summary>
        public List<JobRun> JobRuns
        {
            get { return this._jobRuns; }
            set { this._jobRuns = value; }
        }

        // Check to see if JobRuns property is set
        internal bool IsSetJobRuns()
        {
            return this._jobRuns != null && this._jobRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// This output displays the token for the next set of job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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