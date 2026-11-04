/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a notification.
    /// </summary>
    public partial class NotificationConfiguration
    {
        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// One of the following event notification types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>autoscaling:EC2_INSTANCE_LAUNCH</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>autoscaling:EC2_INSTANCE_LAUNCH_ERROR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>autoscaling:EC2_INSTANCE_TERMINATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>autoscaling:EC2_INSTANCE_TERMINATE_ERROR</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>autoscaling:TEST_NOTIFICATION</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Checks to see if the NotificationType property is set.
        /// </summary>
        internal bool IsSetNotificationType() => this.NotificationType != null;

        /// <summary>
        /// Gets and sets the property TopicARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TopicARN { get; set; }

        /// <summary>
        /// Checks to see if the TopicARN property is set.
        /// </summary>
        internal bool IsSetTopicARN() => this.TopicARN != null;
    }
}
