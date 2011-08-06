/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateAutoScalingGroup operation.
    /// <para> Creates a new Auto Scaling group with the specified name. Once the creation request is completed, the AutoScalingGroup is ready to be
    /// used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of your AWS account, and under
    /// the quota of Auto Scaling groups allowed for your account. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.CreateAutoScalingGroup"/>
    public class CreateAutoScalingGroupRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private string launchConfigurationName;
        private int? minSize;
        private int? maxSize;
        private int? desiredCapacity;
        private int? defaultCooldown;
        private List<string> availabilityZones = new List<string>();
        private List<string> loadBalancerNames = new List<string>();
        private string healthCheckType;
        private int? healthCheckGracePeriod;
        private string placementGroup;
        private string vPCZoneIdentifier;

        /// <summary>
        /// The name of the Auto Scaling group.
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
        public CreateAutoScalingGroupRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// The name of the launch configuration to use with the Auto Scaling group.
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

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithLaunchConfigurationName(string launchConfigurationName)
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
        /// The minimum size of the Auto Scaling group.
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
        public CreateAutoScalingGroupRequest WithMinSize(int minSize)
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
        /// The maximum size of the Auto Scaling group.
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
        public CreateAutoScalingGroupRequest WithMaxSize(int maxSize)
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
        /// The number of EC2 instances that should be running in the group.
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
        public CreateAutoScalingGroupRequest WithDesiredCapacity(int desiredCapacity)
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
        /// The amount of time, in seconds, after a scaling activity completes before any further trigger-related scaling activities can start.
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
        public CreateAutoScalingGroupRequest WithDefaultCooldown(int defaultCooldown)
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
        /// A list of availability zones for the Auto Scaling group.
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
        public CreateAutoScalingGroupRequest WithAvailabilityZones(params string[] availabilityZones)
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
        public CreateAutoScalingGroupRequest WithAvailabilityZones(IEnumerable<string> availabilityZones)
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
        /// A list of LoadBalancers to use.
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
        public CreateAutoScalingGroupRequest WithLoadBalancerNames(params string[] loadBalancerNames)
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
        public CreateAutoScalingGroupRequest WithLoadBalancerNames(IEnumerable<string> loadBalancerNames)
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
        /// The service you want the health status from, Amazon EC2 or Elastic Load Balancer. Valid values are "EC2" or "ELB."
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
        public CreateAutoScalingGroupRequest WithHealthCheckType(string healthCheckType)
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
        /// Length of time in seconds after a new EC2 instance comes into service that Auto Scaling starts checking its health.
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
        public CreateAutoScalingGroupRequest WithHealthCheckGracePeriod(int healthCheckGracePeriod)
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
        /// Physical location of your cluster placement group created in Amazon EC2.
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
        public CreateAutoScalingGroupRequest WithPlacementGroup(string placementGroup)
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
        /// The subnet identifier of the Virtual Private Cloud.
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
        public CreateAutoScalingGroupRequest WithVPCZoneIdentifier(string vPCZoneIdentifier)
        {
            this.vPCZoneIdentifier = vPCZoneIdentifier;
            return this;
        }
            

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this.vPCZoneIdentifier != null;       
        }
    }
}
    
