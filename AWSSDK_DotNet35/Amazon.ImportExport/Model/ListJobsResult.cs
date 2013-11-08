/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// <para> Output structure for the ListJobs operation. </para>
    /// </summary>
    public partial class ListJobsResult : AmazonWebServiceResponse
    {
        
        private List<Job> jobs = new List<Job>();
        private bool? isTruncated;

        /// <summary>
        /// A list container for Jobs returned by the ListJobs operation.
        ///  
        /// </summary>
        public List<Job> Jobs
        {
            get { return this.jobs; }
            set { this.jobs = value; }
        }

        // Check to see if Jobs property is set
        internal bool IsSetJobs()
        {
            return this.jobs.Count > 0;
        }

        /// <summary>
        /// Indicates whether the list of jobs was truncated. If true, then call ListJobs again using the last JobId element as the marker.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }
    }
}
