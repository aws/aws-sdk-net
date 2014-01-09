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
    /// Container for the parameters to the CreateAutoScalingGroup operation.
    /// <para> Creates a new Auto Scaling group with the specified name and other attributes. When the creation request is completed, the Auto
    /// Scaling group is ready to be used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of
    /// your AWS account. </para>
    /// </summary>
    public partial class CreateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string autoScalingGroupName;
        private string launchConfigurationName;
        private string instanceId;
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
        private List<string> terminationPolicies = new List<string>();
        private List<Tag> tags = new List<Tag>();


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

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The name of an existing launch configuration to use to launch new instances.
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
        /// The ID of the Amazon EC2 instance you want to use to create the Auto Scaling group. When you use an instance to create an Auto Scaling
        /// group, by default all the parameters are automatically derived from the instance with the exception of the following: <ul> <li>The block
        /// device mappings are derived from the AMI that was used to launch the instance.</li> <li>The <c>AssociatePublicIpAddress</c> is not derived
        /// if the flag is already set for the instance.</li> </ul> You can override any of the values by specifying your own values as part of the same
        /// request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
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
        /// The number of Amazon EC2 instances that should be running in the group. The desired capacity must be greater than or equal to the minimum
        /// size and less than or equal to the maximum size specified for the Auto Scaling group.
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
        /// The amount of time, in seconds, between a successful scaling activity and the succeeding scaling activity. If a <c>DefaultCooldown</c>
        /// period is not specified, Auto Scaling uses the default value of 300 as the default cool down period for the Auto Scaling group. For more
        /// information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown Period</a>
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
        /// A list of Availability Zones for the Auto Scaling group. This is required unless you have specified subnets.
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
        /// A list of existing Elastic Load Balancing load balancers to use. The load balancers must be associated with the AWS account. For information
        /// on using load balancers, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SetUpASLBApp.html">Use Load Balancer
        /// to Load Balance Your Auto Scaling Group</a>.
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
        /// The service you want the health checks from, Amazon EC2 or Elastic Load Balancer. Valid values are <c>EC2</c> or <c>ELB</c>. By default, the
        /// Auto Scaling health check uses the results of Amazon EC2 instance status checks to determine the health of an instance. For more
        /// information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#healthcheck">Health Check</a>.
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
        /// Length of time in seconds after a new Amazon EC2 instance comes into service that Auto Scaling starts checking its health. During this time
        /// any health check failure for the that instance is ignored. This is required if you are adding <c>ELB</c> health check. Frequently, new
        /// instances need to warm up, briefly, before they can pass a health check. To provide ample warm-up time, set the health check grace period of
        /// the group to match the expected startup period of your application.
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
        /// Physical location of an existing cluster placement group into which you want to launch your instances. For information about cluster
        /// placement group, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Using Cluster Instances</a>
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
        /// A comma-separated list of subnet identifiers of Amazon Virtual Private Clouds (Amazon VPCs). If you specify subnets and Availability Zones
        /// with this call, ensure that the subnets' Availability Zones match the Availability Zones specified. For information on launching your Auto
        /// Scaling group into Amazon VPC subnets, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Launch Auto Scaling Instances into Amazon
        /// VPC</a>.
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
        /// order that they are listed. For more information on configuring a termination policy for your Auto Scaling group, see <a
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

        /// <summary>
        /// The tag to be created or updated. Each tag should be defined by its resource type, resource ID, key, value, and a propagate flag. Valid
        /// values: key=<i>value</i>, value=<i>value</i>, propagate=<i>true</i> or <i>false</i>. Value and propagate are optional parameters. For
        /// information about using tags, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag Your Auto
        /// Scaling Groups and Amazon EC2 Instances</a>.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
