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
    /// Describes an Auto Scaling group.
    /// </summary>
    public partial class AutoScalingGroup
    {
        private string _autoScalingGroupARN;
        private string _autoScalingGroupName;
        private List<string> _availabilityZones = new List<string>();
        private bool? _capacityRebalance;
        private string _context;
        private DateTime? _createdTime;
        private int? _defaultCooldown;
        private int? _defaultInstanceWarmup;
        private int? _desiredCapacity;
        private string _desiredCapacityType;
        private List<EnabledMetric> _enabledMetrics = new List<EnabledMetric>();
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private List<Instance> _instances = new List<Instance>();
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private List<string> _loadBalancerNames = new List<string>();
        private int? _maxInstanceLifetime;
        private int? _maxSize;
        private int? _minSize;
        private MixedInstancesPolicy _mixedInstancesPolicy;
        private bool? _newInstancesProtectedFromScaleIn;
        private string _placementGroup;
        private int? _predictedCapacity;
        private string _serviceLinkedRoleARN;
        private string _status;
        private List<SuspendedProcess> _suspendedProcesses = new List<SuspendedProcess>();
        private List<TagDescription> _tags = new List<TagDescription>();
        private List<string> _targetGroupARNs = new List<string>();
        private List<string> _terminationPolicies = new List<string>();
        private List<TrafficSourceIdentifier> _trafficSources = new List<TrafficSourceIdentifier>();
        private string _vpcZoneIdentifier;
        private WarmPoolConfiguration _warmPoolConfiguration;
        private int? _warmPoolSize;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string AutoScalingGroupARN
        {
            get { return this._autoScalingGroupARN; }
            set { this._autoScalingGroupARN = value; }
        }

        // Check to see if AutoScalingGroupARN property is set
        internal bool IsSetAutoScalingGroupARN()
        {
            return this._autoScalingGroupARN != null;
        }

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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// One or more Availability Zones for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Indicates whether Capacity Rebalancing is enabled.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time the group was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        /// The duration of the default cooldown period, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DefaultInstanceWarmup. 
        /// <para>
        /// The duration of the default instance warmup, in seconds.
        /// </para>
        /// </summary>
        public int DefaultInstanceWarmup
        {
            get { return this._defaultInstanceWarmup.GetValueOrDefault(); }
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
        /// The desired size of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DesiredCapacityType. 
        /// <para>
        /// The unit of measurement for the value specified for desired capacity. Amazon EC2 Auto
        /// Scaling supports <code>DesiredCapacityType</code> for attribute-based instance type
        /// selection only.
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
        /// Gets and sets the property EnabledMetrics. 
        /// <para>
        /// The metrics enabled for the group.
        /// </para>
        /// </summary>
        public List<EnabledMetric> EnabledMetrics
        {
            get { return this._enabledMetrics; }
            set { this._enabledMetrics = value; }
        }

        // Check to see if EnabledMetrics property is set
        internal bool IsSetEnabledMetrics()
        {
            return this._enabledMetrics != null && this._enabledMetrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The duration of the health check grace period, in seconds.
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
        /// A comma-separated list of one or more health check types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property Instances. 
        /// <para>
        /// The EC2 instances associated with the group.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the associated launch configuration.
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
        /// The launch template for the group.
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
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// One or more load balancers associated with the group.
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
        /// The maximum amount of time, in seconds, that an instance can be in service.
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
        /// The mixed instances policy for the group.
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
        /// The name of the placement group into which to launch your instances, if any.
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
        /// Gets and sets the property PredictedCapacity. 
        /// <para>
        /// The predicted capacity of the group when it has a predictive scaling policy.
        /// </para>
        /// </summary>
        public int PredictedCapacity
        {
            get { return this._predictedCapacity.GetValueOrDefault(); }
            set { this._predictedCapacity = value; }
        }

        // Check to see if PredictedCapacity property is set
        internal bool IsSetPredictedCapacity()
        {
            return this._predictedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceLinkedRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other Amazon Web Services on your behalf.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the group when the <a>DeleteAutoScalingGroup</a> operation is
        /// in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SuspendedProcesses. 
        /// <para>
        /// The suspended processes associated with the group.
        /// </para>
        /// </summary>
        public List<SuspendedProcess> SuspendedProcesses
        {
            get { return this._suspendedProcesses; }
            set { this._suspendedProcesses = value; }
        }

        // Check to see if SuspendedProcesses property is set
        internal bool IsSetSuspendedProcesses()
        {
            return this._suspendedProcesses != null && this._suspendedProcesses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the group.
        /// </para>
        /// </summary>
        public List<TagDescription> Tags
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
        /// The Amazon Resource Names (ARN) of the target groups for your load balancer.
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
        /// The termination policies for the group.
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
        /// Gets and sets the property TrafficSources. 
        /// <para>
        /// The traffic sources associated with this Auto Scaling group.
        /// </para>
        /// </summary>
        public List<TrafficSourceIdentifier> TrafficSources
        {
            get { return this._trafficSources; }
            set { this._trafficSources = value; }
        }

        // Check to see if TrafficSources property is set
        internal bool IsSetTrafficSources()
        {
            return this._trafficSources != null && this._trafficSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// One or more subnet IDs, if applicable, separated by commas.
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

        /// <summary>
        /// Gets and sets the property WarmPoolConfiguration. 
        /// <para>
        /// The warm pool for the group.
        /// </para>
        /// </summary>
        public WarmPoolConfiguration WarmPoolConfiguration
        {
            get { return this._warmPoolConfiguration; }
            set { this._warmPoolConfiguration = value; }
        }

        // Check to see if WarmPoolConfiguration property is set
        internal bool IsSetWarmPoolConfiguration()
        {
            return this._warmPoolConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WarmPoolSize. 
        /// <para>
        /// The current size of the warm pool.
        /// </para>
        /// </summary>
        public int WarmPoolSize
        {
            get { return this._warmPoolSize.GetValueOrDefault(); }
            set { this._warmPoolSize = value; }
        }

        // Check to see if WarmPoolSize property is set
        internal bool IsSetWarmPoolSize()
        {
            return this._warmPoolSize.HasValue; 
        }

    }
}