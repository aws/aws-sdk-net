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
    /// The channel-specific parameters used to render and deliver a one-time passcode. Each
    /// member configures the parameters for one delivery route. Populate only the channels
    /// that a configuration or send request supports. A notify code configuration can carry
    /// every channel at once, and a send request resolves to a single route that selects
    /// the matching channel at send time.
    /// </summary>
    public partial class ChannelParameters
    {
        private NotifyParameters _notify;
        private TextParameters _text;
        private VoiceParameters _voice;
        private WhatsAppParameters _whatsApp;

        /// <summary>
        /// Gets and sets the property Notify. 
        /// <para>
        /// The parameters for the preapproved notify-template route over the SMS or voice channels.
        /// </para>
        /// </summary>
        public NotifyParameters Notify
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
        /// The parameters for the text channel, which delivers over SMS or RCS.
        /// </para>
        /// </summary>
        public TextParameters Text
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
        /// The parameters for the voice channel.
        /// </para>
        /// </summary>
        public VoiceParameters Voice
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
        /// The parameters for the WhatsApp channel.
        /// </para>
        /// </summary>
        public WhatsAppParameters WhatsApp
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