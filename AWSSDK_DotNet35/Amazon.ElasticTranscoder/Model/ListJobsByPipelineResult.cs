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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <code>ListJobsByPipelineResponse</code> structure.
    /// </summary>
    public partial class ListJobsByPipelineResult : AmazonWebServiceResponse
    {
        private List<Job> _jobs = new List<Job>();
        private string _nextPageToken;

        /// <summary>
        /// Gets and sets the property Jobs. 
        /// <para>
        /// An array of <code>Job</code> objects that are in the specified pipeline.
        /// </para>
        /// </summary>
        public List<Job> Jobs
        {
            get { return this._jobs; }
            set { this._jobs = value; }
        }

        // Check to see if Jobs property is set
        internal bool IsSetJobs()
        {
            return this._jobs != null && this._jobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        ///  A value that you use to access the second and subsequent pages of results, if any.
        /// When the jobs in the specified pipeline fit on one page or when you've reached the
        /// last page of results, the value of <code>NextPageToken</code> is <code>null</code>.
        /// 
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

    }
}