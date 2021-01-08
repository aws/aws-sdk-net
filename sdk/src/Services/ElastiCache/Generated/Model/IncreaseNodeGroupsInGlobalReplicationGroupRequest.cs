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
    /// Container for the parameters to the IncreaseNodeGroupsInGlobalReplicationGroup operation.
    /// Increase the number of node groups in the Global Datastore
    /// </summary>
    public partial class IncreaseNodeGroupsInGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private string _globalReplicationGroupId;
        private int? _nodeGroupCount;
        private List<RegionalConfiguration> _regionalConfigurations = new List<RegionalConfiguration>();

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates that the process begins immediately. At present, the only permitted value
        /// for this parameter is true.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool ApplyImmediately
        {
            get { return this._applyImmediately.GetValueOrDefault(); }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalReplicationGroupId. 
        /// <para>
        /// The name of the Global Datastore
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

        /// <summary>
        /// Gets and sets the property NodeGroupCount. 
        /// <para>
        /// The number of node groups you wish to add
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int NodeGroupCount
        {
            get { return this._nodeGroupCount.GetValueOrDefault(); }
            set { this._nodeGroupCount = value; }
        }

        // Check to see if NodeGroupCount property is set
        internal bool IsSetNodeGroupCount()
        {
            return this._nodeGroupCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionalConfigurations. 
        /// <para>
        /// Describes the replication group IDs, the AWS regions where they are stored and the
        /// shard configuration for each that comprise the Global Datastore
        /// </para>
        /// </summary>
        public List<RegionalConfiguration> RegionalConfigurations
        {
            get { return this._regionalConfigurations; }
            set { this._regionalConfigurations = value; }
        }

        // Check to see if RegionalConfigurations property is set
        internal bool IsSetRegionalConfigurations()
        {
            return this._regionalConfigurations != null && this._regionalConfigurations.Count > 0; 
        }

    }
}