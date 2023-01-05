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
        private string _arn;
        private bool? _atRestEncryptionEnabled;
        private bool? _authTokenEnabled;
        private string _cacheNodeType;
        private bool? _clusterEnabled;
        private string _engine;
        private string _engineVersion;
        private List<GlobalNodeGroup> _globalNodeGroups = new List<GlobalNodeGroup>();
        private string _globalReplicationGroupDescription;
        private string _globalReplicationGroupId;
        private List<GlobalReplicationGroupMember> _members = new List<GlobalReplicationGroupMember>();
        private string _status;
        private bool? _transitEncryptionEnabled;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the global replication group.
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
        /// Gets and sets the property AtRestEncryptionEnabled. 
        /// <para>
        /// A flag that enables encryption at rest when set to <code>true</code>.
        /// </para>
        ///  
        /// <para>
        /// You cannot modify the value of <code>AtRestEncryptionEnabled</code> after the replication
        /// group is created. To enable encryption at rest on a replication group you must set
        /// <code>AtRestEncryptionEnabled</code> to <code>true</code> when you create the replication
        /// group. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using redis version <code>3.2.6</code>, <code>4.x</code> or later.
        /// </para>
        /// </summary>
        public bool AtRestEncryptionEnabled
        {
            get { return this._atRestEncryptionEnabled.GetValueOrDefault(); }
            set { this._atRestEncryptionEnabled = value; }
        }

        // Check to see if AtRestEncryptionEnabled property is set
        internal bool IsSetAtRestEncryptionEnabled()
        {
            return this._atRestEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthTokenEnabled. 
        /// <para>
        /// A flag that enables using an <code>AuthToken</code> (password) when issuing Redis
        /// commands.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool AuthTokenEnabled
        {
            get { return this._authTokenEnabled.GetValueOrDefault(); }
            set { this._authTokenEnabled = value; }
        }

        // Check to see if AuthTokenEnabled property is set
        internal bool IsSetAuthTokenEnabled()
        {
            return this._authTokenEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type of the Global datastore
        /// </para>
        /// </summary>
        public string CacheNodeType
        {
            get { return this._cacheNodeType; }
            set { this._cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this._cacheNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterEnabled. 
        /// <para>
        /// A flag that indicates whether the Global datastore is cluster enabled.
        /// </para>
        /// </summary>
        public bool ClusterEnabled
        {
            get { return this._clusterEnabled.GetValueOrDefault(); }
            set { this._clusterEnabled = value; }
        }

        // Check to see if ClusterEnabled property is set
        internal bool IsSetClusterEnabled()
        {
            return this._clusterEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The Elasticache engine. For Redis only.
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
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The Elasticache Redis engine version.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalNodeGroups. 
        /// <para>
        /// Indicates the slot configuration and global identifier for each slice group.
        /// </para>
        /// </summary>
        public List<GlobalNodeGroup> GlobalNodeGroups
        {
            get { return this._globalNodeGroups; }
            set { this._globalNodeGroups = value; }
        }

        // Check to see if GlobalNodeGroups property is set
        internal bool IsSetGlobalNodeGroups()
        {
            return this._globalNodeGroups != null && this._globalNodeGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupDescription. 
        /// <para>
        /// The optional description of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupDescription
        {
            get { return this._globalReplicationGroupDescription; }
            set { this._globalReplicationGroupDescription = value; }
        }

        // Check to see if GlobalReplicationGroupDescription property is set
        internal bool IsSetGlobalReplicationGroupDescription()
        {
            return this._globalReplicationGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global datastore
        /// </para>
        /// </summary>
        public string GlobalReplicationGroupId
        {
            get { return this._globalReplicationGroupId; }
            set { this._globalReplicationGroupId = value; }
        }

        // Check to see if GlobalReplicationGroupId property is set
        internal bool IsSetGlobalReplicationGroupId()
        {
            return this._globalReplicationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The replication groups that comprise the Global datastore.
        /// </para>
        /// </summary>
        public List<GlobalReplicationGroupMember> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && this._members.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Global datastore
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
        /// Gets and sets the property TransitEncryptionEnabled. 
        /// <para>
        /// A flag that enables in-transit encryption when set to true.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required:</b> Only available when creating a replication group in an Amazon VPC
        /// using redis version <code>3.2.6</code>, <code>4.x</code> or later.
        /// </para>
        /// </summary>
        public bool TransitEncryptionEnabled
        {
            get { return this._transitEncryptionEnabled.GetValueOrDefault(); }
            set { this._transitEncryptionEnabled = value; }
        }

        // Check to see if TransitEncryptionEnabled property is set
        internal bool IsSetTransitEncryptionEnabled()
        {
            return this._transitEncryptionEnabled.HasValue; 
        }

    }
}