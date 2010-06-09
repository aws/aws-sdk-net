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
    /// Adjusts the desired size of the AutoScalingGroup by initiating scaling activities. When reducing
    /// the size of the group, it is not possible to define which EC2 instances will be terminated. This applies
    /// to any auto-scaling decisions that might result in the termination of instances. When a trigger fires, it
    /// is possible that it will override the desired capacity set for this group.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class SetDesiredCapacityRequest
    {
        private string autoScalingGroupNameField;
        private Decimal? desiredCapacityField;

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// Name of AutoScalingGroup.
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
        /// <param name="autoScalingGroupName">Name of AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public SetDesiredCapacityRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// Gets and sets the DesiredCapacity property.
        /// New capacity setting for the group. Should be between AutoScalingGroup's minimum and maximum size settings.
        /// </summary>
        [XmlElementAttribute(ElementName = "DesiredCapacity")]
        public Decimal DesiredCapacity
        {
            get { return this.desiredCapacityField.GetValueOrDefault() ; }
            set { this.desiredCapacityField= value; }
        }

        /// <summary>
        /// Sets the DesiredCapacity property
        /// </summary>
        /// <param name="desiredCapacity">New capacity setting for the group. Should be between AutoScalingGroup's minimum and maximum size settings.</param>
        /// <returns>this instance</returns>
        public SetDesiredCapacityRequest WithDesiredCapacity(Decimal desiredCapacity)
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
            return  this.desiredCapacityField.HasValue;
        }

    }
}
