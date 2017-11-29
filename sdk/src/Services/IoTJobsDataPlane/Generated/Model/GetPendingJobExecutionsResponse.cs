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
 * Do not modify this file. This file is generated from the iot-jobs-data-2017-09-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTJobsDataPlane.Model
{
    /// <summary>
    /// This is the response object from the GetPendingJobExecutions operation.
    /// </summary>
    public partial class GetPendingJobExecutionsResponse : AmazonWebServiceResponse
    {
        private List<JobExecutionSummary> _inProgressJobs = new List<JobExecutionSummary>();
        private List<JobExecutionSummary> _queuedJobs = new List<JobExecutionSummary>();

        /// <summary>
        /// Gets and sets the property InProgressJobs. 
        /// <para>
        /// A list of JobExecutionSummary objects with status IN_PROGRESS.
        /// </para>
        /// </summary>
        public List<JobExecutionSummary> InProgressJobs
        {
            get { return this._inProgressJobs; }
            set { this._inProgressJobs = value; }
        }

        // Check to see if InProgressJobs property is set
        internal bool IsSetInProgressJobs()
        {
            return this._inProgressJobs != null && this._inProgressJobs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueuedJobs. 
        /// <para>
        /// A list of JobExecutionSummary objects with status QUEUED.
        /// </para>
        /// </summary>
        public List<JobExecutionSummary> QueuedJobs
        {
            get { return this._queuedJobs; }
            set { this._queuedJobs = value; }
        }

        // Check to see if QueuedJobs property is set
        internal bool IsSetQueuedJobs()
        {
            return this._queuedJobs != null && this._queuedJobs.Count > 0; 
        }

    }
}