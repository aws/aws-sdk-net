/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// The <code>AutoScalingNotificationTypes</code> data type.
    /// </summary>
    public partial class DescribeAutoScalingNotificationTypesResult
    {
        private List<string> _autoScalingNotificationTypes = new List<string>();


        /// <summary>
        /// Gets and sets the property AutoScalingNotificationTypes. 
        /// <para>
        /// Returns a list of all notification types supported by Auto Scaling. They are:
        /// </para>
        ///          <ul>            <li>
        /// <para>
        /// <code>autoscaling:EC2_INSTANCE_LAUNCH</code>
        /// </para>
        /// </li>            <li>
        /// <para>
        /// <code>autoscaling:EC2_INSTANCE_LAUNCH_ERROR</code>
        /// </para>
        /// </li>            <li>
        /// <para>
        /// <code>autoscaling:EC2_INSTANCE_TERMINATE</code>
        /// </para>
        /// </li>            <li>
        /// <para>
        /// <code>autoscaling:EC2_INSTANCE_TERMINATE_ERROR</code>
        /// </para>
        /// </li>            <li>
        /// <para>
        /// <code>autoscaling:TEST_NOTIFICATION</code>
        /// </para>
        /// </li>                </ul>
        /// </summary>
        public List<string> AutoScalingNotificationTypes
        {
            get { return this._autoScalingNotificationTypes; }
            set { this._autoScalingNotificationTypes = value; }
        }

        /// <summary>
        /// Sets the AutoScalingNotificationTypes property
        /// </summary>
        /// <param name="autoScalingNotificationTypes">The values to add to the AutoScalingNotificationTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingNotificationTypesResult WithAutoScalingNotificationTypes(params string[] autoScalingNotificationTypes)
        {
            foreach (var element in autoScalingNotificationTypes)
            {
                this._autoScalingNotificationTypes.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the AutoScalingNotificationTypes property
        /// </summary>
        /// <param name="autoScalingNotificationTypes">The values to add to the AutoScalingNotificationTypes collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeAutoScalingNotificationTypesResult WithAutoScalingNotificationTypes(IEnumerable<string> autoScalingNotificationTypes)
        {
            foreach (var element in autoScalingNotificationTypes)
            {
                this._autoScalingNotificationTypes.Add(element);
            }
            return this;
        }
        // Check to see if AutoScalingNotificationTypes property is set
        internal bool IsSetAutoScalingNotificationTypes()
        {
            return this._autoScalingNotificationTypes != null && this._autoScalingNotificationTypes.Count > 0; 
        }

    }
}