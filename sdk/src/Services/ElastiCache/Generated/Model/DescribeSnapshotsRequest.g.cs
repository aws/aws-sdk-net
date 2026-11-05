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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation. Returns information
    /// about cluster or replication group snapshots. By default, <c>DescribeSnapshots</c>
    /// lists all of your snapshots; it can optionally describe a single snapshot, or just
    /// the snapshots associated with a particular cache cluster. <note> <para> This operation
    /// is valid for Valkey or Redis OSS only. </para> </note>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// A user-supplied cluster identifier. If this parameter is specified, only snapshots
        /// associated with that specific cluster are described.
        /// </para>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <c>MaxRecords</c> value, a marker is included in the response so that
        /// the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 50
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20; maximum 50.
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// A user-supplied replication group identifier. If this parameter is specified, only
        /// snapshots associated with that specific replication group are described.
        /// </para>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ShowNodeGroupConfig. 
        /// <para>
        /// A Boolean value which if true, the node group (shard) configuration is included in
        /// the snapshot description.
        /// </para>
        /// </summary>
        public bool? ShowNodeGroupConfig { get; set; }

        /// <summary>
        /// Checks to see if the ShowNodeGroupConfig property is set.
        /// </summary>
        internal bool IsSetShowNodeGroupConfig() => this.ShowNodeGroupConfig.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// A user-supplied name of the snapshot. If this parameter is specified, only this snapshot
        /// are described.
        /// </para>
        /// </summary>
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property SnapshotSource. 
        /// <para>
        /// If set to <c>system</c>, the output shows snapshots that were automatically created
        /// by ElastiCache. If set to <c>user</c> the output shows snapshots that were manually
        /// created. If omitted, the output shows both automatically and manually created snapshots.
        /// </para>
        /// </summary>
        public string SnapshotSource { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotSource property is set.
        /// </summary>
        internal bool IsSetSnapshotSource() => this.SnapshotSource != null;
    }
}
