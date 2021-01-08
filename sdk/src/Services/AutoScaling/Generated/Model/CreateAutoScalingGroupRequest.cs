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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAutoScalingGroup operation.
    /// <b>We strongly recommend using a launch template when calling this operation to ensure
    /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
    /// 
    ///  
    /// <para>
    /// Creates an Auto Scaling group with the specified name and attributes. 
    /// </para>
    ///  
    /// <para>
    /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
    /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
    /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
    /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For introductory exercises for creating an Auto Scaling group, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/GettingStartedTutorial.html">Getting
    /// started with Amazon EC2 Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-register-lbs-with-asg.html">Tutorial:
    /// Set up a scaled and load-balanced application</a> in the <i>Amazon EC2 Auto Scaling
    /// User Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html">Auto
    /// Scaling groups</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Every Auto Scaling group has three size parameters (<code>DesiredCapacity</code>,
    /// <code>MaxSize</code>, and <code>MinSize</code>). Usually, you set these sizes based
    /// on a specific number of instances. However, if you configure a mixed instances policy
    /// that defines weights for the instance types, you must specify these sizes with the
    /// same units that you use for weighting instances.
    /// </para>
    /// </summary>
    public partial class CreateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _availabilityZones = new List<string>();
        private bool? _capacityRebalance;
        private int? _defaultCooldown;
        private int? _desiredCapacity;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private string _instanceId;
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private List<LifecycleHookSpecification> _lifecycleHookSpecificationList = new List<LifecycleHookSpecification>();
        private List<string> _loadBalancerNames = new List<string>();
        private int? _maxInstanceLifetime;
        private int? _maxSize;
        private int? _minSize;
        private MixedInstancesPolicy _mixedInstancesPolicy;
        private bool? _newInstancesProtectedFromScaleIn;
        private string _placementGroup;
        private string _serviceLinkedRoleARN;
        private List<Tag> _tags = new List<Tag>();
        private List<string> _targetGroupARNs = new List<string>();
        private List<string> _terminationPolicies = new List<string>();
        private string _vpcZoneIdentifier;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group. This name must be unique per Region per account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones where instances in the Auto Scaling group can be created.
        /// This parameter is optional if you specify one or more subnets for <code>VPCZoneIdentifier</code>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: If your account supports EC2-Classic and VPC, this parameter is required
        /// to launch instances into EC2-Classic.
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// Indicates whether Capacity Rebalancing is enabled. Otherwise, Capacity Rebalancing
        /// is disabled. When you turn on Capacity Rebalancing, Amazon EC2 Auto Scaling attempts
        /// to launch a Spot Instance whenever Amazon EC2 notifies that a Spot Instance is at
        /// an elevated risk of interruption. After launching a new instance, it then terminates
        /// an old instance. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/capacity-rebalance.html">Amazon
        /// EC2 Auto Scaling Capacity Rebalancing</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool CapacityRebalance
        {
            get { return this._capacityRebalance.GetValueOrDefault(); }
            set { this._capacityRebalance = value; }
        }

        // Check to see if CapacityRebalance property is set
        internal bool IsSetCapacityRebalance()
        {
            return this._capacityRebalance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scaling activity completes before another
        /// scaling activity can start. The default value is <code>300</code>. This setting applies
        /// when using simple scaling policies, but not when using other scaling policies or scheduled
        /// scaling. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/Cooldown.html">Scaling
        /// cooldowns for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int DefaultCooldown
        {
            get { return this._defaultCooldown.GetValueOrDefault(); }
            set { this._defaultCooldown = value; }
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this._defaultCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group at the time
        /// of its creation and the capacity it attempts to maintain. It can scale beyond this
        /// capacity if you configure auto scaling. This number must be greater than or equal
        /// to the minimum size of the group and less than or equal to the maximum size of the
        /// group. If you do not specify a desired capacity, the default is the minimum size of
        /// the group.
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking
        /// the health status of an EC2 instance that has come into service. During this time,
        /// any health check failures for the instance are ignored. The default value is <code>0</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html#health-check-grace-period">Health
        /// check grace period</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: Required if you are adding an <code>ELB</code> health check.
        /// </para>
        /// </summary>
        public int HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod.GetValueOrDefault(); }
            set { this._healthCheckGracePeriod = value; }
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this._healthCheckGracePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        /// The service to use for the health checks. The valid values are <code>EC2</code> (default)
        /// and <code>ELB</code>. If you configure an Auto Scaling group to use load balancer
        /// (ELB) health checks, it considers the instance unhealthy if it fails either the EC2
        /// status checks or the load balancer health checks. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// checks for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HealthCheckType
        {
            get { return this._healthCheckType; }
            set { this._healthCheckType = value; }
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this._healthCheckType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance used to base the launch configuration on. If specified, Amazon
        /// EC2 Auto Scaling uses the configuration values from the specified instance to create
        /// a new launch configuration. To get the instance ID, use the Amazon EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// API operation. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-asg-from-instance.html">Creating
        /// an Auto Scaling group using an EC2 instance</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration to use to launch instances. 
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either a launch template (<code>LaunchTemplate</code>
        /// or <code>MixedInstancesPolicy</code>) or a launch configuration (<code>LaunchConfigurationName</code>
        /// or <code>InstanceId</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// Parameters used to specify the launch template and version to use to launch instances.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either a launch template (<code>LaunchTemplate</code>
        /// or <code>MixedInstancesPolicy</code>) or a launch configuration (<code>LaunchConfigurationName</code>
        /// or <code>InstanceId</code>).
        /// </para>
        ///  <note> 
        /// <para>
        /// The launch template that is specified must be configured for use with an Auto Scaling
        /// group. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-template.html">Creating
        /// a launch template for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleHookSpecificationList. 
        /// <para>
        /// One or more lifecycle hooks for the group, which specify actions to perform when Amazon
        /// EC2 Auto Scaling launches or terminates instances.
        /// </para>
        /// </summary>
        public List<LifecycleHookSpecification> LifecycleHookSpecificationList
        {
            get { return this._lifecycleHookSpecificationList; }
            set { this._lifecycleHookSpecificationList = value; }
        }

        // Check to see if LifecycleHookSpecificationList property is set
        internal bool IsSetLifecycleHookSpecificationList()
        {
            return this._lifecycleHookSpecificationList != null && this._lifecycleHookSpecificationList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// A list of Classic Load Balancers associated with this Auto Scaling group. For Application
        /// Load Balancers, Network Load Balancers, and Gateway Load Balancers, specify the <code>TargetGroupARNs</code>
        /// property instead.
        /// </para>
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this._loadBalancerNames; }
            set { this._loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this._loadBalancerNames != null && this._loadBalancerNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxInstanceLifetime. 
        /// <para>
        /// The maximum amount of time, in seconds, that an instance can be in service. The default
        /// is null. If specified, the value must be either 0 or a number equal to or greater
        /// than 86,400 seconds (1 day). For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-max-instance-lifetime.html">Replacing
        /// Auto Scaling instances based on maximum instance lifetime</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int MaxInstanceLifetime
        {
            get { return this._maxInstanceLifetime.GetValueOrDefault(); }
            set { this._maxInstanceLifetime = value; }
        }

        // Check to see if MaxInstanceLifetime property is set
        internal bool IsSetMaxInstanceLifetime()
        {
            return this._maxInstanceLifetime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size of the group.
        /// </para>
        ///  <note> 
        /// <para>
        /// With a mixed instances policy that uses instance weighting, Amazon EC2 Auto Scaling
        /// may need to go above <code>MaxSize</code> to meet your capacity requirements. In this
        /// event, Amazon EC2 Auto Scaling will never go above <code>MaxSize</code> by more than
        /// your largest instance weight (weights that define how many units each instance contributes
        /// to the desired capacity of the group).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// An embedded object that specifies a mixed instances policy. The required parameters
        /// must be specified. If optional parameters are unspecified, their default values are
        /// used.
        /// </para>
        ///  
        /// <para>
        /// The policy includes parameters that not only define the distribution of On-Demand
        /// Instances and Spot Instances, the maximum price to pay for Spot Instances, and how
        /// the Auto Scaling group allocates instance types to fulfill On-Demand and Spot capacities,
        /// but also the parameters that specify the instance configuration information—the launch
        /// template and instance types. The policy can also include a weight for each instance
        /// type and different launch templates for individual instance types. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-purchase-options.html">Auto
        /// Scaling groups with multiple instance types and purchase options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public MixedInstancesPolicy MixedInstancesPolicy
        {
            get { return this._mixedInstancesPolicy; }
            set { this._mixedInstancesPolicy = value; }
        }

        // Check to see if MixedInstancesPolicy property is set
        internal bool IsSetMixedInstancesPolicy()
        {
            return this._mixedInstancesPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property NewInstancesProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether newly launched instances are protected from termination by Amazon
        /// EC2 Auto Scaling when scaling in. For more information about preventing instances
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool NewInstancesProtectedFromScaleIn
        {
            get { return this._newInstancesProtectedFromScaleIn.GetValueOrDefault(); }
            set { this._newInstancesProtectedFromScaleIn = value; }
        }

        // Check to see if NewInstancesProtectedFromScaleIn property is set
        internal bool IsSetNewInstancesProtectedFromScaleIn()
        {
            return this._newInstancesProtectedFromScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// The name of an existing placement group into which to launch your instances, if any.
        /// A placement group is a logical grouping of instances within a single Availability
        /// Zone. You cannot specify multiple Availability Zones and a placement group. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceLinkedRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other AWS services on your behalf. By default, Amazon EC2 Auto Scaling
        /// uses a service-linked role named AWSServiceRoleForAutoScaling, which it creates if
        /// it does not exist. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-linked
        /// roles</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ServiceLinkedRoleARN
        {
            get { return this._serviceLinkedRoleARN; }
            set { this._serviceLinkedRoleARN = value; }
        }

        // Check to see if ServiceLinkedRoleARN property is set
        internal bool IsSetServiceLinkedRoleARN()
        {
            return this._serviceLinkedRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. You can tag your Auto Scaling group and propagate the tags to the
        /// Amazon EC2 instances it launches. Tags are not propagated to Amazon EBS volumes. To
        /// add tags to Amazon EBS volumes, specify the tags in a launch template but use caution.
        /// If the launch template specifies an instance tag with a key that is also specified
        /// for the Auto Scaling group, Amazon EC2 Auto Scaling overrides the value of that instance
        /// tag with the value specified by the Auto Scaling group. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// Gets and sets the property TargetGroupARNs. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the target groups to associate with the Auto Scaling
        /// group. Instances are registered as targets in a target group, and traffic is routed
        /// to the target group. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Elastic
        /// Load Balancing and Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public List<string> TargetGroupARNs
        {
            get { return this._targetGroupARNs; }
            set { this._targetGroupARNs = value; }
        }

        // Check to see if TargetGroupARNs property is set
        internal bool IsSetTargetGroupARNs()
        {
            return this._targetGroupARNs != null && this._targetGroupARNs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        /// A policy or a list of policies that are used to select the instance to terminate.
        /// These policies are executed in the order that you list them. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// which Auto Scaling instances terminate during scale in</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this._terminationPolicies; }
            set { this._terminationPolicies = value; }
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this._terminationPolicies != null && this._terminationPolicies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// A comma-separated list of subnet IDs for a virtual private cloud (VPC) where instances
        /// in the Auto Scaling group can be created. If you specify <code>VPCZoneIdentifier</code>
        /// with <code>AvailabilityZones</code>, the subnets that you specify for this parameter
        /// must reside in those Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// Conditional: If your account supports EC2-Classic and VPC, this parameter is required
        /// to launch instances into a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2047)]
        public string VPCZoneIdentifier
        {
            get { return this._vpcZoneIdentifier; }
            set { this._vpcZoneIdentifier = value; }
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this._vpcZoneIdentifier != null;
        }

    }
}