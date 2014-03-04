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
using Amazon.Runtime.Internal;

namespace Amazon.ImportExport.Model
{
    /// <summary>
    /// Container for the parameters to the ListJobs operation.
    /// <para> This operation returns the jobs associated with the requester. AWS Import/Export lists the jobs in reverse chronological order based
    /// on the date of creation. For example if Job Test1 was created 2009Dec30 and Test2 was created 2010Feb05, the ListJobs operation would return
    /// Test2 followed by Test1. </para>
    /// </summary>
    /// <seealso cref="Amazon.ImportExport.AmazonImportExport.ListJobs"/>
    public class ListJobsRequest : AmazonWebServiceRequest
    {
        private int? maxJobs;
        private string marker;

        /// <summary>
        /// Sets the maximum number of jobs returned in the response. If there are additional jobs that were not returned because MaxJobs was exceeded,
        /// the response contains <IsTruncated>true</IsTruncated>. To return the additional jobs, see Marker.
        ///  
        /// </summary>
        public int MaxJobs
        {
            get { return this.maxJobs ?? default(int); }
            set { this.maxJobs = value; }
        }

        /// <summary>
        /// Sets the MaxJobs property
        /// </summary>
        /// <param name="maxJobs">The value to set for the MaxJobs property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithMaxJobs(int maxJobs)
        {
            this.maxJobs = maxJobs;
            return this;
        }
            

        // Check to see if MaxJobs property is set
        internal bool IsSetMaxJobs()
        {
            return this.maxJobs.HasValue;       
        }

        /// <summary>
        /// Specifies the JOBID to start after when listing the jobs created with your account. AWS Import/Export lists your jobs in reverse
        /// chronological order. See MaxJobs.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListJobsRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }
    }
}
    
