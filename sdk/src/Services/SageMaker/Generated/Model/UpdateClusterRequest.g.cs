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
    /// Container for the parameters to the UpdateCluster operation. Updates a SageMaker HyperPod
    /// cluster.
    /// </summary>
    public partial class UpdateClusterRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScaling. 
        /// <para>
        /// Updates the autoscaling configuration for the cluster. Use to enable or disable automatic
        /// node scaling.
        /// </para>
        /// </summary>
        public ClusterAutoScalingConfig AutoScaling { get; set; }

        /// <summary>
        /// Checks to see if the AutoScaling property is set.
        /// </summary>
        internal bool IsSetAutoScaling() => this.AutoScaling != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// Specify the name of the SageMaker HyperPod cluster you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property ClusterRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that HyperPod assumes for cluster autoscaling
        /// operations. Cannot be updated while autoscaling is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ClusterRole { get; set; }

        /// <summary>
        /// Checks to see if the ClusterRole property is set.
        /// </summary>
        internal bool IsSetClusterRole() => this.ClusterRole != null;

        /// <summary>
        /// Gets and sets the property InstanceGroups. 
        /// <para>
        /// Specify the instance groups to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<ClusterInstanceGroupSpecification> InstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterInstanceGroupSpecification>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroups property is set.
        /// </summary>
        internal bool IsSetInstanceGroups() => this.InstanceGroups != null && (this.InstanceGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceGroupsToDelete. 
        /// <para>
        /// Specify the names of the instance groups to delete. Use a single <c>,</c> as the separator
        /// between multiple names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<string> InstanceGroupsToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstanceGroupsToDelete property is set.
        /// </summary>
        internal bool IsSetInstanceGroupsToDelete() => this.InstanceGroupsToDelete != null && (this.InstanceGroupsToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeProvisioningMode. 
        /// <para>
        /// Determines how instance provisioning is handled during cluster operations. In <c>Continuous</c>
        /// mode, the cluster provisions available instances incrementally and retries until the
        /// target count is reached. The cluster becomes operational once cluster-level resources
        /// are ready. Use <c>CurrentCount</c> and <c>TargetCount</c> in <c>DescribeCluster</c>
        /// to track provisioning progress.
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
        /// The node recovery mode to be applied to the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public ClusterNodeRecovery NodeRecovery { get; set; }

        /// <summary>
        /// Checks to see if the NodeRecovery property is set.
        /// </summary>
        internal bool IsSetNodeRecovery() => this.NodeRecovery != null;

        /// <summary>
        /// Gets and sets the property Orchestrator.
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
        [AWSProperty(Min = 1, Max = 100)]
        public List<ClusterRestrictedInstanceGroupSpecification> RestrictedInstanceGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterRestrictedInstanceGroupSpecification>() : null;

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
        public ClusterRestrictedInstanceGroupsConfig RestrictedInstanceGroupsConfig { get; set; }

        /// <summary>
        /// Checks to see if the RestrictedInstanceGroupsConfig property is set.
        /// </summary>
        internal bool IsSetRestrictedInstanceGroupsConfig() => this.RestrictedInstanceGroupsConfig != null;

        /// <summary>
        /// Gets and sets the property TieredStorageConfig. 
        /// <para>
        /// Updates the configuration for managed tier checkpointing on the HyperPod cluster.
        /// For example, you can enable or disable the feature and modify the percentage of cluster
        /// memory allocated for checkpoint storage.
        /// </para>
        /// </summary>
        public ClusterTieredStorageConfig TieredStorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the TieredStorageConfig property is set.
        /// </summary>
        internal bool IsSetTieredStorageConfig() => this.TieredStorageConfig != null;
    }
}
