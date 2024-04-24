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
    /// Specifies the message template to use for the message, for each type of channel.
    /// </summary>
    public partial class TemplateConfiguration
    {
        private Template _emailTemplate;
        private Template _inAppTemplate;
        private Template _pushTemplate;
        private Template _smsTemplate;
        private Template _voiceTemplate;

        /// <summary>
        /// Gets and sets the property EmailTemplate. 
        /// <para>
        /// The email template to use for the message.
        /// </para>
        /// </summary>
        public Template EmailTemplate
        {
            get { return this._emailTemplate; }
            set { this._emailTemplate = value; }
        }

        // Check to see if EmailTemplate property is set
        internal bool IsSetEmailTemplate()
        {
            return this._emailTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property InAppTemplate. 
        /// <para>
        /// The InApp template to use for the message. The InApp template object is not supported
        /// for SendMessages.
        /// </para>
        /// </summary>
        public Template InAppTemplate
        {
            get { return this._inAppTemplate; }
            set { this._inAppTemplate = value; }
        }

        // Check to see if InAppTemplate property is set
        internal bool IsSetInAppTemplate()
        {
            return this._inAppTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property PushTemplate. 
        /// <para>
        /// The push notification template to use for the message.
        /// </para>
        /// </summary>
        public Template PushTemplate
        {
            get { return this._pushTemplate; }
            set { this._pushTemplate = value; }
        }

        // Check to see if PushTemplate property is set
        internal bool IsSetPushTemplate()
        {
            return this._pushTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property SMSTemplate. 
        /// <para>
        /// The SMS template to use for the message.
        /// </para>
        /// </summary>
        public Template SMSTemplate
        {
            get { return this._smsTemplate; }
            set { this._smsTemplate = value; }
        }

        // Check to see if SMSTemplate property is set
        internal bool IsSetSMSTemplate()
        {
            return this._smsTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceTemplate. 
        /// <para>
        /// The voice template to use for the message. This object isn't supported for campaigns.
        /// </para>
        /// </summary>
        public Template VoiceTemplate
        {
            get { return this._voiceTemplate; }
            set { this._voiceTemplate = value; }
        }

        // Check to see if VoiceTemplate property is set
        internal bool IsSetVoiceTemplate()
        {
            return this._voiceTemplate != null;
        }

    }
}