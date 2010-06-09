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
    /// Deletes the specified LaunchConfiguration. The specified launch configuration must not be currently
    /// attached to any auto scaling group. Once this call completes, the launch configuration is no longer
    /// available for use.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DeleteLaunchConfigurationRequest
    {
        private string launchConfigurationNameField;

        /// <summary>
        /// Gets and sets the LaunchConfigurationName property.
        /// Launch configuration to be deleted. The specifed launch configuration cannot be attached to
        /// any AutoScalingGroup.
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
        /// <param name="launchConfigurationName">Launch configuration to be deleted. The specifed launch configuration cannot be attached to
        /// any AutoScalingGroup.</param>
        /// <returns>this instance</returns>
        public DeleteLaunchConfigurationRequest WithLaunchConfigurationName(string launchConfigurationName)
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

    }
}
