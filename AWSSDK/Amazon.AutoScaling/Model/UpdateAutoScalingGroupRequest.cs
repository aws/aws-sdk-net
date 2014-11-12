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
    ///         <note>            
    /// <para>
    ///                 To update an Auto Scaling group with a launch configuration      
    ///          that has the <code>InstanceMonitoring</code> flag                set to <code>False</code>,
    /// you must first ensure that collection                of group metrics is disabled.
    /// Otherwise, calls to                 <a>UpdateAutoScalingGroup</a> will fail.     
    ///           If you have previously enabled group metrics collection,               
    ///  you can disable collection of all group metrics                by calling <a>DisableMetricsCollection</a>.
    ///                            
    /// </para>
    ///         </note>        
    /// <para>
    ///         The new settings are registered upon the completion of this call.        Any
    /// launch configuration settings take effect on any triggers after        this call returns.
    ///        Scaling activities that are currently in progress aren't affected.        
    /// </para>
    ///         <note>            <ul>                <li>                    
    /// <para>
    /// If a new value is specified for <i>MinSize</i> without specifying the value for <i>DesiredCapacity</i>,
    ///                         and if the new <i>MinSize</i> is larger than the current size
    /// of the Auto Scaling Group, there                        will be an implicit call to
    /// <a>SetDesiredCapacity</a> to set the group to the new <i>MinSize</i>. 
    /// </para>
    ///                 </li>                <li>                    
    /// <para>
    /// If a new value is specified for <i>MaxSize</i> without specifying the value for <i>DesiredCapacity</i>,
    /// and                         the new <i>MaxSize</i> is smaller than the current size
    /// of the Auto Scaling Group, there will                         be an implicit call
    /// to <a>SetDesiredCapacity</a> to set the group to the new <i>MaxSize</i>. 
    /// </para>
    ///                 </li>                <li>                    
    /// <para>
    /// All other optional parameters are left unchanged if not passed in the request.
    /// </para>
    ///                 </li>            </ul>        </note>
    /// </summary>
    public partial class UpdateAutoScalingGroupRequest : AmazonWebServiceRequest
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
        ///             The name of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        ///             Availability Zones for the group.        
        /// </para>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithAvailabilityZones(params string[] availabilityZones)
        {
            foreach (var element in availabilityZones)
            {
                this._availabilityZones.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithAvailabilityZones(IEnumerable<string> availabilityZones)
        {
            foreach (var element in availabilityZones)
            {
                this._availabilityZones.Add(element);
            }
            return this;
        }
        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        ///             The amount of time, in seconds, after a scaling activity             completes
        /// before any further scaling activities can start.            For more information,
        ///             see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown
        /// Period</a>.         
        /// </para>
        /// </summary>
        public int DefaultCooldown
        {
            get { return this._defaultCooldown.GetValueOrDefault(); }
            set { this._defaultCooldown = value; }
        }


        /// <summary>
        /// Sets the DefaultCooldown property
        /// </summary>
        /// <param name="defaultCooldown">The value to set for the DefaultCooldown property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithDefaultCooldown(int defaultCooldown)
        {
            this._defaultCooldown = defaultCooldown;
            return this;
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this._defaultCooldown.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        ///             The desired capacity for the Auto Scaling group.        
        /// </para>
        /// </summary>
        public int DesiredCapacity
        {
            get { return this._desiredCapacity.GetValueOrDefault(); }
            set { this._desiredCapacity = value; }
        }


        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">The value to set for the DesiredCapacity property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithDesiredCapacity(int desiredCapacity)
        {
            this._desiredCapacity = desiredCapacity;
            return this;
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        ///             The length of time that Auto Scaling waits            before checking
        /// an instance's health status.            The grace period begins when the instance
        /// passes System Status and the Instance Status checks from Amazon EC2. For more information,
        /// see               <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-DescribeInstanceStatus.html">DescribeInstanceStatus</a>.
        ///        
        /// </para>
        /// </summary>
        public int HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod.GetValueOrDefault(); }
            set { this._healthCheckGracePeriod = value; }
        }


        /// <summary>
        /// Sets the HealthCheckGracePeriod property
        /// </summary>
        /// <param name="healthCheckGracePeriod">The value to set for the HealthCheckGracePeriod property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithHealthCheckGracePeriod(int healthCheckGracePeriod)
        {
            this._healthCheckGracePeriod = healthCheckGracePeriod;
            return this;
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this._healthCheckGracePeriod.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        ///             The type of health check for the instances in the Auto Scaling group.
        ///             The health check type can either be <code>EC2</code> for Amazon EC2 or
        /// <code>ELB</code> for Elastic Load Balancing.        
        /// </para>
        /// </summary>
        public string HealthCheckType
        {
            get { return this._healthCheckType; }
            set { this._healthCheckType = value; }
        }


        /// <summary>
        /// Sets the HealthCheckType property
        /// </summary>
        /// <param name="healthCheckType">The value to set for the HealthCheckType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithHealthCheckType(string healthCheckType)
        {
            this._healthCheckType = healthCheckType;
            return this;
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this._healthCheckType != null;
        }


        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///             The name of the launch configuration.        
        /// </para>
        /// </summary>
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }


        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">The value to set for the LaunchConfigurationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithLaunchConfigurationName(string launchConfigurationName)
        {
            this._launchConfigurationName = launchConfigurationName;
            return this;
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }


        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        ///             The maximum size of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public int MaxSize
        {
            get { return this._maxSize.GetValueOrDefault(); }
            set { this._maxSize = value; }
        }


        /// <summary>
        /// Sets the MaxSize property
        /// </summary>
        /// <param name="maxSize">The value to set for the MaxSize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithMaxSize(int maxSize)
        {
            this._maxSize = maxSize;
            return this;
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        ///             The minimum size of the Auto Scaling group.        
        /// </para>
        /// </summary>
        public int MinSize
        {
            get { return this._minSize.GetValueOrDefault(); }
            set { this._minSize = value; }
        }


        /// <summary>
        /// Sets the MinSize property
        /// </summary>
        /// <param name="minSize">The value to set for the MinSize property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithMinSize(int minSize)
        {
            this._minSize = minSize;
            return this;
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        ///             The name of the cluster placement group, if applicable. For          
        ///  more information, go to             <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">
        ///            Using Cluster Instances</a>            in the Amazon EC2 User Guide.  
        ///      
        /// </para>
        /// </summary>
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }


        /// <summary>
        /// Sets the PlacementGroup property
        /// </summary>
        /// <param name="placementGroup">The value to set for the PlacementGroup property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithPlacementGroup(string placementGroup)
        {
            this._placementGroup = placementGroup;
            return this;
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }


        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        ///               A standalone termination policy or a list of termination policies used
        /// to select the instance to terminate.                 The policies are executed in
        /// the order that they are listed.           
        /// </para>
        ///           
        /// <para>
        ///               For more information on creating a termination policy for your Auto
        /// Scaling group, go to               <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/us-termination-policy.html">Instance
        /// Termination Policy for Your Auto Scaling Group</a> in the               the <i>Auto
        /// Scaling Developer Guide</i>.          
        /// </para>
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this._terminationPolicies; }
            set { this._terminationPolicies = value; }
        }

        /// <summary>
        /// Sets the TerminationPolicies property
        /// </summary>
        /// <param name="terminationPolicies">The values to add to the TerminationPolicies collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithTerminationPolicies(params string[] terminationPolicies)
        {
            foreach (var element in terminationPolicies)
            {
                this._terminationPolicies.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the TerminationPolicies property
        /// </summary>
        /// <param name="terminationPolicies">The values to add to the TerminationPolicies collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithTerminationPolicies(IEnumerable<string> terminationPolicies)
        {
            foreach (var element in terminationPolicies)
            {
                this._terminationPolicies.Add(element);
            }
            return this;
        }
        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this._terminationPolicies != null && this._terminationPolicies.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        ///             The subnet identifier for the Amazon VPC connection, if applicable. You
        /// can specify several subnets in a             comma-separated list.         
        /// </para>
        ///         
        /// <para>
        ///             When you specify <code>VPCZoneIdentifier</code> with <code>AvailabilityZones</code>,
        /// ensure that the             subnets' Availability Zones match the values you specify
        /// for <code>AvailabilityZones</code>.        
        /// </para>
        ///         
        /// <para>
        ///             For more information on creating your Auto Scaling group in Amazon VPC
        /// by specifying subnets, see             <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Launch
        /// Auto Scaling Instances into Amazon VPC</a> in the             the <i>Auto Scaling
        /// Developer Guide</i>.        
        /// </para>
        /// </summary>
        public string VPCZoneIdentifier
        {
            get { return this._vPCZoneIdentifier; }
            set { this._vPCZoneIdentifier = value; }
        }


        /// <summary>
        /// Sets the VPCZoneIdentifier property
        /// </summary>
        /// <param name="vPCZoneIdentifier">The value to set for the VPCZoneIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UpdateAutoScalingGroupRequest WithVPCZoneIdentifier(string vPCZoneIdentifier)
        {
            this._vPCZoneIdentifier = vPCZoneIdentifier;
            return this;
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this._vPCZoneIdentifier != null;
        }

    }
}