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
    /// The status of the service update for a specific replication group
    /// </summary>
    public partial class UpdateAction
    {
        private string _cacheClusterId;
        private List<CacheNodeUpdateStatus> _cacheNodeUpdateStatus = AWSConfigs.InitializeCollections ? new List<CacheNodeUpdateStatus>() : null;
        private string _engine;
        private string _estimatedUpdateTime;
        private List<NodeGroupUpdateStatus> _nodeGroupUpdateStatus = AWSConfigs.InitializeCollections ? new List<NodeGroupUpdateStatus>() : null;
        private string _nodesUpdated;
        private string _replicationGroupId;
        private string _serviceUpdateName;
        private DateTime? _serviceUpdateRecommendedApplyByDate;
        private DateTime? _serviceUpdateReleaseDate;
        private ServiceUpdateSeverity _serviceUpdateSeverity;
        private ServiceUpdateStatus _serviceUpdateStatus;
        private ServiceUpdateType _serviceUpdateType;
        private SlaMet _slaMet;
        private DateTime? _updateActionAvailableDate;
        private UpdateActionStatus _updateActionStatus;
        private DateTime? _updateActionStatusModifiedDate;

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The ID of the cache cluster
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
        /// Gets and sets the property CacheNodeUpdateStatus. 
        /// <para>
        /// The status of the service update on the cache node
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheNodeUpdateStatus> CacheNodeUpdateStatus
        {
            get { return this._cacheNodeUpdateStatus; }
            set { this._cacheNodeUpdateStatus = value; }
        }

        // Check to see if CacheNodeUpdateStatus property is set
        internal bool IsSetCacheNodeUpdateStatus()
        {
            return this._cacheNodeUpdateStatus != null && (this._cacheNodeUpdateStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property EstimatedUpdateTime. 
        /// <para>
        /// The estimated length of time for the update to complete
        /// </para>
        /// </summary>
        public string EstimatedUpdateTime
        {
            get { return this._estimatedUpdateTime; }
            set { this._estimatedUpdateTime = value; }
        }

        // Check to see if EstimatedUpdateTime property is set
        internal bool IsSetEstimatedUpdateTime()
        {
            return this._estimatedUpdateTime != null;
        }

        /// <summary>
        /// Gets and sets the property NodeGroupUpdateStatus. 
        /// <para>
        /// The status of the service update on the node group
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeGroupUpdateStatus> NodeGroupUpdateStatus
        {
            get { return this._nodeGroupUpdateStatus; }
            set { this._nodeGroupUpdateStatus = value; }
        }

        // Check to see if NodeGroupUpdateStatus property is set
        internal bool IsSetNodeGroupUpdateStatus()
        {
            return this._nodeGroupUpdateStatus != null && (this._nodeGroupUpdateStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NodesUpdated. 
        /// <para>
        /// The progress of the service update on the replication group
        /// </para>
        /// </summary>
        public string NodesUpdated
        {
            get { return this._nodesUpdated; }
            set { this._nodesUpdated = value; }
        }

        // Check to see if NodesUpdated property is set
        internal bool IsSetNodesUpdated()
        {
            return this._nodesUpdated != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group
        /// </para>
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this._replicationGroupId; }
            set { this._replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this._replicationGroupId != null;
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
        /// Gets and sets the property ServiceUpdateRecommendedApplyByDate. 
        /// <para>
        /// The recommended date to apply the service update to ensure compliance. For information
        /// on compliance, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/elasticache-compliance.html#elasticache-compliance-self-service">Self-Service
        /// Security Updates for Compliance</a>.
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateRecommendedApplyByDate
        {
            get { return this._serviceUpdateRecommendedApplyByDate; }
            set { this._serviceUpdateRecommendedApplyByDate = value; }
        }

        // Check to see if ServiceUpdateRecommendedApplyByDate property is set
        internal bool IsSetServiceUpdateRecommendedApplyByDate()
        {
            return this._serviceUpdateRecommendedApplyByDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateReleaseDate. 
        /// <para>
        /// The date the update is first available
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateReleaseDate
        {
            get { return this._serviceUpdateReleaseDate; }
            set { this._serviceUpdateReleaseDate = value; }
        }

        // Check to see if ServiceUpdateReleaseDate property is set
        internal bool IsSetServiceUpdateReleaseDate()
        {
            return this._serviceUpdateReleaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateSeverity. 
        /// <para>
        /// The severity of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateSeverity ServiceUpdateSeverity
        {
            get { return this._serviceUpdateSeverity; }
            set { this._serviceUpdateSeverity = value; }
        }

        // Check to see if ServiceUpdateSeverity property is set
        internal bool IsSetServiceUpdateSeverity()
        {
            return this._serviceUpdateSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateStatus. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateStatus ServiceUpdateStatus
        {
            get { return this._serviceUpdateStatus; }
            set { this._serviceUpdateStatus = value; }
        }

        // Check to see if ServiceUpdateStatus property is set
        internal bool IsSetServiceUpdateStatus()
        {
            return this._serviceUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateType. 
        /// <para>
        /// Reflects the nature of the service update 
        /// </para>
        /// </summary>
        public ServiceUpdateType ServiceUpdateType
        {
            get { return this._serviceUpdateType; }
            set { this._serviceUpdateType = value; }
        }

        // Check to see if ServiceUpdateType property is set
        internal bool IsSetServiceUpdateType()
        {
            return this._serviceUpdateType != null;
        }

        /// <summary>
        /// Gets and sets the property SlaMet. 
        /// <para>
        /// If yes, all nodes in the replication group have been updated by the recommended apply-by
        /// date. If no, at least one node in the replication group have not been updated by the
        /// recommended apply-by date. If N/A, the replication group was created after the recommended
        /// apply-by date.
        /// </para>
        /// </summary>
        public SlaMet SlaMet
        {
            get { return this._slaMet; }
            set { this._slaMet = value; }
        }

        // Check to see if SlaMet property is set
        internal bool IsSetSlaMet()
        {
            return this._slaMet != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateActionAvailableDate. 
        /// <para>
        /// The date that the service update is available to a replication group
        /// </para>
        /// </summary>
        public DateTime? UpdateActionAvailableDate
        {
            get { return this._updateActionAvailableDate; }
            set { this._updateActionAvailableDate = value; }
        }

        // Check to see if UpdateActionAvailableDate property is set
        internal bool IsSetUpdateActionAvailableDate()
        {
            return this._updateActionAvailableDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdateActionStatus. 
        /// <para>
        /// The status of the update action
        /// </para>
        /// </summary>
        public UpdateActionStatus UpdateActionStatus
        {
            get { return this._updateActionStatus; }
            set { this._updateActionStatus = value; }
        }

        // Check to see if UpdateActionStatus property is set
        internal bool IsSetUpdateActionStatus()
        {
            return this._updateActionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateActionStatusModifiedDate. 
        /// <para>
        /// The date when the UpdateActionStatus was last modified
        /// </para>
        /// </summary>
        public DateTime? UpdateActionStatusModifiedDate
        {
            get { return this._updateActionStatusModifiedDate; }
            set { this._updateActionStatusModifiedDate = value; }
        }

        // Check to see if UpdateActionStatusModifiedDate property is set
        internal bool IsSetUpdateActionStatusModifiedDate()
        {
            return this._updateActionStatusModifiedDate.HasValue; 
        }

    }
}