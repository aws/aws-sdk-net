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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>A group of settings that will be applied to the cache cluster in the future, or that are currently being applied.</para>
    /// </summary>
    public class PendingModifiedValues
    {
        
        private int? numCacheNodes;
        private List<string> cacheNodeIdsToRemove = new List<string>();
        private string engineVersion;

        /// <summary>
        /// The new number of cache nodes for the cache cluster.
        ///  
        /// </summary>
        public int NumCacheNodes
        {
            get { return this.numCacheNodes ?? default(int); }
            set { this.numCacheNodes = value; }
        }

        /// <summary>
        /// Sets the NumCacheNodes property
        /// </summary>
        /// <param name="numCacheNodes">The value to set for the NumCacheNodes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PendingModifiedValues WithNumCacheNodes(int numCacheNodes)
        {
            this.numCacheNodes = numCacheNodes;
            return this;
        }
            

        // Check to see if NumCacheNodes property is set
        internal bool IsSetNumCacheNodes()
        {
            return this.numCacheNodes.HasValue;
        }

        /// <summary>
        /// A list of cache node IDs that are being removed (or will be removed) from the cache cluster. A node ID is a numeric identifier (0001, 0002,
        /// etc.).
        ///  
        /// </summary>
        public List<string> CacheNodeIdsToRemove
        {
            get { return this.cacheNodeIdsToRemove; }
            set { this.cacheNodeIdsToRemove = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodeIdsToRemove collection
        /// </summary>
        /// <param name="cacheNodeIdsToRemove">The values to add to the CacheNodeIdsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PendingModifiedValues WithCacheNodeIdsToRemove(params string[] cacheNodeIdsToRemove)
        {
            foreach (string element in cacheNodeIdsToRemove)
            {
                this.cacheNodeIdsToRemove.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodeIdsToRemove collection
        /// </summary>
        /// <param name="cacheNodeIdsToRemove">The values to add to the CacheNodeIdsToRemove collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PendingModifiedValues WithCacheNodeIdsToRemove(IEnumerable<string> cacheNodeIdsToRemove)
        {
            foreach (string element in cacheNodeIdsToRemove)
            {
                this.cacheNodeIdsToRemove.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodeIdsToRemove property is set
        internal bool IsSetCacheNodeIdsToRemove()
        {
            return this.cacheNodeIdsToRemove.Count > 0;
        }

        /// <summary>
        /// The new cache engine version that the cache cluster will run.
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PendingModifiedValues WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }
    }
}
