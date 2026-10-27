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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings and content for the default message and any default messages
    /// that you tailored for specific channels.
    /// </summary>
    public partial class DirectMessageConfiguration
    {
        /// <summary>
        /// Gets and sets the property ADMMessage. 
        /// <para>
        /// The default push notification message for the ADM (Amazon Device Messaging) channel.
        /// This message overrides the default push notification message (DefaultPushNotificationMessage).
        /// </para>
        /// </summary>
        public ADMMessage ADMMessage { get; set; }

        /// <summary>
        /// Checks to see if the ADMMessage property is set.
        /// </summary>
        internal bool IsSetADMMessage() => this.ADMMessage != null;

        /// <summary>
        /// Gets and sets the property APNSMessage. 
        /// <para>
        /// The default push notification message for the APNs (Apple Push Notification service)
        /// channel. This message overrides the default push notification message (DefaultPushNotificationMessage).
        /// </para>
        /// </summary>
        public APNSMessage APNSMessage { get; set; }

        /// <summary>
        /// Checks to see if the APNSMessage property is set.
        /// </summary>
        internal bool IsSetAPNSMessage() => this.APNSMessage != null;

        /// <summary>
        /// Gets and sets the property BaiduMessage. 
        /// <para>
        /// The default push notification message for the Baidu (Baidu Cloud Push) channel. This
        /// message overrides the default push notification message (DefaultPushNotificationMessage).
        /// </para>
        /// </summary>
        public BaiduMessage BaiduMessage { get; set; }

        /// <summary>
        /// Checks to see if the BaiduMessage property is set.
        /// </summary>
        internal bool IsSetBaiduMessage() => this.BaiduMessage != null;

        /// <summary>
        /// Gets and sets the property DefaultMessage. 
        /// <para>
        /// The default message for all channels.
        /// </para>
        /// </summary>
        public DefaultMessage DefaultMessage { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMessage property is set.
        /// </summary>
        internal bool IsSetDefaultMessage() => this.DefaultMessage != null;

        /// <summary>
        /// Gets and sets the property DefaultPushNotificationMessage. 
        /// <para>
        /// The default push notification message for all push notification channels.
        /// </para>
        /// </summary>
        public DefaultPushNotificationMessage DefaultPushNotificationMessage { get; set; }

        /// <summary>
        /// Checks to see if the DefaultPushNotificationMessage property is set.
        /// </summary>
        internal bool IsSetDefaultPushNotificationMessage() => this.DefaultPushNotificationMessage != null;

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The default message for the email channel. This message overrides the default message
        /// (DefaultMessage).
        /// </para>
        /// </summary>
        public EmailMessage EmailMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessage property is set.
        /// </summary>
        internal bool IsSetEmailMessage() => this.EmailMessage != null;

        /// <summary>
        /// Gets and sets the property GCMMessage. 
        /// <para>
        /// The default push notification message for the GCM channel, which is used to send notifications
        /// through the Firebase Cloud Messaging (FCM), formerly Google Cloud Messaging (GCM),
        /// service. This message overrides the default push notification message (DefaultPushNotificationMessage).
        /// </para>
        /// </summary>
        public GCMMessage GCMMessage { get; set; }

        /// <summary>
        /// Checks to see if the GCMMessage property is set.
        /// </summary>
        internal bool IsSetGCMMessage() => this.GCMMessage != null;

        /// <summary>
        /// Gets and sets the property SMSMessage. 
        /// <para>
        /// The default message for the SMS channel. This message overrides the default message
        /// (DefaultMessage).
        /// </para>
        /// </summary>
        public SMSMessage SMSMessage { get; set; }

        /// <summary>
        /// Checks to see if the SMSMessage property is set.
        /// </summary>
        internal bool IsSetSMSMessage() => this.SMSMessage != null;

        /// <summary>
        /// Gets and sets the property VoiceMessage. 
        /// <para>
        /// The default message for the voice channel. This message overrides the default message
        /// (DefaultMessage).
        /// </para>
        /// </summary>
        public VoiceMessage VoiceMessage { get; set; }

        /// <summary>
        /// Checks to see if the VoiceMessage property is set.
        /// </summary>
        internal bool IsSetVoiceMessage() => this.VoiceMessage != null;
    }
}
