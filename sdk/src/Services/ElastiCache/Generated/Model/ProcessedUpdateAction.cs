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
    /// Update action that has been processed for the corresponding apply/stop request
    /// </summary>
    public partial class ProcessedUpdateAction
    {
        private string _cacheClusterId;
        private string _replicationGroupId;
        private string _serviceUpdateName;
        private UpdateActionStatus _updateActionStatus;

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
        /// Gets and sets the property UpdateActionStatus. 
        /// <para>
        /// The status of the update action on the Valkey or Redis OSS cluster
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

    }
}