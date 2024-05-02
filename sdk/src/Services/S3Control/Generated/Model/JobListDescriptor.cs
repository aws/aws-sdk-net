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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Contains the configuration and status information for a single job retrieved as part
    /// of a job list.
    /// </summary>
    public partial class JobListDescriptor
    {
        private DateTime? _creationTime;
        private string _description;
        private string _jobId;
        private OperationName _operation;
        private int? _priority;
        private JobProgressSummary _progressSummary;
        private JobStatus _status;
        private DateTime? _terminationDate;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when the specified job was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-specified description that was included in the specified job's <c>Create
        /// Job</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=36)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The operation that the specified job is configured to run on every object listed in
        /// the manifest.
        /// </para>
        /// </summary>
        public OperationName Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The current priority for the specified job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressSummary. 
        /// <para>
        /// Describes the total number of tasks that the specified job has run, the number of
        /// tasks that succeeded, and the number of tasks that failed.
        /// </para>
        /// </summary>
        public JobProgressSummary ProgressSummary
        {
            get { return this._progressSummary; }
            set { this._progressSummary = value; }
        }

        // Check to see if ProgressSummary property is set
        internal bool IsSetProgressSummary()
        {
            return this._progressSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The specified job's current status.
        /// </para>
        /// </summary>
        public JobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationDate. 
        /// <para>
        /// A timestamp indicating when the specified job terminated. A job's termination date
        /// is the date and time when it succeeded, failed, or was canceled.
        /// </para>
        /// </summary>
        public DateTime? TerminationDate
        {
            get { return this._terminationDate; }
            set { this._terminationDate = value; }
        }

        // Check to see if TerminationDate property is set
        internal bool IsSetTerminationDate()
        {
            return this._terminationDate.HasValue; 
        }

    }
}