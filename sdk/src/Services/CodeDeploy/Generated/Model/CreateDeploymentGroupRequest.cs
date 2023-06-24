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
    /// Container for the parameters to the CreateDeploymentGroup operation.
    /// Creates a deployment group to which application revisions are deployed.
    /// </summary>
    public partial class CreateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private string _applicationName;
        private AutoRollbackConfiguration _autoRollbackConfiguration;
        private List<string> _autoScalingGroups = new List<string>();
        private BlueGreenDeploymentConfiguration _blueGreenDeploymentConfiguration;
        private string _deploymentConfigName;
        private string _deploymentGroupName;
        private DeploymentStyle _deploymentStyle;
        private List<EC2TagFilter> _ec2TagFilters = new List<EC2TagFilter>();
        private EC2TagSet _ec2TagSet;
        private List<ECSService> _ecsServices = new List<ECSService>();
        private LoadBalancerInfo _loadBalancerInfo;
        private List<TagFilter> _onPremisesInstanceTagFilters = new List<TagFilter>();
        private OnPremisesTagSet _onPremisesTagSet;
        private OutdatedInstancesStrategy _outdatedInstancesStrategy;
        private string _serviceRoleArn;
        private List<Tag> _tags = new List<Tag>();
        private List<TriggerConfig> _triggerConfigurations = new List<TriggerConfig>();

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// Information to add about Amazon CloudWatch alarms when the deployment group is created.
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
        /// The name of an CodeDeploy application associated with the IAM user or Amazon Web Services
        /// account.
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
        /// Configuration information for an automatic rollback that is added when a deployment
        /// group is created.
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
        /// A list of associated Amazon EC2 Auto Scaling groups.
        /// </para>
        /// </summary>
        public List<string> AutoScalingGroups
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
        /// If specified, the deployment configuration name can be either one of the predefined
        /// configurations provided with CodeDeploy or a custom deployment configuration that
        /// you create by calling the create deployment configuration operation.
        /// </para>
        ///  
        /// <para>
        ///  <code>CodeDeployDefault.OneAtATime</code> is the default deployment configuration.
        /// It is used if a configuration isn't specified for the deployment or deployment group.
        /// </para>
        ///  
        /// <para>
        /// For more information about the predefined deployment configurations in CodeDeploy,
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/deployment-configurations.html">Working
        /// with Deployment Configurations in CodeDeploy</a> in the <i>CodeDeploy User Guide</i>.
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
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The name of a new deployment group for the specified application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Information about the type of deployment, in-place or blue/green, that you want to
        /// run and whether to route deployment traffic behind a load balancer.
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
        /// The Amazon EC2 tags on which to filter. The deployment group includes Amazon EC2 instances
        /// with any of the specified tags. Cannot be used in the same call as ec2TagSet.
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
        /// Information about groups of tags applied to Amazon EC2 instances. The deployment group
        /// includes only Amazon EC2 instances identified by all the tag groups. Cannot be used
        /// in the same call as <code>ec2TagFilters</code>.
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
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The on-premises instance tags on which to filter. The deployment group includes on-premises
        /// instances with any of the specified tags. Cannot be used in the same call as <code>OnPremisesTagSet</code>.
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
        /// Information about groups of tags applied to on-premises instances. The deployment
        /// group includes only on-premises instances identified by all of the tag groups. Cannot
        /// be used in the same call as <code>onPremisesInstanceTagFilters</code>.
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
        /// A service role Amazon Resource Name (ARN) that allows CodeDeploy to act on the user's
        /// behalf when interacting with Amazon Web Services services.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The metadata that you apply to CodeDeploy deployment groups to help you organize
        /// and categorize them. Each tag consists of a key and an optional value, both of which
        /// you define. 
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers to create when the deployment group is created. For examples,
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/how-to-notify-sns.html">Create
        /// a Trigger for an CodeDeploy Event</a> in the <i>CodeDeploy User Guide</i>.
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