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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the ListClusterJobs operation.
    /// </summary>
    public partial class ListClusterJobsResponse : AmazonWebServiceResponse
    {
        private List<JobListEntry> _jobListEntries = new List<JobListEntry>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobListEntries. 
        /// <para>
        /// Each <code>JobListEntry</code> object contains a job's state, a job's ID, and a value
        /// that indicates whether the job is a job part, in the case of export jobs. 
        /// </para>
        /// </summary>
        public List<JobListEntry> JobListEntries
        {
            get { return this._jobListEntries; }
            set { this._jobListEntries = value; }
        }

        // Check to see if JobListEntries property is set
        internal bool IsSetJobListEntries()
        {
            return this._jobListEntries != null && this._jobListEntries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// HTTP requests are stateless. If you use the automatically generated <code>NextToken</code>
        /// value in your next <code>ListClusterJobsResult</code> call, your list of returned
        /// jobs will start from this point in the array.
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

    }
}