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

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// <para> Output structure for the ListJobs operation. </para>
    /// </summary>
    public class ListJobsResult  
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
        /// <summary>
        /// Adds elements to the Jobs collection
        /// </summary>
        /// <param name="jobs">The values to add to the Jobs collection </param>
        /// <returns>this instance</returns>
        public ListJobsResult WithJobs(params Job[] jobs)
        {
            foreach (Job element in jobs)
            {
                this.jobs.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Jobs collection
        /// </summary>
        /// <param name="jobs">The values to add to the Jobs collection </param>
        /// <returns>this instance</returns>
        public ListJobsResult WithJobs(IEnumerable<Job> jobs)
        {
            foreach (Job element in jobs)
            {
                this.jobs.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the IsTruncated property
        /// </summary>
        /// <param name="isTruncated">The value to set for the IsTruncated property </param>
        /// <returns>this instance</returns>
        public ListJobsResult WithIsTruncated(bool isTruncated)
        {
            this.isTruncated = isTruncated;
            return this;
        }
            

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;       
        }
    }
}
