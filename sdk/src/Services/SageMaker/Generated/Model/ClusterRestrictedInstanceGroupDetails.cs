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
    /// The instance group details of the restricted instance group (RIG).
    /// </summary>
    public partial class ClusterRestrictedInstanceGroupDetails
    {
        private int? _currentCount;
        private EnvironmentConfigDetails _environmentConfig;
        private string _executionRole;
        private string _instanceGroupName;
        private List<ClusterInstanceStorageConfig> _instanceStorageConfigs = AWSConfigs.InitializeCollections ? new List<ClusterInstanceStorageConfig>() : null;
        private ClusterInstanceType _instanceType;
        private List<string> _onStartDeepHealthChecks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VpcConfig _overrideVpcConfig;
        private ScheduledUpdateConfig _scheduledUpdateConfig;
        private InstanceGroupStatus _status;
        private int? _targetCount;
        private int? _threadsPerCore;
        private string _trainingPlanArn;
        private string _trainingPlanStatus;

        /// <summary>
        /// Gets and sets the property CurrentCount. 
        /// <para>
        /// The number of instances that are currently in the restricted instance group of a SageMaker
        /// HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? CurrentCount
        {
            get { return this._currentCount; }
            set { this._currentCount = value; }
        }

        // Check to see if CurrentCount property is set
        internal bool IsSetCurrentCount()
        {
            return this._currentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentConfig. 
        /// <para>
        /// The configuration for the restricted instance groups (RIG) environment.
        /// </para>
        /// </summary>
        public EnvironmentConfigDetails EnvironmentConfig
        {
            get { return this._environmentConfig; }
            set { this._environmentConfig = value; }
        }

        // Check to see if EnvironmentConfig property is set
        internal bool IsSetEnvironmentConfig()
        {
            return this._environmentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role for the restricted instance group to assume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the restricted instance group of a SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// The additional storage configurations for the instances in the SageMaker HyperPod
        /// cluster restricted instance group.
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
        /// The instance type of the restricted instance group of a SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OnStartDeepHealthChecks. 
        /// <para>
        /// A flag indicating whether deep health checks should be performed when the cluster's
        /// restricted instance group is created or updated.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the cluster's restricted instance group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>InService</c>: The restricted instance group is active and healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Creating</c>: The restricted instance group is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Updating</c>: The restricted instance group is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c>: The restricted instance group has failed to provision or is no longer
        /// healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Degraded</c>: The restricted instance group is degraded, meaning that some instances
        /// have failed to provision or are no longer healthy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Deleting</c>: The restricted instance group is being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InstanceGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCount. 
        /// <para>
        /// The number of instances you specified to add to the restricted instance group of a
        /// SageMaker HyperPod cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=6758)]
        public int? TargetCount
        {
            get { return this._targetCount; }
            set { this._targetCount = value; }
        }

        // Check to see if TargetCount property is set
        internal bool IsSetTargetCount()
        {
            return this._targetCount.HasValue; 
        }

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
        /// The Amazon Resource Name (ARN) of the training plan to filter clusters by. For more
        /// information about reserving GPU capacity for your SageMaker HyperPod clusters using
        /// Amazon SageMaker Training Plan, see <c> <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingPlan.html">CreateTrainingPlan</a>
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

        /// <summary>
        /// Gets and sets the property TrainingPlanStatus. 
        /// <para>
        /// The current status of the training plan associated with this cluster restricted instance
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string TrainingPlanStatus
        {
            get { return this._trainingPlanStatus; }
            set { this._trainingPlanStatus = value; }
        }

        // Check to see if TrainingPlanStatus property is set
        internal bool IsSetTrainingPlanStatus()
        {
            return this._trainingPlanStatus != null;
        }

    }
}