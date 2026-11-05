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
    /// The resource representing a serverless cache.
    /// </summary>
    public partial class ServerlessCache
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the serverless cache.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property CacheUsageLimits. 
        /// <para>
        /// The cache usage limit for the serverless cache.
        /// </para>
        /// </summary>
        public CacheUsageLimits CacheUsageLimits { get; set; }

        /// <summary>
        /// Checks to see if the CacheUsageLimits property is set.
        /// </summary>
        internal bool IsSetCacheUsageLimits() => this.CacheUsageLimits != null;

        /// <summary>
        /// Gets and sets the property ConnectionType. 
        /// <para>
        /// The connection type for the serverless cache. Must be either <c>vpc</c> | <c>public</c>.
        /// If not specified, defaults to <c>vpc</c>.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// When the serverless cache was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DailySnapshotTime. 
        /// <para>
        /// The daily time that a cache snapshot will be created. Default is NULL, i.e. snapshots
        /// will not be created at a specific time on a daily basis. Available for Valkey, Redis
        /// OSS and Serverless Memcached only.
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
        /// A description of the serverless cache.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Endpoint.
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine the serverless cache is compatible with.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property FullEngineVersion. 
        /// <para>
        /// The name and version number of the engine the serverless cache is compatible with.
        /// </para>
        /// </summary>
        public string FullEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the FullEngineVersion property is set.
        /// </summary>
        internal bool IsSetFullEngineVersion() => this.FullEngineVersion != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Amazon Web Services Key Management Service (KMS) key that is used to
        /// encrypt data at rest in the serverless cache.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// The version number of the engine the serverless cache is compatible with.
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property Migration. 
        /// <para>
        /// Provides a summary of the migration status for the serverless cache.
        /// </para>
        /// </summary>
        public MigrationSummary Migration { get; set; }

        /// <summary>
        /// Checks to see if the Migration property is set.
        /// </summary>
        internal bool IsSetMigration() => this.Migration != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The type of IP address protocol used by the serverless cache. Must be either <c>ipv4</c>
        /// | <c>ipv6</c> | <c>dual_stack</c>. <c>ipv6</c> is only supported with IPv6-only subnets.
        /// If not specified, defaults to <c>ipv4</c>, unless all provided subnets are IPv6-only,
        /// in which case it defaults to <c>ipv6</c>.
        /// </para>
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property ReaderEndpoint.
        /// </summary>
        public Endpoint ReaderEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ReaderEndpoint property is set.
        /// </summary>
        internal bool IsSetReaderEndpoint() => this.ReaderEndpoint != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The IDs of the EC2 security groups associated with the serverless cache.
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
        /// The unique identifier of the serverless cache.
        /// </para>
        /// </summary>
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;

        /// <summary>
        /// Gets and sets the property SnapshotRetentionLimit. 
        /// <para>
        /// The number of days for which ElastiCache retains automatic snapshots before deleting
        /// them. Available for Valkey, Redis OSS and Serverless Memcached only. The maximum value
        /// allowed is 35 days.
        /// </para>
        /// </summary>
        public int? SnapshotRetentionLimit { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotRetentionLimit property is set.
        /// </summary>
        internal bool IsSetSnapshotRetentionLimit() => this.SnapshotRetentionLimit.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the serverless cache. The allowed values are CREATING, AVAILABLE,
        /// DELETING, CREATE-FAILED and MODIFYING.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageEncryptionType. 
        /// <para>
        /// Indicates the type of encryption for data stored at rest in the serverless cache.
        /// Serverless caches are always encrypted at rest. The value is <c>sse-elasticache</c>
        /// if an ElastiCache service-managed key is used, or <c>sse-kms</c> if a customer-managed
        /// KMS key is used.
        /// </para>
        /// </summary>
        public StorageEncryptionType StorageEncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the StorageEncryptionType property is set.
        /// </summary>
        internal bool IsSetStorageEncryptionType() => this.StorageEncryptionType != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// If no subnet IDs are given and your VPC is in us-west-1, then ElastiCache will select
        /// 2 default subnets across AZs in your VPC. For all other Regions, if no subnet IDs
        /// are given then ElastiCache will select 3 default subnets across AZs in your default
        /// VPC.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The identifier of the user group associated with the serverless cache. Available for
        /// Valkey and Redis OSS only. Default is NULL.
        /// </para>
        /// </summary>
        public string UserGroupId { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupId property is set.
        /// </summary>
        internal bool IsSetUserGroupId() => this.UserGroupId != null;
    }
}
