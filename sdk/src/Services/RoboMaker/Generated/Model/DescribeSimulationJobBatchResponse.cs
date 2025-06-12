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
    /// This is the response object from the DescribeSimulationJobBatch operation.
    /// </summary>
    public partial class DescribeSimulationJobBatchResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private BatchPolicy _batchPolicy;
        private string _clientRequestToken;
        private DateTime? _createdAt;
        private List<SimulationJobSummary> _createdRequests = AWSConfigs.InitializeCollections ? new List<SimulationJobSummary>() : null;
        private List<FailedCreateSimulationJobRequest> _failedRequests = AWSConfigs.InitializeCollections ? new List<FailedCreateSimulationJobRequest>() : null;
        private SimulationJobBatchErrorCode _failureCode;
        private string _failureReason;
        private DateTime? _lastUpdatedAt;
        private List<SimulationJobRequest> _pendingRequests = AWSConfigs.InitializeCollections ? new List<SimulationJobRequest>() : null;
        private SimulationJobBatchStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property BatchPolicy. 
        /// <para>
        /// The batch policy.
        /// </para>
        /// </summary>
        public BatchPolicy BatchPolicy
        {
            get { return this._batchPolicy; }
            set { this._batchPolicy = value; }
        }

        // Check to see if BatchPolicy property is set
        internal bool IsSetBatchPolicy()
        {
            return this._batchPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
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
        /// Gets and sets the property CreatedRequests. 
        /// <para>
        /// A list of created simulation job summaries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<SimulationJobSummary> CreatedRequests
        {
            get { return this._createdRequests; }
            set { this._createdRequests = value; }
        }

        // Check to see if CreatedRequests property is set
        internal bool IsSetCreatedRequests()
        {
            return this._createdRequests != null && (this._createdRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailedRequests. 
        /// <para>
        /// A list of failed create simulation job requests. The request failed to be created
        /// into a simulation job. Failed requests do not have a simulation job ID. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedCreateSimulationJobRequest> FailedRequests
        {
            get { return this._failedRequests; }
            set { this._failedRequests = value; }
        }

        // Check to see if FailedRequests property is set
        internal bool IsSetFailedRequests()
        {
            return this._failedRequests != null && (this._failedRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code of the simulation job batch.
        /// </para>
        /// </summary>
        public SimulationJobBatchErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the simulation job batch failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
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
        /// Gets and sets the property PendingRequests. 
        /// <para>
        /// A list of pending simulation job requests. These requests have not yet been created
        /// into simulation jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<SimulationJobRequest> PendingRequests
        {
            get { return this._pendingRequests; }
            set { this._pendingRequests = value; }
        }

        // Check to see if PendingRequests property is set
        internal bool IsSetPendingRequests()
        {
            return this._pendingRequests != null && (this._pendingRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the batch.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the simulation job
        /// batch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}