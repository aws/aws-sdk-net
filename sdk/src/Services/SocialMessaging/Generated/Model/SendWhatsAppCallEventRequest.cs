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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
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
    /// Container for the parameters to the SendWhatsAppCallEvent operation.
    /// Sends a WhatsApp calling event, such as connecting or terminating a call, for a business
    /// phone number. This operation passes the event through to Meta. To use this operation,
    /// the origination phone number must belong to a WhatsApp Business Account that is linked
    /// to your Amazon Web Services account.
    /// </summary>
    public partial class SendWhatsAppCallEventRequest : AmazonSocialMessagingRequest
    {
        private MemoryStream _callEvent;
        private string _metaApiVersion;
        private string _originationPhoneNumberId;

        /// <summary>
        /// Gets and sets the property CallEvent. 
        /// <para>
        /// The call event payload to send, as a JSON blob in the format defined by the Meta calling
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048000)]
        public MemoryStream CallEvent
        {
            get { return this._callEvent; }
            set { this._callEvent = value; }
        }

        // Check to see if CallEvent property is set
        internal bool IsSetCallEvent()
        {
            return this._callEvent != null;
        }

        /// <summary>
        /// Gets and sets the property MetaApiVersion. 
        /// <para>
        /// The version of the Meta Graph API to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetaApiVersion
        {
            get { return this._metaApiVersion; }
            set { this._metaApiVersion = value; }
        }

        // Check to see if MetaApiVersion property is set
        internal bool IsSetMetaApiVersion()
        {
            return this._metaApiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The unique identifier of the origination phone number for the call. The phone number
        /// identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// Use <c>GetLinkedWhatsAppBusinessAccount</c> to find a phone number's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=115)]
        public string OriginationPhoneNumberId
        {
            get { return this._originationPhoneNumberId; }
            set { this._originationPhoneNumberId = value; }
        }

        // Check to see if OriginationPhoneNumberId property is set
        internal bool IsSetOriginationPhoneNumberId()
        {
            return this._originationPhoneNumberId != null;
        }

    }
}