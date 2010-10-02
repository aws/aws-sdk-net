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
    /// Returns the activity to terminate the instance.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class TerminateInstanceInAutoScalingGroupResult
    {
        private Activity activityField;

        /// <summary>
        /// Gets and sets the Activity property.
        /// The activity to terminate the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Activity")]
        public Activity Activity
        {
            get { return this.activityField; }
            set { this.activityField = value; }
        }

        /// <summary>
        /// Sets the Activity property
        /// </summary>
        /// <param name="activity">The activity to terminate the instance.</param>
        /// <returns>this instance</returns>
        public TerminateInstanceInAutoScalingGroupResult WithActivity(Activity activity)
        {
            this.activityField = activity;
            return this;
        }

        /// <summary>
        /// Checks if Activity property is set
        /// </summary>
        /// <returns>true if Activity property is set</returns>
        public bool IsSetActivity()
        {
            return this.activityField != null;
        }

    }
}
