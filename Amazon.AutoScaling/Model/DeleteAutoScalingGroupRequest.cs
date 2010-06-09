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
    /// Deletes all configuration for the specified AutoScalingGroup and deletes the group.
    /// In order to successfully call this API, no triggers can be currently in progress. Once this call
    /// successfully executes, no further triggers will begin, and the specified AutoScalingGroup will not be
    /// available for use in other API calls.
    ///
    /// You cannot delete an AutoScalingGroup if it contains instances or there are scaling activities in progress.
    /// Before attempting to delete an AutoScalingGroup, you should use the UpdateAutoScalingGroup API to set the minimum
    /// and maximum size of the AutoScalingGroup to zero. This will remove all instances and avoid problems with a
    /// previously set trigger preventing the deletion of the AutoScalingGroup.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DeleteAutoScalingGroupRequest
    {
        private string autoScalingGroupNameField;

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// Name of AutoScalingGroup to be deleted.
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
        /// <param name="autoScalingGroupName">Name of AutoScalingGroup to be deleted.</param>
        /// <returns>this instance</returns>
        public DeleteAutoScalingGroupRequest WithAutoScalingGroupName(string autoScalingGroupName)
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

    }
}
