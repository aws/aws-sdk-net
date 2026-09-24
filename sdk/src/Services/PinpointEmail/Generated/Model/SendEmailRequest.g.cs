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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the SendEmail operation. Sends an email message. You
    /// can use the Amazon Pinpoint Email API to send two types of messages: <ul> <li> <para>
    /// <b>Simple</b> – A standard email message. When you create this type of message, you
    /// specify the sender, the recipient, and the message body, and Amazon Pinpoint assembles
    /// the message for you. </para> </li> <li> <para> <b>Raw</b> – A raw, MIME-formatted
    /// email message. When you send this type of email, you have to specify all of the message
    /// headers, as well as the message body. You can use this message type to send messages
    /// that contain attachments. The message that you specify has to be a valid MIME message.
    /// </para> </li> </ul>
    /// </summary>
    public partial class SendEmailRequest : AmazonPinpointEmailRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set that you want to use when sending the email.
        /// </para>
        /// </summary>
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// An object that contains the body of the message. You can send either a Simple message
        /// or a Raw message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EmailContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// An object that contains the recipients of the email message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property EmailTags. 
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
        public List<MessageTag> EmailTags { get; set; } = AWSConfigs.InitializeCollections ? new List<MessageTag>() : null;

        /// <summary>
        /// Checks to see if the EmailTags property is set.
        /// </summary>
        internal bool IsSetEmailTags() => this.EmailTags != null && (this.EmailTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeedbackForwardingEmailAddress. 
        /// <para>
        /// The address that Amazon Pinpoint should send bounce and complaint notifications to.
        /// </para>
        /// </summary>
        public string FeedbackForwardingEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackForwardingEmailAddress property is set.
        /// </summary>
        internal bool IsSetFeedbackForwardingEmailAddress() => this.FeedbackForwardingEmailAddress != null;

        /// <summary>
        /// Gets and sets the property FromEmailAddress. 
        /// <para>
        /// The email address that you want to use as the "From" address for the email. The address
        /// that you specify has to be verified. 
        /// </para>
        /// </summary>
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromEmailAddress property is set.
        /// </summary>
        internal bool IsSetFromEmailAddress() => this.FromEmailAddress != null;

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
    }
}
