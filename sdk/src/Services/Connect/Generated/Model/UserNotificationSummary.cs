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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Summary information about a notification for a specific user, including the user's
    /// read status.
    /// </summary>
    public partial class UserNotificationSummary
    {
        private Dictionary<string, string> _content = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _createdAt;
        private DateTime? _expiresAt;
        private string _instanceId;
        private string _notificationId;
        private NotificationStatus _notificationStatus;
        private NotificationPriority _priority;
        private string _recipientId;
        private NotificationSource _source;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The localized content of the notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the notification was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the notification expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationId. 
        /// <para>
        /// The unique identifier for the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NotificationId
        {
            get { return this._notificationId; }
            set { this._notificationId = value; }
        }

        // Check to see if NotificationId property is set
        internal bool IsSetNotificationId()
        {
            return this._notificationId != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationStatus. 
        /// <para>
        /// The status of the notification for this user. Valid values are READ, UNREAD, and HIDDEN.
        /// </para>
        /// </summary>
        public NotificationStatus NotificationStatus
        {
            get { return this._notificationStatus; }
            set { this._notificationStatus = value; }
        }

        // Check to see if NotificationStatus property is set
        internal bool IsSetNotificationStatus()
        {
            return this._notificationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of the notification.
        /// </para>
        /// </summary>
        public NotificationPriority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property RecipientId. 
        /// <para>
        /// The identifier of the recipient user.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RecipientId
        {
            get { return this._recipientId; }
            set { this._recipientId = value; }
        }

        // Check to see if RecipientId property is set
        internal bool IsSetRecipientId()
        {
            return this._recipientId != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source that created the notification. Valid values are CUSTOMER, RULES, and SYSTEM.
        /// </para>
        /// </summary>
        public NotificationSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}