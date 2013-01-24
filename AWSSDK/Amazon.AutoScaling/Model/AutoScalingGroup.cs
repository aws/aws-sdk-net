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

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
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

        /// <summary>
        /// Sets the AutoScalingGroupARN property
        /// </summary>
        /// <param name="autoScalingGroupARN">The value to set for the AutoScalingGroupARN property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithAutoScalingGroupARN(string autoScalingGroupARN)
        {
            this.autoScalingGroupARN = autoScalingGroupARN;
            return this;
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

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithLaunchConfigurationName(string launchConfigurationName)
        {
            this.launchConfigurationName = launchConfigurationName;
            return this;
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

        /// <summary>
        /// Sets the MinSize property
        /// </summary>
        /// <param name="minSize">The value to set for the MinSize property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithMinSize(int minSize)
        {
            this.minSize = minSize;
            return this;
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

        /// <summary>
        /// Sets the MaxSize property
        /// </summary>
        /// <param name="maxSize">The value to set for the MaxSize property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithMaxSize(int maxSize)
        {
            this.maxSize = maxSize;
            return this;
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

        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">The value to set for the DesiredCapacity property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithDesiredCapacity(int desiredCapacity)
        {
            this.desiredCapacity = desiredCapacity;
            return this;
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

        /// <summary>
        /// Sets the DefaultCooldown property
        /// </summary>
        /// <param name="defaultCooldown">The value to set for the DefaultCooldown property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithDefaultCooldown(int defaultCooldown)
        {
            this.defaultCooldown = defaultCooldown;
            return this;
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
        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithAvailabilityZones(params string[] availabilityZones)
        {
            foreach (string element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithAvailabilityZones(IEnumerable<string> availabilityZones)
        {
            foreach (string element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the LoadBalancerNames collection
        /// </summary>
        /// <param name="loadBalancerNames">The values to add to the LoadBalancerNames collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithLoadBalancerNames(params string[] loadBalancerNames)
        {
            foreach (string element in loadBalancerNames)
            {
                this.loadBalancerNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the LoadBalancerNames collection
        /// </summary>
        /// <param name="loadBalancerNames">The values to add to the LoadBalancerNames collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithLoadBalancerNames(IEnumerable<string> loadBalancerNames)
        {
            foreach (string element in loadBalancerNames)
            {
                this.loadBalancerNames.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the HealthCheckType property
        /// </summary>
        /// <param name="healthCheckType">The value to set for the HealthCheckType property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithHealthCheckType(string healthCheckType)
        {
            this.healthCheckType = healthCheckType;
            return this;
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

        /// <summary>
        /// Sets the HealthCheckGracePeriod property
        /// </summary>
        /// <param name="healthCheckGracePeriod">The value to set for the HealthCheckGracePeriod property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithHealthCheckGracePeriod(int healthCheckGracePeriod)
        {
            this.healthCheckGracePeriod = healthCheckGracePeriod;
            return this;
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
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithInstances(params Instance[] instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Instances collection
        /// </summary>
        /// <param name="instances">The values to add to the Instances collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithInstances(IEnumerable<Instance> instances)
        {
            foreach (Instance element in instances)
            {
                this.instances.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">The value to set for the CreatedTime property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithCreatedTime(DateTime createdTime)
        {
            this.createdTime = createdTime;
            return this;
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
        /// <summary>
        /// Adds elements to the SuspendedProcesses collection
        /// </summary>
        /// <param name="suspendedProcesses">The values to add to the SuspendedProcesses collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithSuspendedProcesses(params SuspendedProcess[] suspendedProcesses)
        {
            foreach (SuspendedProcess element in suspendedProcesses)
            {
                this.suspendedProcesses.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the SuspendedProcesses collection
        /// </summary>
        /// <param name="suspendedProcesses">The values to add to the SuspendedProcesses collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithSuspendedProcesses(IEnumerable<SuspendedProcess> suspendedProcesses)
        {
            foreach (SuspendedProcess element in suspendedProcesses)
            {
                this.suspendedProcesses.Add(element);
            }

            return this;
        }

        // Check to see if SuspendedProcesses property is set
        internal bool IsSetSuspendedProcesses()
        {
            return this.suspendedProcesses.Count > 0;       
        }

        /// <summary>
        /// The name of the cluster placement group, if applicable. For more information, go to <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/latest/UserGuide/using_cluster_computing.html"> Using Cluster Instances</a> in the Amazon EC2
        /// User Guide.
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

        /// <summary>
        /// Sets the PlacementGroup property
        /// </summary>
        /// <param name="placementGroup">The value to set for the PlacementGroup property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithPlacementGroup(string placementGroup)
        {
            this.placementGroup = placementGroup;
            return this;
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

        /// <summary>
        /// Sets the VPCZoneIdentifier property
        /// </summary>
        /// <param name="vPCZoneIdentifier">The value to set for the VPCZoneIdentifier property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithVPCZoneIdentifier(string vPCZoneIdentifier)
        {
            this.vPCZoneIdentifier = vPCZoneIdentifier;
            return this;
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
        /// <summary>
        /// Adds elements to the EnabledMetrics collection
        /// </summary>
        /// <param name="enabledMetrics">The values to add to the EnabledMetrics collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithEnabledMetrics(params EnabledMetric[] enabledMetrics)
        {
            foreach (EnabledMetric element in enabledMetrics)
            {
                this.enabledMetrics.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the EnabledMetrics collection
        /// </summary>
        /// <param name="enabledMetrics">The values to add to the EnabledMetrics collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithEnabledMetrics(IEnumerable<EnabledMetric> enabledMetrics)
        {
            foreach (EnabledMetric element in enabledMetrics)
            {
                this.enabledMetrics.Add(element);
            }

            return this;
        }

        // Check to see if EnabledMetrics property is set
        internal bool IsSetEnabledMetrics()
        {
            return this.enabledMetrics.Count > 0;       
        }

        /// <summary>
        /// A list of status conditions for the Auto Scaling group.
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

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithStatus(string status)
        {
            this.status = status;
            return this;
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
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithTags(params TagDescription[] tags)
        {
            foreach (TagDescription element in tags)
            {
                this.tags.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Tags collection
        /// </summary>
        /// <param name="tags">The values to add to the Tags collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithTags(IEnumerable<TagDescription> tags)
        {
            foreach (TagDescription element in tags)
            {
                this.tags.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the TerminationPolicies collection
        /// </summary>
        /// <param name="terminationPolicies">The values to add to the TerminationPolicies collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithTerminationPolicies(params string[] terminationPolicies)
        {
            foreach (string element in terminationPolicies)
            {
                this.terminationPolicies.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the TerminationPolicies collection
        /// </summary>
        /// <param name="terminationPolicies">The values to add to the TerminationPolicies collection </param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithTerminationPolicies(IEnumerable<string> terminationPolicies)
        {
            foreach (string element in terminationPolicies)
            {
                this.terminationPolicies.Add(element);
            }

            return this;
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this.terminationPolicies.Count > 0;       
        }
    }
}
