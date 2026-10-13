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
    /// Details of an instance group in a SageMaker HyperPod cluster.
    /// </summary>
    public partial class ClusterInstanceGroupDetails
    {
        /// <summary>
        /// Gets and sets the property ActiveOperations. 
        /// <para>
        /// A map indicating active operations currently in progress for the instance group of
        /// a SageMaker HyperPod cluster. When there is a scaling operation in progress, this
        /// map contains a key <c>Scaling</c> with value 1. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> ActiveOperations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Checks to see if the ActiveOperations property is set.
        /// </summary>
        internal bool IsSetActiveOperations() => this.ActiveOperations != null && (this.ActiveOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActiveSoftwareUpdateConfig.
        /// </summary>
        public DeploymentConfiguration ActiveSoftwareUpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the ActiveSoftwareUpdateConfig property is set.
        /// </summary>
        internal bool IsSetActiveSoftwareUpdateConfig() => this.ActiveSoftwareUpdateConfig != null;

        /// <summary>
        /// Gets and sets the property AutoPatchConfig. 
        /// <para>
        /// The auto-patching configuration for the instance group, including the current patching
        /// strategy and next scheduled patch date.
        /// </para>
        /// </summary>
        public ClusterAutoPatchConfigDetails AutoPatchConfig { get; set; }

        /// <summary>
        /// Checks to see if the AutoPatchConfig property is set.
        /// </summary>
        internal bool IsSetAutoPatchConfig() => this.AutoPatchConfig != null;

        /// <summary>
        /// Gets and sets the property CapacityRequirements. 
        /// <para>
        /// The instance capacity requirements for the instance group.
        /// </para>
        /// </summary>
        public ClusterCapacityRequirements CapacityRequirements { get; set; }

        /// <summary>
        /// Checks to see if the CapacityRequirements property is set.
        /// </summary>
        internal bool IsSetCapacityRequirements() => this.CapacityRequirements != null;

        /// <summary>
        /// Gets and sets the property CurrentCount. 
        /// <para>
        /// The number of instances that are currently in the instance group of a SageMaker HyperPod
        /// cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? CurrentCount { get; set; }

        /// <summary>
        /// Checks to see if the CurrentCount property is set.
        /// </summary>
        internal bool IsSetCurrentCount() => this.CurrentCount.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentImageId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) currently in use by the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 21)]
        public string CurrentImageId { get; set; }

        /// <summary>
        /// Checks to see if the CurrentImageId property is set.
        /// </summary>
        internal bool IsSetCurrentImageId() => this.CurrentImageId != null;

        /// <summary>
        /// Gets and sets the property CurrentImageReleaseVersion. 
        /// <para>
        /// The version of the HyperPod-managed AMI currently running on the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string CurrentImageReleaseVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentImageReleaseVersion property is set.
        /// </summary>
        internal bool IsSetCurrentImageReleaseVersion() => this.CurrentImageReleaseVersion != null;

        /// <summary>
        /// Gets and sets the property DesiredImageId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) desired for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 21)]
        public string DesiredImageId { get; set; }

        /// <summary>
        /// Checks to see if the DesiredImageId property is set.
        /// </summary>
        internal bool IsSetDesiredImageId() => this.DesiredImageId != null;

        /// <summary>
        /// Gets and sets the property DesiredImageReleaseVersion. 
        /// <para>
        /// The desired version of the HyperPod-managed AMI for the instance group. This may differ
        /// from the current version when an update is pending.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string DesiredImageReleaseVersion { get; set; }

        /// <summary>
        /// Checks to see if the DesiredImageReleaseVersion property is set.
        /// </summary>
        internal bool IsSetDesiredImageReleaseVersion() => this.DesiredImageReleaseVersion != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role for the instance group to assume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property ImageVersionStatus. 
        /// <para>
        /// The status of the image version for the instance group. Indicates whether the instance
        /// group is running the latest image version or if an update is available.
        /// </para>
        /// </summary>
        public ClusterImageVersionStatus ImageVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersionStatus property is set.
        /// </summary>
        internal bool IsSetImageVersionStatus() => this.ImageVersionStatus != null;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group of a SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance requirements for the instance group, including the current and desired
        /// instance types. This field is present for flexible instance groups that support multiple
        /// instance types.
        /// </para>
        /// </summary>
        public ClusterInstanceRequirementDetails InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property InstanceStorageConfigs. 
        /// <para>
        /// The additional storage configurations for the instances in the SageMaker HyperPod
        /// cluster instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<ClusterInstanceStorageConfig> InstanceStorageConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterInstanceStorageConfig>() : null;

        /// <summary>
        /// Checks to see if the InstanceStorageConfigs property is set.
        /// </summary>
        internal bool IsSetInstanceStorageConfigs() => this.InstanceStorageConfigs != null && (this.InstanceStorageConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type of the instance group of a SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public ClusterInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property InstanceTypeDetails. 
        /// <para>
        /// Details about the instance types in the instance group, including the count and configuration
        /// of each instance type. This field is present for flexible instance groups that support
        /// multiple instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<ClusterInstanceTypeDetail> InstanceTypeDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ClusterInstanceTypeDetail>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeDetails property is set.
        /// </summary>
        internal bool IsSetInstanceTypeDetails() => this.InstanceTypeDetails != null && (this.InstanceTypeDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KubernetesConfig. 
        /// <para>
        /// The Kubernetes configuration for the instance group that contains labels and taints
        /// to be applied for the nodes in this instance group. 
        /// </para>
        /// </summary>
        public ClusterKubernetesConfigDetails KubernetesConfig { get; set; }

        /// <summary>
        /// Checks to see if the KubernetesConfig property is set.
        /// </summary>
        internal bool IsSetKubernetesConfig() => this.KubernetesConfig != null;

        /// <summary>
        /// Gets and sets the property LifeCycleConfig. 
        /// <para>
        /// Details of LifeCycle configuration for the instance group.
        /// </para>
        /// </summary>
        public ClusterLifeCycleConfig LifeCycleConfig { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycleConfig property is set.
        /// </summary>
        internal bool IsSetLifeCycleConfig() => this.LifeCycleConfig != null;

        /// <summary>
        /// Gets and sets the property MinCount. 
        /// <para>
        /// The minimum number of instances that must be available in the instance group of a
        /// SageMaker HyperPod cluster before it transitions to <c>InService</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6758)]
        public int? MinCount { get; set; }

        /// <summary>
        /// Checks to see if the MinCount property is set.
        /// </summary>
        internal bool IsSetMinCount() => this.MinCount.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// The network interface configuration for the instance group.
        /// </para>
        /// </summary>
        public ClusterNetworkInterfaceDetails NetworkInterface { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterface property is set.
        /// </summary>
        internal bool IsSetNetworkInterface() => this.NetworkInterface != null;

        /// <summary>
        /// Gets and sets the property OnStartDeepHealthChecks. 
        /// <para>
        /// A flag indicating whether deep health checks should be performed when the cluster
        /// instance group is created or updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> OnStartDeepHealthChecks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OnStartDeepHealthChecks property is set.
        /// </summary>
        internal bool IsSetOnStartDeepHealthChecks() => this.OnStartDeepHealthChecks != null && (this.OnStartDeepHealthChecks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OverrideVpcConfig. 
        /// <para>
        /// The customized Amazon VPC configuration at the instance group level that overrides
        /// the default Amazon VPC configuration of the SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        public VpcConfig OverrideVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the OverrideVpcConfig property is set.
        /// </summary>
        internal bool IsSetOverrideVpcConfig() => this.OverrideVpcConfig != null;

        /// <summary>
        /// Gets and sets the property ScheduledUpdateConfig. 
        /// <para>
        /// The configuration object of the schedule that SageMaker follows when updating the
        /// AMI.
        /// </para>
        /// </summary>
        public ScheduledUpdateConfig ScheduledUpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledUpdateConfig property is set.
        /// </summary>
        internal bool IsSetScheduledUpdateConfig() => this.ScheduledUpdateConfig != null;

        /// <summary>
        /// Gets and sets the property SlurmConfig. 
        /// <para>
        /// The Slurm configuration for the instance group.
        /// </para>
        /// </summary>
        public ClusterSlurmConfigDetails SlurmConfig { get; set; }

        /// <summary>
        /// Checks to see if the SlurmConfig property is set.
        /// </summary>
        internal bool IsSetSlurmConfig() => this.SlurmConfig != null;

        /// <summary>
        /// Gets and sets the property SoftwareUpdateStatus. 
        /// <para>
        /// Status of the last software udpate request.
        /// </para>
        ///  
        /// <para>
        /// Status transitions follow these possible sequences:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending -&gt; InProgress -&gt; Succeeded
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending -&gt; InProgress -&gt; RollbackInProgress -&gt; RollbackComplete
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending -&gt; InProgress -&gt; RollbackInProgress -&gt; Failed
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SoftwareUpdateStatus SoftwareUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the SoftwareUpdateStatus property is set.
        /// </summary>
        internal bool IsSetSoftwareUpdateStatus() => this.SoftwareUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cluster instance group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InService</c>: The instance group is active and healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Creating</c>: The instance group is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c>: The instance group is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The instance group has failed to provision or is no longer healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Degraded</c>: The instance group is degraded, meaning that some instances have
        /// failed to provision or are no longer healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: The instance group is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetCount. 
        /// <para>
        /// The number of instances you specified to add to the instance group of a SageMaker
        /// HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6758)]
        public int? TargetCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetCount property is set.
        /// </summary>
        internal bool IsSetTargetCount() => this.TargetCount.HasValue;

        /// <summary>
        /// Gets and sets the property TargetStateCount. 
        /// <para>
        /// Represents the number of running nodes using the desired Image ID.
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <b>During software update operations:</b> This count shows the number of nodes running
        /// on the desired Image ID. If a rollback occurs, the current image ID and desired image
        /// ID (both included in the describe cluster response) swap values. The TargetStateCount
        /// then shows the number of nodes running on the newly designated desired image ID (which
        /// was previously the current image ID).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>During simultaneous scaling and software update operations:</b> This count shows
        /// the number of instances running on the desired image ID, including any new instances
        /// created as part of the scaling request. New nodes are always created using the desired
        /// image ID, so TargetStateCount reflects the total count of nodes running on the desired
        /// image ID, even during rollback scenarios.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6758)]
        public int? TargetStateCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetStateCount property is set.
        /// </summary>
        internal bool IsSetTargetStateCount() => this.TargetStateCount.HasValue;

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number you specified to <c>TreadsPerCore</c> in <c>CreateCluster</c> for enabling
        /// or disabling multithreading. For instance types that support multithreading, you can
        /// specify 1 for disabling multithreading and 2 for enabling multithreading. For more
        /// information, see the reference table of <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cpu-options-supported-instances-values.html">CPU
        /// cores and threads per CPU core per instance type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2)]
        public int? ThreadsPerCore { get; set; }

        /// <summary>
        /// Checks to see if the ThreadsPerCore property is set.
        /// </summary>
        internal bool IsSetThreadsPerCore() => this.ThreadsPerCore.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan associated with this cluster
        /// instance group.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
        /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 2048)]
        public string TrainingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanArn property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArn() => this.TrainingPlanArn != null;

        /// <summary>
        /// Gets and sets the property TrainingPlanStatus. 
        /// <para>
        /// The current status of the training plan associated with this cluster instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string TrainingPlanStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanStatus property is set.
        /// </summary>
        internal bool IsSetTrainingPlanStatus() => this.TrainingPlanStatus != null;
    }
}
