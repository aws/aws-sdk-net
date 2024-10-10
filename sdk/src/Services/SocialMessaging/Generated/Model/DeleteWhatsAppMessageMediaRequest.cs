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
    /// Container for the parameters to the DeleteWhatsAppMessageMedia operation.
    /// Delete a media object from the WhatsApp service. If the object is still in an Amazon
    /// S3 bucket you should delete it from there too.
    /// </summary>
    public partial class DeleteWhatsAppMessageMediaRequest : AmazonSocialMessagingRequest
    {
        private string _mediaId;
        private string _originationPhoneNumberId;

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// The unique identifier of the media file to delete. Use the <c>mediaId</c> returned
        /// from <a href="https://console.aws.amazon.com/social-messaging/latest/APIReference/API_PostWhatsAppMessageMedia.html">PostWhatsAppMessageMedia</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string MediaId
        {
            get { return this._mediaId; }
            set { this._mediaId = value; }
        }

        // Check to see if MediaId property is set
        internal bool IsSetMediaId()
        {
            return this._mediaId != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The unique identifier of the originating phone number associated with the media. Phone
        /// number identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
        /// Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_GetLinkedWhatsAppBusinessAccountPhoneNumber.html">GetLinkedWhatsAppBusinessAccount</a>
        /// to find a phone number's id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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