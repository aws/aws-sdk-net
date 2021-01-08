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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SendEmail operation.
    /// Composes an email message and immediately queues it for sending. In order to send
    /// email using the <code>SendEmail</code> operation, your message must meet the following
    /// requirements:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The message must be sent from a verified email address or domain. If you attempt to
    /// send email using a non-verified address or domain, the operation will result in an
    /// "Email address not verified" error. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your account is still in the Amazon SES sandbox, you may only send to verified
    /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
    /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
    /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum message size is 10 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The message must include at least one recipient email address. The recipient address
    /// can be a To: address, a CC: address, or a BCC: address. If a recipient email address
    /// is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
    /// the entire message will be rejected, even if the message contains other recipients
    /// that are valid.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
    /// fields. If you need to send an email message to a larger audience, you can divide
    /// your recipient list into groups of 50 or fewer, and then call the <code>SendEmail</code>
    /// operation several times to send the message to each group.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// For every message that you send, the total number of recipients (including each recipient
    /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
    /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
    /// sending quotas in Amazon SES, see <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Managing
    /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SendEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private Destination _destination;
        private Message _message;
        private List<string> _replyToAddresses = new List<string>();
        private string _returnPath;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;
        private List<MessageTag> _tags = new List<MessageTag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendEmailRequest() { }

        /// <summary>
        /// Instantiates SendEmailRequest with the parameterized properties
        /// </summary>
        /// <param name="source">The email address that is sending the email. This email address must be either individually verified with Amazon SES, or from a domain that has been verified with Amazon SES. For information about verifying identities, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon SES Developer Guide</a>. If you are sending on behalf of another user and have been permitted to do so by a sending authorization policy, then you must also specify the <code>SourceArn</code> parameter. For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon SES Developer Guide</a>. <note> Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>. For this reason, the <i>local part</i> of a source email address (the part of the email address that precedes the @ sign) may only contain <a href="https://en.wikipedia.org/wiki/Email_address#Local-part">7-bit ASCII characters</a>. If the <i>domain part</i> of an address (the part after the @ sign) contains non-ASCII characters, they must be encoded using Punycode, as described in <a href="https://tools.ietf.org/html/rfc3492.html">RFC3492</a>. The sender name (also known as the <i>friendly name</i>) may contain non-ASCII characters. These characters must be encoded using MIME encoded-word syntax, as described in <a href="https://tools.ietf.org/html/rfc2047">RFC 2047</a>. MIME encoded-word syntax uses the following form: <code>=?charset?encoding?encoded-text?=</code>. </note></param>
        /// <param name="destination">The destination for this email, composed of To:, CC:, and BCC: fields.</param>
        /// <param name="message">The message to be sent.</param>
        public SendEmailRequest(string source, Destination destination, Message message)
        {
            _source = source;
            _destination = destination;
            _message = message;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when you send an email using <code>SendEmail</code>.
        /// </para>
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
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination for this email, composed of To:, CC:, and BCC: fields.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// The email address that bounces and complaints will be forwarded to when feedback forwarding
        /// is enabled. If the message cannot be delivered to the recipient, then an error message
        /// will be returned from the recipient's ISP; this message will then be forwarded to
        /// the email address specified by the <code>ReturnPath</code> parameter. The <code>ReturnPath</code>
        /// parameter is never overwritten. This email address must be either individually verified
        /// with Amazon SES, or from a domain that has been verified with Amazon SES. 
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
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
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
        /// For information about verifying identities, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are sending on behalf of another user and have been permitted to do so by a
        /// sending authorization policy, then you must also specify the <code>SourceArn</code>
        /// parameter. For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
        /// For this reason, the <i>local part</i> of a source email address (the part of the
        /// email address that precedes the @ sign) may only contain <a href="https://en.wikipedia.org/wiki/Email_address#Local-part">7-bit
        /// ASCII characters</a>. If the <i>domain part</i> of an address (the part after the
        /// @ sign) contains non-ASCII characters, they must be encoded using Punycode, as described
        /// in <a href="https://tools.ietf.org/html/rfc3492.html">RFC3492</a>. The sender name
        /// (also known as the <i>friendly name</i>) may contain non-ASCII characters. These characters
        /// must be encoded using MIME encoded-word syntax, as described in <a href="https://tools.ietf.org/html/rfc2047">RFC
        /// 2047</a>. MIME encoded-word syntax uses the following form: <code>=?charset?encoding?encoded-text?=</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// using <code>SendEmail</code>. Tags correspond to characteristics of the email that
        /// you define, so that you can publish email sending events.
        /// </para>
        /// </summary>
        public List<MessageTag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}