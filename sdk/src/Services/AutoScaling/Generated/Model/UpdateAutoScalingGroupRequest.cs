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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutoScalingGroup operation.
    /// <b>We strongly recommend that all Auto Scaling groups use launch templates to ensure
    /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
    /// 
    ///  
    /// <para>
    /// Updates the configuration for the specified Auto Scaling group.
    /// </para>
    ///  
    /// <para>
    /// To update an Auto Scaling group, specify the name of the group and the property that
    /// you want to change. Any properties that you don't specify are not changed by this
    /// update request. The new settings take effect on any scaling activities after this
    /// call returns. 
    /// </para>
    ///  
    /// <para>
    /// If you associate a new launch configuration or template with an Auto Scaling group,
    /// all new instances will get the updated configuration. Existing instances continue
    /// to run with the configuration that they were originally launched with. When you update
    /// a group to specify a mixed instances policy instead of a launch configuration or template,
    /// existing instances may be replaced to match the new purchasing options that you specified
    /// in the policy. For example, if the group currently has 100% On-Demand capacity and
    /// the policy specifies 50% Spot capacity, this means that half of your instances will
    /// be gradually terminated and relaunched as Spot Instances. When replacing instances,
    /// Amazon EC2 Auto Scaling launches new instances before terminating the old ones, so
    /// that updating your group does not compromise the performance or availability of your
    /// application.
    /// </para>
    ///  
    /// <para>
    /// Note the following about changing <c>DesiredCapacity</c>, <c>MaxSize</c>, or <c>MinSize</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If a scale-in activity occurs as a result of a new <c>DesiredCapacity</c> value that
    /// is lower than the current size of the group, the Auto Scaling group uses its termination
    /// policy to determine which instances to terminate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you specify a new value for <c>MinSize</c> without specifying a value for <c>DesiredCapacity</c>,
    /// and the new <c>MinSize</c> is larger than the current size of the group, this sets
    /// the group's <c>DesiredCapacity</c> to the new <c>MinSize</c> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you specify a new value for <c>MaxSize</c> without specifying a value for <c>DesiredCapacity</c>,
    /// and the new <c>MaxSize</c> is smaller than the current size of the group, this sets
    /// the group's <c>DesiredCapacity</c> to the new <c>MaxSize</c> value.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To see which properties have been set, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAutoScalingGroups.html">DescribeAutoScalingGroups</a>
    /// API. To view the scaling policies for an Auto Scaling group, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribePolicies.html">DescribePolicies</a>
    /// API. If the group has scaling policies, you can update them by calling the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_PutScalingPolicy.html">PutScalingPolicy</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class UpdateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private AvailabilityZoneDistribution _availabilityZoneDistribution;
        private AvailabilityZoneImpairmentPolicy _availabilityZoneImpairmentPolicy;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _capacityRebalance;
        private CapacityReservationSpecification _capacityReservationSpecification;
        private string _context;
        private int? _defaultCooldown;
        private int? _defaultInstanceWarmup;
        private int? _desiredCapacity;
        private string _desiredCapacityType;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private InstanceMaintenancePolicy _instanceMaintenancePolicy;
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private int? _maxInstanceLifetime;
        private int? _maxSize;
        private int? _minSize;
        private MixedInstancesPolicy _mixedInstancesPolicy;
        private bool? _newInstancesProtectedFromScaleIn;
        private string _placementGroup;
        private string _serviceLinkedRoleARN;
        private bool? _skipZonalShiftValidation;
        private List<string> _terminationPolicies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcZoneIdentifier;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
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
        /// Gets and sets the property AvailabilityZoneDistribution. 
        /// <para>
        ///  The instance capacity distribution across Availability Zones. 
        /// </para>
        /// </summary>
        public AvailabilityZoneDistribution AvailabilityZoneDistribution
        {
            get { return this._availabilityZoneDistribution; }
            set { this._availabilityZoneDistribution = value; }
        }

        // Check to see if AvailabilityZoneDistribution property is set
        internal bool IsSetAvailabilityZoneDistribution()
        {
            return this._availabilityZoneDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneImpairmentPolicy. 
        /// <para>
        ///  The policy for Availability Zone impairment. 
        /// </para>
        /// </summary>
        public AvailabilityZoneImpairmentPolicy AvailabilityZoneImpairmentPolicy
        {
            get { return this._availabilityZoneImpairmentPolicy; }
            set { this._availabilityZoneImpairmentPolicy = value; }
        }

        // Check to see if AvailabilityZoneImpairmentPolicy property is set
        internal bool IsSetAvailabilityZoneImpairmentPolicy()
        {
            return this._availabilityZoneImpairmentPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones for the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// Enables or disables Capacity Rebalancing. If Capacity Rebalancing is disabled, proactive
        /// replacement of at-risk Spot Instances does not occur. For more information, see <a
        /// href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-capacity-rebalancing.html">Capacity
        /// Rebalancing in Auto Scaling to replace at-risk Spot Instances</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To suspend rebalancing across Availability Zones, use the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_SuspendedProcess.html">SuspendProcesses</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? CapacityRebalance
        {
            get { return this._capacityRebalance; }
            set { this._capacityRebalance = value; }
        }

        // Check to see if CapacityRebalance property is set
        internal bool IsSetCapacityRebalance()
        {
            return this._capacityRebalance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        ///  The capacity reservation specification for the Auto Scaling group. 
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification
        {
            get { return this._capacityReservationSpecification; }
            set { this._capacityReservationSpecification = value; }
        }

        // Check to see if CapacityReservationSpecification property is set
        internal bool IsSetCapacityReservationSpecification()
        {
            return this._capacityReservationSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        ///  <i>Only needed if you use simple scaling policies.</i> 
        /// </para>
        ///  
        /// <para>
        /// The amount of time, in seconds, between one scaling activity ending and another one
        /// starting due to simple scaling policies. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-scaling-cooldowns.html">Scaling
        /// cooldowns for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? DefaultCooldown
        {
            get { return this._defaultCooldown; }
            set { this._defaultCooldown = value; }
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this._defaultCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultInstanceWarmup. 
        /// <para>
        /// The amount of time, in seconds, until a new instance is considered to have finished
        /// initializing and resource consumption to become stable after it enters the <c>InService</c>
        /// state. 
        /// </para>
        ///  
        /// <para>
        /// During an instance refresh, Amazon EC2 Auto Scaling waits for the warm-up period after
        /// it replaces an instance before it moves on to replacing the next instance. Amazon
        /// EC2 Auto Scaling also waits for the warm-up period before aggregating the metrics
        /// for new instances with existing instances in the Amazon CloudWatch metrics that are
        /// used for scaling, resulting in more reliable usage data. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-default-instance-warmup.html">Set
        /// the default instance warmup for an Auto Scaling group</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To manage various warm-up settings at the group level, we recommend that you set the
        /// default instance warmup, <i>even if it is set to 0 seconds</i>. To remove a value
        /// that you previously set, include the property but specify <c>-1</c> for the value.
        /// However, we strongly recommend keeping the default instance warmup enabled by specifying
        /// a value of <c>0</c> or other nominal value.
        /// </para>
        ///  </important>
        /// </summary>
        public int? DefaultInstanceWarmup
        {
            get { return this._defaultInstanceWarmup; }
            set { this._defaultInstanceWarmup = value; }
        }

        // Check to see if DefaultInstanceWarmup property is set
        internal bool IsSetDefaultInstanceWarmup()
        {
            return this._defaultInstanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group after this
        /// operation completes and the capacity it attempts to maintain. This number must be
        /// greater than or equal to the minimum size of the group and less than or equal to the
        /// maximum size of the group.
        /// </para>
        /// </summary>
        public int? DesiredCapacity
        {
            get { return this._desiredCapacity; }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacityType. 
        /// <para>
        /// The unit of measurement for the value specified for desired capacity. Amazon EC2 Auto
        /// Scaling supports <c>DesiredCapacityType</c> for attribute-based instance type selection
        /// only. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-mixed-instances-group-attribute-based-instance-type-selection.html">Create
        /// a mixed instances group using attribute-based instance type selection</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 Auto Scaling specifies <c>units</c>, which translates into
        /// number of instances.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>units</c> | <c>vcpu</c> | <c>memory-mib</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DesiredCapacityType
        {
            get { return this._desiredCapacityType; }
            set { this._desiredCapacityType = value; }
        }

        // Check to see if DesiredCapacityType property is set
        internal bool IsSetDesiredCapacityType()
        {
            return this._desiredCapacityType != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking
        /// the health status of an EC2 instance that has come into service and marking it unhealthy
        /// due to a failed health check. This is useful if your instances do not immediately
        /// pass their health checks after they enter the <c>InService</c> state. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/health-check-grace-period.html">Set
        /// the health check grace period for an Auto Scaling group</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod; }
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
        /// A comma-separated value string of one or more health check types.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>EC2</c>, <c>EBS</c>, <c>ELB</c>, and <c>VPC_LATTICE</c>. <c>EC2</c>
        /// is the default health check and cannot be disabled. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-health-checks.html">Health
        /// checks for instances in an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only specify <c>EC2</c> if you must clear a value that was previously set.
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
        /// Gets and sets the property InstanceMaintenancePolicy. 
        /// <para>
        /// An instance maintenance policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-maintenance-policy.html">Set
        /// instance maintenance policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMaintenancePolicy InstanceMaintenancePolicy
        {
            get { return this._instanceMaintenancePolicy; }
            set { this._instanceMaintenancePolicy = value; }
        }

        // Check to see if InstanceMaintenancePolicy property is set
        internal bool IsSetInstanceMaintenancePolicy()
        {
            return this._instanceMaintenancePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration. If you specify <c>LaunchConfigurationName</c>
        /// in your update request, you can't specify <c>LaunchTemplate</c> or <c>MixedInstancesPolicy</c>.
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
        /// The launch template and version to use to specify the updates. If you specify <c>LaunchTemplate</c>
        /// in your update request, you can't specify <c>LaunchConfigurationName</c> or <c>MixedInstancesPolicy</c>.
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
        /// Gets and sets the property MaxInstanceLifetime. 
        /// <para>
        /// The maximum amount of time, in seconds, that an instance can be in service. The default
        /// is null. If specified, the value must be either 0 or a number equal to or greater
        /// than 86,400 seconds (1 day). To clear a previously set value, specify a new value
        /// of 0. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-max-instance-lifetime.html">Replacing
        /// Auto Scaling instances based on maximum instance lifetime</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? MaxInstanceLifetime
        {
            get { return this._maxInstanceLifetime; }
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
        /// The maximum size of the Auto Scaling group.
        /// </para>
        ///  <note> 
        /// <para>
        /// With a mixed instances policy that uses instance weighting, Amazon EC2 Auto Scaling
        /// may need to go above <c>MaxSize</c> to meet your capacity requirements. In this event,
        /// Amazon EC2 Auto Scaling will never go above <c>MaxSize</c> by more than your largest
        /// instance weight (weights that define how many units each instance contributes to the
        /// desired capacity of the group).
        /// </para>
        ///  </note>
        /// </summary>
        public int? MaxSize
        {
            get { return this._maxSize; }
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
        /// The minimum size of the Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MinSize
        {
            get { return this._minSize; }
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
        /// The mixed instances policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups.html">Auto
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
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-protection.html">Use
        /// instance scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? NewInstancesProtectedFromScaleIn
        {
            get { return this._newInstancesProtectedFromScaleIn; }
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
        /// The name of an existing placement group into which to launch your instances. To remove
        /// the placement group setting, pass an empty string for <c>placement-group</c>. For
        /// more information about placement groups, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <i>cluster</i> placement group is a logical grouping of instances within a single
        /// Availability Zone. You cannot specify multiple Availability Zones and a cluster placement
        /// group. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// uses to call other Amazon Web Services on your behalf. For more information, see <a
        /// href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-linked
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
        /// Gets and sets the property SkipZonalShiftValidation. 
        /// <para>
        ///  If you enable zonal shift with cross-zone disabled load balancers, capacity could
        /// become imbalanced across Availability Zones. To skip the validation, specify <c>true</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-zonal-shift.html">Auto
        /// Scaling group zonal shift</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public bool? SkipZonalShiftValidation
        {
            get { return this._skipZonalShiftValidation; }
            set { this._skipZonalShiftValidation = value; }
        }

        // Check to see if SkipZonalShiftValidation property is set
        internal bool IsSetSkipZonalShiftValidation()
        {
            return this._skipZonalShiftValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        /// A policy or a list of policies that are used to select the instances to terminate.
        /// The policies are executed in the order that you list them. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-termination-policies.html">Configure
        /// termination policies for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Default</c> | <c>AllocationStrategy</c> | <c>ClosestToNextInstanceHour</c>
        /// | <c>NewestInstance</c> | <c>OldestInstance</c> | <c>OldestLaunchConfiguration</c>
        /// | <c>OldestLaunchTemplate</c> | <c>arn:aws:lambda:region:account-id:function:my-function:my-alias</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this._terminationPolicies; }
            set { this._terminationPolicies = value; }
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this._terminationPolicies != null && (this._terminationPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// A comma-separated list of subnet IDs for a virtual private cloud (VPC). If you specify
        /// <c>VPCZoneIdentifier</c> with <c>AvailabilityZones</c>, the subnets that you specify
        /// must reside in those Availability Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
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