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
    /// Container for the parameters to the PostWhatsAppMessageMedia operation.
    /// Upload a media file to the WhatsApp service. Only the specified <c>originationPhoneNumberId</c>
    /// has the permissions to send the media file when using <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_SendWhatsAppMessage.html">SendWhatsAppMessage</a>.
    /// You must use either <c>sourceS3File</c> or <c>sourceS3PresignedUrl</c> for the source.
    /// If both or neither are specified then an <c>InvalidParameterException</c> is returned.
    /// </summary>
    public partial class PostWhatsAppMessageMediaRequest : AmazonSocialMessagingRequest
    {
        private string _originationPhoneNumberId;
        private S3File _sources3File;
        private S3PresignedUrl _sources3PresignedUrl;

        /// <summary>
        /// Gets and sets the property OriginationPhoneNumberId. 
        /// <para>
        /// The ID of the phone number to associate with the WhatsApp media file. The phone number
        /// identifiers are formatted as <c>phone-number-id-01234567890123456789012345678901</c>.
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

        /// <summary>
        /// Gets and sets the property SourceS3File. 
        /// <para>
        /// The source S3 url for the media file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public S3File SourceS3File
        {
            get { return this._sources3File; }
            set { this._sources3File = value; }
        }

        // Check to see if SourceS3File property is set
        internal bool IsSetSourceS3File()
        {
            return this._sources3File != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3PresignedUrl. 
        /// <para>
        /// The source presign url of the media file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public S3PresignedUrl SourceS3PresignedUrl
        {
            get { return this._sources3PresignedUrl; }
            set { this._sources3PresignedUrl = value; }
        }

        // Check to see if SourceS3PresignedUrl property is set
        internal bool IsSetSourceS3PresignedUrl()
        {
            return this._sources3PresignedUrl != null;
        }

    }
}