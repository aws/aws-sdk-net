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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SendEmail operation.
    /// Composes an email message based on input data, and then immediately queues the message
    /// for sending.
    /// 
    ///  
    /// <para>
    /// There are several important points to know about <code>SendEmail</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can only send email from verified email addresses and domains; otherwise, you
    /// will get an "Email address not verified" error. If your account is still in the Amazon
    /// SES sandbox, you must also verify every recipient email address except for the recipients
    /// provided by the Amazon SES mailbox simulator. For more information, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The total size of the message cannot exceed 10 MB. This includes any attachments that
    /// are part of the message.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SES has a limit on the total number of recipients per message. The combined
    /// number of To:, CC: and BCC: email addresses cannot exceed 50. If you need to send
    /// an email message to a larger audience, you can divide your recipient list into groups
    /// of 50 or fewer, and then call Amazon SES repeatedly to send the message to each group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For every message that you send, the total number of recipients (To:, CC: and BCC:)
    /// is counted against your sending quota - the maximum number of emails you can send
    /// in a 24-hour period. For information about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SendEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private Destination _destination;
        private Message _message;
        private List<string> _replyToAddresses = new List<string>();
        private string _returnPath;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendEmailRequest() { }

        /// <summary>
        /// Instantiates SendEmailRequest with the parameterized properties
        /// </summary>
        /// <param name="source">The email address that is sending the email. This email address must be either individually verified with Amazon SES, or from a domain that has been verified with Amazon SES. For information about verifying identities, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon SES Developer Guide</a>. If you are sending on behalf of another user and have been permitted to do so by a sending authorization policy, then you must also specify the <code>SourceArn</code> parameter. For more information about sending authorization, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon SES Developer Guide</a>.  In all cases, the email address must be 7-bit ASCII. If the text must contain any other characters, then you must use MIME encoded-word syntax (RFC 2047) instead of a literal string. MIME encoded-word syntax uses the following form: <code>=?charset?encoding?encoded-text?=</code>. For more information, see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>. </param>
        /// <param name="destination">The destination for this email, composed of To:, CC:, and BCC: fields.</param>
        /// <param name="message">The message to be sent.</param>
        public SendEmailRequest(string source, Destination destination, Message message)
        {
            _source = source;
            _destination = destination;
            _message = message;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination for this email, composed of To:, CC:, and BCC: fields.
        /// </para>
        /// </summary>
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message to be sent.
        /// </para>
        /// </summary>
        public Message Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The reply-to email address(es) for the message. If the recipient replies to the message,
        /// each reply-to address will receive the reply.
        /// </para>
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
        /// Gets and sets the property ReturnPath. 
        /// <para>
        /// The email address to which bounces and complaints are to be forwarded when feedback
        /// forwarding is enabled. If the message cannot be delivered to the recipient, then an
        /// error message will be returned from the recipient's ISP; this message will then be
        /// forwarded to the email address specified by the <code>ReturnPath</code> parameter.
        /// The <code>ReturnPath</code> parameter is never overwritten. This email address must
        /// be either individually verified with Amazon SES, or from a domain that has been verified
        /// with Amazon SES. 
        /// </para>
        /// </summary>
        public string ReturnPath
        {
            get { return this._returnPath; }
            set { this._returnPath = value; }
        }

        // Check to see if ReturnPath property is set
        internal bool IsSetReturnPath()
        {
            return this._returnPath != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnPathArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to use the
        /// email address specified in the <code>ReturnPath</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, if the owner of <code>example.com</code> (which has ARN <code>arn:aws:ses:us-east-1:123456789012:identity/example.com</code>)
        /// attaches a policy to it that authorizes you to use <code>feedback@example.com</code>,
        /// then you would specify the <code>ReturnPathArn</code> to be <code>arn:aws:ses:us-east-1:123456789012:identity/example.com</code>,
        /// and the <code>ReturnPath</code> to be <code>feedback@example.com</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about sending authorization, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>. 
        /// </para>
        /// </summary>
        public string ReturnPathArn
        {
            get { return this._returnPathArn; }
            set { this._returnPathArn = value; }
        }

        // Check to see if ReturnPathArn property is set
        internal bool IsSetReturnPathArn()
        {
            return this._returnPathArn != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The email address that is sending the email. This email address must be either individually
        /// verified with Amazon SES, or from a domain that has been verified with Amazon SES.
        /// For information about verifying identities, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are sending on behalf of another user and have been permitted to do so by a
        /// sending authorization policy, then you must also specify the <code>SourceArn</code>
        /// parameter. For more information about sending authorization, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        ///  In all cases, the email address must be 7-bit ASCII. If the text must contain any
        /// other characters, then you must use MIME encoded-word syntax (RFC 2047) instead of
        /// a literal string. MIME encoded-word syntax uses the following form: <code>=?charset?encoding?encoded-text?=</code>.
        /// For more information, see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.
        /// 
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to send
        /// for the email address specified in the <code>Source</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, if the owner of <code>example.com</code> (which has ARN <code>arn:aws:ses:us-east-1:123456789012:identity/example.com</code>)
        /// attaches a policy to it that authorizes you to send from <code>user@example.com</code>,
        /// then you would specify the <code>SourceArn</code> to be <code>arn:aws:ses:us-east-1:123456789012:identity/example.com</code>,
        /// and the <code>Source</code> to be <code>user@example.com</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about sending authorization, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>. 
        /// </para>
        /// </summary>
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}