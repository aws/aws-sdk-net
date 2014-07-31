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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The AutoScalingGroup data type.
    /// </summary>
    public partial class AutoScalingGroup
    {
        private string _autoScalingGroupARN;
        private string _autoScalingGroupName;
        private List<string> _availabilityZones = new List<string>();
        private DateTime? _createdTime;
        private int? _defaultCooldown;
        private int? _desiredCapacity;
        private List<EnabledMetric> _enabledMetrics = new List<EnabledMetric>();
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private List<Instance> _instances = new List<Instance>();
        private string _launchConfigurationName;
        private List<string> _loadBalancerNames = new List<string>();
        private int? _maxSize;
        private int? _minSize;
        private string _placementGroup;
        private string _status;
        private List<SuspendedProcess> _suspendedProcesses = new List<SuspendedProcess>();
        private List<TagDescription> _tags = new List<TagDescription>();
        private List<string> _terminationPolicies = new List<string>();
        private string _vPCZoneIdentifier;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupARN. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the Auto Scaling group. 
        /// </para>
        /// </summary>
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
        ///  Specifies the name of the group. 
        /// </para>
        /// </summary>
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
        ///  Contains a list of Availability Zones for the group. 
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        ///  Specifies the date and time the Auto Scaling group was created. 
        /// </para>
        /// </summary>
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
        ///  The number of seconds after a scaling activity completes before any further scaling
        /// activities can start. 
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
        ///  Specifies the desired capacity for the Auto Scaling group. 
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
        /// Gets and sets the property EnabledMetrics. 
        /// <para>
        ///  A list of metrics enabled for this Auto Scaling group. 
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
        ///  The length of time that Auto Scaling waits before checking an instance's health status.
        /// The grace period begins when an instance comes into service. 
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
        ///  The service of interest for the health status check, either "EC2" for Amazon EC2
        /// or "ELB" for Elastic Load Balancing. 
        /// </para>
        /// </summary>
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
        ///  Provides a summary list of Amazon EC2 instances. 
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
        ///  Specifies the name of the associated <a>LaunchConfiguration</a>. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        ///  A list of load balancers associated with this Auto Scaling group. 
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
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///  Contains the maximum size of the Auto Scaling group. 
        /// </para>
        /// </summary>
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
        ///  Contains the minimum size of the Auto Scaling group. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        ///  The name of the cluster placement group, if applicable. For more information, go
        /// to <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">
        /// Using Cluster Instances</a> in the Amazon EC2 User Guide. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current state of the Auto Scaling group when a <a>DeleteAutoScalingGroup</a>
        /// action is in progress. 
        /// </para>
        /// </summary>
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
        ///  Suspended processes associated with this Auto Scaling group. 
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
        ///  A list of tags for the Auto Scaling group. 
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
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        ///  A standalone termination policy or a list of termination policies for this Auto Scaling
        /// group. 
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
        ///  The subnet identifier for the Amazon VPC connection, if applicable. You can specify
        /// several subnets in a comma-separated list. 
        /// </para>
        ///  
        /// <para>
        ///  When you specify <code>VPCZoneIdentifier</code> with <code>AvailabilityZones</code>,
        /// ensure that the subnets' Availability Zones match the values you specify for <code>AvailabilityZones</code>.
        /// 
        /// </para>
        /// </summary>
        public string VPCZoneIdentifier
        {
            get { return this._vPCZoneIdentifier; }
            set { this._vPCZoneIdentifier = value; }
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this._vPCZoneIdentifier != null;
        }

    }
}