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
    /// Contains data about a job execution.
    /// </summary>
    public partial class JobExecution
    {
        private long? _executionNumber;
        private string _jobDocument;
        private string _jobId;
        private long? _lastUpdatedAt;
        private long? _queuedAt;
        private long? _startedAt;
        private JobExecutionStatus _status;
        private Dictionary<string, string> _statusDetails = new Dictionary<string, string>();
        private string _thingName;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// A number that identifies a particular job execution on a particular device. It can
        /// be used later in commands that return or update job execution information.
        /// </para>
        /// </summary>
        public long ExecutionNumber
        {
            get { return this._executionNumber.GetValueOrDefault(); }
            set { this._executionNumber = value; }
        }

        // Check to see if ExecutionNumber property is set
        internal bool IsSetExecutionNumber()
        {
            return this._executionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobDocument. 
        /// <para>
        /// The content of the job document.
        /// </para>
        /// </summary>
        public string JobDocument
        {
            get { return this._jobDocument; }
            set { this._jobDocument = value; }
        }

        // Check to see if JobDocument property is set
        internal bool IsSetJobDocument()
        {
            return this._jobDocument != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to this job when it was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the job execution was last updated.
        /// 
        /// </para>
        /// </summary>
        public long LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueuedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the job execution was enqueued.
        /// </para>
        /// </summary>
        public long QueuedAt
        {
            get { return this._queuedAt.GetValueOrDefault(); }
            set { this._queuedAt = value; }
        }

        // Check to see if QueuedAt property is set
        internal bool IsSetQueuedAt()
        {
            return this._queuedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the job execution was started.
        /// </para>
        /// </summary>
        public long StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job execution. Can be one of: "QUEUED", "IN_PROGRESS", "FAILED",
        /// "SUCCESS", "CANCELED", "REJECTED", or "REMOVED".
        /// </para>
        /// </summary>
        public JobExecutionStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// A collection of name/value pairs that describe the status of the job execution.
        /// </para>
        /// </summary>
        public Dictionary<string, string> StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null && this._statusDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing that is executing the job.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version of the job execution. Job execution versions are incremented each time
        /// they are updated by a device.
        /// </para>
        /// </summary>
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}