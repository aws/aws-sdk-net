/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Links a CacheCluster to one or more CacheSecurityGroups. </para>
    /// </summary>
    public class CacheSecurityGroupMembership  
    {
        
        private string cacheSecurityGroupName;
        private string status;

        /// <summary>
        /// The name of the Cache Security Group.
        ///  
        /// </summary>
        public string CacheSecurityGroupName
        {
            get { return this.cacheSecurityGroupName; }
            set { this.cacheSecurityGroupName = value; }
        }

        /// <summary>
        /// Sets the CacheSecurityGroupName property
        /// </summary>
        /// <param name="cacheSecurityGroupName">The value to set for the CacheSecurityGroupName property </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroupMembership WithCacheSecurityGroupName(string cacheSecurityGroupName)
        {
            this.cacheSecurityGroupName = cacheSecurityGroupName;
            return this;
        }
            

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this.cacheSecurityGroupName != null;       
        }

        /// <summary>
        /// The status of the CacheSecurityGroupMembership, the status changes either when a CacheSecurityGroup is modified, or when the
        /// CacheSecurityGroups assigned to a Cache Cluster are modified.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public CacheSecurityGroupMembership WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;       
        }
    }
}
