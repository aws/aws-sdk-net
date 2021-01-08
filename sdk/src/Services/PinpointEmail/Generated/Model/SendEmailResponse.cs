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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// A unique message ID that you receive when Amazon Pinpoint accepts an email for sending.
    /// </summary>
    public partial class SendEmailResponse : AmazonWebServiceResponse
    {
        private string _messageId;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier for the message that is generated when Amazon Pinpoint accepts
        /// the message.
        /// </para>
        ///  <note> 
        /// <para>
        /// It is possible for Amazon Pinpoint to accept a message without sending it. This can
        /// happen when the message you're trying to send has an attachment doesn't pass a virus
        /// check, or when you send a templated email that contains invalid personalization content,
        /// for example.
        /// </para>
        ///  </note>
        /// </summary>
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