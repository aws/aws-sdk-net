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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one over-the-air (OTA) task execution summary.
    /// </summary>
    public partial class OtaTaskExecutionSummary
    {
        /// <summary>
        /// Gets and sets the property ExecutionNumber. 
        /// <para>
        /// The execution number of the over-the-air (OTA) task execution summary.
        /// </para>
        /// </summary>
        public long? ExecutionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionNumber property is set.
        /// </summary>
        internal bool IsSetExecutionNumber() => this.ExecutionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp value of when the over-the-air (OTA) task execution summary was last
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property QueuedAt. 
        /// <para>
        /// The timestamp value of when the over-the-air (OTA) task execution summary is targeted
        /// to start.
        /// </para>
        /// </summary>
        public DateTime? QueuedAt { get; set; }

        /// <summary>
        /// Checks to see if the QueuedAt property is set.
        /// </summary>
        internal bool IsSetQueuedAt() => this.QueuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RetryAttempt. 
        /// <para>
        /// The number of retry attempts for starting the over-the-air (OTA) task execution summary
        /// after a failed attempt.
        /// </para>
        /// </summary>
        public int? RetryAttempt { get; set; }

        /// <summary>
        /// Checks to see if the RetryAttempt property is set.
        /// </summary>
        internal bool IsSetRetryAttempt() => this.RetryAttempt.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp value of when the over-the-air (OTA) task execution summary started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the over-the-air (OTA) task execution summary.
        /// </para>
        /// </summary>
        public OtaTaskExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
