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
    /// This is the response object from the DescribeReplicationBackfillResults operation.
    /// </summary>
    public partial class DescribeReplicationBackfillResultsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination Region and registry to which the images are replicated.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>DescribeReplicationBackfillResults</c>
        /// request. When the results of a <c>DescribeReplicationBackfillResults</c> request exceed
        /// <c>maxResults</c>, this value can be used to retrieve the next page of results. This
        /// value is <c>null</c> when there are no more results to return.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId { get; set; }

        /// <summary>
        /// Checks to see if the RegistryId property is set.
        /// </summary>
        internal bool IsSetRegistryId() => this.RegistryId != null;

        /// <summary>
        /// Gets and sets the property ReplicationBackfillId. 
        /// <para>
        /// The ID of the replication backfill.
        /// </para>
        /// </summary>
        public string ReplicationBackfillId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationBackfillId property is set.
        /// </summary>
        internal bool IsSetReplicationBackfillId() => this.ReplicationBackfillId != null;

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// The per-image results for the replication backfill. Results are available only after
        /// the replication backfill reaches a terminal status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicationBackfillResult> Results { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicationBackfillResult>() : null;

        /// <summary>
        /// Checks to see if the Results property is set.
        /// </summary>
        internal bool IsSetResults() => this.Results != null && (this.Results.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time, in JavaScript date format, when the replication backfill was started.
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
        /// The current status of the replication backfill.
        /// </para>
        /// </summary>
        public ReplicationBackfillStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
