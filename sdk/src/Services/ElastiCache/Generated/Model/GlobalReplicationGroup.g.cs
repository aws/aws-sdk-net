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
    /// Consists of a primary cluster that accepts writes and an associated secondary cluster
    /// that resides in a different Amazon region. The secondary cluster accepts only reads.
    /// The primary cluster automatically replicates updates to the secondary cluster.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The <b>GlobalReplicationGroupIdSuffix</b> represents the name of the Global datastore,
    /// which is what you use to associate a secondary cluster.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GlobalReplicationGroup
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the global replication group.
        /// </para>
        /// </summary>
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property AtRestEncryptionEnabled. 
        /// <para>
        /// A flag that enables encryption at rest when set to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the value of <c>AtRestEncryptionEnabled</c> after the replication
        /// group is created. To enable encryption at rest on a replication group you must set
        /// <c>AtRestEncryptionEnabled</c> to <c>true</c> when you create the replication group.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using Redis OSS version <c>3.2.6</c>, <c>4.x</c> or later.
        /// </para>
        /// </summary>
        public bool? AtRestEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AtRestEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetAtRestEncryptionEnabled() => this.AtRestEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property AuthTokenEnabled. 
        /// <para>
        /// A flag that enables using an <c>AuthToken</c> (password) when issuing Valkey or Redis
        /// OSS commands.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? AuthTokenEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AuthTokenEnabled property is set.
        /// </summary>
        internal bool IsSetAuthTokenEnabled() => this.AuthTokenEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type of the Global datastore
        /// </para>
        /// </summary>
        public string CacheNodeType { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeType property is set.
        /// </summary>
        internal bool IsSetCacheNodeType() => this.CacheNodeType != null;

        /// <summary>
        /// Gets and sets the property ClusterEnabled. 
        /// <para>
        /// A flag that indicates whether the Global datastore is cluster enabled.
        /// </para>
        /// </summary>
        public bool? ClusterEnabled { get; set; }

        /// <summary>
        /// Checks to see if the ClusterEnabled property is set.
        /// </summary>
        internal bool IsSetClusterEnabled() => this.ClusterEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The ElastiCache engine. For Valkey or Redis OSS only.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The ElastiCache engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property GlobalNodeGroups. 
        /// <para>
        /// Indicates the slot configuration and global identifier for each slice group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalNodeGroup> GlobalNodeGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalNodeGroup>() : null;

        /// <summary>
        /// Checks to see if the GlobalNodeGroups property is set.
        /// </summary>
        internal bool IsSetGlobalNodeGroups() => this.GlobalNodeGroups != null && (this.GlobalNodeGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupDescription. 
        /// <para>
        /// The optional description of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the GlobalReplicationGroupDescription property is set.
        /// </summary>
        internal bool IsSetGlobalReplicationGroupDescription() => this.GlobalReplicationGroupDescription != null;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetGlobalReplicationGroupId() => this.GlobalReplicationGroupId != null;

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The replication groups that comprise the Global datastore.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<GlobalReplicationGroupMember> Members { get; set; } = AWSConfigs.InitializeCollections ? new List<GlobalReplicationGroupMember>() : null;

        /// <summary>
        /// Checks to see if the Members property is set.
        /// </summary>
        internal bool IsSetMembers() => this.Members != null && (this.Members.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Global datastore
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to true.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using Redis OSS version <c>3.2.6</c>, <c>4.x</c> or later.
        /// </para>
        /// </summary>
        public bool? TransitEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TransitEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetTransitEncryptionEnabled() => this.TransitEncryptionEnabled.HasValue;
    }
}
