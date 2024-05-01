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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The job execution object represents the execution of a job on a particular device.
    /// </summary>
    public partial class JobExecution
    {
        private long? _approximateSecondsBeforeTimedOut;
        private long? _executionNumber;
        private bool? _forceCanceled;
        private string _jobId;
        private DateTime? _lastUpdatedAt;
        private DateTime? _queuedAt;
        private DateTime? _startedAt;
        private JobExecutionStatus _status;
        private JobExecutionStatusDetails _statusDetails;
        private string _thingArn;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property ApproximateSecondsBeforeTimedOut. 
        /// <para>
        /// The estimated number of seconds that remain before the job execution status will be
        /// changed to <c>TIMED_OUT</c>. The timeout interval can be anywhere between 1 minute
        /// and 7 days (1 to 10080 minutes). The actual job execution timeout can occur up to
        /// 60 seconds later than the estimated duration. This value will not be included if the
        /// job execution has reached a terminal status.
        /// </para>
        /// </summary>
        public long? ApproximateSecondsBeforeTimedOut
        {
            get { return this._approximateSecondsBeforeTimedOut; }
            set { this._approximateSecondsBeforeTimedOut = value; }
        }

        // Check to see if ApproximateSecondsBeforeTimedOut property is set
        internal bool IsSetApproximateSecondsBeforeTimedOut()
        {
            return this._approximateSecondsBeforeTimedOut.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// A string (consisting of the digits "0" through "9") which identifies this particular
        /// job execution on this particular device. It can be used in commands which return or
        /// update job execution information. 
        /// </para>
        /// </summary>
        public long? ExecutionNumber
        {
            get { return this._executionNumber; }
            set { this._executionNumber = value; }
        }

        // Check to see if ExecutionNumber property is set
        internal bool IsSetExecutionNumber()
        {
            return this._executionNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForceCanceled. 
        /// <para>
        /// Will be <c>true</c> if the job execution was canceled with the optional <c>force</c>
        /// parameter set to <c>true</c>.
        /// </para>
        /// </summary>
        public bool? ForceCanceled
        {
            get { return this._forceCanceled; }
            set { this._forceCanceled = value; }
        }

        // Check to see if ForceCanceled property is set
        internal bool IsSetForceCanceled()
        {
            return this._forceCanceled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier you assigned to the job when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The time, in seconds since the epoch, when the job execution was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
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
        /// The time, in seconds since the epoch, when the job execution was queued.
        /// </para>
        /// </summary>
        public DateTime? QueuedAt
        {
            get { return this._queuedAt; }
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
        /// The time, in seconds since the epoch, when the job execution started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
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
        /// The status of the job execution (IN_PROGRESS, QUEUED, FAILED, SUCCEEDED, TIMED_OUT,
        /// CANCELED, or REJECTED).
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
        public JobExecutionStatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ThingArn. 
        /// <para>
        /// The ARN of the thing on which the job execution is running.
        /// </para>
        /// </summary>
        public string ThingArn
        {
            get { return this._thingArn; }
            set { this._thingArn = value; }
        }

        // Check to see if ThingArn property is set
        internal bool IsSetThingArn()
        {
            return this._thingArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version of the job execution. Job execution versions are incremented each time
        /// they are updated by a device.
        /// </para>
        /// </summary>
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}