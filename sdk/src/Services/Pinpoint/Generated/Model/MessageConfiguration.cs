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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private Message _admMessage;
        private Message _apnsMessage;
        private Message _baiduMessage;
        private CampaignCustomMessage _customMessage;
        private Message _defaultMessage;
        private CampaignEmailMessage _emailMessage;
        private Message _gcmMessage;
        private CampaignInAppMessage _inAppMessage;
        private CampaignSmsMessage _smsMessage;

        /// <summary>
        /// Gets and sets the property ADMMessage. 
        /// <para>
        /// The message that the campaign sends through the ADM (Amazon Device Messaging) channel.
        /// If specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public Message ADMMessage
        {
            get { return this._admMessage; }
            set { this._admMessage = value; }
        }

        // Check to see if ADMMessage property is set
        internal bool IsSetADMMessage()
        {
            return this._admMessage != null;
        }

        /// <summary>
        /// Gets and sets the property APNSMessage. 
        /// <para>
        /// The message that the campaign sends through the APNs (Apple Push Notification service)
        /// channel. If specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public Message APNSMessage
        {
            get { return this._apnsMessage; }
            set { this._apnsMessage = value; }
        }

        // Check to see if APNSMessage property is set
        internal bool IsSetAPNSMessage()
        {
            return this._apnsMessage != null;
        }

        /// <summary>
        /// Gets and sets the property BaiduMessage. 
        /// <para>
        /// The message that the campaign sends through the Baidu (Baidu Cloud Push) channel.
        /// If specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public Message BaiduMessage
        {
            get { return this._baiduMessage; }
            set { this._baiduMessage = value; }
        }

        // Check to see if BaiduMessage property is set
        internal bool IsSetBaiduMessage()
        {
            return this._baiduMessage != null;
        }

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// The message that the campaign sends through a custom channel, as specified by the
        /// delivery configuration (CustomDeliveryConfiguration) settings for the campaign. If
        /// specified, this message overrides the default message.
        /// </para>
        /// </summary>
        public CampaignCustomMessage CustomMessage
        {
            get { return this._customMessage; }
            set { this._customMessage = value; }
        }

        // Check to see if CustomMessage property is set
        internal bool IsSetCustomMessage()
        {
            return this._customMessage != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultMessage. 
        /// <para>
        /// The default message that the campaign sends through all the channels that are configured
        /// for the campaign.
        /// </para>
        /// </summary>
        public Message DefaultMessage
        {
            get { return this._defaultMessage; }
            set { this._defaultMessage = value; }
        }

        // Check to see if DefaultMessage property is set
        internal bool IsSetDefaultMessage()
        {
            return this._defaultMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EmailMessage. 
        /// <para>
        /// The message that the campaign sends through the email channel. If specified, this
        /// message overrides the default message.
        /// </para>
        /// </summary>
        public CampaignEmailMessage EmailMessage
        {
            get { return this._emailMessage; }
            set { this._emailMessage = value; }
        }

        // Check to see if EmailMessage property is set
        internal bool IsSetEmailMessage()
        {
            return this._emailMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GCMMessage. 
        /// <para>
        /// The message that the campaign sends through the GCM channel, which enables Amazon
        /// Pinpoint to send push notifications through the Firebase Cloud Messaging (FCM), formerly
        /// Google Cloud Messaging (GCM), service. If specified, this message overrides the default
        /// message.
        /// </para>
        /// </summary>
        public Message GCMMessage
        {
            get { return this._gcmMessage; }
            set { this._gcmMessage = value; }
        }

        // Check to see if GCMMessage property is set
        internal bool IsSetGCMMessage()
        {
            return this._gcmMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InAppMessage. 
        /// <para>
        /// The in-app message configuration.
        /// </para>
        /// </summary>
        public CampaignInAppMessage InAppMessage
        {
            get { return this._inAppMessage; }
            set { this._inAppMessage = value; }
        }

        // Check to see if InAppMessage property is set
        internal bool IsSetInAppMessage()
        {
            return this._inAppMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SMSMessage. 
        /// <para>
        /// The message that the campaign sends through the SMS channel. If specified, this message
        /// overrides the default message.
        /// </para>
        /// </summary>
        public CampaignSmsMessage SMSMessage
        {
            get { return this._smsMessage; }
            set { this._smsMessage = value; }
        }

        // Check to see if SMSMessage property is set
        internal bool IsSetSMSMessage()
        {
            return this._smsMessage != null;
        }

    }
}