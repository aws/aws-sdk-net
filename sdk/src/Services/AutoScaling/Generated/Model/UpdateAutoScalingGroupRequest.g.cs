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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutoScalingGroup operation. <b>We strongly
    /// recommend that all Auto Scaling groups use launch templates to ensure full functionality
    /// for Amazon EC2 Auto Scaling and Amazon EC2.</b> <para> Updates the configuration for
    /// the specified Auto Scaling group. </para> <para> To update an Auto Scaling group,
    /// specify the name of the group and the property that you want to change. Any properties
    /// that you don't specify are not changed by this update request. The new settings take
    /// effect on any scaling activities after this call returns. </para> <para> If you associate
    /// a new launch configuration or template with an Auto Scaling group, all new instances
    /// will get the updated configuration. Existing instances continue to run with the configuration
    /// that they were originally launched with. When you update a group to specify a mixed
    /// instances policy instead of a launch configuration or template, existing instances
    /// may be replaced to match the new purchasing options that you specified in the policy.
    /// For example, if the group currently has 100% On-Demand capacity and the policy specifies
    /// 50% Spot capacity, this means that half of your instances will be gradually terminated
    /// and relaunched as Spot Instances. When replacing instances, Amazon EC2 Auto Scaling
    /// launches new instances before terminating the old ones, so that updating your group
    /// does not compromise the performance or availability of your application. </para> <para>
    /// Note the following about changing <c>DesiredCapacity</c>, <c>MaxSize</c>, or <c>MinSize</c>:
    /// </para> <ul> <li> <para> If a scale-in activity occurs as a result of a new <c>DesiredCapacity</c>
    /// value that is lower than the current size of the group, the Auto Scaling group uses
    /// its termination policy to determine which instances to terminate. </para> </li> <li>
    /// <para> If you specify a new value for <c>MinSize</c> without specifying a value for
    /// <c>DesiredCapacity</c>, and the new <c>MinSize</c> is larger than the current size
    /// of the group, this sets the group's <c>DesiredCapacity</c> to the new <c>MinSize</c>
    /// value. </para> </li> <li> <para> If you specify a new value for <c>MaxSize</c> without
    /// specifying a value for <c>DesiredCapacity</c>, and the new <c>MaxSize</c> is smaller
    /// than the current size of the group, this sets the group's <c>DesiredCapacity</c> to
    /// the new <c>MaxSize</c> value. </para> </li> </ul> <para> To see which properties have
    /// been set, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAutoScalingGroups.html">DescribeAutoScalingGroups</a>
    /// API. To view the scaling policies for an Auto Scaling group, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribePolicies.html">DescribePolicies</a>
    /// API. If the group has scaling policies, you can update them by calling the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_PutScalingPolicy.html">PutScalingPolicy</a>
    /// API. </para>
    /// </summary>
    public partial class UpdateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneDistribution. 
        /// <para>
        ///  The instance capacity distribution across Availability Zones. 
        /// </para>
        /// </summary>
        public AvailabilityZoneDistribution AvailabilityZoneDistribution { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneDistribution property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneDistribution() => this.AvailabilityZoneDistribution != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneIds. 
        /// <para>
        ///  A list of Availability Zone IDs for the Auto Scaling group. You cannot specify both
        /// AvailabilityZones and AvailabilityZoneIds in the same request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZoneIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZoneIds property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneIds() => this.AvailabilityZoneIds != null && (this.AvailabilityZoneIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZoneImpairmentPolicy. 
        /// <para>
        ///  The policy for Availability Zone impairment. 
        /// </para>
        /// </summary>
        public AvailabilityZoneImpairmentPolicy AvailabilityZoneImpairmentPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZoneImpairmentPolicy property is set.
        /// </summary>
        internal bool IsSetAvailabilityZoneImpairmentPolicy() => this.AvailabilityZoneImpairmentPolicy != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones for the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public bool? CapacityRebalance { get; set; }

        /// <summary>
        /// Checks to see if the CapacityRebalance property is set.
        /// </summary>
        internal bool IsSetCapacityRebalance() => this.CapacityRebalance.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        ///  The capacity reservation specification for the Auto Scaling group. 
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

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
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCooldown property is set.
        /// </summary>
        internal bool IsSetDefaultCooldown() => this.DefaultCooldown.HasValue;

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
        public int? DefaultInstanceWarmup { get; set; }

        /// <summary>
        /// Checks to see if the DefaultInstanceWarmup property is set.
        /// </summary>
        internal bool IsSetDefaultInstanceWarmup() => this.DefaultInstanceWarmup.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        ///  The deletion protection setting for the Auto Scaling group. This setting helps safeguard
        /// your Auto Scaling group and its instances by controlling whether the <c>DeleteAutoScalingGroup</c>
        /// operation is allowed. When deletion protection is enabled, users cannot delete the
        /// Auto Scaling group according to the specified protection level until the setting is
        /// changed back to a less restrictive level. 
        /// </para>
        ///  
        /// <para>
        ///  The valid values are <c>none</c>, <c>prevent-force-deletion</c>, and <c>prevent-all-deletion</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Default: <c>none</c> 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/resource-deletion-protection.html">
        /// Configure deletion protection for your Amazon EC2 Auto Scaling resources</a> in the
        /// <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public DeletionProtection DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection != null;

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group after this
        /// operation completes and the capacity it attempts to maintain. This number must be
        /// greater than or equal to the minimum size of the group and less than or equal to the
        /// maximum size of the group.
        /// </para>
        /// </summary>
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCapacity property is set.
        /// </summary>
        internal bool IsSetDesiredCapacity() => this.DesiredCapacity.HasValue;

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
        [AWSProperty(Min = 1, Max = 255)]
        public string DesiredCapacityType { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCapacityType property is set.
        /// </summary>
        internal bool IsSetDesiredCapacityType() => this.DesiredCapacityType != null;

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
        public int? HealthCheckGracePeriod { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckGracePeriod property is set.
        /// </summary>
        internal bool IsSetHealthCheckGracePeriod() => this.HealthCheckGracePeriod.HasValue;

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
        [AWSProperty(Min = 1, Max = 32)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckType property is set.
        /// </summary>
        internal bool IsSetHealthCheckType() => this.HealthCheckType != null;

        /// <summary>
        /// Gets and sets the property InstanceLifecyclePolicy. 
        /// <para>
        ///  The instance lifecycle policy for the Auto Scaling group. This policy controls instance
        /// behavior when an instance transitions through its lifecycle states. Configure retention
        /// triggers to specify when instances should move to a <c>Retained</c> state instead
        /// of automatic termination. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/instance-lifecycle-policy.html">
        /// Control instance retention with instance lifecycle policies</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public InstanceLifecyclePolicy InstanceLifecyclePolicy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceLifecyclePolicy property is set.
        /// </summary>
        internal bool IsSetInstanceLifecyclePolicy() => this.InstanceLifecyclePolicy != null;

        /// <summary>
        /// Gets and sets the property InstanceMaintenancePolicy. 
        /// <para>
        /// An instance maintenance policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-maintenance-policy.html">Set
        /// instance maintenance policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMaintenancePolicy InstanceMaintenancePolicy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMaintenancePolicy property is set.
        /// </summary>
        internal bool IsSetInstanceMaintenancePolicy() => this.InstanceMaintenancePolicy != null;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration. If you specify <c>LaunchConfigurationName</c>
        /// in your update request, you can't specify <c>LaunchTemplate</c> or <c>MixedInstancesPolicy</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LaunchConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationName property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationName() => this.LaunchConfigurationName != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template and version to use to specify the updates. If you specify <c>LaunchTemplate</c>
        /// in your update request, you can't specify <c>LaunchConfigurationName</c> or <c>MixedInstancesPolicy</c>.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

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
        public int? MaxInstanceLifetime { get; set; }

        /// <summary>
        /// Checks to see if the MaxInstanceLifetime property is set.
        /// </summary>
        internal bool IsSetMaxInstanceLifetime() => this.MaxInstanceLifetime.HasValue;

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
        public int? MaxSize { get; set; }

        /// <summary>
        /// Checks to see if the MaxSize property is set.
        /// </summary>
        internal bool IsSetMaxSize() => this.MaxSize.HasValue;

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size of the Auto Scaling group.
        /// </para>
        /// </summary>
        public int? MinSize { get; set; }

        /// <summary>
        /// Checks to see if the MinSize property is set.
        /// </summary>
        internal bool IsSetMinSize() => this.MinSize.HasValue;

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// The mixed instances policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups.html">Auto
        /// Scaling groups with multiple instance types and purchase options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can remove the Distribution Segments configuration by specifying <c>OnDemandBaseCapacity</c>
        /// or <c>OnDemandPercentageAboveBaseCapacity</c>. You can also remove it explicitly by
        /// specifying an empty list for <c>DistributionSegments</c>.
        /// </para>
        /// </summary>
        public MixedInstancesPolicy MixedInstancesPolicy { get; set; }

        /// <summary>
        /// Checks to see if the MixedInstancesPolicy property is set.
        /// </summary>
        internal bool IsSetMixedInstancesPolicy() => this.MixedInstancesPolicy != null;

        /// <summary>
        /// Gets and sets the property NewInstancesProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether newly launched instances are protected from termination by Amazon
        /// EC2 Auto Scaling when scaling in. For more information about preventing instances
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-protection.html">Use
        /// instance scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? NewInstancesProtectedFromScaleIn { get; set; }

        /// <summary>
        /// Checks to see if the NewInstancesProtectedFromScaleIn property is set.
        /// </summary>
        internal bool IsSetNewInstancesProtectedFromScaleIn() => this.NewInstancesProtectedFromScaleIn.HasValue;

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
        [AWSProperty(Min = 0, Max = 255)]
        public string PlacementGroup { get; set; }

        /// <summary>
        /// Checks to see if the PlacementGroup property is set.
        /// </summary>
        internal bool IsSetPlacementGroup() => this.PlacementGroup != null;

        /// <summary>
        /// Gets and sets the property ServiceLinkedRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other Amazon Web Services on your behalf. For more information, see <a
        /// href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-linked
        /// roles</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ServiceLinkedRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLinkedRoleARN property is set.
        /// </summary>
        internal bool IsSetServiceLinkedRoleARN() => this.ServiceLinkedRoleARN != null;

        /// <summary>
        /// Gets and sets the property SkipZonalShiftValidation. 
        /// <para>
        ///  If you enable zonal shift with cross-zone disabled load balancers, capacity could
        /// become imbalanced across Availability Zones. To skip the validation, specify <c>true</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-zonal-shift.html">Auto
        /// Scaling group zonal shift</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public bool? SkipZonalShiftValidation { get; set; }

        /// <summary>
        /// Checks to see if the SkipZonalShiftValidation property is set.
        /// </summary>
        internal bool IsSetSkipZonalShiftValidation() => this.SkipZonalShiftValidation.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminationPolicies { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TerminationPolicies property is set.
        /// </summary>
        internal bool IsSetTerminationPolicies() => this.TerminationPolicies != null && (this.TerminationPolicies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// A comma-separated list of subnet IDs for a virtual private cloud (VPC). If you specify
        /// <c>VPCZoneIdentifier</c> with <c>AvailabilityZones</c>, the subnets that you specify
        /// must reside in those Availability Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string VPCZoneIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VPCZoneIdentifier property is set.
        /// </summary>
        internal bool IsSetVPCZoneIdentifier() => this.VPCZoneIdentifier != null;
    }
}
