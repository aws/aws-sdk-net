/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The AutoScalingGroup data type. </para>
    /// </summary>
    public class AutoScalingGroup
    {
        
        private string autoScalingGroupName;
        private string autoScalingGroupARN;
        private string launchConfigurationName;
        private int? minSize;
        private int? maxSize;
        private int? desiredCapacity;
        private int? defaultCooldown;
        private List<string> availabilityZones = new List<string>();
        private List<string> loadBalancerNames = new List<string>();
        private string healthCheckType;
        private int? healthCheckGracePeriod;
        private List<Instance> instances = new List<Instance>();
        private DateTime? createdTime;
        private List<SuspendedProcess> suspendedProcesses = new List<SuspendedProcess>();
        private string placementGroup;
        private string vPCZoneIdentifier;
        private List<EnabledMetric> enabledMetrics = new List<EnabledMetric>();
        private string status;
        private List<TagDescription> tags = new List<TagDescription>();
        private List<string> terminationPolicies = new List<string>();


        /// <summary>
        /// Specifies the name of the group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Auto Scaling group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupARN
        {
            get { return this.autoScalingGroupARN; }
            set { this.autoScalingGroupARN = value; }
        }

        // Check to see if AutoScalingGroupARN property is set
        internal bool IsSetAutoScalingGroupARN()
        {
            return this.autoScalingGroupARN != null;
        }

        /// <summary>
        /// Specifies the name of the associated <a>LaunchConfiguration</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this.launchConfigurationName; }
            set { this.launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this.launchConfigurationName != null;
        }

        /// <summary>
        /// Contains the minimum size of the Auto Scaling group.
        ///  
        /// </summary>
        public int MinSize
        {
            get { return this.minSize ?? default(int); }
            set { this.minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this.minSize.HasValue;
        }

        /// <summary>
        /// Contains the maximum size of the Auto Scaling group.
        ///  
        /// </summary>
        public int MaxSize
        {
            get { return this.maxSize ?? default(int); }
            set { this.maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this.maxSize.HasValue;
        }

        /// <summary>
        /// Specifies the desired capacity for the Auto Scaling group.
        ///  
        /// </summary>
        public int DesiredCapacity
        {
            get { return this.desiredCapacity ?? default(int); }
            set { this.desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this.desiredCapacity.HasValue;
        }

        /// <summary>
        /// The number of seconds after a scaling activity completes before any further scaling activities can start.
        ///  
        /// </summary>
        public int DefaultCooldown
        {
            get { return this.defaultCooldown ?? default(int); }
            set { this.defaultCooldown = value; }
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this.defaultCooldown.HasValue;
        }

        /// <summary>
        /// Contains a list of Availability Zones for the group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;
        }

        /// <summary>
        /// A list of load balancers associated with this Auto Scaling group.
        ///  
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this.loadBalancerNames; }
            set { this.loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this.loadBalancerNames.Count > 0;
        }

        /// <summary>
        /// The service of interest for the health status check, either "EC2" for Amazon EC2 or "ELB" for Elastic Load Balancing.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string HealthCheckType
        {
            get { return this.healthCheckType; }
            set { this.healthCheckType = value; }
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this.healthCheckType != null;
        }

        /// <summary>
        /// The length of time that Auto Scaling waits before checking an instance's health status. The grace period begins when an instance comes into
        /// service.
        ///  
        /// </summary>
        public int HealthCheckGracePeriod
        {
            get { return this.healthCheckGracePeriod ?? default(int); }
            set { this.healthCheckGracePeriod = value; }
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this.healthCheckGracePeriod.HasValue;
        }

        /// <summary>
        /// Provides a summary list of Amazon EC2 instances.
        ///  
        /// </summary>
        public List<Instance> Instances
        {
            get { return this.instances; }
            set { this.instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this.instances.Count > 0;
        }

        /// <summary>
        /// Specifies the date and time the Auto Scaling group was created.
        ///  
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this.createdTime ?? default(DateTime); }
            set { this.createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this.createdTime.HasValue;
        }

        /// <summary>
        /// Suspended processes associated with this Auto Scaling group.
        ///  
        /// </summary>
        public List<SuspendedProcess> SuspendedProcesses
        {
            get { return this.suspendedProcesses; }
            set { this.suspendedProcesses = value; }
        }

        // Check to see if SuspendedProcesses property is set
        internal bool IsSetSuspendedProcesses()
        {
            return this.suspendedProcesses.Count > 0;
        }

        /// <summary>
        /// The name of the cluster placement group, if applicable. For more information, go to <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html"> Using Cluster Instances</a> in the Amazon EC2 User
        /// Guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PlacementGroup
        {
            get { return this.placementGroup; }
            set { this.placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this.placementGroup != null;
        }

        /// <summary>
        /// The subnet identifier for the Amazon VPC connection, if applicable. You can specify several subnets in a comma-separated list. When you
        /// specify <c>VPCZoneIdentifier</c> with <c>AvailabilityZones</c>, ensure that the subnets' Availability Zones match the values you specify for
        /// <c>AvailabilityZones</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VPCZoneIdentifier
        {
            get { return this.vPCZoneIdentifier; }
            set { this.vPCZoneIdentifier = value; }
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this.vPCZoneIdentifier != null;
        }

        /// <summary>
        /// A list of metrics enabled for this Auto Scaling group.
        ///  
        /// </summary>
        public List<EnabledMetric> EnabledMetrics
        {
            get { return this.enabledMetrics; }
            set { this.enabledMetrics = value; }
        }

        // Check to see if EnabledMetrics property is set
        internal bool IsSetEnabledMetrics()
        {
            return this.enabledMetrics.Count > 0;
        }

        /// <summary>
        /// The current state of the Auto Scaling group when a <a>DeleteAutoScalingGroup</a> action is in progress.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// A list of tags for the Auto Scaling group.
        ///  
        /// </summary>
        public List<TagDescription> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

        /// <summary>
        /// A standalone termination policy or a list of termination policies for this Auto Scaling group.
        ///  
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this.terminationPolicies; }
            set { this.terminationPolicies = value; }
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this.terminationPolicies.Count > 0;
        }
    }
}
