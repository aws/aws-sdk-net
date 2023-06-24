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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDeploymentGroup operation.
    /// Changes information about a deployment group.
    /// </summary>
    public partial class UpdateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private string _applicationName;
        private AutoRollbackConfiguration _autoRollbackConfiguration;
        private List<string> _autoScalingGroups = new List<string>();
        private BlueGreenDeploymentConfiguration _blueGreenDeploymentConfiguration;
        private string _currentDeploymentGroupName;
        private string _deploymentConfigName;
        private DeploymentStyle _deploymentStyle;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private EC2TagSet _ec2TagSet;
        private List<ECSService> _ecsServices = new List<ECSService>();
        private LoadBalancerInfo _loadBalancerInfo;
        private string _newDeploymentGroupName;
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private OnPremisesTagSet _onPremisesTagSet;
        private OutdatedInstancesStrategy _outdatedInstancesStrategy;
        private string _serviceRoleArn;
        private List<TriggerConfig> _triggerConfigurations = new List<TriggerConfig>();

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// Information to add or change about Amazon CloudWatch alarms when the deployment group
        /// is updated.
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
        /// The application name that corresponds to the deployment group to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Information for an automatic rollback configuration that is added or changed when
        /// a deployment group is updated.
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
        /// The replacement list of Auto Scaling groups to be included in the deployment group,
        /// if you want to change them.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To keep the Auto Scaling groups, enter their names or do not specify this parameter.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove Auto Scaling groups, specify a non-null empty list of Auto Scaling group
        /// names to detach all CodeDeploy-managed Auto Scaling lifecycle hooks. For examples,
        /// see <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/codedeploy/latest/userguide/troubleshooting-auto-scaling.html#troubleshooting-auto-scaling-heartbeat">Amazon
        /// EC2 instances in an Amazon EC2 Auto Scaling group fail to launch and receive the error
        /// "Heartbeat Timeout"</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> AutoScalingGroups
        {
            get { return this._autoScalingGroups; }
            set { this._autoScalingGroups = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="AutoScalingGroups"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsAutoScalingGroupsSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._autoScalingGroups);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._autoScalingGroups);
            }
        }

        // Check to see if AutoScalingGroups property is set
        internal bool IsSetAutoScalingGroups()
        {
            return this.IsAutoScalingGroupsSet; 
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
        /// Gets and sets the property CurrentDeploymentGroupName. 
        /// <para>
        /// The current name of the deployment group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string CurrentDeploymentGroupName
        {
            get { return this._currentDeploymentGroupName; }
            set { this._currentDeploymentGroupName = value; }
        }

        // Check to see if CurrentDeploymentGroupName property is set
        internal bool IsSetCurrentDeploymentGroupName()
        {
            return this._currentDeploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The replacement deployment configuration name to use, if you want to change it.
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
        /// The replacement set of Amazon EC2 tags on which to filter, if you want to change them.
        /// To keep the existing tags, enter their names. To remove tags, do not enter any tag
        /// names.
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
        /// Gets and sets the property Ec2TagSet. 
        /// <para>
        /// Information about groups of tags applied to on-premises instances. The deployment
        /// group includes only Amazon EC2 instances identified by all the tag groups.
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
        /// as an Amazon ECS cluster and service name pair using the format <code>&lt;clustername&gt;:&lt;servicename&gt;</code>.
        /// 
        /// </para>
        /// </summary>
        public List<ECSService> EcsServices
        {
            get { return this._ecsServices; }
            set { this._ecsServices = value; }
        }

        // Check to see if EcsServices property is set
        internal bool IsSetEcsServices()
        {
            return this._ecsServices != null && this._ecsServices.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerInfo. 
        /// <para>
        /// Information about the load balancer used in a deployment.
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
        /// Gets and sets the property NewDeploymentGroupName. 
        /// <para>
        /// The new name of the deployment group, if you want to change it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string NewDeploymentGroupName
        {
            get { return this._newDeploymentGroupName; }
            set { this._newDeploymentGroupName = value; }
        }

        // Check to see if NewDeploymentGroupName property is set
        internal bool IsSetNewDeploymentGroupName()
        {
            return this._newDeploymentGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The replacement set of on-premises instance tags on which to filter, if you want to
        /// change them. To keep the existing tags, enter their names. To remove tags, do not
        /// enter any tag names.
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
        /// Gets and sets the property OnPremisesTagSet. 
        /// <para>
        /// Information about an on-premises instance tag set. The deployment group includes only
        /// on-premises instances identified by all the tag groups.
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
        /// If this option is set to <code>UPDATE</code> or is unspecified, CodeDeploy initiates
        /// one or more 'auto-update outdated instances' deployments to apply the deployed application
        /// revision to the new Amazon EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// If this option is set to <code>IGNORE</code>, CodeDeploy does not initiate a deployment
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
        /// A replacement ARN for the service role, if you want to change it.
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
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers to change when the deployment group is updated. For examples,
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/how-to-notify-edit.html">Edit
        /// a Trigger in a CodeDeploy Deployment Group</a> in the <i>CodeDeploy User Guide</i>.
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