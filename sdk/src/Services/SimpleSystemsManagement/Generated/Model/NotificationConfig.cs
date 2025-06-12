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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Configurations for sending notifications.
    /// </summary>
    public partial class NotificationConfig
    {
        private string _notificationArn;
        private List<string> _notificationEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NotificationType _notificationType;

        /// <summary>
        /// Gets and sets the property NotificationArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) for an Amazon Simple Notification Service (Amazon SNS)
        /// topic. Run Command pushes notifications about command status changes to this topic.
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
        /// The different events for which you can receive notifications. To learn more about
        /// these events, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/monitoring-sns-notifications.html">Monitoring
        /// Systems Manager status changes using Amazon SNS notifications</a> in the <i>Amazon
        /// Web Services Systems Manager User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationEvents
        {
            get { return this._notificationEvents; }
            set { this._notificationEvents = value; }
        }

        // Check to see if NotificationEvents property is set
        internal bool IsSetNotificationEvents()
        {
            return this._notificationEvents != null && (this._notificationEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotificationType. 
        /// <para>
        /// The type of notification.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Command</c>: Receive notification when the status of a command changes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Invocation</c>: For commands sent to multiple managed nodes, receive notification
        /// on a per-node basis when the status of a command changes. 
        /// </para>
        ///  </li> </ul>
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