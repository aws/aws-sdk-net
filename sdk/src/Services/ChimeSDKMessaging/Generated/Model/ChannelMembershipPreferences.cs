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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKMessaging.Model
{
    /// <summary>
    /// The channel membership preferences for an <c>AppInstanceUser</c>.
    /// </summary>
    public partial class ChannelMembershipPreferences
    {
        private PushNotificationPreferences _pushNotifications;

        /// <summary>
        /// Gets and sets the property PushNotifications. 
        /// <para>
        /// The push notification configuration of a message.
        /// </para>
        /// </summary>
        public PushNotificationPreferences PushNotifications
        {
            get { return this._pushNotifications; }
            set { this._pushNotifications = value; }
        }

        // Check to see if PushNotifications property is set
        internal bool IsSetPushNotifications()
        {
            return this._pushNotifications != null;
        }

    }
}