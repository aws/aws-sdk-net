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
    /// <para> Representation of a job returned by the ListJobs operation. </para>
    /// </summary>
    public class Job
    {
        
        private string jobId;
        private DateTime? creationDate;
        private bool? isCanceled;
        private JobType jobType;

        /// <summary>
        /// A unique identifier which refers to a particular job.
        ///  
        /// </summary>
        public string JobId
        {
            get { return this.jobId; }
            set { this.jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this.jobId != null;
        }

        /// <summary>
        /// Timestamp of the CreateJob request in ISO8601 date format. For example "2010-03-28T20:27:35Z".
        ///  
        /// </summary>
        public DateTime CreationDate
        {
            get { return this.creationDate ?? default(DateTime); }
            set { this.creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this.creationDate.HasValue;
        }

        /// <summary>
        /// Indicates whether the job was canceled.
        ///  
        /// </summary>
        public bool IsCanceled
        {
            get { return this.isCanceled ?? default(bool); }
            set { this.isCanceled = value; }
        }

        // Check to see if IsCanceled property is set
        internal bool IsSetIsCanceled()
        {
            return this.isCanceled.HasValue;
        }

        /// <summary>
        /// Specifies whether the job to initiate is an import or export job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Import, Export</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public JobType JobType
        {
            get { return this.jobType; }
            set { this.jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this.jobType != null;
        }
    }
}
