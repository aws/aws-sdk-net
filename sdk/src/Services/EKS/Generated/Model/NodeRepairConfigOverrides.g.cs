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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Specify granular overrides for specific repair actions. These overrides control the
    /// repair action and the repair delay time before a node is considered eligible for repair.
    /// If you use this, you must specify all the values.
    /// </summary>
    public partial class NodeRepairConfigOverrides
    {
        /// <summary>
        /// Gets and sets the property MinRepairWaitTimeMins. 
        /// <para>
        /// Specify the minimum time in minutes to wait before attempting to repair a node with
        /// this specific <c>nodeMonitoringCondition</c> and <c>nodeUnhealthyReason</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MinRepairWaitTimeMins { get; set; }

        /// <summary>
        /// Checks to see if the MinRepairWaitTimeMins property is set.
        /// </summary>
        internal bool IsSetMinRepairWaitTimeMins() => this.MinRepairWaitTimeMins.HasValue;

        /// <summary>
        /// Gets and sets the property NodeMonitoringCondition. 
        /// <para>
        /// Specify an unhealthy condition reported by the node monitoring agent that this override
        /// would apply to.
        /// </para>
        /// </summary>
        public string NodeMonitoringCondition { get; set; }

        /// <summary>
        /// Checks to see if the NodeMonitoringCondition property is set.
        /// </summary>
        internal bool IsSetNodeMonitoringCondition() => this.NodeMonitoringCondition != null;

        /// <summary>
        /// Gets and sets the property NodeUnhealthyReason. 
        /// <para>
        /// Specify a reason reported by the node monitoring agent that this override would apply
        /// to.
        /// </para>
        /// </summary>
        public string NodeUnhealthyReason { get; set; }

        /// <summary>
        /// Checks to see if the NodeUnhealthyReason property is set.
        /// </summary>
        internal bool IsSetNodeUnhealthyReason() => this.NodeUnhealthyReason != null;

        /// <summary>
        /// Gets and sets the property RepairAction. 
        /// <para>
        /// Specify the repair action to take for nodes when all of the specified conditions are
        /// met.
        /// </para>
        /// </summary>
        public RepairAction RepairAction { get; set; }

        /// <summary>
        /// Checks to see if the RepairAction property is set.
        /// </summary>
        internal bool IsSetRepairAction() => this.RepairAction != null;
    }
}
