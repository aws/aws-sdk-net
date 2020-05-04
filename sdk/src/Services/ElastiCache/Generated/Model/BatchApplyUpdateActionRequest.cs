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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the BatchApplyUpdateAction operation.
    /// Apply the service update. For more information on service updates and applying them,
    /// see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/applying-updates.html">Applying
    /// Service Updates</a>.
    /// </summary>
    public partial class BatchApplyUpdateActionRequest : AmazonElastiCacheRequest
    {
        private List<string> _cacheClusterIds = new List<string>();
        private List<string> _replicationGroupIds = new List<string>();
        private string _serviceUpdateName;

        /// <summary>
        /// Gets and sets the property CacheClusterIds. 
        /// <para>
        /// The cache cluster IDs
        /// </para>
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
            return this._cacheClusterIds != null && this._cacheClusterIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupIds. 
        /// <para>
        /// The replication group IDs
        /// </para>
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
            return this._replicationGroupIds != null && this._replicationGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}