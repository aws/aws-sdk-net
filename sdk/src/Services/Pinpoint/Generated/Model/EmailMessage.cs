/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Email Message.
    /// </summary>
    public partial class EmailMessage
    {
        private string _body;
        private string _feedbackForwardingAddress;
        private string _fromAddress;
        private RawEmail _rawEmail;
        private List<string> _replyToAddresses = new List<string>();
        private SimpleEmail _simpleEmail;
        private Dictionary<string, List<string>> _substitutions = new Dictionary<string, List<string>>();

        /// <summary>
        /// Gets and sets the property Body. The body of the email message.
        /// </summary>
        public string Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackForwardingAddress. The email address that bounces
        /// and complaints will be forwarded to when feedback forwarding is enabled.
        /// </summary>
        public string FeedbackForwardingAddress
        {
            get { return this._feedbackForwardingAddress; }
            set { this._feedbackForwardingAddress = value; }
        }

        // Check to see if FeedbackForwardingAddress property is set
        internal bool IsSetFeedbackForwardingAddress()
        {
            return this._feedbackForwardingAddress != null;
        }

        /// <summary>
        /// Gets and sets the property FromAddress. The email address used to send the email from.
        /// Defaults to use FromAddress specified in the Email Channel.
        /// </summary>
        public string FromAddress
        {
            get { return this._fromAddress; }
            set { this._fromAddress = value; }
        }

        // Check to see if FromAddress property is set
        internal bool IsSetFromAddress()
        {
            return this._fromAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RawEmail. An email represented as a raw MIME message.
        /// </summary>
        public RawEmail RawEmail
        {
            get { return this._rawEmail; }
            set { this._rawEmail = value; }
        }

        // Check to see if RawEmail property is set
        internal bool IsSetRawEmail()
        {
            return this._rawEmail != null;
        }

        /// <summary>
        /// Gets and sets the property ReplyToAddresses. The reply-to email address(es) for the
        /// email. If the recipient replies to the email, each reply-to address will receive the
        /// reply.
        /// </summary>
        public List<string> ReplyToAddresses
        {
            get { return this._replyToAddresses; }
            set { this._replyToAddresses = value; }
        }

        // Check to see if ReplyToAddresses property is set
        internal bool IsSetReplyToAddresses()
        {
            return this._replyToAddresses != null && this._replyToAddresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SimpleEmail. An email composed of a subject, a text part
        /// and a html part.
        /// </summary>
        public SimpleEmail SimpleEmail
        {
            get { return this._simpleEmail; }
            set { this._simpleEmail = value; }
        }

        // Check to see if SimpleEmail property is set
        internal bool IsSetSimpleEmail()
        {
            return this._simpleEmail != null;
        }

        /// <summary>
        /// Gets and sets the property Substitutions. Default message substitutions. Can be overridden
        /// by individual address substitutions.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && this._substitutions.Count > 0; 
        }

    }
}