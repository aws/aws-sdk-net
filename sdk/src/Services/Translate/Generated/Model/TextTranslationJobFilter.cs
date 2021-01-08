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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Provides information for filtering a list of translation jobs. For more information,
    /// see <a>ListTextTranslationJobs</a>.
    /// </summary>
    public partial class TextTranslationJobFilter
    {
        private string _jobName;
        private JobStatus _jobStatus;
        private DateTime? _submittedAfterTime;
        private DateTime? _submittedBeforeTime;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Filters the list of jobs by name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// Filters the list of jobs based by job status.
        /// </para>
        /// </summary>
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SubmittedAfterTime. 
        /// <para>
        /// Filters the list of jobs based on the time that the job was submitted for processing
        /// and returns only the jobs submitted after the specified time. Jobs are returned in
        /// descending order, newest to oldest.
        /// </para>
        /// </summary>
        public DateTime SubmittedAfterTime
        {
            get { return this._submittedAfterTime.GetValueOrDefault(); }
            set { this._submittedAfterTime = value; }
        }

        // Check to see if SubmittedAfterTime property is set
        internal bool IsSetSubmittedAfterTime()
        {
            return this._submittedAfterTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubmittedBeforeTime. 
        /// <para>
        /// Filters the list of jobs based on the time that the job was submitted for processing
        /// and returns only the jobs submitted before the specified time. Jobs are returned in
        /// ascending order, oldest to newest.
        /// </para>
        /// </summary>
        public DateTime SubmittedBeforeTime
        {
            get { return this._submittedBeforeTime.GetValueOrDefault(); }
            set { this._submittedBeforeTime = value; }
        }

        // Check to see if SubmittedBeforeTime property is set
        internal bool IsSetSubmittedBeforeTime()
        {
            return this._submittedBeforeTime.HasValue; 
        }

    }
}