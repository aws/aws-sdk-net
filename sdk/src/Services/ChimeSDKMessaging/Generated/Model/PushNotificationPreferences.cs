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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The channel membership preferences for push notification.
    /// </summary>
    public partial class PushNotificationPreferences
    {
        private AllowNotifications _allowNotifications;
        private string _filterRule;

        /// <summary>
        /// Gets and sets the property AllowNotifications. 
        /// <para>
        /// Enum value that indicates which push notifications to send to the requested member
        /// of a channel. <code>ALL</code> sends all push notifications, <code>NONE</code> sends
        /// no push notifications, <code>FILTERED</code> sends only filtered push notifications.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AllowNotifications AllowNotifications
        {
            get { return this._allowNotifications; }
            set { this._allowNotifications = value; }
        }

        // Check to see if AllowNotifications property is set
        internal bool IsSetAllowNotifications()
        {
            return this._allowNotifications != null;
        }

        /// <summary>
        /// Gets and sets the property FilterRule. 
        /// <para>
        /// The simple JSON object used to send a subset of a push notification to the requested
        /// member.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public string FilterRule
        {
            get { return this._filterRule; }
            set { this._filterRule = value; }
        }

        // Check to see if FilterRule property is set
        internal bool IsSetFilterRule()
        {
            return this._filterRule != null;
        }

    }
}