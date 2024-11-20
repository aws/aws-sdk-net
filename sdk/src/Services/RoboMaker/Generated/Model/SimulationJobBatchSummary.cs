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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
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
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Information about a simulation job batch.
    /// </summary>
    public partial class SimulationJobBatchSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private int? _createdRequestCount;
        private int? _failedRequestCount;
        private DateTime? _lastUpdatedAt;
        private int? _pendingRequestCount;
        private SimulationJobBatchStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the batch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation job batch was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedRequestCount. 
        /// <para>
        /// The number of created simulation job requests.
        /// </para>
        /// </summary>
        public int? CreatedRequestCount
        {
            get { return this._createdRequestCount; }
            set { this._createdRequestCount = value; }
        }

        // Check to see if CreatedRequestCount property is set
        internal bool IsSetCreatedRequestCount()
        {
            return this._createdRequestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedRequestCount. 
        /// <para>
        /// The number of failed simulation job requests.
        /// </para>
        /// </summary>
        public int? FailedRequestCount
        {
            get { return this._failedRequestCount; }
            set { this._failedRequestCount = value; }
        }

        // Check to see if FailedRequestCount property is set
        internal bool IsSetFailedRequestCount()
        {
            return this._failedRequestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation job batch was last
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
        /// Gets and sets the property PendingRequestCount. 
        /// <para>
        /// The number of pending simulation job requests.
        /// </para>
        /// </summary>
        public int? PendingRequestCount
        {
            get { return this._pendingRequestCount; }
            set { this._pendingRequestCount = value; }
        }

        // Check to see if PendingRequestCount property is set
        internal bool IsSetPendingRequestCount()
        {
            return this._pendingRequestCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the simulation job batch.
        /// </para>
        ///  <dl> <dt>Pending</dt> <dd> 
        /// <para>
        /// The simulation job batch request is pending.
        /// </para>
        ///  </dd> <dt>InProgress</dt> <dd> 
        /// <para>
        /// The simulation job batch is in progress. 
        /// </para>
        ///  </dd> <dt>Failed</dt> <dd> 
        /// <para>
        /// The simulation job batch failed. One or more simulation job requests could not be
        /// completed due to an internal failure (like <c>InternalServiceError</c>). See <c>failureCode</c>
        /// and <c>failureReason</c> for more information.
        /// </para>
        ///  </dd> <dt>Completed</dt> <dd> 
        /// <para>
        /// The simulation batch job completed. A batch is complete when (1) there are no pending
        /// simulation job requests in the batch and none of the failed simulation job requests
        /// are due to <c>InternalServiceError</c> and (2) when all created simulation jobs have
        /// reached a terminal state (for example, <c>Completed</c> or <c>Failed</c>). 
        /// </para>
        ///  </dd> <dt>Canceled</dt> <dd> 
        /// <para>
        /// The simulation batch job was cancelled.
        /// </para>
        ///  </dd> <dt>Canceling</dt> <dd> 
        /// <para>
        /// The simulation batch job is being cancelled.
        /// </para>
        ///  </dd> <dt>Completing</dt> <dd> 
        /// <para>
        /// The simulation batch job is completing.
        /// </para>
        ///  </dd> <dt>TimingOut</dt> <dd> 
        /// <para>
        /// The simulation job batch is timing out.
        /// </para>
        ///  
        /// <para>
        /// If a batch timing out, and there are pending requests that were failing due to an
        /// internal failure (like <c>InternalServiceError</c>), the batch status will be <c>Failed</c>.
        /// If there are no such failing request, the batch status will be <c>TimedOut</c>. 
        /// </para>
        ///  </dd> <dt>TimedOut</dt> <dd> 
        /// <para>
        /// The simulation batch job timed out.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public SimulationJobBatchStatus Status
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