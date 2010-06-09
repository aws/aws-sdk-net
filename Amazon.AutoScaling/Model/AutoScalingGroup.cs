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
    ///<summary>
    ///The AutoScalingGroup data type.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class AutoScalingGroup
    {
        private string autoScalingGroupNameField;
        private string launchConfigurationNameField;
        private Decimal? minSizeField;
        private Decimal? maxSizeField;
        private Decimal? desiredCapacityField;
        private Decimal? cooldownField;
        private List<string> availabilityZonesField;
        private List<string> loadBalancerNamesField;
        private List<Instance> instancesField;
        private DateTime? createdTimeField;

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// Name of the AutoScalingGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "AutoScalingGroupName")]
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupNameField; }
            set { this.autoScalingGroupNameField = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">Name of the AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithAutoScalingGroupName(string autoScalingGroupName)
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
            return this.autoScalingGroupNameField != null;
        }

        /// <summary>
        /// Gets and sets the LaunchConfigurationName property.
        /// Name of the associated LaunchConfiguration.
        /// </summary>
        [XmlElementAttribute(ElementName = "LaunchConfigurationName")]
        public string LaunchConfigurationName
        {
            get { return this.launchConfigurationNameField; }
            set { this.launchConfigurationNameField = value; }
        }

        /// <summary>
        /// Sets the LaunchConfigurationName property
        /// </summary>
        /// <param name="launchConfigurationName">Name of the associated LaunchConfiguration.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithLaunchConfigurationName(string launchConfigurationName)
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
            return this.launchConfigurationNameField != null;
        }

        /// <summary>
        /// Gets and sets the MinSize property.
        /// Minimum size of the AutoScalingGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "MinSize")]
        public Decimal MinSize
        {
            get { return this.minSizeField.GetValueOrDefault(); }
            set { this.minSizeField = value; }
        }

        /// <summary>
        /// Sets the MinSize property
        /// </summary>
        /// <param name="minSize">Minimum size of the AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithMinSize(Decimal minSize)
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
            return this.minSizeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MaxSize property.
        /// Maximum size of the AutoScalingGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxSize")]
        public Decimal MaxSize
        {
            get { return this.maxSizeField.GetValueOrDefault(); }
            set { this.maxSizeField = value; }
        }

        /// <summary>
        /// Sets the MaxSize property
        /// </summary>
        /// <param name="maxSize">Maximum size of the AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithMaxSize(Decimal maxSize)
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
            return this.maxSizeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the DesiredCapacity property.
        /// Desired capacity for the AutoScalingGroup.
        /// </summary>
        [XmlElementAttribute(ElementName = "DesiredCapacity")]
        public Decimal DesiredCapacity
        {
            get { return this.desiredCapacityField.GetValueOrDefault(); }
            set { this.desiredCapacityField = value; }
        }

        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">Desired capacity for the AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithDesiredCapacity(Decimal desiredCapacity)
        {
            this.desiredCapacityField = desiredCapacity;
            return this;
        }

        /// <summary>
        /// Checks if DesiredCapacity property is set
        /// </summary>
        /// <returns>true if DesiredCapacity property is set</returns>
        public bool IsSetDesiredCapacity()
        {
            return this.desiredCapacityField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Cooldown property.
        /// The number of seconds after a ScalingActivity completes before any further scaling activities can start.
        /// Default is 0.
        /// </summary>
        [XmlElementAttribute(ElementName = "Cooldown")]
        public Decimal Cooldown
        {
            get { return this.cooldownField.GetValueOrDefault(); }
            set { this.cooldownField = value; }
        }

        /// <summary>
        /// Sets the Cooldown property
        /// </summary>
        /// <param name="cooldown">The number of seconds after a ScalingActivity completes before any further scaling activities can start.
        /// Default is 0.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithCooldown(Decimal cooldown)
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
            return this.cooldownField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZones property.
        /// Availability Zones for the group. Restricted to one availability zone.
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
        /// <param name="list">Availability Zones for the group. Restricted to one availability zone.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithAvailabilityZones(params string[] list)
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
        /// List of load balancer names.
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
        /// <param name="list">List of load balancer names.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithLoadBalancerNames(params string[] list)
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
        /// <summary>
        /// Gets and sets the Instances property.
        /// Summary list of EC2 instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "Instances")]
        public List<Instance> Instances
        {
            get
            {
                if (this.instancesField == null)
                {
                    this.instancesField = new List<Instance>();
                }
                return this.instancesField;
            }
            set { this.instancesField = value; }
        }

        /// <summary>
        /// Sets the Instances property
        /// </summary>
        /// <param name="list">Summary list of EC2 instances.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithInstances(params Instance[] list)
        {
            foreach (Instance item in list)
            {
                Instances.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Instances property is set
        /// </summary>
        /// <returns>true if Instances property is set</returns>
        public bool IsSetInstances()
        {
            return (Instances.Count > 0);
        }

        /// <summary>
        /// Gets and sets the CreatedTime property.
        /// The date and time that this AutoScalingGroup was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreatedTime")]
        public DateTime CreatedTime
        {
            get { return this.createdTimeField.GetValueOrDefault(); }
            set { this.createdTimeField = value; }
        }

        /// <summary>
        /// Sets the CreatedTime property
        /// </summary>
        /// <param name="createdTime">The date and time that this AutoScalingGroup was created.</param>
        /// <returns>this instance</returns>
        public AutoScalingGroup WithCreatedTime(DateTime createdTime)
        {
            this.createdTimeField = createdTime;
            return this;
        }

        /// <summary>
        /// Checks if CreatedTime property is set
        /// </summary>
        /// <returns>true if CreatedTime property is set</returns>
        public bool IsSetCreatedTime()
        {
            return this.createdTimeField.HasValue;
        }

    }
}
