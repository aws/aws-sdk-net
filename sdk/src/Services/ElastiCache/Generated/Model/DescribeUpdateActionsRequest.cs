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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
    /// Container for the parameters to the DescribeUpdateActions operation.
    /// Returns details of the update actions
    /// </summary>
    public partial class DescribeUpdateActionsRequest : AmazonElastiCacheRequest
    {
        private List<string> _cacheClusterIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _engine;
        private string _marker;
        private int? _maxRecords;
        private List<string> _replicationGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serviceUpdateName;
        private List<string> _serviceUpdateStatus = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TimeRangeFilter _serviceUpdateTimeRange;
        private bool? _showNodeLevelUpdateStatus;
        private List<string> _updateActionStatus = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CacheClusterIds. 
        /// <para>
        /// The cache cluster IDs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> CacheClusterIds
        {
            get { return this._cacheClusterIds; }
            set { this._cacheClusterIds = value; }
        }

        // Check to see if CacheClusterIds property is set
        internal bool IsSetCacheClusterIds()
        {
            return this._cacheClusterIds != null && (this._cacheClusterIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The Elasticache engine to which the update applies. Either Valkey, Redis OSS or Memcached.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <c>MaxRecords</c>.
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
        /// The maximum number of records to include in the response
        /// </para>
        /// </summary>
        public int? MaxRecords
        {
            get { return this._maxRecords; }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupIds. 
        /// <para>
        /// The replication group IDs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=20)]
        public List<string> ReplicationGroupIds
        {
            get { return this._replicationGroupIds; }
            set { this._replicationGroupIds = value; }
        }

        // Check to see if ReplicationGroupIds property is set
        internal bool IsSetReplicationGroupIds()
        {
            return this._replicationGroupIds != null && (this._replicationGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateName
        {
            get { return this._serviceUpdateName; }
            set { this._serviceUpdateName = value; }
        }

        // Check to see if ServiceUpdateName property is set
        internal bool IsSetServiceUpdateName()
        {
            return this._serviceUpdateName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateStatus. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<string> ServiceUpdateStatus
        {
            get { return this._serviceUpdateStatus; }
            set { this._serviceUpdateStatus = value; }
        }

        // Check to see if ServiceUpdateStatus property is set
        internal bool IsSetServiceUpdateStatus()
        {
            return this._serviceUpdateStatus != null && (this._serviceUpdateStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateTimeRange. 
        /// <para>
        /// The range of time specified to search for service updates that are in available status
        /// </para>
        /// </summary>
        public TimeRangeFilter ServiceUpdateTimeRange
        {
            get { return this._serviceUpdateTimeRange; }
            set { this._serviceUpdateTimeRange = value; }
        }

        // Check to see if ServiceUpdateTimeRange property is set
        internal bool IsSetServiceUpdateTimeRange()
        {
            return this._serviceUpdateTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property ShowNodeLevelUpdateStatus. 
        /// <para>
        /// Dictates whether to include node level update status in the response 
        /// </para>
        /// </summary>
        public bool? ShowNodeLevelUpdateStatus
        {
            get { return this._showNodeLevelUpdateStatus; }
            set { this._showNodeLevelUpdateStatus = value; }
        }

        // Check to see if ShowNodeLevelUpdateStatus property is set
        internal bool IsSetShowNodeLevelUpdateStatus()
        {
            return this._showNodeLevelUpdateStatus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateActionStatus. 
        /// <para>
        /// The status of the update action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=9)]
        public List<string> UpdateActionStatus
        {
            get { return this._updateActionStatus; }
            set { this._updateActionStatus = value; }
        }

        // Check to see if UpdateActionStatus property is set
        internal bool IsSetUpdateActionStatus()
        {
            return this._updateActionStatus != null && (this._updateActionStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}