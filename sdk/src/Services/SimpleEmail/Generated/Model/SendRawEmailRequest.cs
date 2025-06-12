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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SendRawEmail operation.
    /// Composes an email message and immediately queues it for sending.
    /// 
    ///  
    /// <para>
    /// This operation is more flexible than the <c>SendEmail</c> operation. When you use
    /// the <c>SendRawEmail</c> operation, you can specify the headers of the message as well
    /// as its content. This flexibility is useful, for example, when you need to send a multipart
    /// MIME email (such a message that contains both a text and an HTML version). You can
    /// also use this operation to send messages that include attachments.
    /// </para>
    ///  
    /// <para>
    /// The <c>SendRawEmail</c> operation has the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can only send email from <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">verified
    /// email addresses or domains</a>. If you try to send email from an address that isn't
    /// verified, the operation results in an "Email address not verified" error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your account is still in the <a href="https://docs.aws.amazon.com/ses/latest/dg/request-production-access.html">Amazon
    /// SES sandbox</a>, you can only send email to other verified addresses in your account,
    /// or to addresses that are associated with the <a href="https://docs.aws.amazon.com/ses/latest/dg/send-an-email-from-console.html">Amazon
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
    /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html#send-email-mime-encoding">MIME
    /// Encoding</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Additionally, keep the following considerations in mind when using the <c>SendRawEmail</c>
    /// operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Although you can customize the message headers when using the <c>SendRawEmail</c>
    /// operation, Amazon SES automatically applies its own <c>Message-ID</c> and <c>Date</c>
    /// headers; if you passed these headers when creating the message, they are overwritten
    /// by the values that Amazon SES provides.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are using sending authorization to send on behalf of another user, <c>SendRawEmail</c>
    /// enables you to specify the cross-account identity for the email's Source, From, and
    /// Return-Path parameters in one of two ways: you can pass optional parameters <c>SourceArn</c>,
    /// <c>FromArn</c>, and/or <c>ReturnPathArn</c>, or you can include the following X-headers
    /// in the header of your raw email:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>X-SES-SOURCE-ARN</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>X-SES-FROM-ARN</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>X-SES-RETURN-PATH-ARN</c> 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// Don't include these X-headers in the DKIM signature. Amazon SES removes these before
    /// it sends the email.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you only specify the <c>SourceIdentityArn</c> parameter, Amazon SES sets the From
    /// and Return-Path addresses to the same identity that you specified.
    /// </para>
    ///  
    /// <para>
    /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Using
    /// Sending Authorization with Amazon SES</a> in the <i>Amazon SES Developer Guide.</i>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For every message that you send, the total number of recipients (including each recipient
    /// in the To:, CC: and BCC: fields) is counted against the maximum number of emails you
    /// can send in a 24-hour period (your <i>sending quota</i>). For more information about
    /// sending quotas in Amazon SES, see <a href="https://docs.aws.amazon.com/ses/latest/dg/manage-sending-quotas.html">Managing
    /// Your Amazon SES Sending Limits</a> in the <i>Amazon SES Developer Guide.</i> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SendRawEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private List<string> _destinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _fromArn;
        private RawMessage _rawMessage;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;
        private List<MessageTag> _tags = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendRawEmailRequest() { }

        /// <summary>
        /// Instantiates SendRawEmailRequest with the parameterized properties
        /// </summary>
        /// <param name="rawMessage">The raw email message itself. The message has to meet the following criteria: <ul> <li> The message has to contain a header and a body, separated by a blank line. </li> <li> All of the required header fields must be present in the message. </li> <li> Each part of a multipart MIME message must be formatted properly. </li> <li> Attachments must be of a content type that Amazon SES supports. For a list on unsupported content types, see <a href="https://docs.aws.amazon.com/ses/latest/dg/mime-types.html">Unsupported Attachment Types</a> in the <i>Amazon SES Developer Guide</i>. </li> <li> The entire message must be base64-encoded. </li> <li> If any of the MIME parts in your message contain content that is outside of the 7-bit ASCII character range, we highly recommend that you encode that content. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html">Sending Raw Email</a> in the <i>Amazon SES Developer Guide</i>. </li> <li> Per <a href="https://tools.ietf.org/html/rfc5321#section-4.5.3.1.6">RFC 5321</a>, the maximum length of each line of text, including the &lt;CRLF&gt;, must not exceed 1,000 characters. </li> </ul></param>
        public SendRawEmailRequest(RawMessage rawMessage)
        {
            _rawMessage = rawMessage;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when you send an email using <c>SendRawEmail</c>.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Instead of using this parameter, you can use the X-header <c>X-SES-FROM-ARN</c> in
        /// the raw message of the email. If you use both the <c>FromArn</c> parameter and the
        /// corresponding X-header, Amazon SES uses the value of the <c>FromArn</c> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about when to use this parameter, see the description of <c>SendRawEmail</c>
        /// in this guide, or see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization-delegate-sender-tasks-email.html">Amazon
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
        /// content types, see <a href="https://docs.aws.amazon.com/ses/latest/dg/mime-types.html">Unsupported
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
        /// information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html">Sending
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
        [AWSProperty(Required=true)]
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
        /// email address specified in the <c>ReturnPath</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, if the owner of <c>example.com</c> (which has ARN <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>)
        /// attaches a policy to it that authorizes you to use <c>feedback@example.com</c>, then
        /// you would specify the <c>ReturnPathArn</c> to be <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>,
        /// and the <c>ReturnPath</c> to be <c>feedback@example.com</c>.
        /// </para>
        ///  
        /// <para>
        /// Instead of using this parameter, you can use the X-header <c>X-SES-RETURN-PATH-ARN</c>
        /// in the raw message of the email. If you use both the <c>ReturnPathArn</c> parameter
        /// and the corresponding X-header, Amazon SES uses the value of the <c>ReturnPathArn</c>
        /// parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about when to use this parameter, see the description of <c>SendRawEmail</c>
        /// in this guide, or see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization-delegate-sender-tasks-email.html">Amazon
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
        /// For this reason, the email address string must be 7-bit ASCII. If you want to send
        /// to or from email addresses that contain Unicode characters in the domain part of an
        /// address, you must encode the domain using Punycode. Punycode is not permitted in the
        /// local part of the email address (the part before the @ sign) nor in the "friendly
        /// from" name. If you want to use Unicode characters in the "friendly from" name, you
        /// must encode the "friendly from" name using MIME encoded-word syntax, as described
        /// in <a href="https://docs.aws.amazon.com/ses/latest/dg/send-email-raw.html">Sending
        /// raw email using the Amazon SES API</a>. For more information about Punycode, see <a
        /// href="http://tools.ietf.org/html/rfc3492">RFC 3492</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you specify the <c>Source</c> parameter and have feedback forwarding enabled, then
        /// bounces and complaints are sent to this email address. This takes precedence over
        /// any Return-Path header that you might include in the raw text of the message.
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
        /// for the email address specified in the <c>Source</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, if the owner of <c>example.com</c> (which has ARN <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>)
        /// attaches a policy to it that authorizes you to send from <c>user@example.com</c>,
        /// then you would specify the <c>SourceArn</c> to be <c>arn:aws:ses:us-east-1:123456789012:identity/example.com</c>,
        /// and the <c>Source</c> to be <c>user@example.com</c>.
        /// </para>
        ///  
        /// <para>
        /// Instead of using this parameter, you can use the X-header <c>X-SES-SOURCE-ARN</c>
        /// in the raw message of the email. If you use both the <c>SourceArn</c> parameter and
        /// the corresponding X-header, Amazon SES uses the value of the <c>SourceArn</c> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// For information about when to use this parameter, see the description of <c>SendRawEmail</c>
        /// in this guide, or see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization-delegate-sender-tasks-email.html">Amazon
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
        /// using <c>SendRawEmail</c>. Tags correspond to characteristics of the email that you
        /// define, so that you can publish email sending events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}