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
    /// A group of settings that will be applied to the cache cluster in the future, or that
    /// are currently being applied.
    /// </summary>
    public partial class PendingModifiedValues
    {
        private List<string> _cacheNodeIdsToRemove = new List<string>();
        private string _engineVersion;
        private int? _numCacheNodes;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PendingModifiedValues() { }

        /// <summary>
        /// Gets and sets the property CacheNodeIdsToRemove. 
        /// <para>
        /// A list of cache node IDs that are being removed (or will be removed) from the cache
        /// cluster. A node ID is a numeric identifier (0001, 0002, etc.).
        /// </para>
        /// </summary>
        public List<string> CacheNodeIdsToRemove
        {
            get { return this._cacheNodeIdsToRemove; }
            set { this._cacheNodeIdsToRemove = value; }
        }

        // Check to see if CacheNodeIdsToRemove property is set
        internal bool IsSetCacheNodeIdsToRemove()
        {
            return this._cacheNodeIdsToRemove != null && this._cacheNodeIdsToRemove.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The new cache engine version that the cache cluster will run.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NumCacheNodes. 
        /// <para>
        /// The new number of cache nodes for the cache cluster.
        /// </para>
        /// </summary>
        public int NumCacheNodes
        {
            get { return this._numCacheNodes.GetValueOrDefault(); }
            set { this._numCacheNodes = value; }
        }

        // Check to see if NumCacheNodes property is set
        internal bool IsSetNumCacheNodes()
        {
            return this._numCacheNodes.HasValue; 
        }

    }
}