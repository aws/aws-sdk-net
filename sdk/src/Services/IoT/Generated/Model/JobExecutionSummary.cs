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
    /// The job execution summary.
    /// </summary>
    public partial class JobExecutionSummary
    {
        private long? _executionNumber;
        private DateTime? _lastUpdatedAt;
        private DateTime? _queuedAt;
        private int? _retryAttempt;
        private DateTime? _startedAt;
        private JobExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// A string (consisting of the digits "0" through "9") which identifies this particular
        /// job execution on this particular device. It can be used later in commands which return
        /// or update job execution information.
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
        /// Gets and sets the property RetryAttempt. 
        /// <para>
        /// The number that indicates how many retry attempts have been completed for this job
        /// on this device.
        /// </para>
        /// </summary>
        public int? RetryAttempt
        {
            get { return this._retryAttempt; }
            set { this._retryAttempt = value; }
        }

        // Check to see if RetryAttempt property is set
        internal bool IsSetRetryAttempt()
        {
            return this._retryAttempt.HasValue; 
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
        /// The status of the job execution.
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

    }
}