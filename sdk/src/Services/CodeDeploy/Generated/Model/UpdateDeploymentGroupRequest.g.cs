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
    /// Container for the parameters to the UpdateDeploymentGroup operation. Changes information
    /// about a deployment group.
    /// </summary>
    public partial class UpdateDeploymentGroupRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// Information to add or change about Amazon CloudWatch alarms when the deployment group
        /// is updated.
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
        /// The application name that corresponds to the deployment group to update.
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
        /// Information for an automatic rollback configuration that is added or changed when
        /// a deployment group is updated.
        /// </para>
        /// </summary>
        public AutoRollbackConfiguration AutoRollbackConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoRollbackConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoRollbackConfiguration() => this.AutoRollbackConfiguration != null;

        private List<string> _AutoScalingGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/troubleshooting-auto-scaling.html#troubleshooting-auto-scaling-heartbeat">Amazon
        /// EC2 instances in an Amazon EC2 Auto Scaling group fail to launch and receive the error
        /// "Heartbeat Timeout"</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoScalingGroups { get => this._AutoScalingGroups; set => this._AutoScalingGroups = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="AutoScalingGroups"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="AutoScalingGroups"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsAutoScalingGroupsSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._AutoScalingGroups);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._AutoScalingGroups);
        }

        /// <summary>
        /// Checks to see if the AutoScalingGroups property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroups() => this.IsAutoScalingGroupsSet;

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
        /// Gets and sets the property CurrentDeploymentGroupName. 
        /// <para>
        /// The current name of the deployment group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string CurrentDeploymentGroupName { get; set; }

        /// <summary>
        /// Checks to see if the CurrentDeploymentGroupName property is set.
        /// </summary>
        internal bool IsSetCurrentDeploymentGroupName() => this.CurrentDeploymentGroupName != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfigName. 
        /// <para>
        /// The replacement deployment configuration name to use, if you want to change it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DeploymentConfigName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfigName property is set.
        /// </summary>
        internal bool IsSetDeploymentConfigName() => this.DeploymentConfigName != null;

        /// <summary>
        /// Gets and sets the property DeploymentStyle. 
        /// <para>
        /// Information about the type of deployment, either in-place or blue/green, you want
        /// to run and whether to route deployment traffic behind a load balancer.
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
        /// The replacement set of Amazon EC2 tags on which to filter, if you want to change them.
        /// To keep the existing tags, enter their names. To remove tags, do not enter any tag
        /// names.
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
        /// Information about groups of tags applied to on-premises instances. The deployment
        /// group includes only Amazon EC2 instances identified by all the tag groups.
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
        /// Gets and sets the property NewDeploymentGroupName. 
        /// <para>
        /// The new name of the deployment group, if you want to change it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string NewDeploymentGroupName { get; set; }

        /// <summary>
        /// Checks to see if the NewDeploymentGroupName property is set.
        /// </summary>
        internal bool IsSetNewDeploymentGroupName() => this.NewDeploymentGroupName != null;

        /// <summary>
        /// Gets and sets the property OnPremisesInstanceTagFilters. 
        /// <para>
        /// The replacement set of on-premises instance tags on which to filter, if you want to
        /// change them. To keep the existing tags, enter their names. To remove tags, do not
        /// enter any tag names.
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
        /// Information about an on-premises instance tag set. The deployment group includes only
        /// on-premises instances identified by all the tag groups.
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
        /// A replacement ARN for the service role, if you want to change it.
        /// </para>
        /// </summary>
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceRoleArn() => this.ServiceRoleArn != null;

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
        /// hook into your Auto Scaling group when you update a deployment group. When this hook
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
        /// Information about triggers to change when the deployment group is updated. For examples,
        /// see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/how-to-notify-edit.html">Edit
        /// a Trigger in a CodeDeploy Deployment Group</a> in the <i>CodeDeploy User Guide</i>.
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
