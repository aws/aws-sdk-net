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
    /// Container for the parameters to the CreateServerlessCache operation. Creates a serverless
    /// cache.
    /// </summary>
    public partial class CreateServerlessCacheRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property CacheUsageLimits. 
        /// <para>
        /// Sets the cache usage limits for storage and ElastiCache Processing Units for the cache.
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
        /// Use <c>vpc</c> to access the cache through a VPC endpoint, or <c>public</c> to access
        /// the cache over the internet. If not specified, defaults to <c>vpc</c>. This value
        /// cannot be changed after the serverless cache is created. Setting this to <c>public</c>
        /// requires Valkey 9 or above.
        /// </para>
        /// </summary>
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionType property is set.
        /// </summary>
        internal bool IsSetConnectionType() => this.ConnectionType != null;

        /// <summary>
        /// Gets and sets the property DailySnapshotTime. 
        /// <para>
        /// The daily time that snapshots will be created from the new serverless cache. By default
        /// this number is populated with 0, i.e. no snapshots will be created on an automatic
        /// daily basis. Available for Valkey, Redis OSS and Serverless Memcached only.
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
        /// User-provided description for the serverless cache. The default is NULL, i.e. if no
        /// description is provided then an empty string will be returned. The maximum length
        /// is 255 characters. 
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
        /// The name of the cache engine to be used for creating the serverless cache.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// ARN of the customer managed key for encrypting the data at rest. If no KMS key is
        /// provided, a default service key is used.
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
        /// The version of the cache engine that will be used to create the serverless cache.
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// The IP protocol version used by the serverless cache. Must be either <c>ipv4</c> |
        /// <c>ipv6</c> | <c>dual_stack</c>. <c>ipv6</c> is only supported with IPv6-only subnets.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of the one or more VPC security groups to be associated with the serverless
        /// cache. The security group will authorize traffic access for the VPC end-point (private-link).
        /// If no other information is given this will be the VPC’s Default Security Group that
        /// is associated with the cluster VPC end-point.
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
        /// User-provided identifier for the serverless cache. This parameter is stored as a lowercase
        /// string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;

        /// <summary>
        /// Gets and sets the property SnapshotArnsToRestore. 
        /// <para>
        /// The ARN(s) of the snapshot that the new serverless cache will be created from. Available
        /// for Valkey, Redis OSS and Serverless Memcached only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SnapshotArnsToRestore { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SnapshotArnsToRestore property is set.
        /// </summary>
        internal bool IsSetSnapshotArnsToRestore() => this.SnapshotArnsToRestore != null && (this.SnapshotArnsToRestore.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of the identifiers of the subnets where the VPC endpoint for the serverless
        /// cache will be deployed. All the subnetIds must belong to the same VPC.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags (key, value) pairs to be added to the serverless cache resource.
        /// Default is NULL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserGroupId. 
        /// <para>
        /// The identifier of the UserGroup to be associated with the serverless cache. Available
        /// for Valkey and Redis OSS only. Default is NULL.
        /// </para>
        /// </summary>
        public string UserGroupId { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupId property is set.
        /// </summary>
        internal bool IsSetUserGroupId() => this.UserGroupId != null;
    }
}
