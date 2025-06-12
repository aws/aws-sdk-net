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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about a deployment group.
    /// </summary>
    public partial class DeploymentGroupInfo
    {
        private AlarmConfiguration _alarmConfiguration;
        private string _applicationName;
        private AutoRollbackConfiguration _autoRollbackConfiguration;
        private List<AutoScalingGroup> _autoScalingGroups = AWSConfigs.InitializeCollections ? new List<AutoScalingGroup>() : null;
        private BlueGreenDeploymentConfiguration _blueGreenDeploymentConfiguration;
        private ComputePlatform _computePlatform;
        private string _deploymentConfigName;
        private string _deploymentGroupId;
        private string _deploymentGroupName;
        private DeploymentStyle _deploymentStyle;
        private List<EC2TagFilter> _ec2TagFilters = AWSConfigs.InitializeCollections ? new List<EC2TagFilter>() : null;
        private EC2TagSet _ec2TagSet;
        private List<ECSService> _ecsServices = AWSConfigs.InitializeCollections ? new List<ECSService>() : null;
        private LastDeploymentInfo _lastAttemptedDeployment;
        private LastDeploymentInfo _lastSuccessfulDeployment;
        private LoadBalancerInfo _loadBalancerInfo;
        private List<TagFilter> _onPremisesInstanceTagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;
        private OnPremisesTagSet _onPremisesTagSet;
        private OutdatedInstancesStrategy _outdatedInstancesStrategy;
        private string _serviceRoleArn;
        private RevisionLocation _targetRevision;
        private bool? _terminationHookEnabled;
        private List<TriggerConfig> _triggerConfigurations = AWSConfigs.InitializeCollections ? new List<TriggerConfig>() : null;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// A list of alarms associated with the deployment group.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoRollbackConfiguration. 
        /// <para>
        /// Information about the automatic rollback configuration associated with the deployment
        /// group.
        /// </para>
        /// </summary>
        public AutoRollbackConfiguration AutoRollbackConfiguration
        {
            get { return this._autoRollbackConfiguration; }
            set { this._autoRollbackConfiguration = value; }
        }

        // Check to see if AutoRollbackConfiguration property is set
        internal bool IsSetAutoRollbackConfiguration()
        {
            return this._autoRollbackConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// A list of associated Auto Scaling groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && (this._autoScalingGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentConfiguration. 
        /// <para>
        /// Information about blue/green deployment options for a deployment group.
        /// </para>
        /// </summary>
        public BlueGreenDeploymentConfiguration BlueGreenDeploymentConfiguration
        {
            get { return this._blueGreenDeploymentConfiguration; }
            set { this._blueGreenDeploymentConfiguration = value; }
        }

        // Check to see if BlueGreenDeploymentConfiguration property is set
        internal bool IsSetBlueGreenDeploymentConfiguration()
        {
            return this._blueGreenDeploymentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        /// The destination platform type for the deployment (<c>Lambda</c>, <c>Server</c>, or
        /// <c>ECS</c>).
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform
        {
            get { return this._computePlatform; }
            set { this._computePlatform = value; }
        }

        // Check to see if ComputePlatform property is set
        internal bool IsSetComputePlatform()
        {
            return this._computePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The deployment configuration name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DeploymentConfigName
        {
            get { return this._deploymentConfigName; }
            set { this._deploymentConfigName = value; }
        }

        // Check to see if DeploymentConfigName property is set
        internal bool IsSetDeploymentConfigName()
        {
            return this._deploymentConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentGroupId. 
        /// <para>
        /// The deployment group ID.
        /// </para>
        /// </summary>
        public string DeploymentGroupId
        {
            get { return this._deploymentGroupId; }
            set { this._deploymentGroupId = value; }
        }

        // Check to see if DeploymentGroupId property is set
        internal bool IsSetDeploymentGroupId()
        {
            return this._deploymentGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The deployment group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DeploymentGroupName
        {
            get { return this._deploymentGroupName; }
            set { this._deploymentGroupName = value; }
        }

        // Check to see if DeploymentGroupName property is set
        internal bool IsSetDeploymentGroupName()
        {
            return this._deploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStyle. 
        /// <para>
        /// Information about the type of deployment, either in-place or blue/green, you want
        /// to run and whether to route deployment traffic behind a load balancer.
        /// </para>
        /// </summary>
        public DeploymentStyle DeploymentStyle
        {
            get { return this._deploymentStyle; }
            set { this._deploymentStyle = value; }
        }

        // Check to see if DeploymentStyle property is set
        internal bool IsSetDeploymentStyle()
        {
            return this._deploymentStyle != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2TagFilters. 
        /// <para>
        /// The Amazon EC2 tags on which to filter. The deployment group includes EC2 instances
        /// with any of the specified tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2TagFilter> Ec2TagFilters
        {
            get { return this._ec2TagFilters; }
            set { this._ec2TagFilters = value; }
        }

        // Check to see if Ec2TagFilters property is set
        internal bool IsSetEc2TagFilters()
        {
            return this._ec2TagFilters != null && (this._ec2TagFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ec2TagSet. 
        /// <para>
        /// Information about groups of tags applied to an Amazon EC2 instance. The deployment
        /// group includes only Amazon EC2 instances identified by all of the tag groups. Cannot
        /// be used in the same call as ec2TagFilters.
        /// </para>
        /// </summary>
        public EC2TagSet Ec2TagSet
        {
            get { return this._ec2TagSet; }
            set { this._ec2TagSet = value; }
        }

        // Check to see if Ec2TagSet property is set
        internal bool IsSetEc2TagSet()
        {
            return this._ec2TagSet != null;
        }

        /// <summary>
        /// Gets and sets the property EcsServices. 
        /// <para>
        ///  The target Amazon ECS services in the deployment group. This applies only to deployment
        /// groups that use the Amazon ECS compute platform. A target Amazon ECS service is specified
        /// as an Amazon ECS cluster and service name pair using the format <c>&lt;clustername&gt;:&lt;servicename&gt;</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ECSService> EcsServices
        {
            get { return this._ecsServices; }
            set { this._ecsServices = value; }
        }

        // Check to see if EcsServices property is set
        internal bool IsSetEcsServices()
        {
            return this._ecsServices != null && (this._ecsServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastAttemptedDeployment. 
        /// <para>
        /// Information about the most recent attempted deployment to the deployment group.
        /// </para>
        /// </summary>
        public LastDeploymentInfo LastAttemptedDeployment
        {
            get { return this._lastAttemptedDeployment; }
            set { this._lastAttemptedDeployment = value; }
        }

        // Check to see if LastAttemptedDeployment property is set
        internal bool IsSetLastAttemptedDeployment()
        {
            return this._lastAttemptedDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulDeployment. 
        /// <para>
        /// Information about the most recent successful deployment to the deployment group.
        /// </para>
        /// </summary>
        public LastDeploymentInfo LastSuccessfulDeployment
        {
            get { return this._lastSuccessfulDeployment; }
            set { this._lastSuccessfulDeployment = value; }
        }

        // Check to see if LastSuccessfulDeployment property is set
        internal bool IsSetLastSuccessfulDeployment()
        {
            return this._lastSuccessfulDeployment != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerInfo. 
        /// <para>
        /// Information about the load balancer to use in a deployment.
        /// </para>
        /// </summary>
        public LoadBalancerInfo LoadBalancerInfo
        {
            get { return this._loadBalancerInfo; }
            set { this._loadBalancerInfo = value; }
        }

        // Check to see if LoadBalancerInfo property is set
        internal bool IsSetLoadBalancerInfo()
        {
            return this._loadBalancerInfo != null;
        }

        /// <summary>
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The on-premises instance tags on which to filter. The deployment group includes on-premises
        /// instances with any of the specified tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagFilter> OnPremisesInstanceTagFilters
        {
            get { return this._onPremisesInstanceTagFilters; }
            set { this._onPremisesInstanceTagFilters = value; }
        }

        // Check to see if OnPremisesInstanceTagFilters property is set
        internal bool IsSetOnPremisesInstanceTagFilters()
        {
            return this._onPremisesInstanceTagFilters != null && (this._onPremisesInstanceTagFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnPremisesTagSet. 
        /// <para>
        /// Information about groups of tags applied to an on-premises instance. The deployment
        /// group includes only on-premises instances identified by all the tag groups. Cannot
        /// be used in the same call as onPremisesInstanceTagFilters.
        /// </para>
        /// </summary>
        public OnPremisesTagSet OnPremisesTagSet
        {
            get { return this._onPremisesTagSet; }
            set { this._onPremisesTagSet = value; }
        }

        // Check to see if OnPremisesTagSet property is set
        internal bool IsSetOnPremisesTagSet()
        {
            return this._onPremisesTagSet != null;
        }

        /// <summary>
        /// Gets and sets the property OutdatedInstancesStrategy. 
        /// <para>
        /// Indicates what happens when new Amazon EC2 instances are launched mid-deployment and
        /// do not receive the deployed application revision.
        /// </para>
        ///  
        /// <para>
        /// If this option is set to <c>UPDATE</c> or is unspecified, CodeDeploy initiates one
        /// or more 'auto-update outdated instances' deployments to apply the deployed application
        /// revision to the new Amazon EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// If this option is set to <c>IGNORE</c>, CodeDeploy does not initiate a deployment
        /// to update the new Amazon EC2 instances. This may result in instances having different
        /// revisions.
        /// </para>
        /// </summary>
        public OutdatedInstancesStrategy OutdatedInstancesStrategy
        {
            get { return this._outdatedInstancesStrategy; }
            set { this._outdatedInstancesStrategy = value; }
        }

        // Check to see if OutdatedInstancesStrategy property is set
        internal bool IsSetOutdatedInstancesStrategy()
        {
            return this._outdatedInstancesStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// A service role Amazon Resource Name (ARN) that grants CodeDeploy permission to make
        /// calls to Amazon Web Services services on your behalf. For more information, see <a
        /// href="https://docs.aws.amazon.com/codedeploy/latest/userguide/getting-started-create-service-role.html">Create
        /// a Service Role for CodeDeploy</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRevision. 
        /// <para>
        /// Information about the deployment group's target revision, including type and location.
        /// </para>
        /// </summary>
        public RevisionLocation TargetRevision
        {
            get { return this._targetRevision; }
            set { this._targetRevision = value; }
        }

        // Check to see if TargetRevision property is set
        internal bool IsSetTargetRevision()
        {
            return this._targetRevision != null;
        }

        /// <summary>
        /// Gets and sets the property TerminationHookEnabled. 
        /// <para>
        /// Indicates whether the deployment group was configured to have CodeDeploy install a
        /// termination hook into an Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information about the termination hook, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/integrations-aws-auto-scaling.html#integrations-aws-auto-scaling-behaviors">How
        /// Amazon EC2 Auto Scaling works with CodeDeploy</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public bool? TerminationHookEnabled
        {
            get { return this._terminationHookEnabled; }
            set { this._terminationHookEnabled = value; }
        }

        // Check to see if TerminationHookEnabled property is set
        internal bool IsSetTerminationHookEnabled()
        {
            return this._terminationHookEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers associated with the deployment group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TriggerConfig> TriggerConfigurations
        {
            get { return this._triggerConfigurations; }
            set { this._triggerConfigurations = value; }
        }

        // Check to see if TriggerConfigurations property is set
        internal bool IsSetTriggerConfigurations()
        {
            return this._triggerConfigurations != null && (this._triggerConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}