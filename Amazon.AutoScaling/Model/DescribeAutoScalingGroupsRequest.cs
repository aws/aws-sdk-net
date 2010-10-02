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
    /// Returns a full description of the AutoScalingGroups from the given list. This includes all Amazon EC2
    /// instances that are members of the group. If a list of names is not provided, then the full details of all
    /// AutoScalingGroups is returned.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DescribeAutoScalingGroupsRequest
    {
        private List<string> autoScalingGroupNamesField;

        /// <summary>
        /// Gets and sets the AutoScalingGroupNames property.
        /// List of AutoScalingGroups from which to retrieve status information. Group names must exist.
        /// </summary>
        [XmlElementAttribute(ElementName = "AutoScalingGroupNames")]
        public List<string> AutoScalingGroupNames
        {
            get
            {
                if (this.autoScalingGroupNamesField == null)
                {
                    this.autoScalingGroupNamesField = new List<string>();
                }
                return this.autoScalingGroupNamesField;
            }
            set { this.autoScalingGroupNamesField = value; }
        }

        /// <summary>
        /// Sets the AutoScalingGroupNames property
        /// </summary>
        /// <param name="list">List of AutoScalingGroups from which to retrieve status information. Group names must exist.</param>
        /// <returns>this instance</returns>
        public DescribeAutoScalingGroupsRequest WithAutoScalingGroupNames(params string[] list)
        {
            foreach (string item in list)
            {
                AutoScalingGroupNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AutoScalingGroupNames property is set
        /// </summary>
        /// <returns>true if AutoScalingGroupNames property is set</returns>
        public bool IsSetAutoScalingGroupNames()
        {
            return (AutoScalingGroupNames.Count > 0);
        }

    }
}
