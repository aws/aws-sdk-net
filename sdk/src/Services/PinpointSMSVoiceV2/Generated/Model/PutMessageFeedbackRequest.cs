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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutMessageFeedback operation.
    /// Set the MessageFeedbackStatus as <c>RECEIVED</c> or <c>FAILED</c> for the passed in
    /// MessageId. 
    /// 
    ///  
    /// <para>
    /// If you use message feedback then you must update message feedback record. When you
    /// receive a signal that a user has received the message you must use <c>PutMessageFeedback</c>
    /// to set the message feedback record as <c>RECEIVED</c>; Otherwise, an hour after the
    /// message feedback record is set to <c>FAILED</c>.
    /// </para>
    /// </summary>
    public partial class PutMessageFeedbackRequest : AmazonPinpointSMSVoiceV2Request
    {
        private MessageFeedbackStatus _messageFeedbackStatus;
        private string _messageId;

        /// <summary>
        /// Gets and sets the property MessageFeedbackStatus. 
        /// <para>
        /// Set the message feedback to be either <c>RECEIVED</c> or <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageFeedbackStatus MessageFeedbackStatus
        {
            get { return this._messageFeedbackStatus; }
            set { this._messageFeedbackStatus = value; }
        }

        // Check to see if MessageFeedbackStatus property is set
        internal bool IsSetMessageFeedbackStatus()
        {
            return this._messageFeedbackStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique identifier for the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

    }
}