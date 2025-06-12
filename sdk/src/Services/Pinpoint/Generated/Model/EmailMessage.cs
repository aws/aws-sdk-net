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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
    /// Specifies the default settings and content for a one-time email message that's sent
    /// directly to an endpoint.
    /// </summary>
    public partial class EmailMessage
    {
        private string _body;
        private string _feedbackForwardingAddress;
        private string _fromAddress;
        private RawEmail _rawEmail;
        private List<string> _replyToAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SimpleEmail _simpleEmail;
        private Dictionary<string, List<string>> _substitutions = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the email message.
        /// </para>
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
        /// Gets and sets the property FeedbackForwardingAddress. 
        /// <para>
        /// The email address to forward bounces and complaints to, if feedback forwarding is
        /// enabled.
        /// </para>
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
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address to send the email message from. The default value is the
        /// FromAddress specified for the email channel.
        /// </para>
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
        /// Gets and sets the property RawEmail. 
        /// <para>
        /// The email message, represented as a raw MIME message.
        /// </para>
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
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The reply-to email address(es) for the email message. If a recipient replies to the
        /// email, each reply-to address receives the reply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplyToAddresses
        {
            get { return this._replyToAddresses; }
            set { this._replyToAddresses = value; }
        }

        // Check to see if ReplyToAddresses property is set
        internal bool IsSetReplyToAddresses()
        {
            return this._replyToAddresses != null && (this._replyToAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SimpleEmail. 
        /// <para>
        /// The email message, composed of a subject, a text part, and an HTML part.
        /// </para>
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
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The default message variables to use in the email message. You can override the default
        /// variables with individual address variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions
        {
            get { return this._substitutions; }
            set { this._substitutions = value; }
        }

        // Check to see if Substitutions property is set
        internal bool IsSetSubstitutions()
        {
            return this._substitutions != null && (this._substitutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}