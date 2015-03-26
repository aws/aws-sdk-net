/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation.
    /// The <i>DescribeSnapshots</i> action returns information about cache cluster snapshots.
    /// By default, <i>DescribeSnapshots</i> lists all of your snapshots; it can optionally
    /// describe a single snapshot, or just the snapshots associated with a particular cache
    /// cluster.
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonElastiCacheRequest
    {
        private string _cacheClusterId;
        private string _marker;
        private int? _maxRecords;
        private string _snapshotName;
        private string _snapshotSource;

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// A user-supplied cluster identifier. If this parameter is specified, only snapshots
        /// associated with that specific cache cluster will be described.
        /// </para>
        /// </summary>
        public string CacheClusterId
        {
            get { return this._cacheClusterId; }
            set { this._cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this._cacheClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this action. If this parameter is specified, the response includes only
        /// records beyond the marker, up to the value specified by <i>MaxRecords</i>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a marker is included in the response
        /// so that the remaining results can be retrieved.
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
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// A user-supplied name of the snapshot. If this parameter is specified, only this snapshot
        /// will be described.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotSource. 
        /// <para>
        /// If set to <code>system</code>, the output shows snapshots that were automatically
        /// created by ElastiCache. If set to <code>user</code> the output shows snapshots that
        /// were manually created. If omitted, the output shows both automatically and manually
        /// created snapshots.
        /// </para>
        /// </summary>
        public string SnapshotSource
        {
            get { return this._snapshotSource; }
            set { this._snapshotSource = value; }
        }

        // Check to see if SnapshotSource property is set
        internal bool IsSetSnapshotSource()
        {
            return this._snapshotSource != null;
        }

    }
}