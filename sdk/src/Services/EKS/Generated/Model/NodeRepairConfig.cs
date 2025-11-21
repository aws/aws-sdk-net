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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The node auto repair configuration for the node group.
    /// </summary>
    public partial class NodeRepairConfig
    {
        private bool? _enabled;
        private int? _maxParallelNodesRepairedCount;
        private int? _maxParallelNodesRepairedPercentage;
        private int? _maxUnhealthyNodeThresholdCount;
        private int? _maxUnhealthyNodeThresholdPercentage;
        private List<NodeRepairConfigOverrides> _nodeRepairConfigOverrides = AWSConfigs.InitializeCollections ? new List<NodeRepairConfigOverrides>() : null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable node auto repair for the node group. Node auto repair
        /// is disabled by default.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxParallelNodesRepairedCount. 
        /// <para>
        /// Specify the maximum number of nodes that can be repaired concurrently or in parallel,
        /// expressed as a count of unhealthy nodes. This gives you finer-grained control over
        /// the pace of node replacements. When using this, you cannot also set <c>maxParallelNodesRepairedPercentage</c>
        /// at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxParallelNodesRepairedCount
        {
            get { return this._maxParallelNodesRepairedCount; }
            set { this._maxParallelNodesRepairedCount = value; }
        }

        // Check to see if MaxParallelNodesRepairedCount property is set
        internal bool IsSetMaxParallelNodesRepairedCount()
        {
            return this._maxParallelNodesRepairedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxParallelNodesRepairedPercentage. 
        /// <para>
        /// Specify the maximum number of nodes that can be repaired concurrently or in parallel,
        /// expressed as a percentage of unhealthy nodes. This gives you finer-grained control
        /// over the pace of node replacements. When using this, you cannot also set <c>maxParallelNodesRepairedCount</c>
        /// at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxParallelNodesRepairedPercentage
        {
            get { return this._maxParallelNodesRepairedPercentage; }
            set { this._maxParallelNodesRepairedPercentage = value; }
        }

        // Check to see if MaxParallelNodesRepairedPercentage property is set
        internal bool IsSetMaxParallelNodesRepairedPercentage()
        {
            return this._maxParallelNodesRepairedPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxUnhealthyNodeThresholdCount. 
        /// <para>
        /// Specify a count threshold of unhealthy nodes, above which node auto repair actions
        /// will stop. When using this, you cannot also set <c>maxUnhealthyNodeThresholdPercentage</c>
        /// at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxUnhealthyNodeThresholdCount
        {
            get { return this._maxUnhealthyNodeThresholdCount; }
            set { this._maxUnhealthyNodeThresholdCount = value; }
        }

        // Check to see if MaxUnhealthyNodeThresholdCount property is set
        internal bool IsSetMaxUnhealthyNodeThresholdCount()
        {
            return this._maxUnhealthyNodeThresholdCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxUnhealthyNodeThresholdPercentage. 
        /// <para>
        /// Specify a percentage threshold of unhealthy nodes, above which node auto repair actions
        /// will stop. When using this, you cannot also set <c>maxUnhealthyNodeThresholdCount</c>
        /// at the same time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxUnhealthyNodeThresholdPercentage
        {
            get { return this._maxUnhealthyNodeThresholdPercentage; }
            set { this._maxUnhealthyNodeThresholdPercentage = value; }
        }

        // Check to see if MaxUnhealthyNodeThresholdPercentage property is set
        internal bool IsSetMaxUnhealthyNodeThresholdPercentage()
        {
            return this._maxUnhealthyNodeThresholdPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeRepairConfigOverrides. 
        /// <para>
        /// Specify granular overrides for specific repair actions. These overrides control the
        /// repair action and the repair delay time before a node is considered eligible for repair.
        /// If you use this, you must specify all the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<NodeRepairConfigOverrides> NodeRepairConfigOverrides
        {
            get { return this._nodeRepairConfigOverrides; }
            set { this._nodeRepairConfigOverrides = value; }
        }

        // Check to see if NodeRepairConfigOverrides property is set
        internal bool IsSetNodeRepairConfigOverrides()
        {
            return this._nodeRepairConfigOverrides != null && (this._nodeRepairConfigOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}