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

/*
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Configurations for sending notifications.
    /// </summary>
    public partial class NotificationConfig
    {
        private string _notificationArn;
        private List<string> _notificationEvents = new List<string>();
        private NotificationType _notificationType;

        /// <summary>
        /// Gets and sets the property NotificationArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) for a Simple Notification Service (SNS) topic. SSM pushes
        /// notifications about command status changes to this topic.
        /// </para>
        /// </summary>
        public string NotificationArn
        {
            get { return this._notificationArn; }
            set { this._notificationArn = value; }
        }

        // Check to see if NotificationArn property is set
        internal bool IsSetNotificationArn()
        {
            return this._notificationArn != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationEvents. 
        /// <para>
        /// The different events for which you can receive notifications. These events include
        /// the following: All (events), InProgress, Success, TimedOut, Cancelled, Failed. To
        /// learn more about these events, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitor-commands.html">Monitoring
        /// Commands</a> in the <i>Amazon Elastic Compute Cloud User Guide </i>.
        /// </para>
        /// </summary>
        public List<string> NotificationEvents
        {
            get { return this._notificationEvents; }
            set { this._notificationEvents = value; }
        }

        // Check to see if NotificationEvents property is set
        internal bool IsSetNotificationEvents()
        {
            return this._notificationEvents != null && this._notificationEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// Command: Receive notification when the status of a command changes. Invocation: For
        /// commands sent to multiple instances, receive notification on a per-instance basis
        /// when the status of a command changes. 
        /// </para>
        /// </summary>
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
            set { this._notificationType = value; }
        }

        // Check to see if NotificationType property is set
        internal bool IsSetNotificationType()
        {
            return this._notificationType != null;
        }

    }
}