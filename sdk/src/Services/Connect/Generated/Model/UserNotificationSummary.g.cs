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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Summary information about a notification for a specific user, including the user's
    /// read status.
    /// </summary>
    public partial class UserNotificationSummary
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The localized content of the notification.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Content { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null && (this.Content.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the notification was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The timestamp when the notification expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property NotificationId. 
        /// <para>
        /// The unique identifier for the notification.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NotificationId { get; set; }

        /// <summary>
        /// Checks to see if the NotificationId property is set.
        /// </summary>
        internal bool IsSetNotificationId() => this.NotificationId != null;

        /// <summary>
        /// Gets and sets the property NotificationStatus. 
        /// <para>
        /// The status of the notification for this user. Valid values are READ, UNREAD, and HIDDEN.
        /// </para>
        /// </summary>
        public NotificationStatus NotificationStatus { get; set; }

        /// <summary>
        /// Checks to see if the NotificationStatus property is set.
        /// </summary>
        internal bool IsSetNotificationStatus() => this.NotificationStatus != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of the notification.
        /// </para>
        /// </summary>
        public NotificationPriority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property RecipientId. 
        /// <para>
        /// The identifier of the recipient user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string RecipientId { get; set; }

        /// <summary>
        /// Checks to see if the RecipientId property is set.
        /// </summary>
        internal bool IsSetRecipientId() => this.RecipientId != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source that created the notification. Valid values are CUSTOMER, RULES, and SYSTEM.
        /// </para>
        /// </summary>
        public NotificationSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
