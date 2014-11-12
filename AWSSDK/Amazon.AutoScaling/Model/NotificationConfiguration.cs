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
    /// The <code>NotificationConfiguration</code> data type.
    /// </summary>
    public partial class NotificationConfiguration
    {
        private string _autoScalingGroupName;
        private string _notificationType;
        private string _topicARN;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///         Specifies the Auto Scaling group name.        
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NotificationConfiguration WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        ///         The types of events for an action to start.        
        /// </para>
        /// </summary>
        public string NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }


        /// <summary>
        /// Sets the NotificationType property
        /// </summary>
        /// <param name="notificationType">The value to set for the NotificationType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NotificationConfiguration WithNotificationType(string notificationType)
        {
            this._notificationType = notificationType;
            return this;
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }


        /// <summary>
        /// Gets and sets the property TopicARN. 
        /// <para>
        ///         The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS)
        /// topic.        
        /// </para>
        /// </summary>
        public string TopicARN
        {
            get { return this._topicARN; }
            set { this._topicARN = value; }
        }


        /// <summary>
        /// Sets the TopicARN property
        /// </summary>
        /// <param name="topicARN">The value to set for the TopicARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NotificationConfiguration WithTopicARN(string topicARN)
        {
            this._topicARN = topicARN;
            return this;
        }

        // Check to see if TopicARN property is set
        internal bool IsSetTopicARN()
        {
            return this._topicARN != null;
        }

    }
}