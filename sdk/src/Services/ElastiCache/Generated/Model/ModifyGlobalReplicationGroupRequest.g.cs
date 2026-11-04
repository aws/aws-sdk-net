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
    /// Container for the parameters to the ModifyGlobalReplicationGroup operation. Modifies
    /// the settings for a Global datastore.
    /// </summary>
    public partial class ModifyGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// This parameter causes the modifications in this request and any pending modifications
        /// to be applied, asynchronously and as soon as possible. Modifications to Global Replication
        /// Groups cannot be requested to be applied in PreferredMaintenceWindow. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? ApplyImmediately { get; set; }

        /// <summary>
        /// Checks to see if the ApplyImmediately property is set.
        /// </summary>
        internal bool IsSetApplyImmediately() => this.ApplyImmediately.HasValue;

        /// <summary>
        /// Gets and sets the property AutomaticFailoverEnabled. 
        /// <para>
        /// Determines whether a read replica is automatically promoted to read/write primary
        /// if the existing primary encounters a failure. 
        /// </para>
        /// </summary>
        public bool? AutomaticFailoverEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutomaticFailoverEnabled property is set.
        /// </summary>
        internal bool IsSetAutomaticFailoverEnabled() => this.AutomaticFailoverEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// A valid cache node type that you want to scale this Global datastore to.
        /// </para>
        /// </summary>
        public string CacheNodeType { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeType property is set.
        /// </summary>
        internal bool IsSetCacheNodeType() => this.CacheNodeType != null;

        /// <summary>
        /// Gets and sets the property CacheParameterGroupName. 
        /// <para>
        /// The name of the cache parameter group to use with the Global datastore. It must be
        /// compatible with the major engine version used by the Global datastore.
        /// </para>
        /// </summary>
        public string CacheParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CacheParameterGroupName property is set.
        /// </summary>
        internal bool IsSetCacheParameterGroupName() => this.CacheParameterGroupName != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Modifies the engine listed in a global replication group message. The options are
        /// valkey, memcached or redis.
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
        /// The upgraded version of the cache engine to be run on the clusters in the Global datastore.
        /// 
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupDescription. 
        /// <para>
        /// A description of the Global datastore
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
        [AWSProperty(Required = true)]
        public string GlobalReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the GlobalReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetGlobalReplicationGroupId() => this.GlobalReplicationGroupId != null;
    }
}
