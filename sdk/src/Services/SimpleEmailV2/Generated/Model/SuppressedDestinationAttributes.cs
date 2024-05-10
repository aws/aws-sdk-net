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
    /// An object that contains additional attributes that are related an email address that
    /// is on the suppression list for your account.
    /// </summary>
    public partial class SuppressedDestinationAttributes
    {
        private string _feedbackId;
        private string _messageId;

        /// <summary>
        /// Gets and sets the property FeedbackId. 
        /// <para>
        /// A unique identifier that's generated when an email address is added to the suppression
        /// list for your account.
        /// </para>
        /// </summary>
        public string FeedbackId
        {
            get { return this._feedbackId; }
            set { this._feedbackId = value; }
        }

        // Check to see if FeedbackId property is set
        internal bool IsSetFeedbackId()
        {
            return this._feedbackId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique identifier of the email message that caused the email address to be added
        /// to the suppression list for your account.
        /// </para>
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