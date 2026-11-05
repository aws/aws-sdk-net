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
    /// Specifies the message configuration settings for a campaign.
    /// </summary>
    public partial class MessageConfiguration
    {
        /// <summary>
        /// Gets and sets the property ADMMessage. 
        /// <para>
        /// The message that the campaign sends through the ADM (Amazon Device Messaging) channel.
        /// If specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public Message ADMMessage { get; set; }

        /// <summary>
        /// Checks to see if the ADMMessage property is set.
        /// </summary>
        internal bool IsSetADMMessage() => this.ADMMessage != null;

        /// <summary>
        /// Gets and sets the property APNSMessage. 
        /// <para>
        /// The message that the campaign sends through the APNs (Apple Push Notification service)
        /// channel. If specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public Message APNSMessage { get; set; }

        /// <summary>
        /// Checks to see if the APNSMessage property is set.
        /// </summary>
        internal bool IsSetAPNSMessage() => this.APNSMessage != null;

        /// <summary>
        /// Gets and sets the property BaiduMessage. 
        /// <para>
        /// The message that the campaign sends through the Baidu (Baidu Cloud Push) channel.
        /// If specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public Message BaiduMessage { get; set; }

        /// <summary>
        /// Checks to see if the BaiduMessage property is set.
        /// </summary>
        internal bool IsSetBaiduMessage() => this.BaiduMessage != null;

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// The message that the campaign sends through a custom channel, as specified by the
        /// delivery configuration (CustomDeliveryConfiguration) settings for the campaign. If
        /// specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public CampaignCustomMessage CustomMessage { get; set; }

        /// <summary>
        /// Checks to see if the CustomMessage property is set.
        /// </summary>
        internal bool IsSetCustomMessage() => this.CustomMessage != null;

        /// <summary>
        /// Gets and sets the property DefaultMessage. 
        /// <para>
        /// The default message that the campaign sends through all the channels that are configured
        /// for the campaign.
        /// </para>
        /// </summary>
        public Message DefaultMessage { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMessage property is set.
        /// </summary>
        internal bool IsSetDefaultMessage() => this.DefaultMessage != null;

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The message that the campaign sends through the email channel. If specified, this
        /// message overrides the default message.
        /// </para>
        /// </summary>
        public CampaignEmailMessage EmailMessage { get; set; }

        /// <summary>
        /// Checks to see if the EmailMessage property is set.
        /// </summary>
        internal bool IsSetEmailMessage() => this.EmailMessage != null;

        /// <summary>
        /// Gets and sets the property GCMMessage. 
        /// <para>
        /// The message that the campaign sends through the GCM channel, which enables Amazon
        /// Pinpoint to send push notifications through the Firebase Cloud Messaging (FCM), formerly
        /// Google Cloud Messaging (GCM), service. If specified, this message overrides the default
        /// message.
        /// </para>
        /// </summary>
        public Message GCMMessage { get; set; }

        /// <summary>
        /// Checks to see if the GCMMessage property is set.
        /// </summary>
        internal bool IsSetGCMMessage() => this.GCMMessage != null;

        /// <summary>
        /// Gets and sets the property InAppMessage. 
        /// <para>
        /// The in-app message configuration.
        /// </para>
        /// </summary>
        public CampaignInAppMessage InAppMessage { get; set; }

        /// <summary>
        /// Checks to see if the InAppMessage property is set.
        /// </summary>
        internal bool IsSetInAppMessage() => this.InAppMessage != null;

        /// <summary>
        /// Gets and sets the property SMSMessage. 
        /// <para>
        /// The message that the campaign sends through the SMS channel. If specified, this message
        /// overrides the default message.
        /// </para>
        /// </summary>
        public CampaignSmsMessage SMSMessage { get; set; }

        /// <summary>
        /// Checks to see if the SMSMessage property is set.
        /// </summary>
        internal bool IsSetSMSMessage() => this.SMSMessage != null;
    }
}
