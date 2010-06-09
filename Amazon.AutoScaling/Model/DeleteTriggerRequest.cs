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
    /// Deletes the specified trigger. If a trigger is currently in progress, it continues
    /// to run until its activities are complete.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class DeleteTriggerRequest
    {
        private string autoScalingGroupNameField;
        private string triggerNameField;

        /// <summary>
        /// Gets and sets the AutoScalingGroupName property.
        /// Name of the AutoScalingGroup associated with the trigger. The AutoScalingGroup
        /// must exist within the scope of the caller's AWS account.
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
        /// <param name="autoScalingGroupName">Name of the AutoScalingGroup associated with the trigger. The AutoScalingGroup
        /// must exist within the scope of the caller's AWS account.</param>
        /// <returns>this instance</returns>
        public DeleteTriggerRequest WithAutoScalingGroupName(string autoScalingGroupName)
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
        /// Gets and sets the TriggerName property.
        /// Name of the trigger to be deleted. The trigger must exist within the scope of the
        /// caller's AWS account. An in-progress trigger will continue until completion.
        /// </summary>
        [XmlElementAttribute(ElementName = "TriggerName")]
        public string TriggerName
        {
            get { return this.triggerNameField ; }
            set { this.triggerNameField= value; }
        }

        /// <summary>
        /// Sets the TriggerName property
        /// </summary>
        /// <param name="triggerName">Name of the trigger to be deleted. The trigger must exist within the scope of the
        /// caller's AWS account. An in-progress trigger will continue until completion.</param>
        /// <returns>this instance</returns>
        public DeleteTriggerRequest WithTriggerName(string triggerName)
        {
            this.triggerNameField = triggerName;
            return this;
        }

        /// <summary>
        /// Checks if TriggerName property is set
        /// </summary>
        /// <returns>true if TriggerName property is set</returns>
        public bool IsSetTriggerName()
        {
            return  this.triggerNameField != null;
        }

    }
}
