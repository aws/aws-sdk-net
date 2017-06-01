/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private List<AutoScalingGroup> _autoScalingGroups = new List<AutoScalingGroup>();
        private BlueGreenDeploymentConfiguration _blueGreenDeploymentConfiguration;
        private string _deploymentConfigName;
        private string _deploymentGroupId;
        private string _deploymentGroupName;
        private DeploymentStyle _deploymentStyle;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private LastDeploymentInfo _lastAttemptedDeployment;
        private LastDeploymentInfo _lastSuccessfulDeployment;
        private LoadBalancerInfo _loadBalancerInfo;
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private string _serviceRoleArn;
        private RevisionLocation _targetRevision;
        private List<TriggerConfig> _triggerConfigurations = new List<TriggerConfig>();

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
        /// </summary>
        public List<AutoScalingGroup> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this._autoScalingGroups != null && this._autoScalingGroups.Count > 0; 
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
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The deployment configuration name.
        /// </para>
        /// </summary>
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
        /// The Amazon EC2 tags on which to filter.
        /// </para>
        /// </summary>
        public List<EC2TagFilter> Ec2TagFilters
        {
            get { return this._ec2TagFilters; }
            set { this._ec2TagFilters = value; }
        }

        // Check to see if Ec2TagFilters property is set
        internal bool IsSetEc2TagFilters()
        {
            return this._ec2TagFilters != null && this._ec2TagFilters.Count > 0; 
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
        /// The on-premises instance tags on which to filter.
        /// </para>
        /// </summary>
        public List<TagFilter> OnPremisesInstanceTagFilters
        {
            get { return this._onPremisesInstanceTagFilters; }
            set { this._onPremisesInstanceTagFilters = value; }
        }

        // Check to see if OnPremisesInstanceTagFilters property is set
        internal bool IsSetOnPremisesInstanceTagFilters()
        {
            return this._onPremisesInstanceTagFilters != null && this._onPremisesInstanceTagFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// A service role ARN.
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
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers associated with the deployment group.
        /// </para>
        /// </summary>
        public List<TriggerConfig> TriggerConfigurations
        {
            get { return this._triggerConfigurations; }
            set { this._triggerConfigurations = value; }
        }

        // Check to see if TriggerConfigurations property is set
        internal bool IsSetTriggerConfigurations()
        {
            return this._triggerConfigurations != null && this._triggerConfigurations.Count > 0; 
        }

    }
}