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
    /// The delivery parameters for the preapproved notify-template route over the SMS or
    /// voice channels.
    /// </summary>
    public partial class NotifyParameters
    {
        private string _notifyTemplateId;
        private string _voiceId;

        /// <summary>
        /// Gets and sets the property NotifyTemplateId. 
        /// <para>
        /// The identifier of a preapproved notify template for the SMS or voice channels.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NotifyTemplateId
        {
            get { return this._notifyTemplateId; }
            set { this._notifyTemplateId = value; }
        }

        // Check to see if NotifyTemplateId property is set
        internal bool IsSetNotifyTemplateId()
        {
            return this._notifyTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The Amazon Polly voice ID used when the notify template is delivered over the voice
        /// channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VoiceId
        {
            get { return this._voiceId; }
            set { this._voiceId = value; }
        }

        // Check to see if VoiceId property is set
        internal bool IsSetVoiceId()
        {
            return this._voiceId != null;
        }

    }
}