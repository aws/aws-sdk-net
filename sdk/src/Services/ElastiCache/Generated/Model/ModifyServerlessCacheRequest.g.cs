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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ModifyServerlessCache operation. This API modifies
    /// the attributes of a serverless cache.
    /// </summary>
    public partial class ModifyServerlessCacheRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property CacheUsageLimits. 
        /// <para>
        /// Modify the cache usage limit for the serverless cache.
        /// </para>
        /// </summary>
        public CacheUsageLimits CacheUsageLimits { get; set; }

        /// <summary>
        /// Checks to see if the CacheUsageLimits property is set.
        /// </summary>
        internal bool IsSetCacheUsageLimits() => this.CacheUsageLimits != null;

        /// <summary>
        /// Gets and sets the property DailySnapshotTime. 
        /// <para>
        /// The daily time during which Elasticache begins taking a daily snapshot of the serverless
        /// cache. Available for Valkey, Redis OSS and Serverless Memcached only. The default
        /// is NULL, i.e. the existing snapshot time configured for the cluster is not removed.
        /// </para>
        /// </summary>
        public string DailySnapshotTime { get; set; }

        /// <summary>
        /// Checks to see if the DailySnapshotTime property is set.
        /// </summary>
        internal bool IsSetDailySnapshotTime() => this.DailySnapshotTime != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// User provided description for the serverless cache. Default = NULL, i.e. the existing
        /// description is not removed/modified. The description has a maximum length of 255 characters.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Modifies the engine listed in a serverless cache request. The options are valkey,
        /// memcached or redis.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// Modifies the engine vesion listed in a serverless cache request. 
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property RemoveUserGroup. 
        /// <para>
        /// The identifier of the UserGroup to be removed from association with the Valkey and
        /// Redis OSS serverless cache. Available for Valkey and Redis OSS only. Default is NULL.
        /// </para>
        /// </summary>
        public bool? RemoveUserGroup { get; set; }

        /// <summary>
        /// Checks to see if the RemoveUserGroup property is set.
        /// </summary>
        internal bool IsSetRemoveUserGroup() => this.RemoveUserGroup.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The new list of VPC security groups to be associated with the serverless cache. Populating
        /// this list means the current VPC security groups will be removed. This security group
        /// is used to authorize traffic access for the VPC end-point (private-link). Default
        /// = NULL - the existing list of VPC security groups is not removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// User-provided identifier for the serverless cache to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which Elasticache retains automatic snapshots before deleting
        /// them. Available for Valkey, Redis OSS and Serverless Memcached only. Default = NULL,
        /// i.e. the existing snapshot-retention-limit will not be removed or modified. The maximum
        /// value allowed is 35 days.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionLimit { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionLimit property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionLimit() => this.SnapshotRetentionLimit.HasValue;

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The identifier of the UserGroup to be associated with the serverless cache. Available
        /// for Valkey and Redis OSS only. Default is NULL - the existing UserGroup is not removed.
        /// </para>
        /// </summary>
        public string UserGroupId { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupId property is set.
        /// </summary>
        internal bool IsSetUserGroupId() => this.UserGroupId != null;
    }
}
