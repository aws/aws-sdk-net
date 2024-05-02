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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A unique message ID that you receive when an email is accepted for sending.
    /// </summary>
    public partial class SendEmailResponse : AmazonWebServiceResponse
    {
        private string _messageId;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// A unique identifier for the message that is generated when the message is accepted.
        /// </para>
        ///  <note> 
        /// <para>
        /// It's possible for Amazon SES to accept a message without sending it. For example,
        /// this can happen when the message that you're trying to send has an attachment that
        /// contains a virus, or when you send a templated email that contains invalid personalization
        /// content.
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