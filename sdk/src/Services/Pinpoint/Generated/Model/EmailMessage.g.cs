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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the default settings and content for a one-time email message that's sent
    /// directly to an endpoint.
    /// </summary>
    public partial class EmailMessage
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the email message.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property FeedbackForwardingAddress. 
        /// <para>
        /// The email address to forward bounces and complaints to, if feedback forwarding is
        /// enabled.
        /// </para>
        /// </summary>
        public string FeedbackForwardingAddress { get; set; }

        /// <summary>
        /// Checks to see if the FeedbackForwardingAddress property is set.
        /// </summary>
        internal bool IsSetFeedbackForwardingAddress() => this.FeedbackForwardingAddress != null;

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The verified email address to send the email message from. The default value is the
        /// FromAddress specified for the email channel.
        /// </para>
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromAddress property is set.
        /// </summary>
        internal bool IsSetFromAddress() => this.FromAddress != null;

        /// <summary>
        /// Gets and sets the property RawEmail. 
        /// <para>
        /// The email message, represented as a raw MIME message.
        /// </para>
        /// </summary>
        public RawEmail RawEmail { get; set; }

        /// <summary>
        /// Checks to see if the RawEmail property is set.
        /// </summary>
        internal bool IsSetRawEmail() => this.RawEmail != null;

        /// <summary>
        /// Gets and sets the property ReplyToAddresses. 
        /// <para>
        /// The reply-to email address(es) for the email message. If a recipient replies to the
        /// email, each reply-to address receives the reply.
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
        /// Gets and sets the property SimpleEmail. 
        /// <para>
        /// The email message, composed of a subject, a text part, and an HTML part.
        /// </para>
        /// </summary>
        public SimpleEmail SimpleEmail { get; set; }

        /// <summary>
        /// Checks to see if the SimpleEmail property is set.
        /// </summary>
        internal bool IsSetSimpleEmail() => this.SimpleEmail != null;

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The default message variables to use in the email message. You can override the default
        /// variables with individual address variables.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> Substitutions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Substitutions property is set.
        /// </summary>
        internal bool IsSetSubstitutions() => this.Substitutions != null && (this.Substitutions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
