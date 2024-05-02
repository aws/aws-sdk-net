/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Represents a cluster's status within a particular cache security group.
    /// </summary>
    public partial class CacheSecurityGroupMembership
    {
        private string _cacheSecurityGroupName;
        private string _status;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CacheSecurityGroupMembership() { }

        /// <summary>
        /// Gets and sets the property CacheSecurityGroupName. 
        /// <para>
        /// The name of the cache security group.
        /// </para>
        /// </summary>
        public string CacheSecurityGroupName
        {
            get { return this._cacheSecurityGroupName; }
            set { this._cacheSecurityGroupName = value; }
        }

        // Check to see if CacheSecurityGroupName property is set
        internal bool IsSetCacheSecurityGroupName()
        {
            return this._cacheSecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The membership status in the cache security group. The status changes when a cache
        /// security group is modified, or when the cache security groups assigned to a cluster
        /// are modified.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}