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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
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
        private CallInstructionsMessageType _callInstructionsMessage;
        private PlainTextMessageType _plainTextMessage;
        private SSMLMessageType _ssmlMessage;

        /// <summary>
        /// Gets and sets the property CallInstructionsMessage.
        /// </summary>
        public CallInstructionsMessageType CallInstructionsMessage
        {
            get { return this._callInstructionsMessage; }
            set { this._callInstructionsMessage = value; }
        }

        // Check to see if CallInstructionsMessage property is set
        internal bool IsSetCallInstructionsMessage()
        {
            return this._callInstructionsMessage != null;
        }

        /// <summary>
        /// Gets and sets the property PlainTextMessage.
        /// </summary>
        public PlainTextMessageType PlainTextMessage
        {
            get { return this._plainTextMessage; }
            set { this._plainTextMessage = value; }
        }

        // Check to see if PlainTextMessage property is set
        internal bool IsSetPlainTextMessage()
        {
            return this._plainTextMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SSMLMessage.
        /// </summary>
        public SSMLMessageType SSMLMessage
        {
            get { return this._ssmlMessage; }
            set { this._ssmlMessage = value; }
        }

        // Check to see if SSMLMessage property is set
        internal bool IsSetSSMLMessage()
        {
            return this._ssmlMessage != null;
        }

    }
}