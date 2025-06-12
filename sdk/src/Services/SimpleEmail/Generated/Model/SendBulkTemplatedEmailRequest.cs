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
    /// Container for the parameters to the SendBulkTemplatedEmail operation.
    /// Composes an email message to multiple destinations. The message body is created using
    /// an email template.
    /// 
    ///  
    /// <para>
    /// To send email using this operation, your call must meet the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The call must refer to an existing email template. You can create email templates
    /// using <a>CreateTemplate</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The message must be sent from a verified email address or domain.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your account is still in the Amazon SES sandbox, you may send only to verified
    /// addresses or domains, or to email addresses associated with the Amazon SES Mailbox
    /// Simulator. For more information, see <a href="https://docs.aws.amazon.com/ses/latest/dg/verify-addresses-and-domains.html">Verifying
    /// Email Addresses and Domains</a> in the <i>Amazon SES Developer Guide.</i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The maximum message size is 10 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each <c>Destination</c> parameter must include at least one recipient email address.
    /// The recipient address can be a To: address, a CC: address, or a BCC: address. If a
    /// recipient email address is invalid (that is, it is not in the format <i>UserName@[SubDomain.]Domain.TopLevelDomain</i>),
    /// the entire message is rejected, even if the message contains other recipients that
    /// are valid.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The message may not include more than 50 recipients, across the To:, CC: and BCC:
    /// fields. If you need to send an email message to a larger audience, you can divide
    /// your recipient list into groups of 50 or fewer, and then call the <c>SendBulkTemplatedEmail</c>
    /// operation several times to send the message to each group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The number of destinations you can contact in a single call can be limited by your
    /// account's maximum sending rate.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SendBulkTemplatedEmailRequest : AmazonSimpleEmailServiceRequest
    {
        private string _configurationSetName;
        private List<MessageTag> _defaultTags = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;
        private string _defaultTemplateData;
        private List<BulkEmailDestination> _destinations = AWSConfigs.InitializeCollections ? new List<BulkEmailDestination>() : null;
        private List<string> _replyToAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _returnPath;
        private string _returnPathArn;
        private string _source;
        private string _sourceArn;
        private string _template;
        private string _templateArn;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when you send an email using <c>SendBulkTemplatedEmail</c>.
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
        /// Gets and sets the property DefaultTags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// to a destination using <c>SendBulkTemplatedEmail</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> DefaultTags
        {
            get { return this._defaultTags; }
            set { this._defaultTags = value; }
        }

        // Check to see if DefaultTags property is set
        internal bool IsSetDefaultTags()
        {
            return this._defaultTags != null && (this._defaultTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultTemplateData. 
        /// <para>
        /// A list of replacement values to apply to the template when replacement data is not
        /// specified in a Destination object. These values act as a default or fallback option
        /// when no other data is available.
        /// </para>
        ///  
        /// <para>
        /// The template data is a JSON object, typically consisting of key-value pairs in which
        /// the keys correspond to replacement tags in the email template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=262144)]
        public string DefaultTemplateData
        {
            get { return this._defaultTemplateData; }
            set { this._defaultTemplateData = value; }
        }

        // Check to see if DefaultTemplateData property is set
        internal bool IsSetDefaultTemplateData()
        {
            return this._defaultTemplateData != null;
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// One or more <c>Destination</c> objects. All of the recipients in a <c>Destination</c>
        /// receive the same version of the email. You can specify up to 50 <c>Destination</c>
        /// objects within a <c>Destinations</c> array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BulkEmailDestination> Destinations
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
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The reply-to email address(es) for the message. If the recipient replies to the message,
        /// each reply-to address receives the reply.
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
        /// Gets and sets the property ReturnPath. 
        /// <para>
        /// The email address that bounces and complaints are forwarded to when feedback forwarding
        /// is enabled. If the message cannot be delivered to the recipient, then an error message
        /// is returned from the recipient's ISP; this message is forwarded to the email address
        /// specified by the <c>ReturnPath</c> parameter. The <c>ReturnPath</c> parameter is never
        /// overwritten. This email address must be either individually verified with Amazon SES,
        /// or from a domain that has been verified with Amazon SES. 
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
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
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
        /// For information about verifying identities, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are sending on behalf of another user and have been permitted to do so by a
        /// sending authorization policy, then you must also specify the <c>SourceArn</c> parameter.
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon SES does not support the SMTPUTF8 extension, as described in <a href="https://tools.ietf.org/html/rfc6531">RFC6531</a>.
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
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/sending-authorization.html">Amazon
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
        /// Gets and sets the property Template. 
        /// <para>
        /// The template to use when sending this email.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}