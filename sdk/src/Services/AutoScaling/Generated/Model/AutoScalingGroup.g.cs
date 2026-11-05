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
    /// Describes an Auto Scaling group.
    /// </summary>
    public partial class AutoScalingGroup
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string AutoScalingGroupARN { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupARN property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupARN() => this.AutoScalingGroupARN != null;

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
        /// The EC2 instance capacity distribution across Availability Zones for the Auto Scaling
        /// group.
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
        ///  The Availability Zone IDs where the Auto Scaling group can launch instances. 
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
        /// The Availability Zone impairment policy for the Auto Scaling group.
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
        /// One or more Availability Zones for the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// Indicates whether Capacity Rebalancing is enabled.
        /// </para>
        /// </summary>
        public bool? CapacityRebalance { get; set; }

        /// <summary>
        /// Checks to see if the CapacityRebalance property is set.
        /// </summary>
        internal bool IsSetCapacityRebalance() => this.CapacityRebalance.HasValue;

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// The capacity reservation specification for the Auto Scaling group.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the Auto Scaling group was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        /// The duration of the default cooldown period, in seconds, for the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DefaultCooldown { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCooldown property is set.
        /// </summary>
        internal bool IsSetDefaultCooldown() => this.DefaultCooldown.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultInstanceWarmup. 
        /// <para>
        /// The duration of the default EC2 instance warmup time, in seconds, for the Auto Scaling
        /// group.
        /// </para>
        /// </summary>
        public int? DefaultInstanceWarmup { get; set; }

        /// <summary>
        /// Checks to see if the DefaultInstanceWarmup property is set.
        /// </summary>
        internal bool IsSetDefaultInstanceWarmup() => this.DefaultInstanceWarmup.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// The deletion protection setting for the Auto Scaling group.
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
        /// The desired size of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        /// only.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DesiredCapacityType { get; set; }

        /// <summary>
        /// Checks to see if the DesiredCapacityType property is set.
        /// </summary>
        internal bool IsSetDesiredCapacityType() => this.DesiredCapacityType != null;

        /// <summary>
        /// Gets and sets the property EnabledMetrics. 
        /// <para>
        /// The metrics enabled for the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EnabledMetric> EnabledMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<EnabledMetric>() : null;

        /// <summary>
        /// Checks to see if the EnabledMetrics property is set.
        /// </summary>
        internal bool IsSetEnabledMetrics() => this.EnabledMetrics != null && (this.EnabledMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The duration of the health check grace period, in seconds, for the Auto Scaling group.
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
        /// One or more comma-separated health check types for the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckType property is set.
        /// </summary>
        internal bool IsSetHealthCheckType() => this.HealthCheckType != null;

        /// <summary>
        /// Gets and sets the property InstanceLifecyclePolicy. 
        /// <para>
        /// The instance lifecycle policy for the Auto Scaling group.
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
        /// An instance maintenance policy.
        /// </para>
        /// </summary>
        public InstanceMaintenancePolicy InstanceMaintenancePolicy { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMaintenancePolicy property is set.
        /// </summary>
        internal bool IsSetInstanceMaintenancePolicy() => this.InstanceMaintenancePolicy != null;

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// The EC2 instances associated with the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Instance> Instances { get; set; } = AWSConfigs.InitializeCollections ? new List<Instance>() : null;

        /// <summary>
        /// Checks to see if the Instances property is set.
        /// </summary>
        internal bool IsSetInstances() => this.Instances != null && (this.Instances.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the associated launch configuration for the Auto Scaling group.
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
        /// The launch template for the Auto Scaling group.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplate property is set.
        /// </summary>
        internal bool IsSetLaunchTemplate() => this.LaunchTemplate != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// One or more load balancers associated with the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LoadBalancerNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LoadBalancerNames property is set.
        /// </summary>
        internal bool IsSetLoadBalancerNames() => this.LoadBalancerNames != null && (this.LoadBalancerNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxInstanceLifetime. 
        /// <para>
        /// The maximum amount of time, in seconds, that an EC2 instance can be in service for
        /// the Auto Scaling group.
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
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public int? MinSize { get; set; }

        /// <summary>
        /// Checks to see if the MinSize property is set.
        /// </summary>
        internal bool IsSetMinSize() => this.MinSize.HasValue;

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// The mixed instances policy for the group.
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
        /// Indicates whether newly launched EC2 instances are protected from termination when
        /// scaling in for the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        ///  For more information about preventing instances from terminating on scale in, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-protection.html">Use
        /// instance scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        public bool? NewInstancesProtectedFromScaleIn { get; set; }

        /// <summary>
        /// Checks to see if the NewInstancesProtectedFromScaleIn property is set.
        /// </summary>
        internal bool IsSetNewInstancesProtectedFromScaleIn() => this.NewInstancesProtectedFromScaleIn.HasValue;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The entity that manages the Auto Scaling group, if applicable. When set, only the
        /// designated operator can make changes to the group configuration.
        /// </para>
        /// </summary>
        public Operator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// The name of the placement group into which to launch EC2 instances for the Auto Scaling
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PlacementGroup { get; set; }

        /// <summary>
        /// Checks to see if the PlacementGroup property is set.
        /// </summary>
        internal bool IsSetPlacementGroup() => this.PlacementGroup != null;

        /// <summary>
        /// Gets and sets the property PredictedCapacity. 
        /// <para>
        /// The predicted capacity of the group when it has a predictive scaling policy.
        /// </para>
        /// </summary>
        public int? PredictedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the PredictedCapacity property is set.
        /// </summary>
        internal bool IsSetPredictedCapacity() => this.PredictedCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceLinkedRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other Amazon Web Services on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ServiceLinkedRoleARN { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLinkedRoleARN property is set.
        /// </summary>
        internal bool IsSetServiceLinkedRoleARN() => this.ServiceLinkedRoleARN != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the Auto Scaling group when the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DeleteAutoScalingGroup.html">DeleteAutoScalingGroup</a>
        /// operation is in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SuspendedProcesses. 
        /// <para>
        /// The suspended processes associated with the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuspendedProcess> SuspendedProcesses { get; set; } = AWSConfigs.InitializeCollections ? new List<SuspendedProcess>() : null;

        /// <summary>
        /// Checks to see if the SuspendedProcesses property is set.
        /// </summary>
        internal bool IsSetSuspendedProcesses() => this.SuspendedProcesses != null && (this.SuspendedProcesses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagDescription> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<TagDescription>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetGroupARNs. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the target groups for your load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetGroupARNs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetGroupARNs property is set.
        /// </summary>
        internal bool IsSetTargetGroupARNs() => this.TargetGroupARNs != null && (this.TargetGroupARNs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        /// The termination policies for the Auto Scaling group.
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
        /// Gets and sets the property TrafficSources. 
        /// <para>
        /// The traffic sources associated with this Auto Scaling group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrafficSourceIdentifier> TrafficSources { get; set; } = AWSConfigs.InitializeCollections ? new List<TrafficSourceIdentifier>() : null;

        /// <summary>
        /// Checks to see if the TrafficSources property is set.
        /// </summary>
        internal bool IsSetTrafficSources() => this.TrafficSources != null && (this.TrafficSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// One or more comma-separated subnet IDs for the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string VPCZoneIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the VPCZoneIdentifier property is set.
        /// </summary>
        internal bool IsSetVPCZoneIdentifier() => this.VPCZoneIdentifier != null;

        /// <summary>
        /// Gets and sets the property WarmPoolConfiguration. 
        /// <para>
        /// The warm pool for the group.
        /// </para>
        /// </summary>
        public WarmPoolConfiguration WarmPoolConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolConfiguration property is set.
        /// </summary>
        internal bool IsSetWarmPoolConfiguration() => this.WarmPoolConfiguration != null;

        /// <summary>
        /// Gets and sets the property WarmPoolSize. 
        /// <para>
        /// The current size of the warm pool.
        /// </para>
        /// </summary>
        public int? WarmPoolSize { get; set; }

        /// <summary>
        /// Checks to see if the WarmPoolSize property is set.
        /// </summary>
        internal bool IsSetWarmPoolSize() => this.WarmPoolSize.HasValue;
    }
}
