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
    /// Updates the configuration for the specified AutoScalingGroup. If the new values are specified for the
    /// MaxSize or MinSize parameters, then there will be an implicit call to SetDesiredCapacity to set the group
    /// to the new MaxSize. All optional parameters are left unchanged if not passed in the request.
    ///
    /// The new settings are registered upon the completion of this call. Any launch configuration settings take effect
    /// on any triggers after this call returns. Triggers that are currently in progress aren't affected.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class UpdateAutoScalingGroupRequest
    {
        private string autoScalingGroupNameField;
        private string launchConfigurationNameField;
        private Decimal? minSizeField;
        private Decimal? maxSizeField;
        private Decimal? cooldownField;
        private List<string> availabilityZonesField;

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
        public UpdateAutoScalingGroupRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// New launch configuration to use with AutoScalingGroup. Default is current launch configuration.
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
        /// <param name="launchConfigurationName">New launch configuration to use with AutoScalingGroup. Default is current launch configuration.</param>
        /// <returns>this instance</returns>
        public UpdateAutoScalingGroupRequest WithLaunchConfigurationName(string launchConfigurationName)
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
        /// New setting for minimum size of the AutoScalingGroup. Must be a positive integer no greater than MaxSize.
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
        /// <param name="minSize">New setting for minimum size of the AutoScalingGroup. Must be a positive integer no greater than MaxSize.</param>
        /// <returns>this instance</returns>
        public UpdateAutoScalingGroupRequest WithMinSize(Decimal minSize)
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
        /// New setting for maximum size of the AutoScalingGroup. Must be a positive integer greater than MinSize
        /// and less than 10000. No error is thrown if you set MaxSize to greater than your EC2 instance limit. However,
        /// the maximum AutoScalingGroup size will be limited by the smaller of this value and your EC2 maximum.
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
        /// <param name="maxSize">New setting for maximum size of the AutoScalingGroup. Must be a positive integer greater than MinSize
        /// and less than 10000. No error is thrown if you set MaxSize to greater than your EC2 instance limit. However,
        /// the maximum AutoScalingGroup size will be limited by the smaller of this value and your EC2 maximum.</param>
        /// <returns>this instance</returns>
        public UpdateAutoScalingGroupRequest WithMaxSize(Decimal maxSize)
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
        /// Gets and sets the Cooldown property.
        /// The amount of time after a Scaling Activity completes before any further trigger-related scaling activities
        /// can start. Time is in seconds.
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
        /// <param name="cooldown">The amount of time after a Scaling Activity completes before any further trigger-related scaling activities
        /// can start. Time is in seconds.</param>
        /// <returns>this instance</returns>
        public UpdateAutoScalingGroupRequest WithCooldown(Decimal cooldown)
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
        public UpdateAutoScalingGroupRequest WithAvailabilityZones(params string[] list)
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

    }
}
