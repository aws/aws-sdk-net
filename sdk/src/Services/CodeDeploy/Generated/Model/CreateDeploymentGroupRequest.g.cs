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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeploymentGroup operation. Creates a deployment
    /// group to which application revisions are deployed.
    /// </summary>
    public partial class CreateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// Information to add about Amazon CloudWatch alarms when the deployment group is created.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an CodeDeploy application associated with the user or Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property AutoRollbackConfiguration. 
        /// <para>
        /// Configuration information for an automatic rollback that is added when a deployment
        /// group is created.
        /// </para>
        /// </summary>
        public AutoRollbackConfiguration AutoRollbackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoRollbackConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoRollbackConfiguration() => this.AutoRollbackConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroups. 
        /// <para>
        /// A list of associated Amazon EC2 Auto Scaling groups.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoScalingGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoScalingGroups property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroups() => this.AutoScalingGroups != null && (this.AutoScalingGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BlueGreenDeploymentConfiguration. 
        /// <para>
        /// Information about blue/green deployment options for a deployment group.
        /// </para>
        /// </summary>
        public BlueGreenDeploymentConfiguration BlueGreenDeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BlueGreenDeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetBlueGreenDeploymentConfiguration() => this.BlueGreenDeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// If specified, the deployment configuration name can be either one of the predefined
        /// configurations provided with CodeDeploy or a custom deployment configuration that
        /// you create by calling the create deployment configuration operation.
        /// </para>
        ///  
        /// <para>
        ///  <c>CodeDeployDefault.OneAtATime</c> is the default deployment configuration. It is
        /// used if a configuration isn't specified for the deployment or deployment group.
        /// </para>
        ///  
        /// <para>
        /// For more information about the predefined deployment configurations in CodeDeploy,
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/deployment-configurations.html">Working
        /// with Deployment Configurations in CodeDeploy</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DeploymentConfigName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfigName property is set.
        /// </summary>
        internal bool IsSetDeploymentConfigName() => this.DeploymentConfigName != null;

        /// <summary>
        /// Gets and sets the property DeploymentGroupName. 
        /// <para>
        /// The name of a new deployment group for the specified application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DeploymentGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentGroupName property is set.
        /// </summary>
        internal bool IsSetDeploymentGroupName() => this.DeploymentGroupName != null;

        /// <summary>
        /// Gets and sets the property DeploymentStyle. 
        /// <para>
        /// Information about the type of deployment, in-place or blue/green, that you want to
        /// run and whether to route deployment traffic behind a load balancer.
        /// </para>
        /// </summary>
        public DeploymentStyle DeploymentStyle { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStyle property is set.
        /// </summary>
        internal bool IsSetDeploymentStyle() => this.DeploymentStyle != null;

        /// <summary>
        /// Gets and sets the property Ec2DeploymentOptions.
        /// </summary>
        public EC2DeploymentOptions Ec2DeploymentOptions { get; set; }

        /// <summary>
        /// Checks to see if the Ec2DeploymentOptions property is set.
        /// </summary>
        internal bool IsSetEc2DeploymentOptions() => this.Ec2DeploymentOptions != null;

        /// <summary>
        /// Gets and sets the property Ec2TagFilters. 
        /// <para>
        /// The Amazon EC2 tags on which to filter. The deployment group includes Amazon EC2 instances
        /// with any of the specified tags. Cannot be used in the same call as ec2TagSet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2TagFilter> Ec2TagFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<EC2TagFilter>() : null;

        /// <summary>
        /// Checks to see if the Ec2TagFilters property is set.
        /// </summary>
        internal bool IsSetEc2TagFilters() => this.Ec2TagFilters != null && (this.Ec2TagFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Ec2TagSet. 
        /// <para>
        /// Information about groups of tags applied to Amazon EC2 instances. The deployment group
        /// includes only Amazon EC2 instances identified by all the tag groups. Cannot be used
        /// in the same call as <c>ec2TagFilters</c>.
        /// </para>
        /// </summary>
        public EC2TagSet Ec2TagSet { get; set; }

        /// <summary>
        /// Checks to see if the Ec2TagSet property is set.
        /// </summary>
        internal bool IsSetEc2TagSet() => this.Ec2TagSet != null;

        /// <summary>
        /// Gets and sets the property EcsServices. 
        /// <para>
        ///  The target Amazon ECS services in the deployment group. This applies only to deployment
        /// groups that use the Amazon ECS compute platform. A target Amazon ECS service is specified
        /// as an Amazon ECS cluster and service name pair using the format <c>&lt;clustername&gt;:&lt;servicename&gt;</c>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ECSService> EcsServices { get; set; } = AWSConfigs.InitializeCollections ? new List<ECSService>() : null;

        /// <summary>
        /// Checks to see if the EcsServices property is set.
        /// </summary>
        internal bool IsSetEcsServices() => this.EcsServices != null && (this.EcsServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LoadBalancerInfo. 
        /// <para>
        /// Information about the load balancer used in a deployment.
        /// </para>
        /// </summary>
        public LoadBalancerInfo LoadBalancerInfo { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerInfo property is set.
        /// </summary>
        internal bool IsSetLoadBalancerInfo() => this.LoadBalancerInfo != null;

        /// <summary>
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The on-premises instance tags on which to filter. The deployment group includes on-premises
        /// instances with any of the specified tags. Cannot be used in the same call as <c>OnPremisesTagSet</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagFilter> OnPremisesInstanceTagFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Checks to see if the OnPremisesInstanceTagFilters property is set.
        /// </summary>
        internal bool IsSetOnPremisesInstanceTagFilters() => this.OnPremisesInstanceTagFilters != null && (this.OnPremisesInstanceTagFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OnPremisesTagSet. 
        /// <para>
        /// Information about groups of tags applied to on-premises instances. The deployment
        /// group includes only on-premises instances identified by all of the tag groups. Cannot
        /// be used in the same call as <c>onPremisesInstanceTagFilters</c>.
        /// </para>
        /// </summary>
        public OnPremisesTagSet OnPremisesTagSet { get; set; }

        /// <summary>
        /// Checks to see if the OnPremisesTagSet property is set.
        /// </summary>
        internal bool IsSetOnPremisesTagSet() => this.OnPremisesTagSet != null;

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
        public OutdatedInstancesStrategy OutdatedInstancesStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OutdatedInstancesStrategy property is set.
        /// </summary>
        internal bool IsSetOutdatedInstancesStrategy() => this.OutdatedInstancesStrategy != null;

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// A service role Amazon Resource Name (ARN) that allows CodeDeploy to act on the user's
        /// behalf when interacting with Amazon Web Services services.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceRoleArn() => this.ServiceRoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The metadata that you apply to CodeDeploy deployment groups to help you organize
        /// and categorize them. Each tag consists of a key and an optional value, both of which
        /// you define. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminationHookEnabled. 
        /// <para>
        /// This parameter only applies if you are using CodeDeploy with Amazon EC2 Auto Scaling.
        /// For more information, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/integrations-aws-auto-scaling.html">Integrating
        /// CodeDeploy with Amazon EC2 Auto Scaling</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Set <c>terminationHookEnabled</c> to <c>true</c> to have CodeDeploy install a termination
        /// hook into your Auto Scaling group when you create a deployment group. When this hook
        /// is installed, CodeDeploy will perform termination deployments.
        /// </para>
        ///  
        /// <para>
        /// For information about termination deployments, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/integrations-aws-auto-scaling.html#integrations-aws-auto-scaling-behaviors-hook-enable">Enabling
        /// termination deployments during Auto Scaling scale-in events</a> in the <i>CodeDeploy
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about Auto Scaling scale-in events, see the <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-lifecycle.html#as-lifecycle-scale-in">Scale
        /// in</a> topic in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? TerminationHookEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TerminationHookEnabled property is set.
        /// </summary>
        internal bool IsSetTerminationHookEnabled() => this.TerminationHookEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TriggerConfigurations. 
        /// <para>
        /// Information about triggers to create when the deployment group is created. For examples,
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/how-to-notify-sns.html">Create
        /// a Trigger for an CodeDeploy Event</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TriggerConfig> TriggerConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<TriggerConfig>() : null;

        /// <summary>
        /// Checks to see if the TriggerConfigurations property is set.
        /// </summary>
        internal bool IsSetTriggerConfigurations() => this.TriggerConfigurations != null && (this.TriggerConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
