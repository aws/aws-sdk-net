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
    /// Returns a full description of the trigger AutoScalingGroup.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeTriggersResult
    {
        private List<Trigger> triggersField;
        /// <summary>
        /// Gets and sets the Triggers property.
        /// List of structures containing the information details for triggers. There is currently a maximum
        /// of 1 trigger per AutoScalingGroup. Always returned. If no trigger exists for the given
        /// AutoScalingGroup, an empty list is returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "Triggers")]
        public List<Trigger> Triggers
        {
            get
            {
                if (this.triggersField == null)
                {
                    this.triggersField = new List<Trigger>();
                }
                return this.triggersField;
            }
            set { this.triggersField = value; }
        }

        /// <summary>
        /// Sets the Triggers property
        /// </summary>
        /// <param name="list">List of structures containing the information details for triggers. There is currently a maximum
        /// of 1 trigger per AutoScalingGroup. Always returned. If no trigger exists for the given
        /// AutoScalingGroup, an empty list is returned.</param>
        /// <returns>this instance</returns>
        public DescribeTriggersResult WithTriggers(params Trigger[] list)
        {
            foreach (Trigger item in list)
            {
                Triggers.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Triggers property is set
        /// </summary>
        /// <returns>true if Triggers property is set</returns>
        public bool IsSetTriggers()
        {
            return (Triggers.Count > 0);
        }

    }
}
