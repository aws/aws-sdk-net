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
    /// The resource representing a serverless cache.
    /// </summary>
    public partial class ServerlessCache
    {
        private string _arn;
        private CacheUsageLimits _cacheUsageLimits;
        private DateTime? _createTime;
        private string _dailySnapshotTime;
        private string _description;
        private Endpoint _endpoint;
        private string _engine;
        private string _fullEngineVersion;
        private string _kmsKeyId;
        private string _majorEngineVersion;
        private Endpoint _readerEndpoint;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _serverlessCacheName;
        private int? _snapshotRetentionLimit;
        private string _status;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _userGroupId;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the serverless cache.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CacheUsageLimits. 
        /// <para>
        /// The cache usage limit for the serverless cache.
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
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// When the serverless cache was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailySnapshotTime. 
        /// <para>
        /// The daily time that a cache snapshot will be created. Default is NULL, i.e. snapshots
        /// will not be created at a specific time on a daily basis. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
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
        /// A description of the serverless cache.
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
        /// Gets and sets the property Endpoint.
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine the serverless cache is compatible with.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FullEngineVersion. 
        /// <para>
        /// The name and version number of the engine the serverless cache is compatible with.
        /// </para>
        /// </summary>
        public string FullEngineVersion
        {
            get { return this._fullEngineVersion; }
            set { this._fullEngineVersion = value; }
        }

        // Check to see if FullEngineVersion property is set
        internal bool IsSetFullEngineVersion()
        {
            return this._fullEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service (KMS) key that is used to
        /// encrypt data at rest in the serverless cache.
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
        /// The version number of the engine the serverless cache is compatible with.
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
        /// Gets and sets the property ReaderEndpoint.
        /// </summary>
        public Endpoint ReaderEndpoint
        {
            get { return this._readerEndpoint; }
            set { this._readerEndpoint = value; }
        }

        // Check to see if ReaderEndpoint property is set
        internal bool IsSetReaderEndpoint()
        {
            return this._readerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the EC2 security groups associated with the serverless cache.
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
        /// The unique identifier of the serverless cache.
        /// </para>
        /// </summary>
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
        /// The current setting for the number of serverless cache snapshots the system will retain.
        /// Available for Valkey, Redis OSS and Serverless Memcached only.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the serverless cache. The allowed values are CREATING, AVAILABLE,
        /// DELETING, CREATE-FAILED and MODIFYING.
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

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// If no subnet IDs are given and your VPC is in us-west-1, then ElastiCache will select
        /// 2 default subnets across AZs in your VPC. For all other Regions, if no subnet IDs
        /// are given then ElastiCache will select 3 default subnets across AZs in your default
        /// VPC.
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
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The identifier of the user group associated with the serverless cache. Available for
        /// Valkey and Redis OSS only. Default is NULL.
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