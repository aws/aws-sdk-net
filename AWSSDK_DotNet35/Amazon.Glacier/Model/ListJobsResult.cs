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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon Glacier response to your request.
    /// </summary>
    public partial class ListJobsResult : AmazonWebServiceResponse
    {
        private List<GlacierJobDescription> _jobList = new List<GlacierJobDescription>();
        private string _marker;

        /// <summary>
        /// Gets and sets the property JobList. 
        /// <para>
        /// A list of job objects. Each job object contains metadata describing the job. 
        /// </para>
        /// </summary>
        public List<GlacierJobDescription> JobList
        {
            get { return this._jobList; }
            set { this._jobList = value; }
        }

        // Check to see if JobList property is set
        internal bool IsSetJobList()
        {
            return this._jobList != null && this._jobList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An opaque string that represents where to continue pagination of the results. You
        /// use this value in a new List Jobs request to obtain more jobs in the list. If there
        /// are no more jobs, this value is <code>null</code>. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}