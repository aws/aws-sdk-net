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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
    /// The job queue utilization at a specific point in time, including total capacity usage
    /// and fairshare utilization breakdown.
    /// </summary>
    public partial class QueueSnapshotUtilizationDetail
    {
        private FairshareUtilizationDetail _fairshareUtilization;
        private long? _lastUpdatedAt;
        private List<QueueSnapshotCapacityUsage> _totalCapacityUsage = AWSConfigs.InitializeCollections ? new List<QueueSnapshotCapacityUsage>() : null;

        /// <summary>
        /// Gets and sets the property FairshareUtilization. 
        /// <para>
        /// The utilization information for a fairshare scheduling job queues, including active
        /// share count and top capacity utilization by share.
        /// </para>
        /// </summary>
        public FairshareUtilizationDetail FairshareUtilization
        {
            get { return this._fairshareUtilization; }
            set { this._fairshareUtilization = value; }
        }

        // Check to see if FairshareUtilization property is set
        internal bool IsSetFairshareUtilization()
        {
            return this._fairshareUtilization != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the queue utilization information was
        /// last updated.
        /// </para>
        /// </summary>
        public long LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCapacityUsage. 
        /// <para>
        /// The total capacity usage for the entire job queue, for both first-in, first-out (FIFO)
        /// and fairshare scheduling job queue.
        /// </para>
        /// </summary>
        public List<QueueSnapshotCapacityUsage> TotalCapacityUsage
        {
            get { return this._totalCapacityUsage; }
            set { this._totalCapacityUsage = value; }
        }

        // Check to see if TotalCapacityUsage property is set
        internal bool IsSetTotalCapacityUsage()
        {
            return this._totalCapacityUsage != null && (this._totalCapacityUsage.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}