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
    /// <para>The status of the cache parameter group.</para>
    /// </summary>
    public class CacheParameterGroupStatus
    {
        
        private string cacheParameterGroupName;
        private string parameterApplyStatus;
        private List<string> cacheNodeIdsToReboot = new List<string>();

        /// <summary>
        /// The name of the cache parameter group.
        ///  
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this.cacheParameterGroupName; }
            set { this.cacheParameterGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheParameterGroupName property
        /// </summary>
        /// <param name="cacheParameterGroupName">The value to set for the CacheParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheParameterGroupStatus WithCacheParameterGroupName(string cacheParameterGroupName)
        {
            this.cacheParameterGroupName = cacheParameterGroupName;
            return this;
        }
            

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this.cacheParameterGroupName != null;
        }

        /// <summary>
        /// The status of parameter updates.
        ///  
        /// </summary>
        public string ParameterApplyStatus
        {
            get { return this.parameterApplyStatus; }
            set { this.parameterApplyStatus = value; }
        }

        /// <summary>
        /// Sets the ParameterApplyStatus property
        /// </summary>
        /// <param name="parameterApplyStatus">The value to set for the ParameterApplyStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheParameterGroupStatus WithParameterApplyStatus(string parameterApplyStatus)
        {
            this.parameterApplyStatus = parameterApplyStatus;
            return this;
        }
            

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this.parameterApplyStatus != null;
        }

        /// <summary>
        /// A list of the cache node IDs which need to be rebooted for parameter changes to be applied. A node ID is a numeric identifier (0001, 0002,
        /// etc.).
        ///  
        /// </summary>
        public List<string> CacheNodeIdsToReboot
        {
            get { return this.cacheNodeIdsToReboot; }
            set { this.cacheNodeIdsToReboot = value; }
        }
        /// <summary>
        /// Adds elements to the CacheNodeIdsToReboot collection
        /// </summary>
        /// <param name="cacheNodeIdsToReboot">The values to add to the CacheNodeIdsToReboot collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheParameterGroupStatus WithCacheNodeIdsToReboot(params string[] cacheNodeIdsToReboot)
        {
            foreach (string element in cacheNodeIdsToReboot)
            {
                this.cacheNodeIdsToReboot.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the CacheNodeIdsToReboot collection
        /// </summary>
        /// <param name="cacheNodeIdsToReboot">The values to add to the CacheNodeIdsToReboot collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheParameterGroupStatus WithCacheNodeIdsToReboot(IEnumerable<string> cacheNodeIdsToReboot)
        {
            foreach (string element in cacheNodeIdsToReboot)
            {
                this.cacheNodeIdsToReboot.Add(element);
            }

            return this;
        }

        // Check to see if CacheNodeIdsToReboot property is set
        internal bool IsSetCacheNodeIdsToReboot()
        {
            return this.cacheNodeIdsToReboot.Count > 0;
        }
    }
}
