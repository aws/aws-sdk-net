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
    /// Container for the parameters to the StartMigration operation.
    /// Starts the migration of data.
    /// </summary>
    public partial class StartMigrationRequest : AmazonElastiCacheRequest
    {
        private bool? _autoCutover;
        private bool? _clearTargetCacheData;
        private List<CustomerNodeEndpoint> _customerNodeEndpointList = AWSConfigs.InitializeCollections ? new List<CustomerNodeEndpoint>() : null;
        private string _replicationGroupId;
        private string _serverlessCacheName;

        /// <summary>
        /// Gets and sets the property AutoCutover. 
        /// <para>
        /// Specifies whether ElastiCache automatically attempts to complete the migration after
        /// data sync is established.
        /// </para>
        /// </summary>
        public bool? AutoCutover
        {
            get { return this._autoCutover; }
            set { this._autoCutover = value; }
        }

        // Check to see if AutoCutover property is set
        internal bool IsSetAutoCutover()
        {
            return this._autoCutover.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClearTargetCacheData. 
        /// <para>
        /// Specifies whether ElastiCache deletes existing data in the serverless cache before
        /// migration begins. After <c>StopMigration</c>, <c>StartMigration</c> requires this
        /// option to restart the data sync.
        /// </para>
        /// </summary>
        public bool? ClearTargetCacheData
        {
            get { return this._clearTargetCacheData; }
            set { this._clearTargetCacheData = value; }
        }

        // Check to see if ClearTargetCacheData property is set
        internal bool IsSetClearTargetCacheData()
        {
            return this._clearTargetCacheData.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerNodeEndpointList. 
        /// <para>
        /// The list of endpoints from which to migrate data. For Valkey or Redis OSS (cluster
        /// mode disabled), the list should have only one element. For serverless cache migrations,
        /// ElastiCache uses the endpoint that you provided in <c>PrepareMigration</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomerNodeEndpoint> CustomerNodeEndpointList
        {
            get { return this._customerNodeEndpointList; }
            set { this._customerNodeEndpointList = value; }
        }

        // Check to see if CustomerNodeEndpointList property is set
        internal bool IsSetCustomerNodeEndpointList()
        {
            return this._customerNodeEndpointList != null && (this._customerNodeEndpointList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The ID of the replication group to which data should be migrated.
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
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The name of the serverless cache to which data is being migrated.
        /// </para>
        /// </summary>
        public string ServerlessCacheName
        {
            get { return this._serverlessCacheName; }
            set { this._serverlessCacheName = value; }
        }

        // Check to see if ServerlessCacheName property is set
        internal bool IsSetServerlessCacheName()
        {
            return this._serverlessCacheName != null;
        }

    }
}