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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// This is the response object from the GetIndexRebuildStatus operation.
    /// </summary>
    public partial class GetIndexRebuildStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The concurrency in effect for this rebuild, as echoed from the original <c>StartIndexRebuild</c>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Checks to see if the Concurrency property is set.
        /// </summary>
        internal bool IsSetConcurrency() => this.Concurrency.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The ISO-8601 timestamp indicating when the index rebuild operation completed. This
        /// field is only present when the operation has completed (status is <c>COMPLETED</c>,
        /// <c>FAILED</c>, or <c>CANCELLED</c>).
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedEndTime. 
        /// <para>
        /// The estimated ISO-8601 timestamp for when the index rebuild operation will complete.
        /// The estimate may change as the operation progresses.
        /// </para>
        /// </summary>
        public DateTime? EstimatedEndTime { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedEndTime property is set.
        /// </summary>
        internal bool IsSetEstimatedEndTime() => this.EstimatedEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for the failure, if the rebuild operation failed. This field is only populated
        /// when the status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The percentage of the index rebuild operation that has been completed, expressed as
        /// an integer from 0 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercentage property is set.
        /// </summary>
        internal bool IsSetProgressPercentage() => this.ProgressPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the rebuild operation. See <c>Scope</c> for possible values: <c>ALL</c>,
        /// <c>QUADS</c>, or <c>DICTIONARIES</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The ISO-8601 timestamp indicating when the index rebuild operation started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the rebuild operation. See <c>RebuildStatus</c> for possible
        /// values: <c>PREPARING</c>, <c>REBUILDING</c>, <c>COMPLETED</c>, <c>FAILED</c>, <c>CANCELLING</c>
        /// or <c>CANCELLED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RebuildStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The <c>WriteBufferSize</c> in effect for this rebuild, as echoed from the original
        /// <c>StartIndexRebuild</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WriteBufferSize WriteBufferSize { get; set; }

        /// <summary>
        /// Checks to see if the WriteBufferSize property is set.
        /// </summary>
        internal bool IsSetWriteBufferSize() => this.WriteBufferSize != null;
    }
}
