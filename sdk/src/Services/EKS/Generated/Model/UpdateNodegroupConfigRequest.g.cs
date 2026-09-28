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
    /// Container for the parameters to the UpdateNodegroupConfig operation. Updates an Amazon
    /// EKS managed node group configuration. Your node group continues to function during
    /// the update. The response output includes an update ID that you can use to track the
    /// status of your node group update with the <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeUpdate.html">
    /// <c>DescribeUpdate</c> </a> API operation. You can update the Kubernetes labels and
    /// taints for a node group and the scaling and version update configuration.
    /// </summary>
    public partial class UpdateNodegroupConfigRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        /// The Kubernetes <c>labels</c> to apply to the nodes in the node group after the update.
        /// </para>
        /// </summary>
        public UpdateLabelsPayload Labels { get; set; }

        /// <summary>
        /// Checks to see if the Labels property is set.
        /// </summary>
        internal bool IsSetLabels() => this.Labels != null;

        /// <summary>
        /// Gets and sets the property NodeRepairConfig. 
        /// <para>
        /// The node auto repair configuration for the node group.
        /// </para>
        /// </summary>
        public NodeRepairConfig NodeRepairConfig { get; set; }

        /// <summary>
        /// Checks to see if the NodeRepairConfig property is set.
        /// </summary>
        internal bool IsSetNodeRepairConfig() => this.NodeRepairConfig != null;

        /// <summary>
        /// Gets and sets the property NodegroupName. 
        /// <para>
        /// The name of the managed node group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodegroupName { get; set; }

        /// <summary>
        /// Checks to see if the NodegroupName property is set.
        /// </summary>
        internal bool IsSetNodegroupName() => this.NodegroupName != null;

        /// <summary>
        /// Gets and sets the property ScalingConfig. 
        /// <para>
        /// The scaling configuration details for the Auto Scaling group after the update.
        /// </para>
        /// </summary>
        public NodegroupScalingConfig ScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScalingConfig property is set.
        /// </summary>
        internal bool IsSetScalingConfig() => this.ScalingConfig != null;

        /// <summary>
        /// Gets and sets the property Taints. 
        /// <para>
        /// The Kubernetes taints to be applied to the nodes in the node group after the update.
        /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/node-taints-managed-node-groups.html">Node
        /// taints on managed node groups</a>.
        /// </para>
        /// </summary>
        public UpdateTaintsPayload Taints { get; set; }

        /// <summary>
        /// Checks to see if the Taints property is set.
        /// </summary>
        internal bool IsSetTaints() => this.Taints != null;

        /// <summary>
        /// Gets and sets the property UpdateConfig. 
        /// <para>
        /// The node group update configuration.
        /// </para>
        /// </summary>
        public NodegroupUpdateConfig UpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the UpdateConfig property is set.
        /// </summary>
        internal bool IsSetUpdateConfig() => this.UpdateConfig != null;

        /// <summary>
        /// Gets and sets the property WarmPoolConfig. 
        /// <para>
        /// The warm pool configuration to apply to the node group. You can use this to add a
        /// warm pool to an existing node group or modify the settings of an existing warm pool.
        /// </para>
        /// </summary>
        public WarmPoolConfig WarmPoolConfig { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolConfig property is set.
        /// </summary>
        internal bool IsSetWarmPoolConfig() => this.WarmPoolConfig != null;
    }
}
