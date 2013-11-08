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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutNotificationConfiguration operation.
    /// <para> Configures an Auto Scaling group to send notifications when specified events take place. Subscribers to this topic can have messages
    /// for events delivered to an endpoint such as a web server or email address. </para> <para>For more information see <a
    /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html" >Get Email Notifications When Your Auto
    /// Scaling Group Changes</a> </para> <para>A new <c>PutNotificationConfiguration</c> overwrites an existing configuration. </para>
    /// </summary>
    public partial class PutNotificationConfigurationRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private string topicARN;
        private List<string> notificationTypes = new List<string>();

        /// <summary>
        /// The name of the Auto Scaling group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TopicARN
        {
            get { return this.topicARN; }
            set { this.topicARN = value; }
        }

        // Check to see if TopicARN property is set
        internal bool IsSetTopicARN()
        {
            return this.topicARN != null;
        }

        /// <summary>
        /// The type of event that will cause the notification to be sent. For details about notification types supported by Auto Scaling, see
        /// <a>DescribeAutoScalingNotificationTypes</a>.
        ///  
        /// </summary>
        public List<string> NotificationTypes
        {
            get { return this.notificationTypes; }
            set { this.notificationTypes = value; }
        }

        // Check to see if NotificationTypes property is set
        internal bool IsSetNotificationTypes()
        {
            return this.notificationTypes.Count > 0;
        }

    }
}
    
