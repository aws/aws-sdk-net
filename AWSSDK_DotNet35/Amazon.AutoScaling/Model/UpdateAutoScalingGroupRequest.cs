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
    /// Container for the parameters to the UpdateAutoScalingGroup operation.
    /// Updates the configuration for the specified <a>AutoScalingGroup</a>. 
    /// 
    ///  
    /// <para>
    ///  The new settings are registered upon the completion of this call. Any launch configuration
    /// settings take effect on any triggers after this call returns. Scaling activities that
    /// are currently in progress aren't affected. 
    /// </para>
    /// </summary>
    public partial class UpdateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _availabilityZones = new List<string>();
        private int? _defaultCooldown;
        private int? _desiredCapacity;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private string _launchConfigurationName;
        private int? _maxSize;
        private int? _minSize;
        private string _placementGroup;
        private List<string> _terminationPolicies = new List<string>();
        private string _vPCZoneIdentifier;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name of the Auto Scaling group. 
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
        ///  Availability Zones for the group. 
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
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        ///  The amount of time, in seconds, after a scaling activity completes before any further
        /// scaling activities can start. For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown
        /// Period</a>. 
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
        ///  The desired capacity for the Auto Scaling group. 
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
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        ///  The length of time that Auto Scaling waits before checking an instance's health status.
        /// The grace period begins when the instance passes System Status and the Instance Status
        /// checks from Amazon EC2. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeInstanceStatus.html">DescribeInstanceStatus</a>.
        /// 
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
        ///  The type of health check for the instances in the Auto Scaling group. The health
        /// check type can either be <code>EC2</code> for Amazon EC2 or <code>ELB</code> for Elastic
        /// Load Balancing. 
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
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///  The name of the launch configuration. 
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
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///  The maximum size of the Auto Scaling group. 
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
        ///  The minimum size of the Auto Scaling group. 
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
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        ///  A standalone termination policy or a list of termination policies used to select
        /// the instance to terminate. The policies are executed in the order that they are listed.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  For more information on creating a termination policy for your Auto Scaling group,
        /// go to <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/us-termination-policy.html">Instance
        /// Termination Policy for Your Auto Scaling Group</a> in the the <i>Auto Scaling Developer
        /// Guide</i>. 
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
        ///  
        /// <para>
        ///  For more information on creating your Auto Scaling group in Amazon VPC by specifying
        /// subnets, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Launch
        /// Auto Scaling Instances into Amazon VPC</a> in the the <i>Auto Scaling Developer Guide</i>.
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