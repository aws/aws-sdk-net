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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
        private string _autoScalingGroupName;
        private string _notificationType;
        private string _topicARN;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

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
        [AWSProperty(Min=1, Max=255)]
        public string NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

        /// <summary>
        /// Gets and sets the property TopicARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TopicARN
        {
            get { return this._topicARN; }
            set { this._topicARN = value; }
        }

        // Check to see if TopicARN property is set
        internal bool IsSetTopicARN()
        {
            return this._topicARN != null;
        }

    }
}