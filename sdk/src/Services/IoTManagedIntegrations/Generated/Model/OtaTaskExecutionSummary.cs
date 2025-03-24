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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one over-the-air (OTA) task execution summary.
    /// </summary>
    public partial class OtaTaskExecutionSummary
    {
        private long? _executionNumber;
        private DateTime? _lastUpdatedAt;
        private DateTime? _queuedAt;
        private int? _retryAttempt;
        private DateTime? _startedAt;
        private OtaTaskExecutionStatus _status;

        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// The execution number of the over-the-air (OTA) task execution summary.
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
        /// The timestamp value of when the over-the-air (OTA) task execution summary was last
        /// updated.
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
        /// The timestamp value of when the over-the-air (OTA) task execution summary is targeted
        /// to start.
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
        /// The number of retry attempts for starting the over-the-air (OTA) task execution summary
        /// after a failed attempt.
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
        /// The timestamp value of when the over-the-air (OTA) task execution summary started.
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
        /// The status of the over-the-air (OTA) task execution summary.
        /// </para>
        /// </summary>
        public OtaTaskExecutionStatus Status
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