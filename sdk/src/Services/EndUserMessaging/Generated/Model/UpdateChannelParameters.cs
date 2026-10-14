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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
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
namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// The updated channel-specific parameters used only when you update a notify code configuration.
    /// When you omit a channel, that channel's parameters remain unchanged. When you supply
    /// a channel, you can clear individual fields by using the empty-string or empty-map
    /// sentinel on a member, or drop the whole channel's parameters by clearing every member.
    /// These sentinels apply only when you update a configuration; a create request rejects
    /// empty values with a validation error.
    /// </summary>
    public partial class UpdateChannelParameters
    {
        private UpdateNotifyParameters _notify;
        private UpdateTextParameters _text;
        private UpdateVoiceParameters _voice;
        private UpdateWhatsAppParameters _whatsApp;

        /// <summary>
        /// Gets and sets the property Notify. 
        /// <para>
        /// The notify-template-route parameters to update. Omit this member to leave them unchanged.
        /// </para>
        /// </summary>
        public UpdateNotifyParameters Notify
        {
            get { return this._notify; }
            set { this._notify = value; }
        }

        // Check to see if Notify property is set
        internal bool IsSetNotify()
        {
            return this._notify != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text-channel parameters to update. Omit this member to leave the text-channel
        /// parameters unchanged.
        /// </para>
        /// </summary>
        public UpdateTextParameters Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Voice. 
        /// <para>
        /// The voice-channel parameters to update. Omit this member to leave the voice-channel
        /// parameters unchanged.
        /// </para>
        /// </summary>
        public UpdateVoiceParameters Voice
        {
            get { return this._voice; }
            set { this._voice = value; }
        }

        // Check to see if Voice property is set
        internal bool IsSetVoice()
        {
            return this._voice != null;
        }

        /// <summary>
        /// Gets and sets the property WhatsApp. 
        /// <para>
        /// The WhatsApp-channel parameters to update. Omit this member to leave the WhatsApp-channel
        /// parameters unchanged.
        /// </para>
        /// </summary>
        public UpdateWhatsAppParameters WhatsApp
        {
            get { return this._whatsApp; }
            set { this._whatsApp = value; }
        }

        // Check to see if WhatsApp property is set
        internal bool IsSetWhatsApp()
        {
            return this._whatsApp != null;
        }

    }
}