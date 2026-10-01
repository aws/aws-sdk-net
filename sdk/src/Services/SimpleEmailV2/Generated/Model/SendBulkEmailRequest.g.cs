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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the SendBulkEmail operation. Composes an email message
    /// to multiple destinations.
    /// </summary>
    public partial class SendBulkEmailRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property BulkEmailEntries. 
        /// <para>
        /// The list of bulk email entry objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BulkEmailEntry> BulkEmailEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<BulkEmailEntry>() : null;

        /// <summary>
        /// Checks to see if the BulkEmailEntries property is set.
        /// </summary>
        internal bool IsSetBulkEmailEntries() => this.BulkEmailEntries != null && (this.BulkEmailEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// An object that overrides, for the messages in this request only, settings that would
        /// otherwise apply to them. The overrides apply to every message in the request. Each
        /// setting that you don't override keeps the value that already applies.
        /// </para>
        /// </summary>
        public ConfigurationOverrides ConfigurationOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationOverrides property is set.
        /// </summary>
        internal bool IsSetConfigurationOverrides() => this.ConfigurationOverrides != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to use when sending the email.
        /// </para>
        /// </summary>
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property DefaultContent. 
        /// <para>
        /// An object that contains the body of the message. You can specify a template message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BulkEmailContent DefaultContent { get; set; }

        /// <summary>
        /// Checks to see if the DefaultContent property is set.
        /// </summary>
        internal bool IsSetDefaultContent() => this.DefaultContent != null;

        /// <summary>
        /// Gets and sets the property DefaultEmailTags. 
        /// <para>
        /// A list of tags, in the form of name/value pairs, to apply to an email that you send
        /// using the <c>SendEmail</c> operation. Tags correspond to characteristics of the email
        /// that you define, so that you can publish email sending events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MessageTag> DefaultEmailTags { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;

        /// <summary>
        /// Checks to see if the DefaultEmailTags property is set.
        /// </summary>
        internal bool IsSetDefaultEmailTags() => this.DefaultEmailTags != null && (this.DefaultEmailTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property FeedbackForwardingEmailAddress. 
        /// <para>
        /// The address that you want bounce and complaint notifications to be sent to.
        /// </para>
        /// </summary>
        public string FeedbackForwardingEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackForwardingEmailAddress property is set.
        /// </summary>
        internal bool IsSetFeedbackForwardingEmailAddress() => this.FeedbackForwardingEmailAddress != null;

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
        [AWSProperty(Min = 1)]
        public string FeedbackForwardingEmailAddressIdentityArn { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackForwardingEmailAddressIdentityArn property is set.
        /// </summary>
        internal bool IsSetFeedbackForwardingEmailAddressIdentityArn() => this.FeedbackForwardingEmailAddressIdentityArn != null;

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address to use as the "From" address for the email. The address that you
        /// specify has to be verified.
        /// </para>
        /// </summary>
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null;

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
        [AWSProperty(Min = 1)]
        public string FromEmailAddressIdentityArn { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddressIdentityArn property is set.
        /// </summary>
        internal bool IsSetFromEmailAddressIdentityArn() => this.FromEmailAddressIdentityArn != null;

        /// <summary>
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The "Reply-to" email addresses for the message. When the recipient replies to the
        /// message, each Reply-to address receives the reply.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReplyToAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplyToAddresses property is set.
        /// </summary>
        internal bool IsSetReplyToAddresses() => this.ReplyToAddresses != null && (this.ReplyToAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Min = 1)]
        public string TenantName { get; set; }

        /// <summary>
        /// Checks to see if the TenantName property is set.
        /// </summary>
        internal bool IsSetTenantName() => this.TenantName != null;
    }
}
