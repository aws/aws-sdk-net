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
    /// Sends an email message, with header and content specified by the client. The <code>SendRawEmail</code>
    /// action is useful for sending multipart MIME emails. The raw text of the message must
    /// comply with Internet email standards; otherwise, the message cannot be sent. 
    /// 
    ///  
    /// <para>
    /// There are several important points to know about <code>SendRawEmail</code>:
    /// </para>
    ///  <ul> <li>You can only send email from verified email addresses and domains; otherwise,
    /// you will get an "Email address not verified" error. If your account is still in the
    /// Amazon SES sandbox, you must also verify every recipient email address except for
    /// the recipients provided by the Amazon SES mailbox simulator. For more information,
    /// go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/verify-addresses-and-domains.html">Amazon
    /// SES Developer Guide</a>.</li> <li>The total size of the message cannot exceed 10 MB.
    /// This includes any attachments that are part of the message.</li> <li>Amazon SES has
    /// a limit on the total number of recipients per message. The combined number of To:,
    /// CC: and BCC: email addresses cannot exceed 50. If you need to send an email message
    /// to a larger audience, you can divide your recipient list into groups of 50 or fewer,
    /// and then call Amazon SES repeatedly to send the message to each group.</li> <li>The
    /// To:, CC:, and BCC: headers in the raw message can contain a group list. Note that
    /// each recipient in a group list counts towards the 50-recipient limit.</li> <li>For
    /// every message that you send, the total number of recipients (To:, CC: and BCC:) is
    /// counted against your sending quota - the maximum number of emails you can send in
    /// a 24-hour period. For information about your sending quota, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/manage-sending-limits.html">Amazon
    /// SES Developer Guide</a>.</li> <li>If you are using sending authorization to send on
    /// behalf of another user, <code>SendRawEmail</code> enables you to specify the cross-account
    /// identity for the email's "Source," "From," and "Return-Path" parameters in one of
    /// two ways: you can pass optional parameters <code>SourceArn</code>, <code>FromArn</code>,
    /// and/or <code>ReturnPathArn</code> to the API, or you can include the following X-headers
    /// in the header of your raw email: <ul> <li><code>X-SES-SOURCE-ARN</code></li> <li><code>X-SES-FROM-ARN</code></li>
    /// <li><code>X-SES-RETURN-PATH-ARN</code></li> </ul> <important>Do not include these
    /// X-headers in the DKIM signature, because they are removed by Amazon SES before sending
    /// the email.</important> For the most common sending authorization use case, we recommend
    /// that you specify the <code>SourceIdentityArn</code> and do not specify either the
    /// <code>FromIdentityArn</code> or <code>ReturnPathIdentityArn</code>. (The same note
    /// applies to the corresponding X-headers.) If you only specify the <code>SourceIdentityArn</code>,
    /// Amazon SES will simply set the "From" address and the "Return Path" address to the
    /// identity specified in <code>SourceIdentityArn</code>. For more information about sending
    /// authorization, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
    /// SES Developer Guide</a>.</li> </ul>
    /// </summary>
    public partial class SendRawEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _destinations = new List<string>();
        private string _fromArn;
        private RawMessage _rawMessage;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SendRawEmailRequest() { }

        /// <summary>
        /// Instantiates SendRawEmailRequest with the parameterized properties
        /// </summary>
        /// <param name="rawMessage">The raw text of the message. The client is responsible for ensuring the following:  <ul> <li>Message must contain a header and a body, separated by a blank line.</li> <li>All required header fields must be present.</li> <li>Each part of a multipart MIME message must be formatted properly.</li> <li>MIME content types must be among those supported by Amazon SES. For more information, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon SES Developer Guide</a>. </li> <li>Content must be base64-encoded, if MIME requires it.</li> </ul> </param>
        public SendRawEmailRequest(RawMessage rawMessage)
        {
            _rawMessage = rawMessage;
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
        ///  <note>For information about when to use this parameter, see the description of <code>SendRawEmail</code>
        /// in this guide, or see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-delegate-sender-tasks-email.html">Amazon
        /// SES Developer Guide</a>. </note>
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
        ///  
        /// <para>
        ///  <ul> <li>Message must contain a header and a body, separated by a blank line.</li>
        /// <li>All required header fields must be present.</li> <li>Each part of a multipart
        /// MIME message must be formatted properly.</li> <li>MIME content types must be among
        /// those supported by Amazon SES. For more information, go to the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/mime-types.html">Amazon
        /// SES Developer Guide</a>. </li> <li>Content must be base64-encoded, if MIME requires
        /// it.</li> </ul> 
        /// </para>
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
        ///  <note>For information about when to use this parameter, see the description of <code>SendRawEmail</code>
        /// in this guide, or see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-delegate-sender-tasks-email.html">Amazon
        /// SES Developer Guide</a>. </note>
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
        ///  
        /// <para>
        ///  By default, the string must be 7-bit ASCII. If the text must contain any other characters,
        /// then you must use MIME encoded-word syntax (RFC 2047) instead of a literal string.
        /// MIME encoded-word syntax uses the following form: <code>=?charset?encoding?encoded-text?=</code>.
        /// For more information, see <a href="http://tools.ietf.org/html/rfc2047">RFC 2047</a>.
        /// 
        /// </para>
        ///  <note>If you specify the <code>Source</code> parameter and have feedback forwarding
        /// enabled, then bounces and complaints will be sent to this email address. This takes
        /// precedence over any <i>Return-Path</i> header that you might include in the raw text
        /// of the message. </note>
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
        ///  <note>For information about when to use this parameter, see the description of <code>SendRawEmail</code>
        /// in this guide, or see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization-delegate-sender-tasks-email.html">Amazon
        /// SES Developer Guide</a>. </note>
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