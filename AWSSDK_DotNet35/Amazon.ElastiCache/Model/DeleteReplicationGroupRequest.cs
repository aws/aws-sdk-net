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
    /// Container for the parameters to the DeleteReplicationGroup operation.
    /// <para>The <i>DeleteReplicationGroup</i> operation deletes an existing replication group. <i>DeleteReplicationGroup</i> deletes the primary
    /// cache cluster and all of the read replicas in the replication group. When you receive a successful response from this operation, Amazon
    /// ElastiCache immediately begins deleting the entire replication group; you cannot cancel or revert this operation.</para>
    /// </summary>
    public partial class DeleteReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string replicationGroupId;


        /// <summary>
        /// The identifier for the replication group to be deleted. This parameter is not case sensitive.
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

    }
}
    
