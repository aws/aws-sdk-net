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
    /// Container for the parameters to the SendRawEmail operation.
    /// Composes an email message and immediately queues it for sending. When calling this
    /// operation, you may specify the message headers as well as the content. The <code>SendRawEmail</code>
    /// operation is particularly useful for sending multipart MIME emails (such as those
    /// that contain both a plain-text and an HTML version). 
    /// 
    ///  
    /// <para>
    /// In order to send email using the <code>SendRawEmail</code> operation, your message
    /// must meet the following requirements:
    /// </para>
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
    /// Simulator. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Verifying
    /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The total size of the message, including attachments, must be smaller than 10 MB.
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
    /// your recipient list into groups of 50 or fewer, and then call the <code>SendRawEmail</code>
    /// operation several times to send the message to each group.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// For every message that you send, the total number of recipients (including each recipient
    /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
    /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
    /// sending quotas in Amazon SES, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Managing
    /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Additionally, keep the following considerations in mind when using the <code>SendRawEmail</code>
    /// operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Although you can customize the message headers when using the <code>SendRawEmail</code>
    /// operation, Amazon SES will automatically apply its own <code>Message-ID</code> and
    /// <code>Date</code> headers; if you passed these headers when creating the message,
    /// they will be overwritten by the values that Amazon SES provides.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using sending authorization to send on behalf of another user, <code>SendRawEmail</code>
    /// enables you to specify the cross-account identity for the email's Source, From, and
    /// Return-Path parameters in one of two ways: you can pass optional parameters <code>SourceArn</code>,
    /// <code>FromArn</code>, and/or <code>ReturnPathArn</code> to the API, or you can include
    /// the following X-headers in the header of your raw email:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>X-SES-SOURCE-ARN</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>X-SES-FROM-ARN</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>X-SES-RETURN-PATH-ARN</code> 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// Do not include these X-headers in the DKIM signature; Amazon SES will remove them
    /// before sending the email.
    /// </para>
    ///  </important> 
    /// <para>
    /// For most common sending authorization scenarios, we recommend that you specify the
    /// <code>SourceIdentityArn</code> parameter and not the <code>FromIdentityArn</code>
    /// or <code>ReturnPathIdentityArn</code> parameters. If you only specify the <code>SourceIdentityArn</code>
    /// parameter, Amazon SES will set the From and Return Path addresses to the identity
    /// specified in <code>SourceIdentityArn</code>. For more information about sending authorization,
    /// see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Using
    /// Sending Authorization with Amazon SES</a> in the <i>Amazon SES Developer Guide.</i>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SendRawEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private List<string> _destinations = new List<string>();
        private string _fromArn;
        private RawMessage _rawMessage;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;
        private List<MessageTag> _tags = new List<MessageTag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendRawEmailRequest() { }

        /// <summary>
        /// Instantiates SendRawEmailRequest with the parameterized properties
        /// </summary>
        /// <param name="rawMessage">The raw text of the message. The client is responsible for ensuring the following: <ul> <li> Message must contain a header and a body, separated by a blank line. </li> <li> All required header fields must be present. </li> <li> Each part of a multipart MIME message must be formatted properly. </li> <li> MIME content types must be among those supported by Amazon SES. For more information, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon SES Developer Guide</a>. </li> <li> Must be base64-encoded. </li> <li> Per <a href="https://tools.ietf.org/html/rfc5321#section-4.5.3.1.6">RFC 5321</a>, the maximum length of each line of text, including the &lt;CRLF&gt;, must not exceed 1,000 characters. </li> </ul></param>
        public SendRawEmailRequest(RawMessage rawMessage)
        {
            _rawMessage = rawMessage;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when you send an email using <code>SendRawEmail</code>.
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
        /// Gets and sets the property Destinations. 
        /// <para>
        /// A list of destinations for the message, consisting of To:, CC:, and BCC: addresses.
        /// </para>
        /// </summary>
        public List<string> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FromArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to specify
        /// a particular "From" address in the header of the raw email.
        /// </para>
        ///  
        /// <para>
        /// Instead of using this parameter, you can use the X-header <code>X-SES-FROM-ARN</code>
        /// in the raw message of the email. If you use both the <code>FromArn</code> parameter
        /// and the corresponding X-header, Amazon SES uses the value of the <code>FromArn</code>
        /// parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about when to use this parameter, see the description of <code>SendRawEmail</code>
        /// in this guide, or see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-delegate-sender-tasks-email.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public string FromArn
        {
            get { return this._fromArn; }
            set { this._fromArn = value; }
        }

        // Check to see if FromArn property is set
        internal bool IsSetFromArn()
        {
            return this._fromArn != null;
        }

        /// <summary>
        /// Gets and sets the property RawMessage. 
        /// <para>
        /// The raw text of the message. The client is responsible for ensuring the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Message must contain a header and a body, separated by a blank line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All required header fields must be present.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each part of a multipart MIME message must be formatted properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MIME content types must be among those supported by Amazon SES. For more information,
        /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be base64-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Per <a href="https://tools.ietf.org/html/rfc5321#section-4.5.3.1.6">RFC 5321</a>,
        /// the maximum length of each line of text, including the &lt;CRLF&gt;, must not exceed
        /// 1,000 characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RawMessage RawMessage
        {
            get { return this._rawMessage; }
            set { this._rawMessage = value; }
        }

        // Check to see if RawMessage property is set
        internal bool IsSetRawMessage()
        {
            return this._rawMessage != null;
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
        /// Instead of using this parameter, you can use the X-header <code>X-SES-RETURN-PATH-ARN</code>
        /// in the raw message of the email. If you use both the <code>ReturnPathArn</code> parameter
        /// and the corresponding X-header, Amazon SES uses the value of the <code>ReturnPathArn</code>
        /// parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about when to use this parameter, see the description of <code>SendRawEmail</code>
        /// in this guide, or see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-delegate-sender-tasks-email.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </note>
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
        /// The identity's email address. If you do not provide a value for this parameter, you
        /// must specify a "From" address in the raw text of the message. (You can also specify
        /// both.)
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon SES does not support the SMTPUTF8 extension, as described in<a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
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
        /// <para>
        /// If you specify the <code>Source</code> parameter and have feedback forwarding enabled,
        /// then bounces and complaints will be sent to this email address. This takes precedence
        /// over any Return-Path header that you might include in the raw text of the message.
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
        /// Instead of using this parameter, you can use the X-header <code>X-SES-SOURCE-ARN</code>
        /// in the raw message of the email. If you use both the <code>SourceArn</code> parameter
        /// and the corresponding X-header, Amazon SES uses the value of the <code>SourceArn</code>
        /// parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about when to use this parameter, see the description of <code>SendRawEmail</code>
        /// in this guide, or see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-delegate-sender-tasks-email.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  </note>
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
        /// using <code>SendRawEmail</code>. Tags correspond to characteristics of the email that
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