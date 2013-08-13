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
    /// <para> Contains a list of CacheSecurityGroups. </para>
    /// </summary>
    public class DescribeCacheSecurityGroupsResult
    {
        
        private string marker;
        private List<CacheSecurityGroup> cacheSecurityGroups = new List<CacheSecurityGroup>();

        /// <summary>
        /// The marker obtained from a previous operation response.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheSecurityGroupsResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }

        /// <summary>
        /// A list of <a>CacheSecurityGroup</a> instances.
        ///  
        /// </summary>
        public List<CacheSecurityGroup> CacheSecurityGroups
        {
            get { return this.cacheSecurityGroups; }
            set { this.cacheSecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the CacheSecurityGroups collection
        /// </summary>
        /// <param name="cacheSecurityGroups">The values to add to the CacheSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheSecurityGroupsResult WithCacheSecurityGroups(params CacheSecurityGroup[] cacheSecurityGroups)
        {
            foreach (CacheSecurityGroup element in cacheSecurityGroups)
            {
                this.cacheSecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheSecurityGroups collection
        /// </summary>
        /// <param name="cacheSecurityGroups">The values to add to the CacheSecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCacheSecurityGroupsResult WithCacheSecurityGroups(IEnumerable<CacheSecurityGroup> cacheSecurityGroups)
        {
            foreach (CacheSecurityGroup element in cacheSecurityGroups)
            {
                this.cacheSecurityGroups.Add(element);
            }

            return this;
        }

        // Check to see if CacheSecurityGroups property is set
        internal bool IsSetCacheSecurityGroups()
        {
            return this.cacheSecurityGroups.Count > 0;
        }
    }
}
