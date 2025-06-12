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
    /// Container for the parameters to the IncreaseNodeGroupsInGlobalReplicationGroup operation.
    /// Increase the number of node groups in the Global datastore
    /// </summary>
    public partial class IncreaseNodeGroupsInGlobalReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private bool? _applyImmediately;
        private string _globalReplicationGroupId;
        private int? _nodeGroupCount;
        private List<RegionalConfiguration> _regionalConfigurations = AWSConfigs.InitializeCollections ? new List<RegionalConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates that the process begins immediately. At present, the only permitted value
        /// for this parameter is true.
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

        /// <summary>
        /// Gets and sets the property NodeGroupCount. 
        /// <para>
        /// Total number of node groups you want
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? NodeGroupCount
        {
            get { return this._nodeGroupCount; }
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
        /// Describes the replication group IDs, the Amazon regions where they are stored and
        /// the shard configuration for each that comprise the Global datastore
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionalConfiguration> RegionalConfigurations
        {
            get { return this._regionalConfigurations; }
            set { this._regionalConfigurations = value; }
        }

        // Check to see if RegionalConfigurations property is set
        internal bool IsSetRegionalConfigurations()
        {
            return this._regionalConfigurations != null && (this._regionalConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}