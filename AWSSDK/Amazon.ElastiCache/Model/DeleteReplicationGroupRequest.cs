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
    /// <para>The <i>DeleteReplicationGroup</i> operation deletes an existing replication group. By default, this operation deletes the entire
    /// replication group, including the primary cache cluster and all of the read replicas. You can optionally delete only the read replicas, while
    /// retaining the primary cache cluster.</para> <para>When you receive a successful response from this operation, Amazon ElastiCache immediately
    /// begins deleting the selected resources; you cannot cancel or revert this operation.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElastiCache.AmazonElastiCache.DeleteReplicationGroup"/>
    public class DeleteReplicationGroupRequest : AmazonWebServiceRequest
    {
        private string replicationGroupId;
        private bool? retainPrimaryCluster;

        /// <summary>
        /// The identifier for the replication group to be deleted. This parameter is not case sensitive.
        ///  
        /// </summary>
        public string ReplicationGroupId
        {
            get { return this.replicationGroupId; }
            set { this.replicationGroupId = value; }
        }

        /// <summary>
        /// Sets the ReplicationGroupId property
        /// </summary>
        /// <param name="replicationGroupId">The value to set for the ReplicationGroupId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteReplicationGroupRequest WithReplicationGroupId(string replicationGroupId)
        {
            this.replicationGroupId = replicationGroupId;
            return this;
        }
            

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this.replicationGroupId != null;
        }

        /// <summary>
        /// If set to <i>true</i>, all of the read replicas will be deleted, but the primary cache cluster will be retained.
        ///  
        /// </summary>
        public bool RetainPrimaryCluster
        {
            get { return this.retainPrimaryCluster ?? default(bool); }
            set { this.retainPrimaryCluster = value; }
        }

        /// <summary>
        /// Sets the RetainPrimaryCluster property
        /// </summary>
        /// <param name="retainPrimaryCluster">The value to set for the RetainPrimaryCluster property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DeleteReplicationGroupRequest WithRetainPrimaryCluster(bool retainPrimaryCluster)
        {
            this.retainPrimaryCluster = retainPrimaryCluster;
            return this;
        }
            

        // Check to see if RetainPrimaryCluster property is set
        internal bool IsSetRetainPrimaryCluster()
        {
            return this.retainPrimaryCluster.HasValue;
        }
    }
}
    
