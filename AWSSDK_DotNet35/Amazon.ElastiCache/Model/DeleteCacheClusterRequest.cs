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
    /// Container for the parameters to the DeleteCacheCluster operation.
    /// <para>The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster. <i>DeleteCacheCluster</i> deletes all
    /// associated cache nodes, node endpoints and the cache cluster itself. When you receive a successful response from this operation, Amazon
    /// ElastiCache immediately begins deleting the cache cluster; you cannot cancel or revert this operation.</para>
    /// </summary>
    public partial class DeleteCacheClusterRequest : AmazonElastiCacheRequest
    {
        private string cacheClusterId;
        private string finalSnapshotIdentifier;


        /// <summary>
        /// The cache cluster identifier for the cluster to be deleted. This parameter is not case sensitive.
        ///  
        /// </summary>
        public string CacheClusterId
        {
            get { return this.cacheClusterId; }
            set { this.cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this.cacheClusterId != null;
        }

        /// <summary>
        /// The name of a final cache cluster snapshot. ElastiCache creates the snapshot, and then deletes the cache cluster immediately afterward.
        ///  
        /// </summary>
        public string FinalSnapshotIdentifier
        {
            get { return this.finalSnapshotIdentifier; }
            set { this.finalSnapshotIdentifier = value; }
        }

        // Check to see if FinalSnapshotIdentifier property is set
        internal bool IsSetFinalSnapshotIdentifier()
        {
            return this.finalSnapshotIdentifier != null;
        }

    }
}
    
