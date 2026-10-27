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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing a summary of a replication backfill, including its status,
    /// destination, progress, and start and end times.
    /// </summary>
    public partial class ReplicationBackfillSummary
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination Region and registry to which the images are replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationDestination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the replication backfill ended.
        /// This value is <c>null</c> while the replication backfill is still in progress.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code for a replication backfill that has failed.
        /// </para>
        /// </summary>
        public string FailureCode { get; set; }

        /// <summary>
        /// Checks to see if the FailureCode property is set.
        /// </summary>
        internal bool IsSetFailureCode() => this.FailureCode != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the replication backfill, including the total, completed, and failed
        /// replication counts. This value is <c>null</c> until the replication backfill finishes
        /// preparing the set of images to replicate. It is therefore <c>null</c> while the replication
        /// backfill is <c>PREPARING</c>, and remains <c>null</c> if the replication backfill
        /// is stopped before preparation completes.
        /// </para>
        /// </summary>
        public ReplicationBackfillProgress Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property ReplicationBackfillId. 
        /// <para>
        /// The ID of the replication backfill.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationBackfillId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationBackfillId property is set.
        /// </summary>
        internal bool IsSetReplicationBackfillId() => this.ReplicationBackfillId != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the replication backfill was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the replication backfill.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationBackfillStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
