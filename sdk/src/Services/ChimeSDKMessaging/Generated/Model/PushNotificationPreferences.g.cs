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

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The channel membership preferences for push notification.
    /// </summary>
    public partial class PushNotificationPreferences
    {
        /// <summary>
        /// Gets and sets the property AllowNotifications. 
        /// <para>
        /// Enum value that indicates which push notifications to send to the requested member
        /// of a channel. <c>ALL</c> sends all push notifications, <c>NONE</c> sends no push notifications,
        /// <c>FILTERED</c> sends only filtered push notifications. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AllowNotifications AllowNotifications { get; set; }

        /// <summary>
        /// Checks to see if the AllowNotifications property is set.
        /// </summary>
        internal bool IsSetAllowNotifications() => this.AllowNotifications != null;

        /// <summary>
        /// Gets and sets the property FilterRule. 
        /// <para>
        /// The simple JSON object used to send a subset of a push notification to the requested
        /// member.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string FilterRule { get; set; }

        /// <summary>
        /// Checks to see if the FilterRule property is set.
        /// </summary>
        internal bool IsSetFilterRule() => this.FilterRule != null;
    }
}
