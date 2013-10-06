/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para>The <c>AutoScalingNotificationTypes</c> data type.</para>
    /// </summary>
    public class DescribeAutoScalingNotificationTypesResult
    {
        
        private List<string> autoScalingNotificationTypes = new List<string>();

        /// <summary>
        /// Returns a list of all notification types supported by Auto Scaling. They are: <ul> <li><c>autoscaling:EC2_INSTANCE_LAUNCH</c></li>
        /// <li><c>autoscaling:EC2_INSTANCE_LAUNCH_ERROR</c></li> <li><c>autoscaling:EC2_INSTANCE_TERMINATE</c></li>
        /// <li><c>autoscaling:EC2_INSTANCE_TERMINATE_ERROR</c></li> <li><c>autoscaling:TEST_NOTIFICATION</c></li> </ul>
        ///  
        /// </summary>
        public List<string> AutoScalingNotificationTypes
        {
            get { return this.autoScalingNotificationTypes; }
            set { this.autoScalingNotificationTypes = value; }
        }
        /// <summary>
        /// Adds elements to the AutoScalingNotificationTypes collection
        /// </summary>
        /// <param name="autoScalingNotificationTypes">The values to add to the AutoScalingNotificationTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingNotificationTypesResult WithAutoScalingNotificationTypes(params string[] autoScalingNotificationTypes)
        {
            foreach (string element in autoScalingNotificationTypes)
            {
                this.autoScalingNotificationTypes.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AutoScalingNotificationTypes collection
        /// </summary>
        /// <param name="autoScalingNotificationTypes">The values to add to the AutoScalingNotificationTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingNotificationTypesResult WithAutoScalingNotificationTypes(IEnumerable<string> autoScalingNotificationTypes)
        {
            foreach (string element in autoScalingNotificationTypes)
            {
                this.autoScalingNotificationTypes.Add(element);
            }

            return this;
        }

        // Check to see if AutoScalingNotificationTypes property is set
        internal bool IsSetAutoScalingNotificationTypes()
        {
            return this.autoScalingNotificationTypes.Count > 0;
        }
    }
}
