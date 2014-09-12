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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
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
    /// Container for the parameters to the CreateReplicationGroup operation.
    /// The <i>CreateReplicationGroup</i> operation creates a replication group. A replication
    /// group is a collection of cache clusters, where one of the clusters is a read/write
    /// primary and the other clusters are read-only replicas. Writes to the primary are automatically
    /// propagated to the replicas.
    /// 
    ///  
    /// <para>
    /// When you create a replication group, you must specify an existing cache cluster that
    /// is in the primary role. When the replication group has been successfully created,
    /// you can add one or more read replica replicas to it, up to a total of five read replicas.
    /// </para>
    /// </summary>
    public partial class CreateReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _primaryClusterId;
        private string _replicationGroupDescription;
        private string _replicationGroupId;

        /// <summary>
        /// Gets and sets the property PrimaryClusterId. 
        /// <para>
        /// The identifier of the cache cluster that will serve as the primary for this replication
        /// group. This cache cluster must already exist and have a status of <i>available</i>.
        /// </para>
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this._primaryClusterId; }
            set { this._primaryClusterId = value; }
        }

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this._primaryClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupDescription. 
        /// <para>
        /// A user-specified description for the replication group.
        /// </para>
        /// </summary>
        public string ReplicationGroupDescription
        {
            get { return this._replicationGroupDescription; }
            set { this._replicationGroupDescription = value; }
        }

        // Check to see if ReplicationGroupDescription property is set
        internal bool IsSetReplicationGroupDescription()
        {
            return this._replicationGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The replication group identifier. This parameter is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 20 alphanumeric characters or hyphens.</li> <li>First
        /// character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens.</li> </ul>
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

    }
}