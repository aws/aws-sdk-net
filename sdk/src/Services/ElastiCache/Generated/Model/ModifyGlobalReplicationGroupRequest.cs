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
    /// Container for the parameters to the ModifyGlobalReplicationGroup operation.
    /// Modifies the settings for a Global datastore.
    /// </summary>
    public partial class ModifyGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private bool? _automaticFailoverEnabled;
        private string _cacheNodeType;
        private string _cacheParameterGroupName;
        private string _engine;
        private string _engineVersion;
        private string _globalReplicationGroupDescription;
        private string _globalReplicationGroupId;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// This parameter causes the modifications in this request and any pending modifications
        /// to be applied, asynchronously and as soon as possible. Modifications to Global Replication
        /// Groups cannot be requested to be applied in PreferredMaintenceWindow. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? ApplyImmediately
        {
            get { return this._applyImmediately; }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutomaticFailoverEnabled. 
        /// <para>
        /// Determines whether a read replica is automatically promoted to read/write primary
        /// if the existing primary encounters a failure. 
        /// </para>
        /// </summary>
        public bool? AutomaticFailoverEnabled
        {
            get { return this._automaticFailoverEnabled; }
            set { this._automaticFailoverEnabled = value; }
        }

        // Check to see if AutomaticFailoverEnabled property is set
        internal bool IsSetAutomaticFailoverEnabled()
        {
            return this._automaticFailoverEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// A valid cache node type that you want to scale this Global datastore to.
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
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to use with the Global datastore. It must be
        /// compatible with the major engine version used by the Global datastore.
        /// </para>
        /// </summary>
        public string CacheParameterGroupName
        {
            get { return this._cacheParameterGroupName; }
            set { this._cacheParameterGroupName = value; }
        }

        // Check to see if CacheParameterGroupName property is set
        internal bool IsSetCacheParameterGroupName()
        {
            return this._cacheParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Modifies the engine listed in a global replication group message. The options are
        /// redis, memcached or valkey.
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
        /// The upgraded version of the cache engine to be run on the clusters in the Global datastore.
        /// 
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
        /// Gets and sets the property GlobalReplicationGroupDescription. 
        /// <para>
        /// A description of the Global datastore
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
        [AWSProperty(Required=true)]
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

    }
}