/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Creates a new AutoScalingGroup with the specified name.
    /// You must not have already used up your entire quota of AutoScalingGroups in order for this call to be
    /// successful. Once the creation request is completed, the AutoScalingGroup is ready to be used in other calls.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class CreateAutoScalingGroupRequest
    {
        private string autoScalingGroupNameField;
        private string launchConfigurationNameField;
        private Decimal? minSizeField;
        private Decimal? maxSizeField;
        private Decimal? cooldownField;
        private List<string> availabilityZonesField;
        private List<string> loadBalancerNamesField;

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// Name of AutoScalingGroup. Must contain less than 256 alphanumeric characters. Must be unique within
        /// your Amazon Web Services (AWS) account.
        /// </summary>
        [XmlElementAttribute(ElementName = "AutoScalingGroupName")]
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupNameField ; }
            set { this.autoScalingGroupNameField= value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">Name of AutoScalingGroup. Must contain less than 256 alphanumeric characters. Must be unique within
        /// your Amazon Web Services (AWS) account.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupNameField = autoScalingGroupName;
            return this;
        }

        /// <summary>
        /// Checks if AutoScalingGroupName property is set
        /// </summary>
        /// <returns>true if AutoScalingGroupName property is set</returns>
        public bool IsSetAutoScalingGroupName()
        {
            return  this.autoScalingGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the LaunchConfigurationName property.
        /// Name of launch configuration to use with group.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchConfigurationName")]
        public string LaunchConfigurationName
        {
            get { return this.launchConfigurationNameField ; }
            set { this.launchConfigurationNameField= value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">Name of launch configuration to use with group.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithLaunchConfigurationName(string launchConfigurationName)
        {
            this.launchConfigurationNameField = launchConfigurationName;
            return this;
        }

        /// <summary>
        /// Checks if LaunchConfigurationName property is set
        /// </summary>
        /// <returns>true if LaunchConfigurationName property is set</returns>
        public bool IsSetLaunchConfigurationName()
        {
            return  this.launchConfigurationNameField != null;
        }

        /// <summary>
        /// Gets and sets the MinSize property.
        /// Minimum size of group. Must be a positive integer no greater than MaxSize. If you set the minimum size
        /// of the group to zero, and the group has a trigger that is based on a metric produced by itself, the
        /// trigger can drive the instance count to zero. In this case, the service will never restart itself
        /// without manual intervention, since there are no instances running to generate metrics.
        /// </summary>
        [XmlElementAttribute(ElementName = "MinSize")]
        public Decimal MinSize
        {
            get { return this.minSizeField.GetValueOrDefault() ; }
            set { this.minSizeField= value; }
        }

        /// <summary>
        /// Sets the MinSize property
        /// </summary>
        /// <param name="minSize">Minimum size of group. Must be a positive integer no greater than MaxSize. If you set the minimum size
        /// of the group to zero, and the group has a trigger that is based on a metric produced by itself, the
        /// trigger can drive the instance count to zero. In this case, the service will never restart itself
        /// without manual intervention, since there are no instances running to generate metrics.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithMinSize(Decimal minSize)
        {
            this.minSizeField = minSize;
            return this;
        }

        /// <summary>
        /// Checks if MinSize property is set
        /// </summary>
        /// <returns>true if MinSize property is set</returns>
        public bool IsSetMinSize()
        {
            return  this.minSizeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MaxSize property.
        /// Maximum size of the group. Must be a positive integer that is less than 10000. Maximum number of EC2
        /// instances allowed for caller has not been exceeded. No error will be thrown if you set MaxSize to
        /// greater than your EC2 instance limit. However, the maximum AutoScalingGroup size will be limited by
        /// the smaller of this value and your EC2 maximum.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxSize")]
        public Decimal MaxSize
        {
            get { return this.maxSizeField.GetValueOrDefault() ; }
            set { this.maxSizeField= value; }
        }

        /// <summary>
        /// Sets the MaxSize property
        /// </summary>
        /// <param name="maxSize">Maximum size of the group. Must be a positive integer that is less than 10000. Maximum number of EC2
        /// instances allowed for caller has not been exceeded. No error will be thrown if you set MaxSize to
        /// greater than your EC2 instance limit. However, the maximum AutoScalingGroup size will be limited by
        /// the smaller of this value and your EC2 maximum.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithMaxSize(Decimal maxSize)
        {
            this.maxSizeField = maxSize;
            return this;
        }

        /// <summary>
        /// Checks if MaxSize property is set
        /// </summary>
        /// <returns>true if MaxSize property is set</returns>
        public bool IsSetMaxSize()
        {
            return  this.maxSizeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Cooldown property.
        /// The amount of time after a scaling activity completes before any further trigger-related scaling
        /// activities can start. Time is in seconds. Default is 0.
        /// </summary>
        [XmlElementAttribute(ElementName = "Cooldown")]
        public Decimal Cooldown
        {
            get { return this.cooldownField.GetValueOrDefault() ; }
            set { this.cooldownField= value; }
        }

        /// <summary>
        /// Sets the Cooldown property
        /// </summary>
        /// <param name="cooldown">The amount of time after a scaling activity completes before any further trigger-related scaling
        /// activities can start. Time is in seconds. Default is 0.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithCooldown(Decimal cooldown)
        {
            this.cooldownField = cooldown;
            return this;
        }

        /// <summary>
        /// Checks if Cooldown property is set
        /// </summary>
        /// <returns>true if Cooldown property is set</returns>
        public bool IsSetCooldown()
        {
            return  this.cooldownField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZones property.
        /// Availability Zones for the group. Must contain a list of one or more valid Availability Zones.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZones")]
        public List<string> AvailabilityZones
        {
            get
            {
                if (this.availabilityZonesField == null)
                {
                    this.availabilityZonesField = new List<string>();
                }
                return this.availabilityZonesField;
            }
            set { this.availabilityZonesField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZones property
        /// </summary>
        /// <param name="list">Availability Zones for the group. Must contain a list of one or more valid Availability Zones.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithAvailabilityZones(params string[] list)
        {
            foreach (string item in list)
            {
                AvailabilityZones.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZones property is set
        /// </summary>
        /// <returns>true if AvailabilityZones property is set</returns>
        public bool IsSetAvailabilityZones()
        {
            return (AvailabilityZones.Count > 0);
        }

        /// <summary>
        /// Gets and sets the LoadBalancerNames property.
        /// List of LoadBalancers to use. LoadBalancer must exist in the Elastic Load Balancing Service,
        /// within the scope of caller's AWS account.
        /// </summary>
        [XmlElementAttribute(ElementName = "LoadBalancerNames")]
        public List<string> LoadBalancerNames
        {
            get
            {
                if (this.loadBalancerNamesField == null)
                {
                    this.loadBalancerNamesField = new List<string>();
                }
                return this.loadBalancerNamesField;
            }
            set { this.loadBalancerNamesField = value; }
        }

        /// <summary>
        /// Sets the LoadBalancerNames property
        /// </summary>
        /// <param name="list">List of LoadBalancers to use. LoadBalancer must exist in the Elastic Load Balancing Service,
        /// within the scope of caller's AWS account.</param>
        /// <returns>this instance</returns>
        public CreateAutoScalingGroupRequest WithLoadBalancerNames(params string[] list)
        {
            foreach (string item in list)
            {
                LoadBalancerNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if LoadBalancerNames property is set
        /// </summary>
        /// <returns>true if LoadBalancerNames property is set</returns>
        public bool IsSetLoadBalancerNames()
        {
            return (LoadBalancerNames.Count > 0);
        }

    }
}
