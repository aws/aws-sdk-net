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
    /// The specifications of a restricted instance group that you need to define.
    /// </summary>
    public partial class ClusterRestrictedInstanceGroupSpecification
    {
        /// <summary>
        /// Gets and sets the property EnvironmentConfig. 
        /// <para>
        /// The configuration for the restricted instance groups (RIG) environment.
        /// </para>
        /// </summary>
        public EnvironmentConfig EnvironmentConfig { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfig property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfig() => this.EnvironmentConfig != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// Specifies an IAM execution role to be assumed by the restricted instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Specifies the number of instances to add to the restricted instance group of a SageMaker
        /// HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 6758)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// Specifies the name of the restricted instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property InstanceStorageConfigs. 
        /// <para>
        /// Specifies the additional storage configurations for the instances in the SageMaker
        /// HyperPod cluster restricted instance group.
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
        /// Specifies the instance type of the restricted instance group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClusterInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property OnStartDeepHealthChecks. 
        /// <para>
        /// A flag indicating whether deep health checks should be performed when the cluster
        /// restricted instance group is created or updated.
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
        /// </summary>
        public VpcConfig OverrideVpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the OverrideVpcConfig property is set.
        /// </summary>
        internal bool IsSetOverrideVpcConfig() => this.OverrideVpcConfig != null;

        /// <summary>
        /// Gets and sets the property ScheduledUpdateConfig.
        /// </summary>
        public ScheduledUpdateConfig ScheduledUpdateConfig { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledUpdateConfig property is set.
        /// </summary>
        internal bool IsSetScheduledUpdateConfig() => this.ScheduledUpdateConfig != null;

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
        /// The Amazon Resource Name (ARN) of the training plan to filter clusters by. For more
        /// information about reserving GPU capacity for your SageMaker HyperPod clusters using
        /// Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 2048)]
        public string TrainingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingPlanArn property is set.
        /// </summary>
        internal bool IsSetTrainingPlanArn() => this.TrainingPlanArn != null;
    }
}
