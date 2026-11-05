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
    /// Specifies the default settings for a one-time SMS message that's sent directly to
    /// an endpoint.
    /// </summary>
    public partial class SMSMessage
    {
        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The body of the SMS message.
        /// </para>
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Checks to see if the Body property is set.
        /// </summary>
        internal bool IsSetBody() => this.Body != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The entity ID or Principal Entity (PE) id received from the regulatory body for sending
        /// SMS in your country.
        /// </para>
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The SMS program name that you provided to AWS Support when you requested your dedicated
        /// number.
        /// </para>
        /// </summary>
        public string Keyword { get; set; }

        /// <summary>
        /// Checks to see if the Keyword property is set.
        /// </summary>
        internal bool IsSetKeyword() => this.Keyword != null;

        /// <summary>
        /// Gets and sets the property MediaUrl. 
        /// <para>
        /// This field is reserved for future use.
        /// </para>
        /// </summary>
        public string MediaUrl { get; set; }

        /// <summary>
        /// Checks to see if the MediaUrl property is set.
        /// </summary>
        internal bool IsSetMediaUrl() => this.MediaUrl != null;

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The SMS message type. Valid values are TRANSACTIONAL (for messages that are critical
        /// or time-sensitive, such as a one-time passwords) and PROMOTIONAL (for messsages that
        /// aren't critical or time-sensitive, such as marketing messages).
        /// </para>
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Checks to see if the MessageType property is set.
        /// </summary>
        internal bool IsSetMessageType() => this.MessageType != null;

        /// <summary>
        /// Gets and sets the property OriginationNumber. 
        /// <para>
        /// The number to send the SMS message from. This value should be one of the dedicated
        /// long or short codes that's assigned to your AWS account. If you don't specify a long
        /// or short code, Amazon Pinpoint assigns a random long code to the SMS message and sends
        /// the message from that code.
        /// </para>
        /// </summary>
        public string OriginationNumber { get; set; }

        /// <summary>
        /// Checks to see if the OriginationNumber property is set.
        /// </summary>
        internal bool IsSetOriginationNumber() => this.OriginationNumber != null;

        /// <summary>
        /// Gets and sets the property SenderId. 
        /// <para>
        /// The sender ID to display as the sender of the message on a recipient's device. Support
        /// for sender IDs varies by country or region.
        /// </para>
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// Checks to see if the SenderId property is set.
        /// </summary>
        internal bool IsSetSenderId() => this.SenderId != null;

        /// <summary>
        /// Gets and sets the property Substitutions. 
        /// <para>
        /// The message variables to use in the SMS message. You can override the default variables
        /// with individual address variables.
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

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// The template ID received from the regulatory body for sending SMS in your country.
        /// </para>
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
