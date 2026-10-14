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
    /// This is the response object from the DescribeCluster operation.
    /// </summary>
    public partial class DescribeClusterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// The current autoscaling configuration and status for the autoscaler.
        /// </para>
        /// </summary>
        public ClusterAutoScalingConfigOutput AutoScaling { get; set; }

        /// <summary>
        /// Checks to see if the AutoScaling property is set.
        /// </summary>
        internal bool IsSetAutoScaling() => this.AutoScaling != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ClusterRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that HyperPod uses for cluster autoscaling
        /// operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ClusterRole { get; set; }

        /// <summary>
        /// Checks to see if the ClusterRole property is set.
        /// </summary>
        internal bool IsSetClusterRole() => this.ClusterRole != null;

        /// <summary>
        /// Gets and sets the property ClusterStatus. 
        /// <para>
        /// The status of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterStatus ClusterStatus { get; set; }

        /// <summary>
        /// Checks to see if the ClusterStatus property is set.
        /// </summary>
        internal bool IsSetClusterStatus() => this.ClusterStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the SageMaker Cluster is created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// The failure message of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// The instance groups of the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ClusterInstanceGroupDetails> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupDetails>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeProvisioningMode. 
        /// <para>
        /// The mode used for provisioning nodes in the cluster.
        /// </para>
        /// </summary>
        public ClusterNodeProvisioningMode NodeProvisioningMode { get; set; }

        /// <summary>
        /// Checks to see if the NodeProvisioningMode property is set.
        /// </summary>
        internal bool IsSetNodeProvisioningMode() => this.NodeProvisioningMode != null;

        /// <summary>
        /// Gets and sets the property NodeRecovery. 
        /// <para>
        /// The node recovery mode configured for the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public ClusterNodeRecovery NodeRecovery { get; set; }

        /// <summary>
        /// Checks to see if the NodeRecovery property is set.
        /// </summary>
        internal bool IsSetNodeRecovery() => this.NodeRecovery != null;

        /// <summary>
        /// Gets and sets the property Orchestrator. 
        /// <para>
        /// The type of orchestrator used for the SageMaker HyperPod cluster. 
        /// </para>
        /// </summary>
        public ClusterOrchestrator Orchestrator { get; set; }

        /// <summary>
        /// Checks to see if the Orchestrator property is set.
        /// </summary>
        internal bool IsSetOrchestrator() => this.Orchestrator != null;

        /// <summary>
        /// Gets and sets the property RestrictedInstanceGroups. 
        /// <para>
        /// The specialized instance groups for training models like Amazon Nova to be created
        /// in the SageMaker HyperPod cluster.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ClusterRestrictedInstanceGroupDetails> RestrictedInstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterRestrictedInstanceGroupDetails>() : null;

        /// <summary>
        /// Checks to see if the RestrictedInstanceGroups property is set.
        /// </summary>
        internal bool IsSetRestrictedInstanceGroups() => this.RestrictedInstanceGroups != null && (this.RestrictedInstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestrictedInstanceGroupsConfig. 
        /// <para>
        /// The configuration for the restricted instance groups (RIG) in the SageMaker HyperPod
        /// cluster.
        /// </para>
        /// </summary>
        public ClusterRestrictedInstanceGroupsConfigOutput RestrictedInstanceGroupsConfig { get; set; }

        /// <summary>
        /// Checks to see if the RestrictedInstanceGroupsConfig property is set.
        /// </summary>
        internal bool IsSetRestrictedInstanceGroupsConfig() => this.RestrictedInstanceGroupsConfig != null;

        /// <summary>
        /// Gets and sets the property TieredStorageConfig. 
        /// <para>
        /// The current configuration for managed tier checkpointing on the HyperPod cluster.
        /// For example, this shows whether the feature is enabled and the percentage of cluster
        /// memory allocated for checkpoint storage.
        /// </para>
        /// </summary>
        public ClusterTieredStorageConfig TieredStorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the TieredStorageConfig property is set.
        /// </summary>
        internal bool IsSetTieredStorageConfig() => this.TieredStorageConfig != null;

        /// <summary>
        /// Gets and sets the property VpcConfig.
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
