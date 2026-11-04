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
    /// Container for the parameters to the DescribeUpdateActions operation. Returns details
    /// of the update actions
    /// </summary>
    public partial class DescribeUpdateActionsRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property CacheClusterIds. 
        /// <para>
        /// The cache cluster IDs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> CacheClusterIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CacheClusterIds property is set.
        /// </summary>
        internal bool IsSetCacheClusterIds() => this.CacheClusterIds != null && (this.CacheClusterIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The maximum number of records to include in the response
        /// </para>
        /// </summary>
        public int? MaxRecords { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecords property is set.
        /// </summary>
        internal bool IsSetMaxRecords() => this.MaxRecords.HasValue;

        /// <summary>
        /// Gets and sets the property ReplicationGroupIds. 
        /// <para>
        /// The replication group IDs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> ReplicationGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationGroupIds property is set.
        /// </summary>
        internal bool IsSetReplicationGroupIds() => this.ReplicationGroupIds != null && (this.ReplicationGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property ServiceUpdateStatus. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> ServiceUpdateStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ServiceUpdateStatus property is set.
        /// </summary>
        internal bool IsSetServiceUpdateStatus() => this.ServiceUpdateStatus != null && (this.ServiceUpdateStatus.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceUpdateTimeRange. 
        /// <para>
        /// The range of time specified to search for service updates that are in available status
        /// </para>
        /// </summary>
        public TimeRangeFilter ServiceUpdateTimeRange { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateTimeRange property is set.
        /// </summary>
        internal bool IsSetServiceUpdateTimeRange() => this.ServiceUpdateTimeRange != null;

        /// <summary>
        /// Gets and sets the property ShowNodeLevelUpdateStatus. 
        /// <para>
        /// Dictates whether to include node level update status in the response 
        /// </para>
        /// </summary>
        public bool? ShowNodeLevelUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the ShowNodeLevelUpdateStatus property is set.
        /// </summary>
        internal bool IsSetShowNodeLevelUpdateStatus() => this.ShowNodeLevelUpdateStatus.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateActionStatus. 
        /// <para>
        /// The status of the update action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 9)]
        public List<string> UpdateActionStatus { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UpdateActionStatus property is set.
        /// </summary>
        internal bool IsSetUpdateActionStatus() => this.UpdateActionStatus != null && (this.UpdateActionStatus.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
