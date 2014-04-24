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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents an individual cache node in a snapshot of a cache cluster.</para>
    /// </summary>
    public partial class NodeSnapshot
    {
        
        private string cacheNodeId;
        private string cacheSize;
        private DateTime? cacheNodeCreateTime;
        private DateTime? snapshotCreateTime;


        /// <summary>
        /// The cache node identifier for the node in the source cache cluster.
        ///  
        /// </summary>
        public string CacheNodeId
        {
            get { return this.cacheNodeId; }
            set { this.cacheNodeId = value; }
        }

        // Check to see if CacheNodeId property is set
        internal bool IsSetCacheNodeId()
        {
            return this.cacheNodeId != null;
        }

        /// <summary>
        /// The size of the cache on the source cache node.
        ///  
        /// </summary>
        public string CacheSize
        {
            get { return this.cacheSize; }
            set { this.cacheSize = value; }
        }

        // Check to see if CacheSize property is set
        internal bool IsSetCacheSize()
        {
            return this.cacheSize != null;
        }

        /// <summary>
        /// The date and time when the cache node was created in the source cache cluster.
        ///  
        /// </summary>
        public DateTime CacheNodeCreateTime
        {
            get { return this.cacheNodeCreateTime ?? default(DateTime); }
            set { this.cacheNodeCreateTime = value; }
        }

        // Check to see if CacheNodeCreateTime property is set
        internal bool IsSetCacheNodeCreateTime()
        {
            return this.cacheNodeCreateTime.HasValue;
        }

        /// <summary>
        /// The date and time when the source node's metadata and cache data set was obtained for the snapshot.
        ///  
        /// </summary>
        public DateTime SnapshotCreateTime
        {
            get { return this.snapshotCreateTime ?? default(DateTime); }
            set { this.snapshotCreateTime = value; }
        }

        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this.snapshotCreateTime.HasValue;
        }
    }
}
