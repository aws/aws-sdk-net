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
    /// Container for the parameters to the SendTemplatedEmail operation.
    /// Composes an email message using an email template and immediately queues it for sending.
    /// 
    ///  
    /// <para>
    /// In order to send email using the <code>SendTemplatedEmail</code> operation, your call
    /// to the API must meet the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The call must refer to an existing email template. You can create email templates
    /// using the <a>CreateTemplate</a> operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The message must be sent from a verified email address or domain.
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
    /// The total size of the message, including attachments, must be less than 10 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Calls to the <code>SendTemplatedEmail</code> operation may only include one <code>Destination</code>
    /// parameter. A destination is a set of recipients who will receive the same version
    /// of the email. The <code>Destination</code> parameter can include up to 50 recipients,
    /// across the To:, CC: and BCC: fields.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Destination</code> parameter must include at least one recipient email address.
    /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
    /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
    /// the entire message will be rejected, even if the message contains other recipients
    /// that are valid.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// If your call to the <code>SendTemplatedEmail</code> operation includes all of the
    /// required parameters, Amazon SES accepts it and returns a Message ID. However, if Amazon
    /// SES can't render the email because the template contains errors, it doesn't send the
    /// email. Additionally, because it already accepted the message, Amazon SES doesn't return
    /// a message stating that it was unable to send the email.
    /// </para>
    ///  
    /// <para>
    /// For these reasons, we highly recommend that you set up Amazon SES to send you notifications
    /// when Rendering Failure events occur. For more information, see <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/send-personalized-email-api.html">Sending
    /// Personalized Email Using the Amazon SES API</a> in the <i>Amazon Simple Email Service
    /// Developer Guide</i>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SendTemplatedEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private Destination _destination;
        private List<string> _replyToAddresses = new List<string>();
        private string _returnPath;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;
        private List<MessageTag> _tags = new List<MessageTag>();
        private string _template;
        private string _templateArn;
        private string _templateData;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when you send an email using <code>SendTemplatedEmail</code>.
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
        /// The destination for this email, composed of To:, CC:, and BCC: fields. A Destination
        /// can include up to 50 recipients across these three fields.
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
        ///  <note> 
        /// <para>
        /// Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
        /// For this reason, the <i>local part</i> of a source email address (the part of the
        /// email address that precedes the @ sign) may only contain <a href="https://en.wikipedia.org/wiki/Email_address#Local-part">7-bit
        /// ASCII characters</a>. If the <i>domain part</i> of an address (the part after the
        /// @ sign) contains non-ASCII characters, they must be encoded using Punycode, as described
        /// in <a href="https://tools.ietf.org/html/rfc3492.html">RFC3492</a>. The sender name
        /// (also known as the <i>friendly name</i>) may contain non-ASCII characters. These characters
        /// must be encoded using MIME encoded-word syntax, as described in<a href="https://tools.ietf.org/html/rfc2047">RFC
        /// 2047</a>. MIME encoded-word syntax uses the following form: <code>=?charset?encoding?encoded-text?=</code>.
        /// </para>
        ///  </note>
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// using <code>SendTemplatedEmail</code>. Tags correspond to characteristics of the email
        /// that you define, so that you can publish email sending events.
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

        /// <summary>
        /// Gets and sets the property Template. 
        /// <para>
        /// The template to use when sending this email.
        /// </para>
        /// </summary>
        public string Template
        {
            get { return this._template; }
            set { this._template = value; }
        }

        // Check to see if Template property is set
        internal bool IsSetTemplate()
        {
            return this._template != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The ARN of the template to use when sending this email.
        /// </para>
        /// </summary>
        public string TemplateArn
        {
            get { return this._templateArn; }
            set { this._templateArn = value; }
        }

        // Check to see if TemplateArn property is set
        internal bool IsSetTemplateArn()
        {
            return this._templateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateData. 
        /// <para>
        /// A list of replacement values to apply to the template. This parameter is a JSON object,
        /// typically consisting of key-value pairs in which the keys correspond to replacement
        /// tags in the email template.
        /// </para>
        /// </summary>
        public string TemplateData
        {
            get { return this._templateData; }
            set { this._templateData = value; }
        }

        // Check to see if TemplateData property is set
        internal bool IsSetTemplateData()
        {
            return this._templateData != null;
        }

    }
}