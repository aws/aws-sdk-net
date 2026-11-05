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
    /// The status of the service update for a specific replication group
    /// </summary>
    public partial class UpdateAction
    {
        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The ID of the cache cluster
        /// </para>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property CacheNodeUpdateStatus. 
        /// <para>
        /// The status of the service update on the cache node
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheNodeUpdateStatus> CacheNodeUpdateStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheNodeUpdateStatus>() : null;

        /// <summary>
        /// Checks to see if the CacheNodeUpdateStatus property is set.
        /// </summary>
        internal bool IsSetCacheNodeUpdateStatus() => this.CacheNodeUpdateStatus != null && (this.CacheNodeUpdateStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The Elasticache engine to which the update applies. Either Valkey, Redis OSS or Memcached.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EstimatedUpdateTime. 
        /// <para>
        /// The estimated length of time for the update to complete
        /// </para>
        /// </summary>
        public string EstimatedUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedUpdateTime property is set.
        /// </summary>
        internal bool IsSetEstimatedUpdateTime() => this.EstimatedUpdateTime != null;

        /// <summary>
        /// Gets and sets the property NodeGroupUpdateStatus. 
        /// <para>
        /// The status of the service update on the node group
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeGroupUpdateStatus> NodeGroupUpdateStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<NodeGroupUpdateStatus>() : null;

        /// <summary>
        /// Checks to see if the NodeGroupUpdateStatus property is set.
        /// </summary>
        internal bool IsSetNodeGroupUpdateStatus() => this.NodeGroupUpdateStatus != null && (this.NodeGroupUpdateStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodesUpdated. 
        /// <para>
        /// The progress of the service update on the replication group
        /// </para>
        /// </summary>
        public string NodesUpdated { get; set; }

        /// <summary>
        /// Checks to see if the NodesUpdated property is set.
        /// </summary>
        internal bool IsSetNodesUpdated() => this.NodesUpdated != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group
        /// </para>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateName property is set.
        /// </summary>
        internal bool IsSetServiceUpdateName() => this.ServiceUpdateName != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateRecommendedApplyByDate. 
        /// <para>
        /// The recommended date to apply the service update to ensure compliance. For information
        /// on compliance, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/elasticache-compliance.html#elasticache-compliance-self-service">Self-Service
        /// Security Updates for Compliance</a>.
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateRecommendedApplyByDate { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateRecommendedApplyByDate property is set.
        /// </summary>
        internal bool IsSetServiceUpdateRecommendedApplyByDate() => this.ServiceUpdateRecommendedApplyByDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceUpdateReleaseDate. 
        /// <para>
        /// The date the update is first available
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateReleaseDate property is set.
        /// </summary>
        internal bool IsSetServiceUpdateReleaseDate() => this.ServiceUpdateReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceUpdateSeverity. 
        /// <para>
        /// The severity of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateSeverity ServiceUpdateSeverity { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateSeverity property is set.
        /// </summary>
        internal bool IsSetServiceUpdateSeverity() => this.ServiceUpdateSeverity != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateStatus. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateStatus ServiceUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateStatus property is set.
        /// </summary>
        internal bool IsSetServiceUpdateStatus() => this.ServiceUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateType. 
        /// <para>
        /// Reflects the nature of the service update 
        /// </para>
        /// </summary>
        public ServiceUpdateType ServiceUpdateType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateType property is set.
        /// </summary>
        internal bool IsSetServiceUpdateType() => this.ServiceUpdateType != null;

        /// <summary>
        /// Gets and sets the property SlaMet. 
        /// <para>
        /// If yes, all nodes in the replication group have been updated by the recommended apply-by
        /// date. If no, at least one node in the replication group have not been updated by the
        /// recommended apply-by date. If N/A, the replication group was created after the recommended
        /// apply-by date.
        /// </para>
        /// </summary>
        public SlaMet SlaMet { get; set; }

        /// <summary>
        /// Checks to see if the SlaMet property is set.
        /// </summary>
        internal bool IsSetSlaMet() => this.SlaMet != null;

        /// <summary>
        /// Gets and sets the property UpdateActionAvailableDate. 
        /// <para>
        /// The date that the service update is available to a replication group
        /// </para>
        /// </summary>
        public DateTime? UpdateActionAvailableDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateActionAvailableDate property is set.
        /// </summary>
        internal bool IsSetUpdateActionAvailableDate() => this.UpdateActionAvailableDate.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateActionStatus. 
        /// <para>
        /// The status of the update action
        /// </para>
        /// </summary>
        public UpdateActionStatus UpdateActionStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateActionStatus property is set.
        /// </summary>
        internal bool IsSetUpdateActionStatus() => this.UpdateActionStatus != null;

        /// <summary>
        /// Gets and sets the property UpdateActionStatusModifiedDate. 
        /// <para>
        /// The date when the UpdateActionStatus was last modified
        /// </para>
        /// </summary>
        public DateTime? UpdateActionStatusModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the UpdateActionStatusModifiedDate property is set.
        /// </summary>
        internal bool IsSetUpdateActionStatusModifiedDate() => this.UpdateActionStatusModifiedDate.HasValue;
    }
}
