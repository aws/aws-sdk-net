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
    /// Container for the parameters to the SendVoiceMessage operation.
    /// Create a new voice message and send it to a recipient's phone number.
    /// </summary>
    public partial class SendVoiceMessageRequest : AmazonPinpointSMSVoiceRequest
    {
        private string _callerId;
        private string _configurationSetName;
        private VoiceMessageContent _content;
        private string _destinationPhoneNumber;
        private string _originationPhoneNumber;

        /// <summary>
        /// Gets and sets the property CallerId. The phone number that appears on recipients'
        /// devices when they receive the message.
        /// </summary>
        public string CallerId
        {
            get { return this._callerId; }
            set { this._callerId = value; }
        }

        // Check to see if CallerId property is set
        internal bool IsSetCallerId()
        {
            return this._callerId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. The name of the configuration set
        /// that you want to use to send the message.
        /// </summary>
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Content.
        /// </summary>
        public VoiceMessageContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. The phone number that you want
        /// to send the voice message to.
        /// </summary>
        public string DestinationPhoneNumber
        {
            get { return this._destinationPhoneNumber; }
            set { this._destinationPhoneNumber = value; }
        }

        // Check to see if DestinationPhoneNumber property is set
        internal bool IsSetDestinationPhoneNumber()
        {
            return this._destinationPhoneNumber != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumber. The phone number that Amazon Pinpoint
        /// should use to send the voice message. This isn't necessarily the phone number that
        /// appears on recipients' devices when they receive the message, because you can specify
        /// a CallerId parameter in the request.
        /// </summary>
        public string OriginationPhoneNumber
        {
            get { return this._originationPhoneNumber; }
            set { this._originationPhoneNumber = value; }
        }

        // Check to see if OriginationPhoneNumber property is set
        internal bool IsSetOriginationPhoneNumber()
        {
            return this._originationPhoneNumber != null;
        }

    }
}