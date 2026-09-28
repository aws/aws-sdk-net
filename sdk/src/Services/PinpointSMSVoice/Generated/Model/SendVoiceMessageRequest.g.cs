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
    /// Container for the parameters to the SendVoiceMessage operation. Create a new voice
    /// message and send it to a recipient's phone number.
    /// </summary>
    public partial class SendVoiceMessageRequest : AmazonPinpointSMSVoiceRequest
    {
        /// <summary>
        /// Gets and sets the property CallerId. The phone number that appears on recipients'
        /// devices when they receive the message.
        /// </summary>
        public string CallerId { get; set; }

        /// <summary>
        /// Checks to see if the CallerId property is set.
        /// </summary>
        internal bool IsSetCallerId() => this.CallerId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. The name of the configuration set
        /// that you want to use to send the message.
        /// </summary>
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property Content.
        /// </summary>
        public VoiceMessageContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property DestinationPhoneNumber. The phone number that you want
        /// to send the voice message to.
        /// </summary>
        public string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetDestinationPhoneNumber() => this.DestinationPhoneNumber != null;

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumber. The phone number that Amazon Pinpoint
        /// should use to send the voice message. This isn't necessarily the phone number that
        /// appears on recipients' devices when they receive the message, because you can specify
        /// a CallerId parameter in the request.
        /// </summary>
        public string OriginationPhoneNumber { get; set; }

        /// <summary>
        /// Checks to see if the OriginationPhoneNumber property is set.
        /// </summary>
        internal bool IsSetOriginationPhoneNumber() => this.OriginationPhoneNumber != null;
    }
}
