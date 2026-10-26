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
    /// Specifies the message template to use for the message, for each type of channel.
    /// </summary>
    public partial class TemplateConfiguration
    {
        /// <summary>
        /// Gets and sets the property EmailTemplate. 
        /// <para>
        /// The email template to use for the message.
        /// </para>
        /// </summary>
        public Template EmailTemplate { get; set; }

        /// <summary>
        /// Checks to see if the EmailTemplate property is set.
        /// </summary>
        internal bool IsSetEmailTemplate() => this.EmailTemplate != null;

        /// <summary>
        /// Gets and sets the property InAppTemplate. 
        /// <para>
        /// The InApp template to use for the message. The InApp template object is not supported
        /// for SendMessages.
        /// </para>
        /// </summary>
        public Template InAppTemplate { get; set; }

        /// <summary>
        /// Checks to see if the InAppTemplate property is set.
        /// </summary>
        internal bool IsSetInAppTemplate() => this.InAppTemplate != null;

        /// <summary>
        /// Gets and sets the property PushTemplate. 
        /// <para>
        /// The push notification template to use for the message.
        /// </para>
        /// </summary>
        public Template PushTemplate { get; set; }

        /// <summary>
        /// Checks to see if the PushTemplate property is set.
        /// </summary>
        internal bool IsSetPushTemplate() => this.PushTemplate != null;

        /// <summary>
        /// Gets and sets the property SMSTemplate. 
        /// <para>
        /// The SMS template to use for the message.
        /// </para>
        /// </summary>
        public Template SMSTemplate { get; set; }

        /// <summary>
        /// Checks to see if the SMSTemplate property is set.
        /// </summary>
        internal bool IsSetSMSTemplate() => this.SMSTemplate != null;

        /// <summary>
        /// Gets and sets the property VoiceTemplate. 
        /// <para>
        /// The voice template to use for the message. This object isn't supported for campaigns.
        /// </para>
        /// </summary>
        public Template VoiceTemplate { get; set; }

        /// <summary>
        /// Checks to see if the VoiceTemplate property is set.
        /// </summary>
        internal bool IsSetVoiceTemplate() => this.VoiceTemplate != null;
    }
}
