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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The job queue utilization at a specific point in time, including total capacity usage,
    /// and quota share or fairshare utilization breakdown depending on the job queue scheduling
    /// policy.
    /// </summary>
    public partial class QueueSnapshotUtilizationDetail
    {
        /// <summary>
        /// Gets and sets the property FairshareUtilization. 
        /// <para>
        /// The utilization information for a fairshare scheduling job queues, including active
        /// share count and top capacity utilization by share.
        /// </para>
        /// </summary>
        public FairshareUtilizationDetail FairshareUtilization { get; set; }

        /// <summary>
        /// Checks to see if the FairshareUtilization property is set.
        /// </summary>
        internal bool IsSetFairshareUtilization() => this.FairshareUtilization != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the queue utilization information was
        /// last updated.
        /// </para>
        /// </summary>
        public long? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property QuotaShareUtilization. 
        /// <para>
        /// The utilization information for a job queue with a quota share scheduling policy.
        /// </para>
        /// </summary>
        public QuotaShareUtilizationDetail QuotaShareUtilization { get; set; }

        /// <summary>
        /// Checks to see if the QuotaShareUtilization property is set.
        /// </summary>
        internal bool IsSetQuotaShareUtilization() => this.QuotaShareUtilization != null;

        /// <summary>
        /// Gets and sets the property TotalCapacityUsage. 
        /// <para>
        /// The total capacity usage for the entire job queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<QueueSnapshotCapacityUsage> TotalCapacityUsage { get; set; } = AWSConfigs.InitializeCollections ? new List<QueueSnapshotCapacityUsage>() : null;

        /// <summary>
        /// Checks to see if the TotalCapacityUsage property is set.
        /// </summary>
        internal bool IsSetTotalCapacityUsage() => this.TotalCapacityUsage != null && (this.TotalCapacityUsage.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
