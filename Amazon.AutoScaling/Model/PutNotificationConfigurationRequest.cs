/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Creates a notification action for an Auto Scaling group when a specified event takes place. </para>
    /// </summary>
    /// <seealso cref="Amazon.AutoScaling.AmazonAutoScaling.PutNotificationConfiguration"/>
    public class PutNotificationConfigurationRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private string topicARN;
        private List<string> notificationTypes = new List<string>();

        /// <summary>
        /// The name of the Auto Scaling Group.
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

        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        public PutNotificationConfigurationRequest WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this.autoScalingGroupName = autoScalingGroupName;
            return this;
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

        /// <summary>
        /// Sets the TopicARN property
        /// </summary>
        /// <param name="topicARN">The value to set for the TopicARN property </param>
        /// <returns>this instance</returns>
        public PutNotificationConfigurationRequest WithTopicARN(string topicARN)
        {
            this.topicARN = topicARN;
            return this;
        }
            

        // Check to see if TopicARN property is set
        internal bool IsSetTopicARN()
        {
            return this.topicARN != null;       
        }

        /// <summary>
        /// The type of events for this action to start.
        ///  
        /// </summary>
        public List<string> NotificationTypes
        {
            get { return this.notificationTypes; }
            set { this.notificationTypes = value; }
        }
        /// <summary>
        /// Adds elements to the NotificationTypes collection
        /// </summary>
        /// <param name="notificationTypes">The values to add to the NotificationTypes collection </param>
        /// <returns>this instance</returns>
        public PutNotificationConfigurationRequest WithNotificationTypes(params string[] notificationTypes)
        {
            foreach (string element in notificationTypes)
            {
                this.notificationTypes.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the NotificationTypes collection
        /// </summary>
        /// <param name="notificationTypes">The values to add to the NotificationTypes collection </param>
        /// <returns>this instance</returns>
        public PutNotificationConfigurationRequest WithNotificationTypes(IEnumerable<string> notificationTypes)
        {
            foreach (string element in notificationTypes)
            {
                this.notificationTypes.Add(element);
            }

            return this;
        }

        // Check to see if NotificationTypes property is set
        internal bool IsSetNotificationTypes()
        {
            return this.notificationTypes.Count > 0;       
        }
    }
}
    
