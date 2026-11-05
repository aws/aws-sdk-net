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
    /// Specifies the content and settings for an SMS message that's sent to recipients of
    /// a campaign.
    /// </summary>
    public partial class CampaignSmsMessage
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
        /// The long code to send the SMS message from. This value should be one of the dedicated
        /// long codes that's assigned to your AWS account. Although it isn't required, we recommend
        /// that you specify the long code using an E.164 format to ensure prompt and accurate
        /// delivery of the message. For example, +12065550100.
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
        /// The sender ID to display on recipients' devices when they receive the SMS message.
        /// </para>
        /// </summary>
        public string SenderId { get; set; }

        /// <summary>
        /// Checks to see if the SenderId property is set.
        /// </summary>
        internal bool IsSetSenderId() => this.SenderId != null;

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
