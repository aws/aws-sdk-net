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
    /// Composes an email message and immediately queues it for sending.
    /// 
    ///  
    /// <para>
    /// This operation is more flexible than the <code>SendEmail</code> API operation. When
    /// you use the <code>SendRawEmail</code> operation, you can specify the headers of the
    /// message as well as its content. This flexibility is useful, for example, when you
    /// want to send a multipart MIME email (such a message that contains both a text and
    /// an HTML version). You can also use this operation to send messages that include attachments.
    /// </para>
    ///  
    /// <para>
    /// The <code>SendRawEmail</code> operation has the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can only send email from <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">verified
    /// email addresses or domains</a>. If you try to send email from an address that isn't
    /// verified, the operation results in an "Email address not verified" error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your account is still in the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/request-production-access.html">Amazon
    /// SES sandbox</a>, you can only send email to other verified addresses in your account,
    /// or to addresses that are associated with the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mailbox-simulator.html">Amazon
    /// SES mailbox simulator</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum message size, including attachments, is 10 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each message has to include at least one recipient address. A recipient address includes
    /// any address on the To:, CC:, or BCC: lines.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you send a single message to more than one recipient address, and one of the recipient
    /// addresses isn't in a valid format (that is, it's not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
    /// Amazon SES rejects the entire message, even if the other addresses are valid.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each message can include up to 50 recipient addresses across the To:, CC:, or BCC:
    /// lines. If you need to send a single message to more than 50 recipients, you have to
    /// split the list of recipient addresses into groups of less than 50 recipients, and
    /// send separate messages to each group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SES allows you to specify 8-bit Content-Transfer-Encoding for MIME message
    /// parts. However, if Amazon SES has to modify the contents of your message (for example,
    /// if you use open and click tracking), 8-bit content isn't preserved. For this reason,
    /// we highly recommend that you encode all content that isn't 7-bit ASCII. For more information,
    /// see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html#send-email-mime-encoding">MIME
    /// Encoding</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
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
    ///  </li> <li> 
    /// <para>
    /// For every message that you send, the total number of recipients (including each recipient
    /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
    /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
    /// sending quotas in Amazon SES, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Managing
    /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
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
        /// <param name="rawMessage">The raw email message itself. The message has to meet the following criteria: <ul> <li> The message has to contain a header and a body, separated by a blank line. </li> <li> All of the required header fields must be present in the message. </li> <li> Each part of a multipart MIME message must be formatted properly. </li> <li> Attachments must be of a content type that Amazon SES supports. For a list on unsupported content types, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Unsupported Attachment Types</a> in the <i>Amazon SES Developer Guide</i>. </li> <li> The entire message must be base64-encoded. </li> <li> If any of the MIME parts in your message contain content that is outside of the 7-bit ASCII character range, we highly recommend that you encode that content. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html">Sending Raw Email</a> in the <i>Amazon SES Developer Guide</i>. </li> <li> Per <a href="https://tools.ietf.org/html/rfc5321#section-4.5.3.1.6">RFC 5321</a>, the maximum length of each line of text, including the &lt;CRLF&gt;, must not exceed 1,000 characters. </li> </ul></param>
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
        /// The raw email message itself. The message has to meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message has to contain a header and a body, separated by a blank line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// All of the required header fields must be present in the message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each part of a multipart MIME message must be formatted properly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attachments must be of a content type that Amazon SES supports. For a list on unsupported
        /// content types, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Unsupported
        /// Attachment Types</a> in the <i>Amazon SES Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The entire message must be base64-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the MIME parts in your message contain content that is outside of the 7-bit
        /// ASCII character range, we highly recommend that you encode that content. For more
        /// information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-email-raw.html">Sending
        /// Raw Email</a> in the <i>Amazon SES Developer Guide</i>.
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