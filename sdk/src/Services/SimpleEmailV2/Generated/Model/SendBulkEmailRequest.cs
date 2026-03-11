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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the SendBulkEmail operation.
    /// Composes an email message to multiple destinations.
    /// </summary>
    public partial class SendBulkEmailRequest : AmazonSimpleEmailServiceV2Request
    {
        private List<BulkEmailEntry> _bulkEmailEntries = AWSConfigs.InitializeCollections ? new List<BulkEmailEntry>() : null;
        private string _configurationSetName;
        private BulkEmailContent _defaultContent;
        private List<MessageTag> _defaultEmailTags = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;
        private string _endpointId;
        private string _feedbackForwardingEmailAddress;
        private string _feedbackForwardingEmailAddressIdentityArn;
        private string _fromEmailAddress;
        private string _fromEmailAddressIdentityArn;
        private List<string> _replyToAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tenantName;

        /// <summary>
        /// Gets and sets the property BulkEmailEntries. 
        /// <para>
        /// The list of bulk email entry objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BulkEmailEntry> BulkEmailEntries
        {
            get { return this._bulkEmailEntries; }
            set { this._bulkEmailEntries = value; }
        }

        // Check to see if BulkEmailEntries property is set
        internal bool IsSetBulkEmailEntries()
        {
            return this._bulkEmailEntries != null && (this._bulkEmailEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when sending the email.
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
        /// Gets and sets the property DefaultContent. 
        /// <para>
        /// An object that contains the body of the message. You can specify a template message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BulkEmailContent DefaultContent
        {
            get { return this._defaultContent; }
            set { this._defaultContent = value; }
        }

        // Check to see if DefaultContent property is set
        internal bool IsSetDefaultContent()
        {
            return this._defaultContent != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultEmailTags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// using the <c>SendEmail</c> operation. Tags correspond to characteristics of the email
        /// that you define, so that you can publish email sending events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> DefaultEmailTags
        {
            get { return this._defaultEmailTags; }
            set { this._defaultEmailTags = value; }
        }

        // Check to see if DefaultEmailTags property is set
        internal bool IsSetDefaultEmailTags()
        {
            return this._defaultEmailTags != null && (this._defaultEmailTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackForwardingEmailAddress. 
        /// <para>
        /// The address that you want bounce and complaint notifications to be sent to.
        /// </para>
        /// </summary>
        public string FeedbackForwardingEmailAddress
        {
            get { return this._feedbackForwardingEmailAddress; }
            set { this._feedbackForwardingEmailAddress = value; }
        }

        // Check to see if FeedbackForwardingEmailAddress property is set
        internal bool IsSetFeedbackForwardingEmailAddress()
        {
            return this._feedbackForwardingEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property FeedbackForwardingEmailAddressIdentityArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to use the
        /// email address specified in the <c>FeedbackForwardingEmailAddress</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, if the owner of example.com (which has ARN arn:aws:ses:us-east-1:123456789012:identity/example.com)
        /// attaches a policy to it that authorizes you to use feedback@example.com, then you
        /// would specify the <c>FeedbackForwardingEmailAddressIdentityArn</c> to be arn:aws:ses:us-east-1:123456789012:identity/example.com,
        /// and the <c>FeedbackForwardingEmailAddress</c> to be feedback@example.com.
        /// </para>
        ///  
        /// <para>
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string FeedbackForwardingEmailAddressIdentityArn
        {
            get { return this._feedbackForwardingEmailAddressIdentityArn; }
            set { this._feedbackForwardingEmailAddressIdentityArn = value; }
        }

        // Check to see if FeedbackForwardingEmailAddressIdentityArn property is set
        internal bool IsSetFeedbackForwardingEmailAddressIdentityArn()
        {
            return this._feedbackForwardingEmailAddressIdentityArn != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address to use as the "From" address for the email. The address that you
        /// specify has to be verified.
        /// </para>
        /// </summary>
        public string FromEmailAddress
        {
            get { return this._fromEmailAddress; }
            set { this._fromEmailAddress = value; }
        }

        // Check to see if FromEmailAddress property is set
        internal bool IsSetFromEmailAddress()
        {
            return this._fromEmailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property FromEmailAddressIdentityArn. 
        /// <para>
        /// This parameter is used only for sending authorization. It is the ARN of the identity
        /// that is associated with the sending authorization policy that permits you to use the
        /// email address specified in the <c>FromEmailAddress</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// For example, if the owner of example.com (which has ARN arn:aws:ses:us-east-1:123456789012:identity/example.com)
        /// attaches a policy to it that authorizes you to use sender@example.com, then you would
        /// specify the <c>FromEmailAddressIdentityArn</c> to be arn:aws:ses:us-east-1:123456789012:identity/example.com,
        /// and the <c>FromEmailAddress</c> to be sender@example.com.
        /// </para>
        ///  
        /// <para>
        /// For more information about sending authorization, see the <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/sending-authorization.html">Amazon
        /// SES Developer Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string FromEmailAddressIdentityArn
        {
            get { return this._fromEmailAddressIdentityArn; }
            set { this._fromEmailAddressIdentityArn = value; }
        }

        // Check to see if FromEmailAddressIdentityArn property is set
        internal bool IsSetFromEmailAddressIdentityArn()
        {
            return this._fromEmailAddressIdentityArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The "Reply-to" email addresses for the message. When the recipient replies to the
        /// message, each Reply-to address receives the reply.
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
        /// Gets and sets the property TenantName. 
        /// <para>
        /// The name of the tenant through which this bulk email will be sent.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The email sending operation will only succeed if all referenced resources (identities,
        /// configuration sets, and templates) are associated with this tenant. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TenantName
        {
            get { return this._tenantName; }
            set { this._tenantName = value; }
        }

        // Check to see if TenantName property is set
        internal bool IsSetTenantName()
        {
            return this._tenantName != null;
        }

    }
}