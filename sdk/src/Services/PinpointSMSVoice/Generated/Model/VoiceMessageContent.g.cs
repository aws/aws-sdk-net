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

namespace Amazon.PinpointSMSVoice.Model
{
    /// <summary>
    /// An object that contains a voice message and information about the recipient that you
    /// want to send it to.
    /// </summary>
    public partial class VoiceMessageContent
    {
        /// <summary>
        /// Gets and sets the property CallInstructionsMessage.
        /// </summary>
        public CallInstructionsMessageType CallInstructionsMessage { get; set; }

        /// <summary>
        /// Checks to see if the CallInstructionsMessage property is set.
        /// </summary>
        internal bool IsSetCallInstructionsMessage() => this.CallInstructionsMessage != null;

        /// <summary>
        /// Gets and sets the property PlainTextMessage.
        /// </summary>
        public PlainTextMessageType PlainTextMessage { get; set; }

        /// <summary>
        /// Checks to see if the PlainTextMessage property is set.
        /// </summary>
        internal bool IsSetPlainTextMessage() => this.PlainTextMessage != null;

        /// <summary>
        /// Gets and sets the property SSMLMessage.
        /// </summary>
        public SSMLMessageType SSMLMessage { get; set; }

        /// <summary>
        /// Checks to see if the SSMLMessage property is set.
        /// </summary>
        internal bool IsSetSSMLMessage() => this.SSMLMessage != null;
    }
}
