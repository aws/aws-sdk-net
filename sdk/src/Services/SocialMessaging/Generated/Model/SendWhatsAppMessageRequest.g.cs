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

namespace Amazon.SocialMessaging.Model
{
    /// <summary>
    /// Container for the parameters to the SendWhatsAppMessage operation. Send a WhatsApp
    /// message. For examples of sending a message using the Amazon Web Services CLI, see
    /// <a href="https://docs.aws.amazon.com/social-messaging/latest/userguide/send-message.html">Sending
    /// messages</a> in the <i> <i>Amazon Web Services End User Messaging Social User Guide</i>
    /// </i>.
    /// </summary>
    public partial class SendWhatsAppMessageRequest : AmazonSocialMessagingRequest
    {
        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message to send through WhatsApp. The length is in KB. The message field passes
        /// through a WhatsApp Message object, see <a href="https://developers.facebook.com/docs/whatsapp/cloud-api/reference/messages">Messages</a>
        /// in the <i>WhatsApp Business Platform Cloud API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048000)]
        public MemoryStream Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property MetaApiVersion. 
        /// <para>
        /// The API version for the request formatted as <c>v{VersionNumber}</c>. For a list of
        /// supported API versions and Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/end-user-messaging.html">
        /// <i>Amazon Web Services End User Messaging Social API</i> Service Endpoints</a> in
        /// the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MetaApiVersion { get; set; }

        /// <summary>
        /// Checks to see if the MetaApiVersion property is set.
        /// </summary>
        internal bool IsSetMetaApiVersion() => this.MetaApiVersion != null;

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The ID of the phone number used to send the WhatsApp message. If you are sending a
        /// media file only the <c>originationPhoneNumberId</c> used to upload the file can be
        /// used. Phone number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_GetLinkedWhatsAppBusinessAccount.html">GetLinkedWhatsAppBusinessAccount</a>
        /// to find a phone number's id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 115)]
        public string OriginationPhoneNumberId { get; set; }

        /// <summary>
        /// Checks to see if the OriginationPhoneNumberId property is set.
        /// </summary>
        internal bool IsSetOriginationPhoneNumberId() => this.OriginationPhoneNumberId != null;
    }
}
