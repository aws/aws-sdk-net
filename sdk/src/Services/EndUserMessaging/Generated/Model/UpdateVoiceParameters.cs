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
    /// The updated delivery parameters for the voice channel. Absent members preserve the
    /// current value, and the empty sentinel on a member clears it.
    /// </summary>
    public partial class UpdateVoiceParameters
    {
        private string _inlineTemplateBody;
        private string _languageCode;
        private string _voiceId;
        private VoiceMessageBodyTextType _voiceMessageBodyTextType;

        /// <summary>
        /// Gets and sets the property InlineTemplateBody. 
        /// <para>
        /// The updated freeform voice template body. An empty string clears the previously stored
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=6000)]
        public string InlineTemplateBody
        {
            get { return this._inlineTemplateBody; }
            set { this._inlineTemplateBody = value; }
        }

        // Check to see if InlineTemplateBody property is set
        internal bool IsSetInlineTemplateBody()
        {
            return this._inlineTemplateBody != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The updated BCP 47 language code. An empty string clears the previously stored value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=35)]
        public string LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The updated Amazon Polly voice ID. An empty string clears the previously stored value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
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

        /// <summary>
        /// Gets and sets the property VoiceMessageBodyTextType. 
        /// <para>
        /// The updated format of the voice message body. Valid values are TEXT and SSML. Omit
        /// this member to preserve the current value.
        /// </para>
        /// </summary>
        public VoiceMessageBodyTextType VoiceMessageBodyTextType
        {
            get { return this._voiceMessageBodyTextType; }
            set { this._voiceMessageBodyTextType = value; }
        }

        // Check to see if VoiceMessageBodyTextType property is set
        internal bool IsSetVoiceMessageBodyTextType()
        {
            return this._voiceMessageBodyTextType != null;
        }

    }
}