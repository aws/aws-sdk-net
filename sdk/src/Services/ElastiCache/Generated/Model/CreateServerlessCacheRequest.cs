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
    /// Container for the parameters to the CreateServerlessCache operation.
    /// Creates a serverless cache.
    /// </summary>
    public partial class CreateServerlessCacheRequest : AmazonElastiCacheRequest
    {
        private CacheUsageLimits _cacheUsageLimits;
        private string _dailySnapshotTime;
        private string _description;
        private string _engine;
        private string _kmsKeyId;
        private string _majorEngineVersion;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serverlessCacheName;
        private List<string> _snapshotArnsToRestore = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _snapshotRetentionLimit;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userGroupId;

        /// <summary>
        /// Gets and sets the property CacheUsageLimits. 
        /// <para>
        /// Sets the cache usage limits for storage and ElastiCache Processing Units for the cache.
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
        /// The daily time that snapshots will be created from the new serverless cache. By default
        /// this number is populated with 0, i.e. no snapshots will be created on an automatic
        /// daily basis. Available for Valkey, Redis OSS and Serverless Memcached only.
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
        /// User-provided description for the serverless cache. The default is NULL, i.e. if no
        /// description is provided then an empty string will be returned. The maximum length
        /// is 255 characters. 
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
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the cache engine to be used for creating the serverless cache.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// ARN of the customer managed key for encrypting the data at rest. If no KMS key is
        /// provided, a default service key is used.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// The version of the cache engine that will be used to create the serverless cache.
        /// </para>
        /// </summary>
        public string MajorEngineVersion
        {
            get { return this._majorEngineVersion; }
            set { this._majorEngineVersion = value; }
        }

        // Check to see if MajorEngineVersion property is set
        internal bool IsSetMajorEngineVersion()
        {
            return this._majorEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of the one or more VPC security groups to be associated with the serverless
        /// cache. The security group will authorize traffic access for the VPC end-point (private-link).
        /// If no other information is given this will be the VPC’s Default Security Group that
        /// is associated with the cluster VPC end-point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// User-provided identifier for the serverless cache. This parameter is stored as a lowercase
        /// string.
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
        /// Gets and sets the property SnapshotArnsToRestore. 
        /// <para>
        /// The ARN(s) of the snapshot that the new serverless cache will be created from. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnapshotArnsToRestore
        {
            get { return this._snapshotArnsToRestore; }
            set { this._snapshotArnsToRestore = value; }
        }

        // Check to see if SnapshotArnsToRestore property is set
        internal bool IsSetSnapshotArnsToRestore()
        {
            return this._snapshotArnsToRestore != null && (this._snapshotArnsToRestore.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of snapshots that will be retained for the serverless cache that is being
        /// created. As new snapshots beyond this limit are added, the oldest snapshots will be
        /// deleted on a rolling basis. Available for Valkey, Redis OSS and Serverless Memcached
        /// only.
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of the identifiers of the subnets where the VPC endpoint for the serverless
        /// cache will be deployed. All the subnetIds must belong to the same VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags (key, value) pairs to be added to the serverless cache resource.
        /// Default is NULL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The identifier of the UserGroup to be associated with the serverless cache. Available
        /// for Valkey and Redis OSS only. Default is NULL.
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