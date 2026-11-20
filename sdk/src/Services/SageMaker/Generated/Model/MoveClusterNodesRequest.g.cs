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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the MoveClusterNodes operation. Moves running nodes
    /// from one instance group to another instance group. The target instance group can be
    /// in the same HyperPod cluster or in a different HyperPod cluster in the same account
    /// and Region. The underlying instances aren't terminated. <para> Each node keeps its
    /// instance ID, its <c>NodeLogicalId</c>, its network interfaces and IP addresses, and
    /// its capacity. The node then joins the target instance group with the target's configuration
    /// and lifecycle scripts. </para> <important> <para> The move replaces the node's root
    /// Amazon Elastic Block Store (Amazon EBS) volume and secondary EBS volume, which deletes
    /// any data stored on them. Back up any data that you need before you move the node.
    /// </para> </important> <para> Specify the nodes to move with exactly one of <c>NodeIds</c>,
    /// <c>NodeLogicalIds</c>, or <c>InstanceCount</c>. The operation is asynchronous and
    /// returns after it accepts the nodes for the move. While a node moves, its status is
    /// <c>DetachInProgress</c> and then <c>AttachInProgress</c>. The node appears in the
    /// source cluster while it detaches. After HyperPod hands the node off to the target
    /// instance group, the node appears in the target cluster. To track the node, call <c>DescribeClusterNode</c>
    /// or <c>ListClusterNodes</c> on the source or target cluster. </para> <note> <para>
    /// Both clusters must be <c>InService</c>, use Amazon EKS orchestration, and use <c>Continuous</c>
    /// as the <c>NodeProvisioningMode</c>. </para> <para> The source and target instance
    /// groups must also use compatible configurations. </para> </note>
    /// </summary>
    public partial class MoveClusterNodesRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the operation
        /// completes no more than one time. If you retry the request with the same client token
        /// and the same parameters within 8 hours, the service returns the original response.
        /// It doesn't start a new move. If you reuse a client token with different parameters,
        /// the request fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of nodes to move, from 1 to 50. HyperPod selects the nodes from the source
        /// instance group. If fewer than this number of nodes are eligible to move, the request
        /// fails and no nodes are moved. Specify exactly one of <c>NodeIds</c>, <c>NodeLogicalIds</c>,
        /// or <c>InstanceCount</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property NodeIds. 
        /// <para>
        /// A list of instance IDs of the nodes to move. You can specify up to 50 instance IDs.
        /// Each node is evaluated separately, so some nodes can be moved while others fail. The
        /// request fails if moving the eligible nodes would reduce the source instance group
        /// below its minimum instance count. Specify exactly one of <c>NodeIds</c>, <c>NodeLogicalIds</c>,
        /// or <c>InstanceCount</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> NodeIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeIds property is set.
        /// </summary>
        internal bool IsSetNodeIds() => this.NodeIds != null && (this.NodeIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeLogicalIds. 
        /// <para>
        /// A list of <c>NodeLogicalIds</c> of the nodes to move. You can specify up to 50 <c>NodeLogicalIds</c>.
        /// Each node is evaluated separately, so some nodes can be moved while others fail. The
        /// request fails if moving the eligible nodes would reduce the source instance group
        /// below its minimum instance count. Specify exactly one of <c>NodeIds</c>, <c>NodeLogicalIds</c>,
        /// or <c>InstanceCount</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> NodeLogicalIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NodeLogicalIds property is set.
        /// </summary>
        internal bool IsSetNodeLogicalIds() => this.NodeLogicalIds != null && (this.NodeLogicalIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the HyperPod cluster that the nodes are moved from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string SourceClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceClusterArn property is set.
        /// </summary>
        internal bool IsSetSourceClusterArn() => this.SourceClusterArn != null;

        /// <summary>
        /// Gets and sets the property SourceInstanceGroupName. 
        /// <para>
        /// The name of the instance group in the source cluster that the nodes are moved from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string SourceInstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the SourceInstanceGroupName property is set.
        /// </summary>
        internal bool IsSetSourceInstanceGroupName() => this.SourceInstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property TargetClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the HyperPod cluster that the nodes are moved to.
        /// The target cluster must be in the same account and Region as the source cluster, and
        /// can be the same cluster as the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TargetClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetClusterArn property is set.
        /// </summary>
        internal bool IsSetTargetClusterArn() => this.TargetClusterArn != null;

        /// <summary>
        /// Gets and sets the property TargetInstanceGroupName. 
        /// <para>
        /// The name of the instance group in the target cluster that the nodes are moved to.
        /// If the target cluster is the same as the source cluster, the target instance group
        /// must be different from the source instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TargetInstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the TargetInstanceGroupName property is set.
        /// </summary>
        internal bool IsSetTargetInstanceGroupName() => this.TargetInstanceGroupName != null;
    }
}
