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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutoScalingGroup operation.
    /// <para> Updates the configuration for the specified AutoScalingGroup. </para> <para><b>NOTE:</b> To update an Auto Scaling group with a
    /// launch configuration that has the InstanceMonitoring flag set to False, you must first ensure that collection of group metrics is disabled.
    /// Otherwise, calls to UpdateAutoScalingGroup will fail. If you have previously enabled group metrics collection, you can disable collection of
    /// all group metrics by calling DisableMetricsCollection. </para> <para> The new settings are registered upon the completion of this call. Any
    /// launch configuration settings take effect on any triggers after this call returns. Scaling activities that are currently in progress aren't
    /// affected. </para> <para><b>NOTE:</b> If a new value is specified for MinSize without specifying the value for DesiredCapacity, and if the
    /// new MinSize is larger than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group
    /// to the new MinSize. If a new value is specified for MaxSize without specifying the value for DesiredCapacity, and the new MaxSize is smaller
    /// than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group to the new MaxSize.
    /// All other optional parameters are left unchanged if not passed in the request. </para>
    /// </summary>
    public partial class UpdateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string autoScalingGroupName;
        private string launchConfigurationName;
        private int? minSize;
        private int? maxSize;
        private int? desiredCapacity;
        private int? defaultCooldown;
        private List<string> availabilityZones = new List<string>();
        private string healthCheckType;
        private int? healthCheckGracePeriod;
        private string placementGroup;
        private string vPCZoneIdentifier;
        private List<string> terminationPolicies = new List<string>();


        /// <summary>
        /// The name of the Auto Scaling group.
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
        /// The name of the launch configuration.
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
        /// The minimum size of the Auto Scaling group.
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
        /// The maximum size of the Auto Scaling group.
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
        /// The desired capacity for the Auto Scaling group.
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
        /// The amount of time, in seconds, after a scaling activity completes before any further scaling activities can start. For more information,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown Period</a>.
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
        /// Availability Zones for the group.
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
        /// The type of health check for the instances in the Auto Scaling group. The health check type can either be <c>EC2</c> for Amazon EC2 or
        /// <c>ELB</c> for Elastic Load Balancing.
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
        /// <c>AvailabilityZones</c>. For more information on creating your Auto Scaling group in Amazon VPC by specifying subnets, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Launch Auto Scaling Instances into Amazon
        /// VPC</a> in the the <i>Auto Scaling Developer Guide</i>.
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
        /// A standalone termination policy or a list of termination policies used to select the instance to terminate. The policies are executed in the
        /// order that they are listed. For more information on creating a termination policy for your Auto Scaling group, go to <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/us-termination-policy.html">Instance Termination Policy for Your Auto
        /// Scaling Group</a> in the the <i>Auto Scaling Developer Guide</i>.
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
    
