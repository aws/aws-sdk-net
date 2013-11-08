/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>The <i>CreateReplicationGroup</i> operation creates a replication group. A replication group is a collection of cache clusters, where
    /// one of the clusters is a read/write primary and the other clusters are read-only replicas. Writes to the primary are automatically
    /// propagated to the replicas.</para> <para>When you create a replication group, you must specify an existing cache cluster that is in the
    /// primary role. When the replication group has been successfully created, you can add one or more read replica replicas to it, up to a total
    /// of five read replicas.</para>
    /// </summary>
    public partial class CreateReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string replicationGroupId;
        private string primaryClusterId;
        private string replicationGroupDescription;


        /// <summary>
        /// The replication group identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li>Must contain from 1 to 20
        /// alphanumeric characters or hyphens.</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens.</li> </ul>
        ///  
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this.replicationGroupId; }
            set { this.replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this.replicationGroupId != null;
        }

        /// <summary>
        /// The identifier of the cache cluster that will serve as the primary for this replication group. This cache cluster must already exist and
        /// have a status of <i>available</i>.
        ///  
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this.primaryClusterId; }
            set { this.primaryClusterId = value; }
        }

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this.primaryClusterId != null;
        }

        /// <summary>
        /// A user-specified description for the replication group.
        ///  
        /// </summary>
        public string ReplicationGroupDescription
        {
            get { return this.replicationGroupDescription; }
            set { this.replicationGroupDescription = value; }
        }

        // Check to see if ReplicationGroupDescription property is set
        internal bool IsSetReplicationGroupDescription()
        {
            return this.replicationGroupDescription != null;
        }

    }
}
    
