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
    /// Creates an Auto Scaling group with the specified name and attributes. 
    /// 
    ///  
    /// <para>
    /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
    /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
    /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
    /// EC2 Auto Scaling Service Quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For introductory exercises for creating an Auto Scaling group, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/GettingStartedTutorial.html">Getting
    /// Started with Amazon EC2 Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-register-lbs-with-asg.html">Tutorial:
    /// Set Up a Scaled and Load-Balanced Application</a> in the <i>Amazon EC2 Auto Scaling
    /// User Guide</i>. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/AutoScalingGroup.html">Auto
    /// Scaling Groups</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// One or more Availability Zones for the group. This parameter is optional if you specify
        /// one or more subnets for <code>VPCZoneIdentifier</code>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: If your account supports EC2-Classic and VPC, this parameter is required
        /// to launch instances into EC2-Classic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scaling activity completes before another
        /// scaling activity can start. The default value is <code>300</code>.
        /// </para>
        ///  
        /// <para>
        /// This setting applies when using simple scaling policies, but not when using other
        /// scaling policies or scheduled scaling. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/Cooldown.html">Scaling
        /// Cooldowns for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// capacity if you configure automatic scaling.
        /// </para>
        ///  
        /// <para>
        /// This number must be greater than or equal to the minimum size of the group and less
        /// than or equal to the maximum size of the group. If you do not specify a desired capacity,
        /// the default is the minimum size of the group.
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
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html#health-check-grace-period">Health
        /// Check Grace Period</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Required if you are adding an <code>ELB</code> health check.
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
        /// The service to use for the health checks. The valid values are <code>EC2</code> and
        /// <code>ELB</code>. The default value is <code>EC2</code>. If you configure an Auto
        /// Scaling group to use ELB health checks, it considers the instance unhealthy if it
        /// fails either the EC2 status checks or the load balancer health checks.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/healthcheck.html">Health
        /// Checks for Auto Scaling Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// The ID of the instance used to create a launch configuration for the group. To get
        /// the instance ID, use the Amazon EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// When you specify an ID of an instance, Amazon EC2 Auto Scaling creates a new launch
        /// configuration and associates it with the group. This launch configuration derives
        /// its attributes from the specified instance, except for the block device mapping.
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the following parameters in your request: <code>LaunchConfigurationName</code>,
        /// <code>LaunchTemplate</code>, <code>InstanceId</code>, or <code>MixedInstancesPolicy</code>.
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
        /// The name of the launch configuration to use when an instance is launched. To get the
        /// launch configuration name, use the <a>DescribeLaunchConfigurations</a> API operation.
        /// New launch configurations can be created with the <a>CreateLaunchConfiguration</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the following parameters in your request: <code>LaunchConfigurationName</code>,
        /// <code>LaunchTemplate</code>, <code>InstanceId</code>, or <code>MixedInstancesPolicy</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Parameters used to specify the launch template and version to use when an instance
        /// is launched.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_LaunchTemplateSpecification.html">LaunchTemplateSpecification</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// You can alternatively associate a launch template to the Auto Scaling group by using
        /// the <code>MixedInstancesPolicy</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the following parameters in your request: <code>LaunchConfigurationName</code>,
        /// <code>LaunchTemplate</code>, <code>InstanceId</code>, or <code>MixedInstancesPolicy</code>.
        /// </para>
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
        /// One or more lifecycle hooks.
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
        /// Load Balancers and Network Load Balancers, specify a list of target groups using the
        /// <code>TargetGroupARNs</code> property instead.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Using
        /// a Load Balancer with an Auto Scaling Group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
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
        /// is null.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional, but if you specify a value for it, you must specify a
        /// value of at least 604,800 seconds (7 days). To clear a previously set value, specify
        /// a new value of 0.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-max-instance-lifetime.html">Replacing
        /// Auto Scaling Instances Based on Maximum Instance Lifetime</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 0.
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
        /// the Auto Scaling group allocates instance types to fulfill On-Demand and Spot capacity,
        /// but also the parameters that specify the instance configuration information—the launch
        /// template and instance types.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_MixedInstancesPolicy.html">MixedInstancesPolicy</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-purchase-options.html">Auto
        /// Scaling Groups with Multiple Instance Types and Purchase Options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the following parameters in your request: <code>LaunchConfigurationName</code>,
        /// <code>LaunchTemplate</code>, <code>InstanceId</code>, or <code>MixedInstancesPolicy</code>.
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
        /// EC2 Auto Scaling when scaling in.
        /// </para>
        ///  
        /// <para>
        /// For more information about preventing instances from terminating on scale in, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html#instance-protection">Instance
        /// Protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// The name of the placement group into which to launch your instances, if any. A placement
        /// group is a logical grouping of instances within a single Availability Zone. You cannot
        /// specify multiple Availability Zones and a placement group. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
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
        /// it does not exist. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-Linked
        /// Roles</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// Amazon EC2 instances it launches.
        /// </para>
        ///  
        /// <para>
        /// Tags are not propagated to Amazon EBS volumes. To add tags to Amazon EBS volumes,
        /// specify the tags in a launch template but use caution. If the launch template specifies
        /// an instance tag with a key that is also specified for the Auto Scaling group, Amazon
        /// EC2 Auto Scaling overrides the value of that instance tag with the value specified
        /// by the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-tagging.html">Tagging
        /// Auto Scaling Groups and Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// to the target group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Using
        /// a Load Balancer with an Auto Scaling Group</a> in the <i>Amazon EC2 Auto Scaling User
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
        /// One or more termination policies used to select the instance to terminate. These policies
        /// are executed in the order that they are listed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// Which Instances Auto Scaling Terminates During Scale In</a> in the <i>Amazon EC2 Auto
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
        /// A comma-separated list of subnet IDs for your virtual private cloud (VPC).
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>VPCZoneIdentifier</code> with <code>AvailabilityZones</code>,
        /// the subnets that you specify for this parameter must reside in those Availability
        /// Zones.
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