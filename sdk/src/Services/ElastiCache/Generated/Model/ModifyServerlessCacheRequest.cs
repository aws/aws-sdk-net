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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyServerlessCache operation.
    /// This API modifies the attributes of a serverless cache.
    /// </summary>
    public partial class ModifyServerlessCacheRequest : AmazonElastiCacheRequest
    {
        private CacheUsageLimits _cacheUsageLimits;
        private string _dailySnapshotTime;
        private string _description;
        private bool? _removeUserGroup;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serverlessCacheName;
        private int? _snapshotRetentionLimit;
        private string _userGroupId;

        /// <summary>
        /// Gets and sets the property CacheUsageLimits. 
        /// <para>
        /// Modify the cache usage limit for the serverless cache.
        /// </para>
        /// </summary>
        public CacheUsageLimits CacheUsageLimits
        {
            get { return this._cacheUsageLimits; }
            set { this._cacheUsageLimits = value; }
        }

        // Check to see if CacheUsageLimits property is set
        internal bool IsSetCacheUsageLimits()
        {
            return this._cacheUsageLimits != null;
        }

        /// <summary>
        /// Gets and sets the property DailySnapshotTime. 
        /// <para>
        /// The daily time during which Elasticache begins taking a daily snapshot of the serverless
        /// cache. Available for Redis only. The default is NULL, i.e. the existing snapshot time
        /// configured for the cluster is not removed.
        /// </para>
        /// </summary>
        public string DailySnapshotTime
        {
            get { return this._dailySnapshotTime; }
            set { this._dailySnapshotTime = value; }
        }

        // Check to see if DailySnapshotTime property is set
        internal bool IsSetDailySnapshotTime()
        {
            return this._dailySnapshotTime != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User provided description for the serverless cache. Default = NULL, i.e. the existing
        /// description is not removed/modified. The description has a maximum length of 255 characters.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveUserGroup. 
        /// <para>
        /// The identifier of the UserGroup to be removed from association with the Redis serverless
        /// cache. Available for Redis only. Default is NULL.
        /// </para>
        /// </summary>
        public bool? RemoveUserGroup
        {
            get { return this._removeUserGroup; }
            set { this._removeUserGroup = value; }
        }

        // Check to see if RemoveUserGroup property is set
        internal bool IsSetRemoveUserGroup()
        {
            return this._removeUserGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The new list of VPC security groups to be associated with the serverless cache. Populating
        /// this list means the current VPC security groups will be removed. This security group
        /// is used to authorize traffic access for the VPC end-point (private-link). Default
        /// = NULL - the existing list of VPC security groups is not removed.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// User-provided identifier for the serverless cache to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServerlessCacheName
        {
            get { return this._serverlessCacheName; }
            set { this._serverlessCacheName = value; }
        }

        // Check to see if ServerlessCacheName property is set
        internal bool IsSetServerlessCacheName()
        {
            return this._serverlessCacheName != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which Elasticache retains automatic snapshots before deleting
        /// them. Available for Redis only. Default = NULL, i.e. the existing snapshot-retention-limit
        /// will not be removed or modified. The maximum value allowed is 35 days.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionLimit
        {
            get { return this._snapshotRetentionLimit; }
            set { this._snapshotRetentionLimit = value; }
        }

        // Check to see if SnapshotRetentionLimit property is set
        internal bool IsSetSnapshotRetentionLimit()
        {
            return this._snapshotRetentionLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The identifier of the UserGroup to be associated with the serverless cache. Available
        /// for Redis only. Default is NULL - the existing UserGroup is not removed.
        /// </para>
        /// </summary>
        public string UserGroupId
        {
            get { return this._userGroupId; }
            set { this._userGroupId = value; }
        }

        // Check to see if UserGroupId property is set
        internal bool IsSetUserGroupId()
        {
            return this._userGroupId != null;
        }

    }
}