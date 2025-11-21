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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// The specifications of an instance group that you need to define.
    /// </summary>
    public partial class ClusterInstanceGroupSpecification
    {
        private string _executionRole;
        private string _imageId;
        private int? _instanceCount;
        private string _instanceGroupName;
        private List<ClusterInstanceStorageConfig> _instanceStorageConfigs = AWSConfigs.InitializeCollections ? new List<ClusterInstanceStorageConfig>() : null;
        private ClusterInstanceType _instanceType;
        private ClusterLifeCycleConfig _lifeCycleConfig;
        private List<string> _onStartDeepHealthChecks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VpcConfig _overrideVpcConfig;
        private ScheduledUpdateConfig _scheduledUpdateConfig;
        private int? _threadsPerCore;
        private string _trainingPlanArn;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// Specifies an IAM execution role to be assumed by the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// When configuring your HyperPod cluster, you can specify an image ID using one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HyperPodPublicAmiId</c>: Use a HyperPod public AMI
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CustomAmiId</c>: Use your custom AMI
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>default</c>: Use the default latest system image
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you choose to use a custom AMI (<c>CustomAmiId</c>), ensure it meets the following
        /// requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Encryption: The custom AMI must be unencrypted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ownership: The custom AMI must be owned by the same Amazon Web Services account that
        /// is creating the HyperPod cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Volume support: Only the primary AMI snapshot volume is supported; additional AMI
        /// volumes are not supported.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When updating the instance group's AMI through the <c>UpdateClusterSoftware</c> operation,
        /// if an instance group uses a custom AMI, you must provide an <c>ImageId</c> or use
        /// the default as input. Note that if you don't specify an instance group in your <c>UpdateClusterSoftware</c>
        /// request, then all of the instance groups are patched with the specified image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=21)]
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Specifies the number of instances to add to the instance group of a SageMaker HyperPod
        /// cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=6758)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// Specifies the name of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string InstanceGroupName
        {
            get { return this._instanceGroupName; }
            set { this._instanceGroupName = value; }
        }

        // Check to see if InstanceGroupName property is set
        internal bool IsSetInstanceGroupName()
        {
            return this._instanceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceStorageConfigs. 
        /// <para>
        /// Specifies the additional storage configurations for the instances in the SageMaker
        /// HyperPod cluster instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<ClusterInstanceStorageConfig> InstanceStorageConfigs
        {
            get { return this._instanceStorageConfigs; }
            set { this._instanceStorageConfigs = value; }
        }

        // Check to see if InstanceStorageConfigs property is set
        internal bool IsSetInstanceStorageConfigs()
        {
            return this._instanceStorageConfigs != null && (this._instanceStorageConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type of the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property LifeCycleConfig. 
        /// <para>
        /// Specifies the LifeCycle configuration for the instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClusterLifeCycleConfig LifeCycleConfig
        {
            get { return this._lifeCycleConfig; }
            set { this._lifeCycleConfig = value; }
        }

        // Check to see if LifeCycleConfig property is set
        internal bool IsSetLifeCycleConfig()
        {
            return this._lifeCycleConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OnStartDeepHealthChecks. 
        /// <para>
        /// A flag indicating whether deep health checks should be performed when the cluster
        /// instance group is created or updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> OnStartDeepHealthChecks
        {
            get { return this._onStartDeepHealthChecks; }
            set { this._onStartDeepHealthChecks = value; }
        }

        // Check to see if OnStartDeepHealthChecks property is set
        internal bool IsSetOnStartDeepHealthChecks()
        {
            return this._onStartDeepHealthChecks != null && (this._onStartDeepHealthChecks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverrideVpcConfig. 
        /// <para>
        /// To configure multi-AZ deployments, customize the Amazon VPC configuration at the instance
        /// group level. You can specify different subnets and security groups across different
        /// AZs in the instance group specification to override a SageMaker HyperPod cluster's
        /// default Amazon VPC configuration. For more information about deploying a cluster in
        /// multiple AZs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-prerequisites.html#sagemaker-hyperpod-prerequisites-multiple-availability-zones">Setting
        /// up SageMaker HyperPod clusters across multiple AZs</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When your Amazon VPC and subnets support IPv6, network communications differ based
        /// on the cluster orchestration platform:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Slurm-orchestrated clusters automatically configure nodes with dual IPv6 and IPv4
        /// addresses, allowing immediate IPv6 network communications.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In Amazon EKS-orchestrated clusters, nodes receive dual-stack addressing, but pods
        /// can only use IPv6 when the Amazon EKS cluster is explicitly IPv6-enabled. For information
        /// about deploying an IPv6 Amazon EKS cluster, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/deploy-ipv6-cluster.html#_deploy_an_ipv6_cluster_with_eksctl">Amazon
        /// EKS IPv6 Cluster Deployment</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additional resources for IPv6 configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For information about adding IPv6 support to your VPC, see to <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-migrate-ipv6.html">IPv6
        /// Support for VPC</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about creating a new IPv6-compatible VPC, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/create-vpc.html">Amazon
        /// VPC Creation Guide</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure SageMaker HyperPod with a custom Amazon VPC, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-hyperpod-prerequisites.html#sagemaker-hyperpod-prerequisites-optional-vpc">Custom
        /// Amazon VPC Setup for SageMaker HyperPod</a>.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public VpcConfig OverrideVpcConfig
        {
            get { return this._overrideVpcConfig; }
            set { this._overrideVpcConfig = value; }
        }

        // Check to see if OverrideVpcConfig property is set
        internal bool IsSetOverrideVpcConfig()
        {
            return this._overrideVpcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledUpdateConfig. 
        /// <para>
        /// The configuration object of the schedule that SageMaker uses to update the AMI.
        /// </para>
        /// </summary>
        public ScheduledUpdateConfig ScheduledUpdateConfig
        {
            get { return this._scheduledUpdateConfig; }
            set { this._scheduledUpdateConfig = value; }
        }

        // Check to see if ScheduledUpdateConfig property is set
        internal bool IsSetScheduledUpdateConfig()
        {
            return this._scheduledUpdateConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// Specifies the value for <b>Threads per core</b>. For instance types that support multithreading,
        /// you can specify <c>1</c> for disabling multithreading and <c>2</c> for enabling multithreading.
        /// For instance types that doesn't support multithreading, specify <c>1</c>. For more
        /// information, see the reference table of <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/cpu-options-supported-instances-values.html">CPU
        /// cores and threads per CPU core per instance type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public int? ThreadsPerCore
        {
            get { return this._threadsPerCore; }
            set { this._threadsPerCore = value; }
        }

        // Check to see if ThreadsPerCore property is set
        internal bool IsSetThreadsPerCore()
        {
            return this._threadsPerCore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingPlanArn. 
        /// <para>
        /// The Amazon Resource Name (ARN); of the training plan to use for this cluster instance
        /// group.
        /// </para>
        ///  
        /// <para>
        /// For more information about how to reserve GPU capacity for your SageMaker HyperPod
        /// clusters using Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=2048)]
        public string TrainingPlanArn
        {
            get { return this._trainingPlanArn; }
            set { this._trainingPlanArn = value; }
        }

        // Check to see if TrainingPlanArn property is set
        internal bool IsSetTrainingPlanArn()
        {
            return this._trainingPlanArn != null;
        }

    }
}